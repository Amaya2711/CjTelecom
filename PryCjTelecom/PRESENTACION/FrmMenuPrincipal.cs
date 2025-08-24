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
            // --- Lógica de estilos ejecutivos fuera de InitializeComponent ---
            var executiveBlue = System.Drawing.Color.FromArgb(33, 37, 41); // Azul oscuro
            var executiveGray = System.Drawing.Color.FromArgb(240, 240, 240); // Gris claro
            var executiveFont = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);

            // Asegurarse de que todos los botones están inicializados
            if (btnOperaciones != null) { btnOperaciones.BackColor = executiveBlue; btnOperaciones.ForeColor = System.Drawing.Color.White; btnOperaciones.Font = executiveFont; btnOperaciones.FlatStyle = FlatStyle.Flat; btnOperaciones.FlatAppearance.BorderSize = 0; btnOperaciones.Cursor = Cursors.Hand; }
            if (btnPagos != null) { btnPagos.BackColor = executiveBlue; btnPagos.ForeColor = System.Drawing.Color.White; btnPagos.Font = executiveFont; btnPagos.FlatStyle = FlatStyle.Flat; btnPagos.FlatAppearance.BorderSize = 0; btnPagos.Cursor = Cursors.Hand; }
            if (btnLogistico != null) { btnLogistico.BackColor = executiveBlue; btnLogistico.ForeColor = System.Drawing.Color.White; btnLogistico.Font = executiveFont; btnLogistico.FlatStyle = FlatStyle.Flat; btnLogistico.FlatAppearance.BorderSize = 0; btnLogistico.Cursor = Cursors.Hand; }
            if (btnMantenimiento != null) { btnMantenimiento.BackColor = executiveBlue; btnMantenimiento.ForeColor = System.Drawing.Color.White; btnMantenimiento.Font = executiveFont; btnMantenimiento.FlatStyle = FlatStyle.Flat; btnMantenimiento.FlatAppearance.BorderSize = 0; btnMantenimiento.Cursor = Cursors.Hand; }
            if (btnVacaciones != null) { btnVacaciones.BackColor = executiveBlue; btnVacaciones.ForeColor = System.Drawing.Color.White; btnVacaciones.Font = executiveFont; btnVacaciones.FlatStyle = FlatStyle.Flat; btnVacaciones.FlatAppearance.BorderSize = 0; btnVacaciones.Cursor = Cursors.Hand; }
            if (btnPlanta != null) { btnPlanta.BackColor = executiveBlue; btnPlanta.ForeColor = System.Drawing.Color.White; btnPlanta.Font = executiveFont; btnPlanta.FlatStyle = FlatStyle.Flat; btnPlanta.FlatAppearance.BorderSize = 0; btnPlanta.Cursor = Cursors.Hand; }
            if (btnLegal != null) { btnLegal.BackColor = executiveBlue; btnLegal.ForeColor = System.Drawing.Color.White; btnLegal.Font = executiveFont; btnLegal.FlatStyle = FlatStyle.Flat; btnLegal.FlatAppearance.BorderSize = 0; btnLegal.Cursor = Cursors.Hand; }

            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240); // Gris claro
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
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

            // Formulario principal con estilo ejecutivo
            this.Text = "ERP - Menú Principal";
            this.ClientSize = new System.Drawing.Size(560, 220);
            this.BackColor = executiveGray;
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
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
