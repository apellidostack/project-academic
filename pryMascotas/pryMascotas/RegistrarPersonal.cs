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
    public partial class RegistrarPersonal : Form
    {
        DSbdadopciones ds = new DSbdadopciones();
        DSbdadopcionesTableAdapters.tipousuarioTableAdapter tTipoUsuario = new DSbdadopcionesTableAdapters.tipousuarioTableAdapter();
        DSbdadopcionesTableAdapters.QueriesTableAdapter Registrar = new DSbdadopcionesTableAdapters.QueriesTableAdapter();
        
        

        public RegistrarPersonal()
        {
            InitializeComponent();
        }

        private void RegistrarPersonal_Load(object sender, EventArgs e)
        {
            tTipoUsuario.Fill(ds.tipousuario);
            cbTipoUsuario.DataSource = ds.tipousuario;
            cbTipoUsuario.ValueMember = "idTipoUsuario";
            cbTipoUsuario.DisplayMember = "tipo";
        }

        private void btnRegistrarPersonal_Click(object sender, EventArgs e)
        {
            Registrar.RegistrarPersonal(txtCarnet.Text, txtNombre.Text, txtApellido.Text, txtEstado.Text, txtTelefono.Text, txtDireccion.Text, Convert.ToInt32(cbTipoUsuario.SelectedValue));
            label2.Visible = true;
        }

        private void btnRegistrarVoluntario_Click(object sender, EventArgs e)
        {
            
        }
    }
}
