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
    public partial class Mascota : Form
    {
        public Mascota()
        {
            InitializeComponent();
        }

        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.QueriesTableAdapter consultas = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        DSbdadopcionesTableAdapters.buscarespecieTableAdapter buscarEspecie = new DSbdadopcionesTableAdapters.buscarespecieTableAdapter();
        DSbdadopcionesTableAdapters.buscarRazaTableAdapter buscarRaza = new DSbdadopcionesTableAdapters.buscarRazaTableAdapter();
        DSbdadopcionesTableAdapters.buscarAnimalTableAdapter buscarAnimal = new DSbdadopcionesTableAdapters.buscarAnimalTableAdapter();
        DSbdadopcionesTableAdapters.buscarColorTableAdapter buscarColor = new DSbdadopcionesTableAdapters.buscarColorTableAdapter();
        DSbdadopcionesTableAdapters.listarVoluntariosTableAdapter listaVoluntarios = new DSbdadopcionesTableAdapters.listarVoluntariosTableAdapter();
        DSbdadopcionesTableAdapters.listarZonasTableAdapter listaZonas = new DSbdadopcionesTableAdapters.listarZonasTableAdapter();
        DSbdadopcionesTableAdapters.maxCodRescateTableAdapter maxCodRescate = new DSbdadopcionesTableAdapters.maxCodRescateTableAdapter();
        DSbdadopcionesTableAdapters.maxCodMascotaTableAdapter maxCodMascota = new DSbdadopcionesTableAdapters.maxCodMascotaTableAdapter();

        public int idpersonalParaMascota;

        private void btnIngresarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirImagen = new OpenFileDialog();
            abrirImagen.Filter = "image files |*.jpg; *.png;";
            DialogResult r = abrirImagen.ShowDialog();
            if (r == DialogResult.OK) {
                pbFoto.ImageLocation = abrirImagen.FileName;
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pbFoto.Size = new Size(50, 40);
            //Image imagen = Image.FromFile(pbFoto.ImageLocation);
            Image imagen = pbFoto.Image;
            var ms = new MemoryStream();
            imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            var bytes = ms.ToArray();

            //prueba
            pbFoto.Size = new Size(100, 78);

            buscarEspecie.Fill(ds.buscarespecie, txtEspecie.Text);
            buscarRaza.Fill(ds.buscarRaza, txtRaza.Text);

            if (ds.buscarespecie.Rows.Count > 0)
            {

            }
            else
            {
                consultas.InsertarEspecie(txtEspecie.Text);
            }

            if (ds.buscarRaza.Rows.Count > 0)
            {

            }
            else
            {
                consultas.InsertarRaza(txtRaza.Text);
                
            }

            buscarEspecie.Fill(ds.buscarespecie, txtEspecie.Text);
            buscarRaza.Fill(ds.buscarRaza, txtRaza.Text);

            buscarAnimal.Fill(ds.buscarAnimal, Convert.ToInt32(ds.buscarespecie.Rows[0].ItemArray[0]), Convert.ToInt32(ds.buscarRaza.Rows[0].ItemArray[0]));
            if (ds.buscarAnimal.Rows.Count > 0)
            {
                MessageBox.Show("ya existe ese animal", "mensaje");
            }
            else {
                consultas.InsertarAnimal(Convert.ToInt32(ds.buscarespecie.Rows[0].ItemArray[0]), Convert.ToInt32(ds.buscarRaza.Rows[0].ItemArray[0]));
            }

            buscarColor.Fill(ds.buscarColor, txtColor.Text);
            if (ds.buscarColor.Rows.Count > 0)
            {

            }
            else {
                consultas.InsertarColor(txtColor.Text);
            }
            buscarColor.Fill(ds.buscarColor, txtColor.Text);
            buscarAnimal.Fill(ds.buscarAnimal, Convert.ToInt32(ds.buscarespecie.Rows[0].ItemArray[0]), Convert.ToInt32(ds.buscarRaza.Rows[0].ItemArray[0]));
            consultas.InsertarMascota(txtNombre.Text, Convert.ToInt32(txtEdad.Text), bytes, txtEstado.Text, Convert.ToInt32(ds.buscarAnimal.Rows[0].ItemArray[0]), Convert.ToInt32(ds.buscarAnimal.Rows[0].ItemArray[1]), Convert.ToInt32(ds.buscarColor.Rows[0].ItemArray[0]));

            //tabla rescate
            

            consultas.RegistrarRescate(DateTime.Parse(dtpfecharescate.Value.ToShortDateString()), dtpHora.Value.ToString(), Convert.ToInt32(cbVoluntario.SelectedValue), txtLugar.Text, idpersonalParaMascota, Convert.ToInt32(cbZona.SelectedValue));

            maxCodRescate.Fill(ds.maxCodRescate);
            maxCodMascota.Fill(ds.maxCodMascota);

            consultas.InsertarDetalleRescate(Convert.ToInt32(ds.maxCodRescate.Rows[0].ItemArray[0]), Convert.ToInt32(ds.maxCodMascota.Rows[0].ItemArray[0]));

        }

        private void dtpfecharescate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Mascota_Load(object sender, EventArgs e)
        {
            listaVoluntarios.Fill(ds.listarVoluntarios);
            cbVoluntario.DataSource = ds.listarVoluntarios;
            cbVoluntario.ValueMember = "codVoluntario";
            cbVoluntario.DisplayMember = "nombreCompleto";

            listaZonas.Fill(ds.listarZonas);
            cbZona.DataSource = ds.listarZonas;
            cbZona.ValueMember = "codZona";
            cbZona.DisplayMember = "descripcionZona";
        }
    }
}
