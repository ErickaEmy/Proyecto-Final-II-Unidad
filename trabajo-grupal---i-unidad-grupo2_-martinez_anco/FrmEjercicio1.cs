using System;
using System.Collections.Generic;
using System.Collections; //referencia para el arraylist
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Anco_Martinez
{
    public partial class FrmEjercicio1 : Form
    {
        int cont1,cont2, cont3,cont4;
        ArrayList lista1 = new ArrayList();
        ArrayList lista2 = new ArrayList();
        ArrayList lista3 = new ArrayList();
        ArrayList listaAux = new ArrayList();
        ArrayList repet = new ArrayList();
        private DataGridViewColumn[] titulo = new DataGridViewColumn[2];
        private DataGridViewColumn[] titulo1 = new DataGridViewColumn[2];
        public FrmEjercicio1()
        {
            InitializeComponent();
            
        }

        private void btnAgregar1_Click(object sender, EventArgs e)
        {
            txtLista1.Clear();
            lista1.Add(txtElemento1.Text);
            listaAux.Add(txtElemento1.Text);
            foreach (var elemento in lista1)
            {
                txtLista1.Text += " - " + elemento + "\r\n";
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            txtLista2.Clear();
            lista2.Add(txtElemento2.Text);
            listaAux.Add(txtElemento2.Text);

            foreach (var elemento in lista2)
            {
                txtLista2.Text += " - " + elemento + "\r\n";
            }
        }

        private void txtLista1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtLista2_TextChanged(object sender, EventArgs e)
        {
        }

        private void FrmEjercicio1_Load(object sender, EventArgs e)
        {
            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Elemento";
            titulo[0].Name = "colElemento";
            titulo[0].Width = 100;
            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Coincidencias";
            titulo[1].Name = "colCoincidencias";
            titulo[1].Width = 100;
            dgvComparaciones.Columns.AddRange(titulo);

            titulo1[0] = new DataGridViewTextBoxColumn();
            titulo1[0].HeaderText = "Elemento";
            titulo1[0].Name = "colElemento";
            titulo1[0].Width = 100;
            titulo1[1] = new DataGridViewTextBoxColumn();
            titulo1[1].HeaderText = "Repeticiones";
            titulo1[1].Name = "colRepeticiones";
            titulo1[1].Width = 100;
            dgvRepeticiones.Columns.AddRange(titulo1);
        }

        private void btnVer22_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtElemento1.Clear();
            txtElemento2.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            dgvComparaciones.Rows.Clear();
            dgvRepeticiones.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtElemento1.Clear();
            txtElemento2.Clear();
            txtLista1.Clear();
            txtLista2.Clear();
            dgvComparaciones.Rows.Clear();
            dgvRepeticiones.Rows.Clear();
            lista1.Clear();
            lista2.Clear();
            lista3.Clear();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dgvComparaciones.Rows.Clear();
            dgvRepeticiones.Rows.Clear();
            string[] listap = listaAux.ToArray(typeof(string)) as string[];
            listap = listap.Distinct().ToArray();
            lista3.Clear();
            foreach (var elementop in listap)
            {
                lista3.Add(elementop);
            }
            foreach (var elemento3 in lista3)
            {
                cont1 = 0;
                cont2 = 0;
                cont3 = 0;
                foreach (var elemento1 in lista1)
                {
                    if (elemento3.Equals(elemento1))
                    {
                        cont1++;
                    }
                }
                foreach (var elemento2 in lista2)
                {
                    if (elemento3.Equals(elemento2))
                    {
                        cont2++;
                    }
                }
                cont3 = cont1 + cont2;
                if ((cont1!=0)&&(cont2!=0))
                {
                    dgvRepeticiones.Rows.Add(elemento3, cont3);
                    if (cont1 < cont2)
                    {
                        cont4 = cont1;
                    }
                    else if (cont2 < cont1)
                    {
                        cont4 = cont2;
                    }
                    else
                    {
                        cont4 = cont1;
                    }
                    dgvComparaciones.Rows.Add(elemento3, cont4);
                }

            }
        }
    }
}
