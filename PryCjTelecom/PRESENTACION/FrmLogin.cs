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
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                FrmMenuPrincipal menu = new FrmMenuPrincipal();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario(string idUsuario, string clave)
        {
            bool resultado = false;
            string connectionString = "Data Source=161.132.37.248;Initial Catalog=JC_Db;Persist Security Info=True;User ID=SA;Password=AuT1iQS6Gxp9ysX;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=False";
            if (connectionString == "<TU_CADENA_CONEXION_AQUI>")
            {
                MessageBox.Show("La cadena de conexión no está configurada. Por favor, actualícela en el código.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT IdUsuario FROM Usuario WHERE IdUsuario = @IdUsuario AND Clave = @Clave";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                        cmd.Parameters.AddWithValue("@Clave", clave);
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id) && id == 1)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al validar usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }
    }
}
