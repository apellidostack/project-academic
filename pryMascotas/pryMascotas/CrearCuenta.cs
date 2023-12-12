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
    public partial class CrearCuenta : Form
    {
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.QueriesTableAdapter crearCuenta = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        DSbdadopcionesTableAdapters.VerificarPersonalTableAdapter verificarPersonal = new DSbdadopcionesTableAdapters.VerificarPersonalTableAdapter();



        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            verificarPersonal.Fill(ds.VerificarPersonal, txtCarnet.Text);
            if (ds.VerificarPersonal.Rows.Count > 0)
            {
                crearCuenta.CrearCuentaPersonal(txtUsuario.Text, txtContraseña.Text, txtCarnet.Text);
                txtCarnet.Clear();
                txtContraseña.Clear();
                txtUsuario.Clear();
                label4.Text = "Registrado Exitosamente";
                label4.Visible = true;
                btnRegistrar.Visible = false;
            }
            else {
                MessageBox.Show("Número de carnet Incorrecto", "Error numero de carnet", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            
            

        }
    }
}
