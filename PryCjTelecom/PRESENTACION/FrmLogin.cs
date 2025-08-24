using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PRESENTACION
{
    public class FrmLogin : Form
    {
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnLogin;
        private Label lblUsuario;
        private Label lblClave;
    #pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtUsuario = new TextBox();
            this.txtClave = new TextBox();
            this.btnLogin = new Button();
            this.lblUsuario = new Label();
            this.lblClave = new Label();
            #pragma warning restore CS8618

            // 
            // lblUsuario
            // 
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Location = new System.Drawing.Point(20, 20);
            this.lblUsuario.Size = new System.Drawing.Size(60, 20);

            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(100, 20);
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);

            // 
            // lblClave
            // 
            this.lblClave.Text = "Clave:";
            this.lblClave.Location = new System.Drawing.Point(20, 60);
            this.lblClave.Size = new System.Drawing.Size(60, 20);

            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(100, 60);
            this.txtClave.Size = new System.Drawing.Size(150, 20);
            this.txtClave.PasswordChar = '*';

            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.Location = new System.Drawing.Point(100, 100);
            this.btnLogin.Size = new System.Drawing.Size(80, 30);
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);

            // 
            // FrmLogin
            // 
            this.Text = "Login";
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string idUsuario = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            if (ValidarUsuario(idUsuario, clave))
            {
                MessageBox.Show("Login exitoso.");
                // Abrir el formulario principal o continuar
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario(string idUsuario, string clave)
        {
            bool resultado = false;
            string connectionString = "<TU_CADENA_CONEXION_AQUI>";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE IdUsuario = @IdUsuario AND Clave = @Clave";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@Clave", clave);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    resultado = count > 0;
                }
            }
            return resultado;
        }
    }
}
