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
    public partial class frmLogin : Form
    {
        DSbdadopciones ds = new DSbdadopciones();

        DSbdadopcionesTableAdapters.VerificarUsuarioTableAdapter verificarUsuario = new DSbdadopcionesTableAdapters.VerificarUsuarioTableAdapter();

       
        public frmLogin()
        {
            InitializeComponent();
        }
        private void AbrirFormHija(object formhija)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            verificarUsuario.Fill(ds.VerificarUsuario, txtUsuario.Text, txtContrasenia.Text);
            if (ds.VerificarUsuario.Rows.Count > 0)
            {
                if (Convert.ToInt32(ds.VerificarUsuario.Rows[0].ItemArray[4]) == 1)
                {
                    frm.btnmascota.Text = "Registrar Personal";
                    frm.btnveterinario.Text = "Crear Cargo";
                }else if (Convert.ToInt32(ds.VerificarUsuario.Rows[0].ItemArray[4]) == 2)
                {
                    frm.btnmascota.Text = "Mascotas";
                    frm.btnveterinario.Text= "Adopción";
                    frm.btnInformes.Text = "Voluntarios";
                    frm.idP = Convert.ToInt32(ds.VerificarUsuario.Rows[0].ItemArray[0]);
                }
                else if (Convert.ToInt32(ds.VerificarUsuario.Rows[0].ItemArray[4]) == 3)
                {
                    frm.btnmascota.Text = "Registrar Veterinaria";
                    frm.btnveterinario.Text = "Revision";
                    frm.btnInformes.Text = "Informes de Revisiones";
                    //frm.btnDonaciones.Visible = false;
                    frm.idP = Convert.ToInt32(ds.VerificarUsuario.Rows[0].ItemArray[0]);
                }
                this.Hide();

                frm.Show();
            }
            else {
                MessageBox.Show("Usuario o contraseña incorrectos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }    
           
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            panelcontenedor.Visible = true;
            pictureBox1.Visible = true;
            AbrirFormHija(new CrearCuenta());
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelcontenedor.Visible = false;
            pictureBox1.Visible = false;
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
