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
    public partial class Donaciones : Form
    {
        public Donaciones()
        {
            InitializeComponent();
        }

        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consulta = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        DSbdadopcionesTableAdapters.buscaridDonacionMonetariaTableAdapter bCodDonacionMonetaria = new DSbdadopcionesTableAdapters.buscaridDonacionMonetariaTableAdapter();
        DSbdadopcionesTableAdapters.buscarcodVoluntarioTableAdapter bCodVoluntario = new DSbdadopcionesTableAdapters.buscarcodVoluntarioTableAdapter();
        DSbdadopcionesTableAdapters.bcodVoluntarioXcarnetTableAdapter bCodVolunatioXcarnet = new DSbdadopcionesTableAdapters.bcodVoluntarioXcarnetTableAdapter();

        public int idPersonal; 

        private void btnRegistrarDonacionMonetaria_Click(object sender, EventArgs e)
        {
            int codVoluntario = 0;
            consulta.InsertarDonacionMonetaria(txtMonto.Text, DateTime.Now.Date, idPersonal);
            bCodVolunatioXcarnet.Fill(ds.bcodVoluntarioXcarnet, txtCarnetVoluntario.Text);
            if (ds.bcodVoluntarioXcarnet.Rows.Count > 0)
            {
                codVoluntario = Convert.ToInt32(ds.bcodVoluntarioXcarnet.Rows[0].ItemArray[0]);

            }
            else {
                consulta.InsertarVoluntario(txtMaterno.Text, txtPaterno.Text, txtnombre.Text, txtDireccion.Text, txtTelefono.Text, txtCarnetVoluntario.Text, rbMasculino.Checked ? "Masculino" : "Femenino", DateTime.Parse(lbFechaNac.Text), idPersonal);
                bCodVoluntario.Fill(ds.buscarcodVoluntario);
                codVoluntario = Convert.ToInt32(ds.buscarcodVoluntario.Rows[0].ItemArray[0]);
            }
            
            bCodDonacionMonetaria.Fill(ds.buscaridDonacionMonetaria);
            
            consulta.RegistrarAporte(codVoluntario, Convert.ToInt32(ds.buscaridDonacionMonetaria.Rows[0].ItemArray[0]),txtRol.Text);

        }

        private void Donaciones_Load(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lbFechaNac.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
