using CapaData;
using System;
using System.Security.Authentication;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Autenticacion : Form
    {
        public Autenticacion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Usuario user;
            try
            {
                user = LoginUsuario();
            }
            catch (InvalidCredentialException ex)
            {
                MessageBox.Show(ex.Message, "Error de nicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                user = null;
            }

            if (user != null) AbrirForm(user);
        }




        //Metodos

        private void AbrirForm(Usuario user)
        {
            frmContenedor form = new frmContenedor(user);
            form.Show();
            this.Hide();
            form.FormClosing += frm_closing; //https://www.youtube.com/watch?v=G9guWqDiddo&list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&index=2
        }

        private Usuario LoginUsuario()
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;
            var usuarios = Data.usuarios;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuario == Data.usuarios[i].Nombre)
                {
                    if (password == Data.usuarios[i].PassWord)
                    {
                        return usuarios[i];
                    }
                    else
                    {
                        throw new InvalidCredentialException("Credenciales de acceso inválidas");
                    }
                }
            }
            return null;
        }


        // Evento que muestra este formulario una vez se cierre el frmContenedor 
        //https://www.youtube.com/watch?v=G9guWqDiddo&list=PLx2nia7-PgoDk8pZ1YG8wtw5A8LH2kz96&index=2
        //https://learn.microsoft.com/es-es/dotnet/standard/events/
        private void frm_closing(object sender, FormClosingEventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";
            this.Show();
        }

    }
}
