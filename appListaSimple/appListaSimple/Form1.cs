using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appListaSimple
{
    public partial class Form1 : Form
    {
        Lista miLista;
        public Form1()
        {
            InitializeComponent();
            miLista = new Lista();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int d = int.Parse(txtDato.Text);
            Nodo n = new Nodo(d, null);

            miLista.Agregar(n);
            txtDato.Clear();
            txtDato.Focus();
            MessageBox.Show(miLista + "");
        }
    }
}
