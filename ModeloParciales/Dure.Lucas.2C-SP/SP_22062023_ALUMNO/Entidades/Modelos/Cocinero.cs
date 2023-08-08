using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using System.ComponentModel.Design;
using Entidades.DataBase;

namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraAtencion(double demora);
    public delegate void DelegadoNuevoIngreso(IComestible menu);

    public class Cocinero <T> where T : IComestible, new()
    {
        public event DelegadoDemoraAtencion OnDemora;
        public event DelegadoNuevoIngreso OnIngreso;

        private CancellationTokenSource cancellation;
        private int cantPedidosFinalizados;
        private string nombre;
        private double demoraPreparacionTotal;
        private T menu;
        private Task tarea;



        public Cocinero(string nombre)
        {
            this.nombre = nombre;
        }


        public bool HabilitarCocina
        {
            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running
                    || this.tarea.Status == TaskStatus.WaitingToRun
                    || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value == true && !(this.HabilitarCocina))
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarIngreso();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        public double TiempoMedioDePreparacion { get => this.cantPedidosFinalizados == 0 ? 0 : this.demoraPreparacionTotal / this.cantPedidosFinalizados; }
        public string Nombre { get => nombre; }

        //Cree una propiedad para poder validar en el test
        public int CantPedidosFinalizados { get => cantPedidosFinalizados; }

        private void IniciarIngreso()
        {
            Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoIngreso();
                    this.EsperarProximoIngreso();
                    this.cantPedidosFinalizados++;
                    DataBaseManager.GuardarTicket<T>(this.Nombre, menu);
                }
            });
        }

        private void NotificarNuevoIngreso()
        {
            if (this.OnIngreso is not null)
            {
                T nuevoMenu = new T();
                nuevoMenu.IniciarPreparacion();
                this.OnIngreso(nuevoMenu);
            }
        }
        private void EsperarProximoIngreso()
        {
            if (this.OnDemora is not null)
            {
                while (!this.cancellation.IsCancellationRequested || !this.menu.Estado)
                {
                    Thread.Sleep(1000);
                    this.demoraPreparacionTotal++;
                    this.OnDemora(this.demoraPreparacionTotal);
                }
            }
        }
    }
}
