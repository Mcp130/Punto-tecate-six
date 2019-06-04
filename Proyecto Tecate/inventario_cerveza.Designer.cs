namespace Proyecto_Tecate
{
    partial class inventario_cerveza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventario_cerveza));
            this.label9 = new System.Windows.Forms.Label();
            this.TexBCB = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Codigo de barra";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // TexBCB
            // 
            this.TexBCB.Location = new System.Drawing.Point(31, 56);
            this.TexBCB.Name = "TexBCB";
            this.TexBCB.Size = new System.Drawing.Size(147, 20);
            this.TexBCB.TabIndex = 32;
            this.TexBCB.TextChanged += new System.EventHandler(this.TexBCB_TextChanged);
            this.TexBCB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TexBCB_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(919, 496);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ButSalir
            // 
            this.ButSalir.Image = global::Proyecto_Tecate.Properties.Resources.exit__1_;
            this.ButSalir.Location = new System.Drawing.Point(836, 590);
            this.ButSalir.Name = "ButSalir";
            this.ButSalir.Size = new System.Drawing.Size(90, 33);
            this.ButSalir.TabIndex = 31;
            this.ButSalir.Text = " Salir";
            this.ButSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButSalir.UseVisualStyleBackColor = true;
            this.ButSalir.Click += new System.EventHandler(this.ButSalir_Click);
            // 
            // inventario_cerveza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TexBCB);
            this.Controls.Add(this.ButSalir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "inventario_cerveza";
            this.Text = "inventario_cerveza";
            this.Load += new System.EventHandler(this.inventario_cerveza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButSalir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TexBCB;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}