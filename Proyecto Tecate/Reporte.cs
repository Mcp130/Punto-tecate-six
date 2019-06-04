using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tecate
{
    public partial class Reporte : Form
    {
        //Manda a llamar a la clase validacion
        validacion va = new validacion();
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        //se utiliza el reporte inventario_def1
        private inventario_def inventario_def1;
        //manda llamar a la clase basededatos
        BaseDeDatos bd = new BaseDeDatos();


        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        //Da todos los parametros del la ventana del cristal report 
        //se agrega solo cuando se colo el diseño en la parte del diseño
        private void InitializeComponent()
        {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.inventario_def1 = new Proyecto_Tecate.inventario_def();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.inventario_def1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(956, 635);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load_1);
            // 
            // Reporte
            // 
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load_1);
            this.ResumeLayout(false);

        }

        private void Reporte_Load_1(object sender, EventArgs e)
        {
            //quita los bordes y lo hace a pantalla completa
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {
           
        }
    }
}
