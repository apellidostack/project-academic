using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMascotas
{
    public partial class Adopcion : Form
    {
        public Adopcion()
        {
            InitializeComponent();
        }

        DSbdadopciones ds = new DSbdadopciones();
        //DSbdadopcionesTableAdapters.mascotaTableAdapter mascota = new DSbdadopcionesTableAdapters.mascotaTableAdapter();
        DSbdadopcionesTableAdapters.listarVoluntariosXCarnetTableAdapter volXCarnet = new DSbdadopcionesTableAdapters.listarVoluntariosXCarnetTableAdapter();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consultas = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        DSbdadopcionesTableAdapters.MascotasSinAdoptarTableAdapter mascotasDisponibles = new DSbdadopcionesTableAdapters.MascotasSinAdoptarTableAdapter();

        public int idpersonalAdop;
        public string codMascota = "";

        private void Adopcion_Load(object sender, EventArgs e)
        {
            //aqui la idea es mostrar las mascotas en la tabla datagridView con las imagenes y hacer la adopcion
            mascotasDisponibles.Fill(ds.MascotasSinAdoptar);
            dgvMascotas.DataSource = ds.MascotasSinAdoptar;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MemoryStream ms = new MemoryStream((byte[])dgvMascotas.CurrentRow.Cells[3].Value);
            Bitmap bm = new Bitmap(ms);
            //dgvMascotas.Columns[3].ValueType = typeof(Image);
            
            pictureBox1.Image = bm;
            //pictureBox1.Size = new Size(100, 100);
            txtNombre.Text = dgvMascotas.CurrentRow.Cells[1].Value.ToString();
            txtEstado.Text = dgvMascotas.CurrentRow.Cells[4].Value.ToString();
            txtEdad.Text = dgvMascotas.CurrentRow.Cells[2].Value.ToString();
            codMascota= dgvMascotas.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnNuevoVoluntario_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarXCarnet_TextChanged(object sender, EventArgs e)
        {
            volXCarnet.Fill(ds.listarVoluntariosXCarnet, txtbuscarXCarnet.Text + "%");
            cbVoluntario.DataSource = ds.listarVoluntariosXCarnet;
            cbVoluntario.ValueMember = "codVoluntario";
            cbVoluntario.DisplayMember = "nombreCompleto";
        }

        private void btnRegistrarAdopcion_Click(object sender, EventArgs e)
        {
            consultas.InsertarAdopcion(dtpfecha.Value, DateTime.Now.ToLongTimeString(), Convert.ToInt32(cbVoluntario.SelectedValue), Convert.ToInt32(codMascota), idpersonalAdop);
            consultas.ActualizarEstadoMascota(Convert.ToInt32(codMascota));
            mascotasDisponibles.Fill(ds.MascotasSinAdoptar);
            dgvMascotas.DataSource = ds.MascotasSinAdoptar;
        }
    }
}
