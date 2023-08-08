using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormCentroDeAtencion
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }
        public Nomina(string nomina) : this()
        {
            this.RchtNomina.Text = nomina;
        }
    }
}
