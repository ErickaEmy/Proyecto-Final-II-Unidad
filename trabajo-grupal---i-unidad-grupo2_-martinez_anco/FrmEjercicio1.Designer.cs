namespace Proyecto_Final_Anco_Martinez
{
    partial class FrmEjercicio1
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
            this.txtElemento1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregar1 = new System.Windows.Forms.Button();
            this.txtLista1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLista2 = new System.Windows.Forms.TextBox();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtElemento2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvRepeticiones = new System.Windows.Forms.DataGridView();
            this.dgvComparaciones = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // txtElemento1
            // 
            this.txtElemento1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento1.Location = new System.Drawing.Point(99, 31);
            this.txtElemento1.Name = "txtElemento1";
            this.txtElemento1.Size = new System.Drawing.Size(297, 26);
            this.txtElemento1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elemento";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar1);
            this.groupBox1.Controls.Add(this.txtLista1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtElemento1);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(37, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 302);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista 1";
            // 
            // btnAgregar1
            // 
            this.btnAgregar1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar1.Location = new System.Drawing.Point(292, 67);
            this.btnAgregar1.Name = "btnAgregar1";
            this.btnAgregar1.Size = new System.Drawing.Size(104, 29);
            this.btnAgregar1.TabIndex = 3;
            this.btnAgregar1.Text = "Agregar";
            this.btnAgregar1.UseVisualStyleBackColor = true;
            this.btnAgregar1.Click += new System.EventHandler(this.btnAgregar1_Click);
            // 
            // txtLista1
            // 
            this.txtLista1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLista1.Location = new System.Drawing.Point(20, 116);
            this.txtLista1.Multiline = true;
            this.txtLista1.Name = "txtLista1";
            this.txtLista1.Size = new System.Drawing.Size(376, 164);
            this.txtLista1.TabIndex = 5;
            this.txtLista1.TextChanged += new System.EventHandler(this.txtLista1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLista2);
            this.groupBox2.Controls.Add(this.btnAgregar2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtElemento2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(498, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 302);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista 2";
            // 
            // txtLista2
            // 
            this.txtLista2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLista2.Location = new System.Drawing.Point(20, 118);
            this.txtLista2.Multiline = true;
            this.txtLista2.Name = "txtLista2";
            this.txtLista2.Size = new System.Drawing.Size(376, 162);
            this.txtLista2.TabIndex = 6;
            this.txtLista2.TextChanged += new System.EventHandler(this.txtLista2_TextChanged);
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregar2.Location = new System.Drawing.Point(292, 67);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(104, 29);
            this.btnAgregar2.TabIndex = 3;
            this.btnAgregar2.Text = "Agregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Elemento";
            // 
            // txtElemento2
            // 
            this.txtElemento2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtElemento2.Location = new System.Drawing.Point(99, 31);
            this.txtElemento2.Name = "txtElemento2";
            this.txtElemento2.Size = new System.Drawing.Size(297, 26);
            this.txtElemento2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(269, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comparación de Listas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvRepeticiones);
            this.groupBox3.Controls.Add(this.dgvComparaciones);
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnVer);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(37, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(881, 216);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de repeticiones";
            // 
            // dgvRepeticiones
            // 
            this.dgvRepeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepeticiones.Location = new System.Drawing.Point(385, 36);
            this.dgvRepeticiones.Name = "dgvRepeticiones";
            this.dgvRepeticiones.RowHeadersWidth = 51;
            this.dgvRepeticiones.RowTemplate.Height = 24;
            this.dgvRepeticiones.Size = new System.Drawing.Size(333, 160);
            this.dgvRepeticiones.TabIndex = 9;
            // 
            // dgvComparaciones
            // 
            this.dgvComparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComparaciones.Location = new System.Drawing.Point(20, 36);
            this.dgvComparaciones.Name = "dgvComparaciones";
            this.dgvComparaciones.RowHeadersWidth = 51;
            this.dgvComparaciones.RowTemplate.Height = 24;
            this.dgvComparaciones.Size = new System.Drawing.Size(333, 160);
            this.dgvComparaciones.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalir.Location = new System.Drawing.Point(753, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Location = new System.Drawing.Point(753, 123);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(104, 29);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLimpiar.Location = new System.Drawing.Point(753, 79);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 29);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVer
            // 
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVer.Location = new System.Drawing.Point(753, 36);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(104, 29);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // FrmEjercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmEjercicio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEjercicio1";
            this.Load += new System.EventHandler(this.FrmEjercicio1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComparaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElemento1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtElemento2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLista1;
        private System.Windows.Forms.TextBox txtLista2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvRepeticiones;
        private System.Windows.Forms.DataGridView dgvComparaciones;
    }
}