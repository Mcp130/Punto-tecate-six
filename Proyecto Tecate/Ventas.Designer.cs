namespace Proyecto_Tecate
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.label1 = new System.Windows.Forms.Label();
            this.texBcodigo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TexBTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ButAgregar = new System.Windows.Forms.Button();
            this.ButCobrar = new System.Windows.Forms.Button();
            this.ButSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de Barra";
            // 
            // texBcodigo
            // 
            this.texBcodigo.Location = new System.Drawing.Point(142, 127);
            this.texBcodigo.Name = "texBcodigo";
            this.texBcodigo.Size = new System.Drawing.Size(163, 20);
            this.texBcodigo.TabIndex = 1;
            this.texBcodigo.TextChanged += new System.EventHandler(this.codigo_TextChanged);
            this.texBcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codigo_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TexBTotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(441, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 36);
            this.panel1.TabIndex = 10;
            // 
            // TexBTotal
            // 
            this.TexBTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TexBTotal.Location = new System.Drawing.Point(73, 5);
            this.TexBTotal.Name = "TexBTotal";
            this.TexBTotal.ReadOnly = true;
            this.TexBTotal.Size = new System.Drawing.Size(91, 26);
            this.TexBTotal.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(65, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 15);
            this.label9.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 21);
            this.comboBox1.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Quien cobró";
            // 
            // ButAgregar
            // 
            this.ButAgregar.Image = global::Proyecto_Tecate.Properties.Resources.plus_22x22;
            this.ButAgregar.Location = new System.Drawing.Point(315, 120);
            this.ButAgregar.Name = "ButAgregar";
            this.ButAgregar.Size = new System.Drawing.Size(95, 33);
            this.ButAgregar.TabIndex = 33;
            this.ButAgregar.Text = "  Agregar";
            this.ButAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButAgregar.UseVisualStyleBackColor = true;
            this.ButAgregar.Click += new System.EventHandler(this.ButAgregar_Click);
            // 
            // ButCobrar
            // 
            this.ButCobrar.Image = global::Proyecto_Tecate.Properties.Resources.coin_dollar_22x22;
            this.ButCobrar.Location = new System.Drawing.Point(626, 575);
            this.ButCobrar.Name = "ButCobrar";
            this.ButCobrar.Size = new System.Drawing.Size(90, 33);
            this.ButCobrar.TabIndex = 32;
            this.ButCobrar.Text = " Cobrar";
            this.ButCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButCobrar.UseVisualStyleBackColor = true;
            this.ButCobrar.Click += new System.EventHandler(this.ButCobrar_Click);
            // 
            // ButSalir
            // 
            this.ButSalir.Image = global::Proyecto_Tecate.Properties.Resources.exit__1_;
            this.ButSalir.Location = new System.Drawing.Point(818, 575);
            this.ButSalir.Name = "ButSalir";
            this.ButSalir.Size = new System.Drawing.Size(90, 33);
            this.ButSalir.TabIndex = 31;
            this.ButSalir.Text = "Salir";
            this.ButSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButSalir.UseVisualStyleBackColor = true;
            this.ButSalir.Click += new System.EventHandler(this.ButSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 367);
            this.dataGridView1.TabIndex = 38;
            // 
            // butCancelar
            // 
            this.butCancelar.Image = global::Proyecto_Tecate.Properties.Resources.coin_dollar_22x22;
            this.butCancelar.Location = new System.Drawing.Point(722, 575);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(90, 33);
            this.butCancelar.TabIndex = 40;
            this.butCancelar.Text = " Cancelar";
            this.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.butCancelar.UseVisualStyleBackColor = true;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 635);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ButAgregar);
            this.Controls.Add(this.ButCobrar);
            this.Controls.Add(this.ButSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.texBcodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texBcodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButSalir;
        private System.Windows.Forms.Button ButCobrar;
        private System.Windows.Forms.Button ButAgregar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TexBTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butCancelar;
    }
}