using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMascotas
{
    public partial class CrearCargo : Form
    {
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.QueriesTableAdapter crearCargo = new DSbdadopcionesTableAdapters.QueriesTableAdapter();



        public CrearCargo()
        {
            InitializeComponent();
        }

        private void btnCrearCargo_Click(object sender, EventArgs e)
        {
            crearCargo.CrearCargo(txtTipo.Text, txtDescripcion.Text);
            btnCrearCargo.Visible = false;
            label4.Visible = true;
            label4.Text = "Creado Exitosamente";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
