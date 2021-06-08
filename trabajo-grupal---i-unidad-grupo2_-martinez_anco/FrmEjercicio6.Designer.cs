namespace Proyecto_Final_Anco_Martinez
{
    partial class FrmEjercicio6
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnSi = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.dgvProceso = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblDiag = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.panel1.Controls.Add(this.btnNo);
            this.panel1.Controls.Add(this.btnSi);
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.lblPregunta);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.panel1.Location = new System.Drawing.Point(22, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 223);
            this.panel1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTitulo.Location = new System.Drawing.Point(12, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(20, 29);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "-";
            this.lblTitulo.Visible = false;
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(201)))), ((int)(((byte)(254)))));
            this.lblPregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPregunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblPregunta.Location = new System.Drawing.Point(13, 67);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(15, 20);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "-";
            this.lblPregunta.Visible = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnIniciar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnIniciar.Location = new System.Drawing.Point(172, 59);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(165, 70);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR TEST";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSi
            // 
            this.btnSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSi.Location = new System.Drawing.Point(150, 165);
            this.btnSi.Name = "btnSi";
            this.btnSi.Size = new System.Drawing.Size(75, 41);
            this.btnSi.TabIndex = 2;
            this.btnSi.Text = "Sí";
            this.btnSi.UseVisualStyleBackColor = true;
            this.btnSi.Visible = false;
            this.btnSi.Click += new System.EventHandler(this.btnSi_Click);
            // 
            // btnNo
            // 
            this.btnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnNo.Location = new System.Drawing.Point(240, 165);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(75, 41);
            this.btnNo.TabIndex = 4;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Visible = false;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // dgvProceso
            // 
            this.dgvProceso.AllowUserToAddRows = false;
            this.dgvProceso.AllowUserToDeleteRows = false;
            this.dgvProceso.AllowUserToResizeColumns = false;
            this.dgvProceso.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProceso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProceso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProceso.Location = new System.Drawing.Point(526, 150);
            this.dgvProceso.Name = "dgvProceso";
            this.dgvProceso.RowHeadersVisible = false;
            this.dgvProceso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvProceso.Size = new System.Drawing.Size(246, 223);
            this.dgvProceso.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(575, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "HISTORIAL DE\r\nDECISIONES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiagnostico.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostico.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiagnostico.Location = new System.Drawing.Point(100, 409);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(161, 29);
            this.lblDiagnostico.TabIndex = 6;
            this.lblDiagnostico.Text = "DIAGNÓSTICO:";
            this.lblDiagnostico.Visible = false;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.BackColor = System.Drawing.SystemColors.Control;
            this.lblDiag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDiag.Location = new System.Drawing.Point(305, 407);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(15, 20);
            this.lblDiag.TabIndex = 5;
            this.lblDiag.Text = "-";
            this.lblDiag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDiag.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fuente: SERGAS - Servicio Gallego de Salud";
            // 
            // FrmEjercicio6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 541);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiag);
            this.Controls.Add(this.lblDiagnostico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProceso);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEjercicio6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Button btnSi;
        private System.Windows.Forms.DataGridView dgvProceso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.Label label2;
    }
}