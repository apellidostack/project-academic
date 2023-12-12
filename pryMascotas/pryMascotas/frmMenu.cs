using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace pryMascotas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        public int idP;

        public void AbrirFormHija(object formhija)
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
        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox4.Visible = false;
            panemenu1.Visible = true;
            
            btnrestaurar.Visible = false;


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox3.Visible = false;
            panemenu1.Visible = false;
            
            btnrestaurar.Visible = false;
        }

        private void btnmascota_Click(object sender, EventArgs e)
        {
            if (btnmascota.Text == "Registrar Personal")
            {
                AbrirFormHija(new RegistrarPersonal());

            }
            else if (btnmascota.Text == "Mascotas")
            {
               /* pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                panemenu1.Visible = false;*/
                Mascota mas = new Mascota();
                mas.idpersonalParaMascota = idP;
                AbrirFormHija(mas);

            }
            else if (btnmascota.Text == "Registrar Veterinaria") {
                Veterinaria vet = new Veterinaria();
                vet.idPersonalVet = idP;
                AbrirFormHija(vet);
            }
        }

        private void btnveterinario_Click(object sender, EventArgs e)
        {
            if (btnveterinario.Text == "Crear Cargo")
            {
                AbrirFormHija(new CrearCargo());
            }
            else if (btnveterinario.Text == "Revision")
            {
                Revision rev = new Revision();
                rev.idPersonalRevision = idP;
                AbrirFormHija(rev);
            }else if(btnveterinario.Text == "Adopción")
            {
                Adopcion adop = new Adopcion();
                adop.idpersonalAdop = idP;
                AbrirFormHija(adop);
                /*pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                panemenu1.Visible = false;
                btnrestaurar.Visible = false;
                if (panelmenu.Width == 307)
                {
                    panelmenu.Width = 200;
                }
                else
                {
                    panelmenu.Width = 307;
                }*/
            }
        }

        private void btninforme_Click(object sender, EventArgs e)
        {
            //este es el boton donaciones
            Donaciones d = new Donaciones();
            d.idPersonal = idP;
            AbrirFormHija(d);
        }

        private void btndonacion_Click(object sender, EventArgs e)
        {
            /*lbltitulo.Text = ("DONACIONES");
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            panemenu1.Visible = false;
            panelmenu2.Visible = true;
            pictureBox9.Visible = false;
            pictureBox10.Visible = true;
            AbrirFormHija(new donaciones());
            if (panelmenu.Width == 307)
            {
                panelmenu.Width = 200;
            }
            else
            {
                panelmenu.Width = 307;
            }*/
            
            if (btnInformes.Text == "Voluntarios") {
                Voluntarios v = new Voluntarios();
                v.idPe = idP;
                AbrirFormHija(v);
            }
            
        }

        private void btnmascota_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
            btnrestaurar.Visible = true;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            btnrestaurar.Visible= true;
        }
        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnmascotas1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnveterinario1_Click(object sender, EventArgs e)
        {
            
        }

        private void btninformes1_Click(object sender, EventArgs e)
        {
            
        }

        private void btndonaciones1_Click(object sender, EventArgs e)
        {
            /*lbltitulo.Text = ("DONACIONES");
            AbrirFormHija(new donaciones());*/
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnmaximizar.Visible = true;
            btnrestaurar.Visible = false;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnmaximizar.Visible = false;
            btnrestaurar.Visible = true;
        }

        private void btnAdopciones_Click(object sender, EventArgs e)
        {
            
        }
    }
}
