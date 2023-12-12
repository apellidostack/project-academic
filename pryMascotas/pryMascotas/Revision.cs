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
    public partial class Revision : Form
    {
        public Revision()
        {
            InitializeComponent();
        }
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consultas = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        DSbdadopcionesTableAdapters.EnfermedadYaExisteTableAdapter verificar = new DSbdadopcionesTableAdapters.EnfermedadYaExisteTableAdapter();
        DSbdadopcionesTableAdapters.ListarVeterinariosTableAdapter veterinarios = new DSbdadopcionesTableAdapters.ListarVeterinariosTableAdapter();
        DSbdadopcionesTableAdapters.veterinariaTableAdapter clinicasVeterinarias = new DSbdadopcionesTableAdapters.veterinariaTableAdapter();
        DSbdadopcionesTableAdapters.FiltrarMascotasTableAdapter filtrarMascotas = new DSbdadopcionesTableAdapters.FiltrarMascotasTableAdapter();


        public int idPersonalRevision;

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int codE = 0;
            verificar.Fill(ds.EnfermedadYaExiste, txtInforme.Text);
            if (ds.EnfermedadYaExiste.Rows.Count > 0)
            {
                codE = Convert.ToInt32(ds.EnfermedadYaExiste.Rows[0].ItemArray[0]);
                consultas.Revision(dtpfecha.Value, DateTime.Now.ToLongTimeString(), Convert.ToInt32(cbMascota.SelectedValue), Convert.ToInt32(cbVeterinario.SelectedValue), codE, idPersonalRevision);
            }
            else {
                consultas.DiagnosticoEnfermedad(txtInforme.Text);
                verificar.Fill(ds.EnfermedadYaExiste, txtInforme.Text);
                codE = Convert.ToInt32(ds.EnfermedadYaExiste.Rows[0].ItemArray[0]);
                consultas.DetalleRevision(codE, txtObservacion.Text);
                consultas.Revision(dtpfecha.Value, DateTime.Now.ToLongTimeString(), Convert.ToInt32(cbMascota.SelectedValue), Convert.ToInt32(cbVeterinario.SelectedValue), codE, idPersonalRevision);
            }
        }

        private void Revision_Load(object sender, EventArgs e)
        {
            veterinarios.Fill(ds.ListarVeterinarios);
            cbVeterinario.DataSource = ds.ListarVeterinarios;
            cbVeterinario.ValueMember = "codVeterinario";
            cbVeterinario.DisplayMember = "nombreCompleto";

            clinicasVeterinarias.Fill(ds.veterinaria);
            cbClinicaVeterinaria.DataSource = ds.veterinaria;
            cbClinicaVeterinaria.ValueMember = "codVeterinaria";
            cbClinicaVeterinaria.DisplayMember = "razonSocial";

            
        }

        private void txtBuscarMascota_TextChanged(object sender, EventArgs e)
        {
            filtrarMascotas.Fill(ds.FiltrarMascotas, txtBuscarMascota.Text + "%");
            cbMascota.DataSource = ds.FiltrarMascotas;
            cbMascota.ValueMember = "codMascota";
            cbMascota.DisplayMember = "nombreProvisional";

        }
    }
}
