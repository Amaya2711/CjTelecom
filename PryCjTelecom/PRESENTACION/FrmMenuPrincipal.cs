using System;
using System.Windows.Forms;

namespace PRESENTACION
{
    public class FrmMenuPrincipal : Form
    {
    private Button btnOperaciones;
    private Button btnPagos;
    private Button btnLogistico;
    private Button btnMantenimiento;
    private Button btnVacaciones;
    private Button btnPlanta;
    private Button btnLegal;
    private ContextMenuStrip contextMenu;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnOperaciones = new Button();
            this.btnPagos = new Button();
            this.btnLogistico = new Button();
            this.btnMantenimiento = new Button();
            this.btnVacaciones = new Button();
            this.btnPlanta = new Button();
            this.contextMenu = new ContextMenuStrip();

            // Botones principales
            this.btnOperaciones.Text = "OPERACIONES";
            this.btnOperaciones.Location = new System.Drawing.Point(30, 30);
            this.btnOperaciones.Size = new System.Drawing.Size(150, 40);

            this.btnPagos.Text = "PAGOS";
            this.btnPagos.Location = new System.Drawing.Point(200, 30);
            this.btnPagos.Size = new System.Drawing.Size(150, 40);

            this.btnLogistico.Text = "LOGISTICO";
            this.btnLogistico.Location = new System.Drawing.Point(370, 30);
            this.btnLogistico.Size = new System.Drawing.Size(150, 40);

            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.Location = new System.Drawing.Point(30, 90);
            this.btnMantenimiento.Size = new System.Drawing.Size(150, 40);

            this.btnVacaciones.Text = "VACACIONES";
            this.btnVacaciones.Location = new System.Drawing.Point(200, 90);
            this.btnVacaciones.Size = new System.Drawing.Size(150, 40);

            this.btnPlanta.Text = "PLANTA";
            this.btnPlanta.Location = new System.Drawing.Point(370, 90);
            this.btnPlanta.Size = new System.Drawing.Size(150, 40);

            this.btnLegal = new Button();
            this.btnLegal.Text = "LEGAL";
            this.btnLegal.Location = new System.Drawing.Point(200, 150);
            this.btnLegal.Size = new System.Drawing.Size(150, 40);

            // Context menu
            this.contextMenu.Items.Add("OPERACIONES");
            this.contextMenu.Items.Add("PAGOS");
            this.contextMenu.Items.Add("LOGISTICO");
            this.contextMenu.Items.Add("MANTENIMIENTO");
            this.contextMenu.Items.Add("VACACIONES");
            this.contextMenu.Items.Add("PLANTA");
            this.contextMenu.Items.Add("LEGAL");

            this.ContextMenuStrip = this.contextMenu;

            // Formulario principal
            this.Text = "ERP - Menú Principal";
            this.ClientSize = new System.Drawing.Size(560, 220);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnLogistico);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.btnVacaciones);
            this.Controls.Add(this.btnPlanta);
            this.Controls.Add(this.btnLegal);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
