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
    public partial class Veterinaria : Form
    {
        public Veterinaria()
        {
            InitializeComponent();
        }
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.buscarVeterinariaPorTelefonoTableAdapter buscarCodVeterinaria = new DSbdadopcionesTableAdapters.buscarVeterinariaPorTelefonoTableAdapter();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consultas = new DSbdadopcionesTableAdapters.QueriesTableAdapter();



        public int idPersonalVet;

        private void button1_Click(object sender, EventArgs e)
        {
            buscarCodVeterinaria.Fill(ds.buscarVeterinariaPorTelefono, txtTelefono.Text);
            int idVeterinaria = 0;
            if (ds.buscarVeterinariaPorTelefono.Rows.Count > 0)
            {
                idVeterinaria = Convert.ToInt32(ds.buscarVeterinariaPorTelefono.Rows[0].ItemArray[0]);
                consultas.RegistroDeVeterinario(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text,idVeterinaria);
            }
            else {
                consultas.RegistrarVeterinaria(txtRazonSocial.Text, txtDireccion.Text, txtTelefono.Text);
                buscarCodVeterinaria.Fill(ds.buscarVeterinariaPorTelefono, txtTelefono.Text);
                idVeterinaria = Convert.ToInt32(ds.buscarVeterinariaPorTelefono.Rows[0].ItemArray[0]);
                consultas.RegistroDeVeterinario(txtNombre.Text, txtApellidoPaterno.Text, txtApellidoMaterno.Text, idVeterinaria);
            }
        }
    }
}
