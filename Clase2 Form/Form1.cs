using Credenciales;

namespace Clase2_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario = TxtUsuario.Text;
            string contrase�a = TxtContrase�a.Text;

            if (usuario.ToUpper() == UserCredentials.UserAdmin.ToUpper() && contrase�a.ToUpper() == UserCredentials.UserAdminPassword.ToUpper())
            {
                MessageBox.Show("Se ha registrado como Usuario Admin", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario.ToUpper() == UserCredentials.UserConsultor.ToUpper() && contrase�a.ToUpper() == UserCredentials.UserConsultorPassword.ToUpper())
            {
                MessageBox.Show("Se ha registrado como Usuario Consultor", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (usuario.ToUpper() == UserCredentials.UserLector.ToUpper() && contrase�a.ToUpper() == UserCredentials.UserLectorPassword.ToUpper())
            {
                MessageBox.Show("Se ha registrado como Usuario Lector", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("contrase�a Erronea", "Registro Fallido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
    

