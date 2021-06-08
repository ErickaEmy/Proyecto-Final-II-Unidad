namespace Proyecto_Final_Anco_Martinez
{
    partial class FrmEjercicio8
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLista2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLista1 = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnRetirarTodos = new System.Windows.Forms.Button();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.btnDerechaTodos = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista2
            // 
            this.dgvLista2.AllowUserToAddRows = false;
            this.dgvLista2.AllowUserToDeleteRows = false;
            this.dgvLista2.AllowUserToResizeColumns = false;
            this.dgvLista2.AllowUserToResizeRows = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvLista2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista2.Location = new System.Drawing.Point(354, 162);
            this.dgvLista2.Name = "dgvLista2";
            this.dgvLista2.ReadOnly = true;
            this.dgvLista2.RowHeadersVisible = false;
            this.dgvLista2.Size = new System.Drawing.Size(156, 161);
            this.dgvLista2.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "LISTAS DE CIUDADES";
            // 
            // dgvLista1
            // 
            this.dgvLista1.AllowUserToAddRows = false;
            this.dgvLista1.AllowUserToDeleteRows = false;
            this.dgvLista1.AllowUserToResizeColumns = false;
            this.dgvLista1.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvLista1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista1.Location = new System.Drawing.Point(54, 162);
            this.dgvLista1.Name = "dgvLista1";
            this.dgvLista1.ReadOnly = true;
            this.dgvLista1.RowHeadersVisible = false;
            this.dgvLista1.Size = new System.Drawing.Size(156, 161);
            this.dgvLista1.TabIndex = 20;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(232, 300);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRetirarTodos
            // 
            this.btnRetirarTodos.Location = new System.Drawing.Point(232, 255);
            this.btnRetirarTodos.Name = "btnRetirarTodos";
            this.btnRetirarTodos.Size = new System.Drawing.Size(100, 23);
            this.btnRetirarTodos.TabIndex = 18;
            this.btnRetirarTodos.Text = "<<- Retirar Todos";
            this.btnRetirarTodos.UseVisualStyleBackColor = true;
            this.btnRetirarTodos.Click += new System.EventHandler(this.btnRetirarTodos_Click);
            // 
            // btnRetirar
            // 
            this.btnRetirar.Location = new System.Drawing.Point(232, 224);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(100, 23);
            this.btnRetirar.TabIndex = 17;
            this.btnRetirar.Text = "<- Retirar Uno";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // btnDerechaTodos
            // 
            this.btnDerechaTodos.Location = new System.Drawing.Point(232, 193);
            this.btnDerechaTodos.Name = "btnDerechaTodos";
            this.btnDerechaTodos.Size = new System.Drawing.Size(100, 23);
            this.btnDerechaTodos.TabIndex = 16;
            this.btnDerechaTodos.Text = "Pasar Todos ->>";
            this.btnDerechaTodos.UseVisualStyleBackColor = true;
            this.btnDerechaTodos.Click += new System.EventHandler(this.btnDerechaTodos_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(232, 162);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(100, 23);
            this.btnDerecha.TabIndex = 15;
            this.btnDerecha.Text = "Pasar Uno ->";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(371, 110);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCiudad
            // 
            this.txtCiudad.Location = new System.Drawing.Point(222, 112);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(125, 20);
            this.txtCiudad.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingresa una ciudad:";
            // 
            // FrmEjercicio8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 374);
            this.Controls.Add(this.dgvLista2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLista1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRetirarTodos);
            this.Controls.Add(this.btnRetirar);
            this.Controls.Add(this.btnDerechaTodos);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label1);
            this.Name = "FrmEjercicio8";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio8";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLista1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnRetirarTodos;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.Button btnDerechaTodos;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label1;
    }
}