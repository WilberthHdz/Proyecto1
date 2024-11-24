using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            Cuentas formulario3 = new Cuentas();
            formulario3.Show();
        }

        private void btnAhorro_Click(object sender, EventArgs e)
        {
            Ahorros formulario4 = new Ahorros();
            formulario4.Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            Movimientos formulario5 = new Movimientos();
            formulario5.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            Pagos formulario6 = new Pagos();
            formulario6.Show();
        }
    }
}
