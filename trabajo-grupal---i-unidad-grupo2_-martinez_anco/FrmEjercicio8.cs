using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Anco_Martinez
{
    public partial class FrmEjercicio8 : Form
    {
        int indexRow;
        string actual1, actual2;
        private DataGridViewColumn[] titulo1 = new DataGridViewColumn[1];
        private DataGridViewColumn[] titulo2 = new DataGridViewColumn[1];
        public FrmEjercicio8()
        {
            InitializeComponent();
            titulo1[0] = new DataGridViewTextBoxColumn();
            titulo1[0].HeaderText = "Ciudades";
            titulo1[0].Width = 153;
            titulo2[0] = new DataGridViewTextBoxColumn();
            titulo2[0].HeaderText = "Ciudades";
            titulo2[0].Width = 153;
            dgvLista1.Columns.AddRange(titulo1);
            dgvLista2.Columns.AddRange(titulo2);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Verifica si el textbox sea diferente al vacío.
            //Si la condicion se cumple, se añadirá al dgv el dato escrito.
            if (txtCiudad.Text == "")
            {
                MessageBox.Show("Ingrese una ciudad.",
                "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                dgvLista1.Rows.Add(txtCiudad.Text);
                txtCiudad.Clear();
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            //Verifica si la lista 1 sea diferente a 0.
            //Si la condicion se cumple, se agregará a la lista 2 el elemento seleccionado de la lista1
            if (dgvLista1.RowCount != 0)
            {
                dgvLista2.Rows.Add(dgvLista1.CurrentRow.Cells[0].Value);
                dgvLista1.Rows.Remove(dgvLista1.CurrentRow);
            }
        }

        private void btnDerechaTodos_Click(object sender, EventArgs e)
        {
            //Se agregará un for para recorrer desde 0 hasta la cantidad de elementos de la lista 1.
            //En cada iteracción, agrega a la lista 2 el elemento de la lista 1 con índice i.
            for (int i = 0; i < dgvLista1.RowCount; i++)
            {
                dgvLista2.Rows.Add(dgvLista1.Rows[i].Cells[0].Value);
            }
            dgvLista1.Rows.Clear();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Verifica si la lista 2 sea diferente a 0.
            //Si la condicion se cumple, se agregará a la lista 1 el elemento seleccionado de la lista 2.
            if (dgvLista2.RowCount != 0)
            {
                dgvLista1.Rows.Add(dgvLista2.CurrentRow.Cells[0].Value);
                dgvLista2.Rows.Remove(dgvLista2.CurrentRow);
            }
        }

        private void btnRetirarTodos_Click(object sender, EventArgs e)
        {
            //Se agregará un for para recorrer desde 0 hasta la cantidad de elementos de la lista 2.
            //En cada iteracción, agrega a la lista 1 el elemento de la lista 2 con índice i.
            for (int i = 0; i < dgvLista2.RowCount; i++)
            {
                dgvLista1.Rows.Add(dgvLista2.Rows[i].Cells[0].Value);
            }
            dgvLista2.Rows.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpia las filas de las 2 listas.
            txtCiudad.Clear();
            dgvLista1.Rows.Clear();
            dgvLista2.Rows.Clear();
        }
    }
}
