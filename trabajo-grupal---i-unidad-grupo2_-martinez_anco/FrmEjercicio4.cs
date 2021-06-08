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
    public partial class FrmEjercicio4 : Form
    {
        int auxiliar = 0;
        private DataGridViewColumn[] casilla = new DataGridViewColumn[4];
        public FrmEjercicio4()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Limpiamos todas las columnas existentes en el dgv, también las filas.
            dgvMuestra.Columns.Clear();
            dgvMuestra.Rows.Clear();
            //Creamos las 4 columnas con un ancho de 80.
            casilla[0] = new DataGridViewTextBoxColumn();
            casilla[0].Width = 80;
            casilla[1] = new DataGridViewTextBoxColumn();
            casilla[1].Width = 80;
            casilla[2] = new DataGridViewTextBoxColumn();
            casilla[2].Width = 80;
            casilla[3] = new DataGridViewTextBoxColumn();
            casilla[3].Width = 80;
            dgvMuestra.Columns.AddRange(casilla);
            //Agregamos 4 filas, con valor vacío.
            dgvMuestra.Rows.Add("", "", "", "", "");
            dgvMuestra.Rows.Add("", "", "", "", "");
            dgvMuestra.Rows.Add("", "", "", "", "");
            dgvMuestra.Rows.Add("", "", "", "", "");
            //Definimos el tamaño de las filas agregadas a 79.
            dgvMuestra.Rows[0].Height = 79;
            dgvMuestra.Rows[1].Height = 79;
            dgvMuestra.Rows[2].Height = 79;
            dgvMuestra.Rows[3].Height = 79;
            //Este auxiliar nos indicará si hay una matriz creada.
            auxiliar = 1;

        }

        private void dgvResultado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            //Si auxiliar es igual a uno, entonces solo editaremos los colores.
            if (auxiliar == 1)
            {
                dgvMuestra.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[2].Cells[2].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[3].Cells[3].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[0].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
            }
            //Si no es igual a uno, vamos a generar una nueva matriz.
            else
            {
                //Limpiamos todas las columnas existentes en el dgv, también las filas.
                dgvMuestra.Columns.Clear();
                dgvMuestra.Rows.Clear();
                //Creamos las 4 columnas con un ancho de 80.
                casilla[0] = new DataGridViewTextBoxColumn();
                casilla[0].Width = 80;
                casilla[1] = new DataGridViewTextBoxColumn();
                casilla[1].Width = 80;
                casilla[2] = new DataGridViewTextBoxColumn();
                casilla[2].Width = 80;
                casilla[3] = new DataGridViewTextBoxColumn();
                casilla[3].Width = 80;
                dgvMuestra.Columns.AddRange(casilla);
                //Agregamos 4 filas, con valor vacío.
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                //Definimos el tamaño de las filas agregadas a 79.
                dgvMuestra.Rows[0].Height = 79;
                dgvMuestra.Rows[1].Height = 79;
                dgvMuestra.Rows[2].Height = 79;
                dgvMuestra.Rows[3].Height = 79;
                auxiliar = 1;
                dgvMuestra.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[2].Cells[2].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[3].Cells[3].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[0].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
            }
        }

        private void btnSecundaria_Click(object sender, EventArgs e)
        {
            //Si auxiliar es igual a uno, entonces solo editaremos los colores.
            if (auxiliar == 1)
            {
                dgvMuestra.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[0].Cells[3].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[2].Cells[1].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[3].Cells[0].Style.BackColor = Color.FromArgb(198, 255, 191);
            }
            //Si no es igual a uno, vamos a generar una nueva matriz.
            else
            {
                //Limpiamos todas las columnas existentes en el dgv, también las filas.
                dgvMuestra.Columns.Clear();
                dgvMuestra.Rows.Clear();
                //Creamos las 4 columnas con un ancho de 80.
                casilla[0] = new DataGridViewTextBoxColumn();
                casilla[0].Width = 80;
                casilla[1] = new DataGridViewTextBoxColumn();
                casilla[1].Width = 80;
                casilla[2] = new DataGridViewTextBoxColumn();
                casilla[2].Width = 80;
                casilla[3] = new DataGridViewTextBoxColumn();
                casilla[3].Width = 80;
                dgvMuestra.Columns.AddRange(casilla);
                //Agregamos 4 filas, con valor vacío.
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                dgvMuestra.Rows.Add("", "", "", "", "");
                //Definimos el tamaño de las filas agregadas a 79.
                dgvMuestra.Rows[0].Height = 79;
                dgvMuestra.Rows[1].Height = 79;
                dgvMuestra.Rows[2].Height = 79;
                dgvMuestra.Rows[3].Height = 79;
                auxiliar = 1;
                dgvMuestra.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[0].Cells[3].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[2].Cells[1].Style.BackColor = Color.FromArgb(198, 255, 191);
                dgvMuestra.Rows[3].Cells[0].Style.BackColor = Color.FromArgb(198, 255, 191);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (auxiliar == 1)
            {
                dgvMuestra.Rows[0].Cells[0].Value = "";
                dgvMuestra.Rows[0].Cells[1].Value = "";
                dgvMuestra.Rows[0].Cells[2].Value = "";
                dgvMuestra.Rows[0].Cells[3].Value = "";
                dgvMuestra.Rows[1].Cells[0].Value = "";
                dgvMuestra.Rows[1].Cells[1].Value = "";
                dgvMuestra.Rows[1].Cells[2].Value = "";
                dgvMuestra.Rows[1].Cells[3].Value = "";
                dgvMuestra.Rows[2].Cells[0].Value = "";
                dgvMuestra.Rows[2].Cells[1].Value = "";
                dgvMuestra.Rows[2].Cells[2].Value = "";
                dgvMuestra.Rows[2].Cells[3].Value = "";
                dgvMuestra.Rows[3].Cells[0].Value = "";
                dgvMuestra.Rows[3].Cells[1].Value = "";
                dgvMuestra.Rows[3].Cells[2].Value = "";
                dgvMuestra.Rows[3].Cells[3].Value = "";
            }
            else
            {
                MessageBox.Show("No hay ninguna matriz creada.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            auxiliar = 0;
            dgvMuestra.Columns.Clear();
            dgvMuestra.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (auxiliar == 1)
            {
                dgvMuestra.Rows[0].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[0].Cells[3].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[2].Cells[1].Style.BackColor = Color.FromArgb(255, 255, 255);
                dgvMuestra.Rows[3].Cells[0].Style.BackColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                MessageBox.Show("No hay ninguna matriz creada.",
                    "Ejercicio 4", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
