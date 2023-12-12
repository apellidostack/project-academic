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
    public partial class Voluntarios : Form
    {
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.buscarcodVoluntarioTableAdapter bCodVoluntario = new DSbdadopcionesTableAdapters.buscarcodVoluntarioTableAdapter();
        DSbdadopcionesTableAdapters.bcodVoluntarioXcarnetTableAdapter bCodVolunatioXcarnet = new DSbdadopcionesTableAdapters.bcodVoluntarioXcarnetTableAdapter();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consulta = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        public int idPe;

        public Voluntarios()
        {
            InitializeComponent();
        }
       
        private void btnRegistrarVoluntario_Click(object sender, EventArgs e)
        {
            bCodVolunatioXcarnet.Fill(ds.bcodVoluntarioXcarnet, txtCarnetVoluntario.Text);
            if (ds.bcodVoluntarioXcarnet.Rows.Count > 0)
            {
                MessageBox.Show("El voluntario ya esta registrado");

            }
            else
            {
                consulta.InsertarVoluntario(txtMaternoV.Text, txtPaternoV.Text, txtNombreV.Text, txtDireccionV.Text, txtTelefonoV.Text, txtCarnetVoluntario.Text, rbMasculino.Checked ? "Masculino" : "Femenino", DateTime.Parse(lbFechaNac.Text), idPe);
                
            }
            //dgrvvoluntarios.Rows.Add(cbtipopaquete.SelectedValue.ToString(), cbtipopaquete.Text);
            //dgvvoluntarios.Rows.Add(txtNombreV.Text, txtPaternoV.Text, txtMaternoV.Text, txtDireccionV.Text, txtTelefonoV.Text, txtCarnetVoluntario.Text);
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            lbFechaNac.Text = monthCalendar1.SelectionStart.ToString();
        }

        private void Voluntarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSbdadopciones.voluntario' Puede moverla o quitarla según sea necesario.
            this.voluntarioTableAdapter.Fill(this.dSbdadopciones.voluntario);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Conecte una impresora");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
