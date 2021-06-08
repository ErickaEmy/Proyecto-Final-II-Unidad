namespace Proyecto_Final_Anco_Martinez
{
    partial class FrmEjercicio7
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
            this.dgvBilletes = new System.Windows.Forms.DataGridView();
            this.txtMonedas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMonedas = new System.Windows.Forms.DataGridView();
            this.txtBilletes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBilletes
            // 
            this.dgvBilletes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilletes.Location = new System.Drawing.Point(59, 105);
            this.dgvBilletes.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBilletes.Name = "dgvBilletes";
            this.dgvBilletes.ReadOnly = true;
            this.dgvBilletes.RowHeadersWidth = 51;
            this.dgvBilletes.RowTemplate.Height = 24;
            this.dgvBilletes.Size = new System.Drawing.Size(226, 145);
            this.dgvBilletes.TabIndex = 51;
            // 
            // txtMonedas
            // 
            this.txtMonedas.BackColor = System.Drawing.Color.White;
            this.txtMonedas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonedas.Location = new System.Drawing.Point(427, 344);
            this.txtMonedas.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonedas.Name = "txtMonedas";
            this.txtMonedas.Size = new System.Drawing.Size(82, 22);
            this.txtMonedas.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 344);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Total de Monedas";
            // 
            // dgvMonedas
            // 
            this.dgvMonedas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonedas.Location = new System.Drawing.Point(311, 105);
            this.dgvMonedas.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMonedas.Name = "dgvMonedas";
            this.dgvMonedas.ReadOnly = true;
            this.dgvMonedas.RowHeadersWidth = 51;
            this.dgvMonedas.RowTemplate.Height = 24;
            this.dgvMonedas.Size = new System.Drawing.Size(234, 222);
            this.dgvMonedas.TabIndex = 48;
            // 
            // txtBilletes
            // 
            this.txtBilletes.BackColor = System.Drawing.Color.White;
            this.txtBilletes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilletes.Location = new System.Drawing.Point(196, 344);
            this.txtBilletes.Margin = new System.Windows.Forms.Padding(2);
            this.txtBilletes.Name = "txtBilletes";
            this.txtBilletes.Size = new System.Drawing.Size(89, 22);
            this.txtBilletes.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 347);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total de Billetes";
            // 
            // btnRetirar
            // 
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(441, 65);
            this.btnRetirar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(104, 26);
            this.btnRetirar.TabIndex = 45;
            this.btnRetirar.Text = "Retirar";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(240, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 26);
            this.label6.TabIndex = 44;
            this.label6.Text = "Cajero";
            // 
            // txtMonto
            // 
            this.txtMonto.BackColor = System.Drawing.Color.White;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(107, 71);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(2);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(292, 22);
            this.txtMonto.TabIndex = 43;
            this.txtMonto.TextChanged += new System.EventHandler(this.txtMonto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Monto";
            // 
            // FrmEjercicio7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 407);
            this.Controls.Add(this.dgvBilletes);
            this.Controls.Add(this.txtMonedas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMonedas);
            this.Controls.Add(this.txtBilletes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Name = "FrmEjercicio7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio7";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilletes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonedas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBilletes;
        private System.Windows.Forms.TextBox txtMonedas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMonedas;
        private System.Windows.Forms.TextBox txtBilletes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
    }
}