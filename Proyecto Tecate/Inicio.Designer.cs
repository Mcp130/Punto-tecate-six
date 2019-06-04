namespace Proyecto_Tecate
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.ButReporte = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ButSalir = new System.Windows.Forms.Button();
            this.ButAjuInv = new System.Windows.Forms.Button();
            this.ButPedidos = new System.Windows.Forms.Button();
            this.ButInventario = new System.Windows.Forms.Button();
            this.ButVentas = new System.Windows.Forms.Button();
            this.pan_contenedor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButReporte
            // 
            this.ButReporte.Image = global::Proyecto_Tecate.Properties.Resources.cogs;
            this.ButReporte.Location = new System.Drawing.Point(35, 376);
            this.ButReporte.Name = "ButReporte";
            this.ButReporte.Size = new System.Drawing.Size(118, 43);
            this.ButReporte.TabIndex = 9;
            this.ButReporte.Text = "Reporte";
            this.ButReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButReporte.UseVisualStyleBackColor = true;
            this.ButReporte.Click += new System.EventHandler(this.ButReporte_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Tecate.Properties.Resources.tecate_logo_B818A73577_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(23, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 228);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ButSalir
            // 
            this.ButSalir.Image = global::Proyecto_Tecate.Properties.Resources.exit;
            this.ButSalir.Location = new System.Drawing.Point(214, 376);
            this.ButSalir.Name = "ButSalir";
            this.ButSalir.Size = new System.Drawing.Size(118, 43);
            this.ButSalir.TabIndex = 5;
            this.ButSalir.Text = "Salir";
            this.ButSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButSalir.UseVisualStyleBackColor = true;
            this.ButSalir.Click += new System.EventHandler(this.ButSalir_Click);
            // 
            // ButAjuInv
            // 
            this.ButAjuInv.Image = global::Proyecto_Tecate.Properties.Resources.cog;
            this.ButAjuInv.Location = new System.Drawing.Point(214, 247);
            this.ButAjuInv.Name = "ButAjuInv";
            this.ButAjuInv.Size = new System.Drawing.Size(118, 43);
            this.ButAjuInv.TabIndex = 3;
            this.ButAjuInv.Text = "Ajustes de inventario";
            this.ButAjuInv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButAjuInv.UseVisualStyleBackColor = true;
            this.ButAjuInv.Click += new System.EventHandler(this.ButAjuInv_Click);
            // 
            // ButPedidos
            // 
            this.ButPedidos.Image = global::Proyecto_Tecate.Properties.Resources.paste;
            this.ButPedidos.Location = new System.Drawing.Point(35, 308);
            this.ButPedidos.Name = "ButPedidos";
            this.ButPedidos.Size = new System.Drawing.Size(118, 43);
            this.ButPedidos.TabIndex = 2;
            this.ButPedidos.Text = "Ajustes de proveedor";
            this.ButPedidos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButPedidos.UseVisualStyleBackColor = true;
            this.ButPedidos.Click += new System.EventHandler(this.ButPedidos_Click);
            // 
            // ButInventario
            // 
            this.ButInventario.Image = global::Proyecto_Tecate.Properties.Resources.clipboard;
            this.ButInventario.Location = new System.Drawing.Point(214, 308);
            this.ButInventario.Name = "ButInventario";
            this.ButInventario.Size = new System.Drawing.Size(118, 43);
            this.ButInventario.TabIndex = 1;
            this.ButInventario.Text = "Inventario";
            this.ButInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButInventario.UseVisualStyleBackColor = true;
            this.ButInventario.Click += new System.EventHandler(this.ButInventario_Click);
            // 
            // ButVentas
            // 
            this.ButVentas.Image = global::Proyecto_Tecate.Properties.Resources.cart;
            this.ButVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButVentas.Location = new System.Drawing.Point(35, 247);
            this.ButVentas.Name = "ButVentas";
            this.ButVentas.Size = new System.Drawing.Size(118, 43);
            this.ButVentas.TabIndex = 0;
            this.ButVentas.Text = "  Ventas";
            this.ButVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButVentas.UseVisualStyleBackColor = true;
            this.ButVentas.Click += new System.EventHandler(this.ButVentas_Click);
            // 
            // pan_contenedor
            // 
            this.pan_contenedor.AutoSize = true;
            this.pan_contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pan_contenedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pan_contenedor.Location = new System.Drawing.Point(366, 13);
            this.pan_contenedor.Name = "pan_contenedor";
            this.pan_contenedor.Size = new System.Drawing.Size(972, 674);
            this.pan_contenedor.TabIndex = 12;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pan_contenedor);
            this.Controls.Add(this.ButReporte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButSalir);
            this.Controls.Add(this.ButAjuInv);
            this.Controls.Add(this.ButPedidos);
            this.Controls.Add(this.ButInventario);
            this.Controls.Add(this.ButVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.Text = "Tecate Six Ixtlan";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButVentas;
        private System.Windows.Forms.Button ButInventario;
        private System.Windows.Forms.Button ButPedidos;
        private System.Windows.Forms.Button ButAjuInv;
        private System.Windows.Forms.Button ButSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButReporte;
        public System.Windows.Forms.Panel pan_contenedor;
    }
}

