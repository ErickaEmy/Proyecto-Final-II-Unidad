namespace Proyecto_Final_Anco_Martinez
{
    partial class FrmEjercicio10
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
            this.dgvProcesos = new System.Windows.Forms.DataGridView();
            this.btnVer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvDiagrama = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMediaEspera = new System.Windows.Forms.TextBox();
            this.btnCalcularMedEsp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEspera = new System.Windows.Forms.TextBox();
            this.btnCalcularEsp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProcesos = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagrama)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProcesos
            // 
            this.dgvProcesos.AllowUserToAddRows = false;
            this.dgvProcesos.AllowUserToDeleteRows = false;
            this.dgvProcesos.AllowUserToResizeColumns = false;
            this.dgvProcesos.AllowUserToResizeRows = false;
            this.dgvProcesos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProcesos.Location = new System.Drawing.Point(1026, 109);
            this.dgvProcesos.Name = "dgvProcesos";
            this.dgvProcesos.ReadOnly = true;
            this.dgvProcesos.RowHeadersVisible = false;
            this.dgvProcesos.RowHeadersWidth = 51;
            this.dgvProcesos.RowTemplate.Height = 24;
            this.dgvProcesos.Size = new System.Drawing.Size(212, 265);
            this.dgvProcesos.TabIndex = 55;
            // 
            // btnVer
            // 
            this.btnVer.Enabled = false;
            this.btnVer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Location = new System.Drawing.Point(1140, 568);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(98, 32);
            this.btnVer.TabIndex = 54;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 510);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "DIAGRAMA DE GRANT";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(1140, 393);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(98, 32);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(1140, 431);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(98, 32);
            this.btnReiniciar.TabIndex = 52;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1140, 469);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(98, 32);
            this.btnSalir.TabIndex = 45;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvDiagrama
            // 
            this.dgvDiagrama.AllowUserToAddRows = false;
            this.dgvDiagrama.AllowUserToDeleteRows = false;
            this.dgvDiagrama.AllowUserToResizeColumns = false;
            this.dgvDiagrama.AllowUserToResizeRows = false;
            this.dgvDiagrama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagrama.EnableHeadersVisualStyles = false;
            this.dgvDiagrama.Location = new System.Drawing.Point(25, 533);
            this.dgvDiagrama.MultiSelect = false;
            this.dgvDiagrama.Name = "dgvDiagrama";
            this.dgvDiagrama.ReadOnly = true;
            this.dgvDiagrama.RowHeadersVisible = false;
            this.dgvDiagrama.RowHeadersWidth = 51;
            this.dgvDiagrama.RowTemplate.Height = 24;
            this.dgvDiagrama.Size = new System.Drawing.Size(995, 67);
            this.dgvDiagrama.TabIndex = 51;
            this.dgvDiagrama.SelectionChanged += new System.EventHandler(this.dgvDiagrama_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMediaEspera);
            this.groupBox2.Controls.Add(this.btnCalcularMedEsp);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(533, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 299);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo Medio de Espera";
            // 
            // txtMediaEspera
            // 
            this.txtMediaEspera.BackColor = System.Drawing.Color.White;
            this.txtMediaEspera.Enabled = false;
            this.txtMediaEspera.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMediaEspera.Location = new System.Drawing.Point(28, 27);
            this.txtMediaEspera.Multiline = true;
            this.txtMediaEspera.Name = "txtMediaEspera";
            this.txtMediaEspera.ReadOnly = true;
            this.txtMediaEspera.Size = new System.Drawing.Size(432, 221);
            this.txtMediaEspera.TabIndex = 6;
            // 
            // btnCalcularMedEsp
            // 
            this.btnCalcularMedEsp.Enabled = false;
            this.btnCalcularMedEsp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularMedEsp.Location = new System.Drawing.Point(362, 254);
            this.btnCalcularMedEsp.Name = "btnCalcularMedEsp";
            this.btnCalcularMedEsp.Size = new System.Drawing.Size(98, 32);
            this.btnCalcularMedEsp.TabIndex = 12;
            this.btnCalcularMedEsp.Text = "Calcular";
            this.btnCalcularMedEsp.UseVisualStyleBackColor = true;
            this.btnCalcularMedEsp.Click += new System.EventHandler(this.btnCalcularMedEsp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEspera);
            this.groupBox1.Controls.Add(this.btnCalcularEsp);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 299);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo de Espera";
            // 
            // txtEspera
            // 
            this.txtEspera.BackColor = System.Drawing.Color.White;
            this.txtEspera.Enabled = false;
            this.txtEspera.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEspera.Location = new System.Drawing.Point(28, 27);
            this.txtEspera.Multiline = true;
            this.txtEspera.Name = "txtEspera";
            this.txtEspera.ReadOnly = true;
            this.txtEspera.Size = new System.Drawing.Size(432, 221);
            this.txtEspera.TabIndex = 6;
            // 
            // btnCalcularEsp
            // 
            this.btnCalcularEsp.Enabled = false;
            this.btnCalcularEsp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularEsp.Location = new System.Drawing.Point(362, 254);
            this.btnCalcularEsp.Name = "btnCalcularEsp";
            this.btnCalcularEsp.Size = new System.Drawing.Size(98, 32);
            this.btnCalcularEsp.TabIndex = 38;
            this.btnCalcularEsp.Text = "Calcular";
            this.btnCalcularEsp.UseVisualStyleBackColor = true;
            this.btnCalcularEsp.Click += new System.EventHandler(this.btnCalcularEsp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbTipo);
            this.groupBox3.Controls.Add(this.txtValor);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtProcesos);
            this.groupBox3.Controls.Add(this.btnAgregar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(25, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(995, 80);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Registros";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(308, 33);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(305, 28);
            this.cmbTipo.TabIndex = 11;
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.White;
            this.txtValor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(688, 33);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(140, 26);
            this.txtValor.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(634, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tipo";
            // 
            // txtProcesos
            // 
            this.txtProcesos.BackColor = System.Drawing.Color.White;
            this.txtProcesos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesos.Location = new System.Drawing.Point(106, 32);
            this.txtProcesos.Name = "txtProcesos";
            this.txtProcesos.Size = new System.Drawing.Size(147, 26);
            this.txtProcesos.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(843, 29);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 32);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Procesos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(594, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 34);
            this.label1.TabIndex = 47;
            this.label1.Text = "FCFS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(355, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 34);
            this.label6.TabIndex = 46;
            this.label6.Text = "Algortimo de planificación de procesos";
            // 
            // FrmEjercicio10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 625);
            this.Controls.Add(this.dgvProcesos);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvDiagrama);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "FrmEjercicio10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio10";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProcesos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagrama)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProcesos;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvDiagrama;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMediaEspera;
        private System.Windows.Forms.Button btnCalcularMedEsp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEspera;
        private System.Windows.Forms.Button btnCalcularEsp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProcesos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}