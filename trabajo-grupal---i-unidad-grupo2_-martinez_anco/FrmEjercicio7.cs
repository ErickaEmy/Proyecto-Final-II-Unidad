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
    public partial class FrmEjercicio7 : Form
    {
        private DataGridViewColumn[] titulo = new DataGridViewColumn[2];
        private DataGridViewColumn[] columna = new DataGridViewColumn[2];
        public FrmEjercicio7()
        {
            InitializeComponent();
            //Se asignan las columnas y filas del DataGridView de los billetes y monedas
            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Billetes";
            titulo[0].Name = "colBilletes";
            titulo[0].Width = 80;
            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Cantidad";
            titulo[1].Name = "colCantidad";
            titulo[1].Width = 75;
            dgvBilletes.Columns.AddRange(titulo);
            dgvBilletes.Rows.Add(100, "");
            dgvBilletes.Rows.Add(50, "");
            dgvBilletes.Rows.Add(20, "");
            dgvBilletes.Rows.Add(10, "");

            columna[0] = new DataGridViewTextBoxColumn();
            columna[0].HeaderText = "Monedas";
            columna[0].Name = "colMonedas";
            columna[0].Width = 70;
            columna[1] = new DataGridViewTextBoxColumn();
            columna[1].HeaderText = "Cantidad";
            columna[1].Name = "colCantidad2";
            columna[1].Width = 70;
            dgvMonedas.Columns.AddRange(columna);
            dgvMonedas.Rows.Add(5, "");
            dgvMonedas.Rows.Add(2, "");
            dgvMonedas.Rows.Add(1, "");
            dgvMonedas.Rows.Add(0.50, "");
            dgvMonedas.Rows.Add(0.20, "");
            dgvMonedas.Rows.Add(0.10, "");
            dgvMonedas.Rows.Add(0.05, "");
        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            //Se limpia la tabla para el siguiente retiro
            dgvBilletes.Rows.Clear();
            dgvMonedas.Rows.Clear();
            dgvMonedas.Rows.Add(5, "");
            dgvMonedas.Rows.Add(2, "");
            dgvMonedas.Rows.Add(1, "");
            dgvMonedas.Rows.Add(0.50, "");
            dgvMonedas.Rows.Add(0.20, "");
            dgvMonedas.Rows.Add(0.10, "");
            dgvMonedas.Rows.Add(0.05, "");
            dgvBilletes.Rows.Add(100, "");
            dgvBilletes.Rows.Add(50, "");
            dgvBilletes.Rows.Add(20, "");
            dgvBilletes.Rows.Add(10, "");

            double monto;
            string entero = "", decimales = "";
            int ent, decim;
            int aux2 = 0;
            //contadores de billetes y monedas
            int b100 = 0, b50 = 0, b20 = 0, b10 = 0, m5 = 0, m2 = 0, m1 = 0, m50 = 0, m20 = 0, m10 = 0, m05 = 0;
            try
            {

                if (txtMonto.Text == "")
                {
                    MessageBox.Show("Deber escribir un monto a retirar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    monto = Convert.ToDouble(txtMonto.Text);
                    if (monto > 0.05)
                    {
                        for (int i = 0; i < txtMonto.Text.Length; i++)
                        {
                            //Bucamos el índice "." o ",", y lo comparamos el valor actual de "i".
                            if (txtMonto.Text.IndexOf(".") == i || txtMonto.Text.IndexOf(",") == i)
                            {
                                aux2 = 1;
                                for (int j = 0; j < i; j++)
                                {
                                    char caracterentero = txtMonto.Text[j];
                                    entero = entero + Convert.ToString(caracterentero);
                                }
                                //For para recorrer las posiciones desde "i" hasta la cantidad de caracteres ingresados, parte decimal.
                                for (int k = i + 1; k < txtMonto.Text.Length; k++)
                                {
                                    char caracterdecimal = txtMonto.Text[k];
                                    decimales = decimales + Convert.ToString(caracterdecimal);
                                }
                            }
                        }
                        //Auxiliar que indica si es entero o numero con decimales
                        //si es 0, entonces el numero ingresado es entero
                        if (aux2 == 0)
                        {
                            //extraer el valor ingresado
                            ent = Convert.ToInt32(txtMonto.Text);
                            //mientras el monto sea mayor a 100 se ira incrementando la cantidad de 
                            //billetes de 100 y se restará el valor del billete entregado (100)
                            while (ent >= 100)
                            {
                                b100++;
                                ent = ent - 100;
                            }
                            //Se aplica la misma logica con el resto de los billetes
                            while (ent >= 50)
                            {
                                b50++;
                                ent = ent - 50;
                            }
                            while (ent >= 20)
                            {
                                b20++;
                                ent = ent - 20;
                            }
                            while (ent >= 10)
                            {
                                b10++;
                                ent = ent - 10;
                            }
                            while (ent >= 5)
                            {
                                m5++;
                                ent = ent - 5;
                            }
                            while (ent >= 2)
                            {
                                m2++;
                                ent = ent - 2;
                            }
                            while (ent >= 1)
                            {
                                m1++;
                                ent = ent - 1;
                            }
                            //al no haber decimales, se asignara la parte decimal como 0
                            decim = 0;
                        }
                        //si el aux=1, entonces el numero contiene decimales
                        else
                        {
                            //se realizan las conversiones a entero del numero antes de la coma y despues de la coma
                            ent = Convert.ToInt32(entero);
                            decim = Convert.ToInt32(decimales);
                            //si el numero decimal es menor a 10, indicará que solo se ingresó un decimal, por lo que
                            //lo multiplicamos por 10 para que contenga dos decimales EJ: 15,9 ► 15,90
                            if (decim < 10)
                            {
                                decim = decim * 10;
                            }
                            //mientras el monto sea mayor a 100 se ira incrementando la cantidad de 
                            //billetes de 100 y se restará el valor del billete entregado (100)
                            while (ent >= 100)
                            {
                                b100++;
                                ent = ent - 100;
                            }
                            while (ent >= 50)
                            {
                                b50++;
                                ent = ent - 50;
                            }
                            while (ent >= 20)
                            {
                                b20++;
                                ent = ent - 20;
                            }
                            while (ent >= 10)
                            {
                                b10++;
                                ent = ent - 10;
                            }
                            while (ent >= 5)
                            {
                                m5++;
                                ent = ent - 5;
                            }
                            while (ent >= 2)
                            {
                                m2++;
                                ent = ent - 2;
                            }
                            while (ent >= 1)
                            {
                                m1++;
                                ent = ent - 1;
                            }
                            //Se aplica la logica anterior, pero esta vez con la parte decimal
                            while (decim >= 50)
                            {
                                m50++;
                                decim = decim - 50;
                            }
                            while (decim >= 20)
                            {
                                m20++;
                                decim = decim - 20;
                            }
                            while (decim >= 10)
                            {
                                m10++;
                                decim = decim - 10;
                            }
                            while (decim >= 5)
                            {
                                m05++;
                                decim = decim - 5;
                            }
                        }
                        //si el valor decimal es mayor a 0 indica que aun queda dinero por retirar, pero como no se tiene monedas de menor cantidad, entonces:
                        if (decim > 0)
                        {
                            MessageBox.Show("Minimo se dan monedas de 0.05 centimos, por favor ingrese otro monto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //si el valor decimal es cero, entonces se retiro todo el dinero exitosamente
                        else
                        {
                            //Se procede a llenar el DataGridView, si la cantidad de billetes es mayor que cero entonces se rellenará 
                            //el valor en la tabla, sino seguira estando vacio
                            if (b100 > 0)
                            {
                                dgvBilletes.Rows[0].Cells[1].Value = b100;
                            }
                            if (b50 > 0)
                            {
                                dgvBilletes.Rows[1].Cells[1].Value = b50;
                            }
                            if (b20 > 0)
                            {
                                dgvBilletes.Rows[2].Cells[1].Value = b20;
                            }
                            if (b10 > 0)
                            {
                                dgvBilletes.Rows[3].Cells[1].Value = b10;
                            }
                            if (m5 > 0)
                            {
                                dgvMonedas.Rows[0].Cells[1].Value = m5;
                            }
                            if (m2 > 0)
                            {
                                dgvMonedas.Rows[1].Cells[1].Value = m2;
                            }
                            if (m1 > 0)
                            {
                                dgvMonedas.Rows[2].Cells[1].Value = m1;
                            }
                            if (m50 > 0)
                            {
                                dgvMonedas.Rows[3].Cells[1].Value = m50;
                            }
                            if (m20 > 0)
                            {
                                dgvMonedas.Rows[4].Cells[1].Value = m20;
                            }
                            if (m10 > 0)
                            {
                                dgvMonedas.Rows[5].Cells[1].Value = m10;
                            }
                            if (m05 > 0)
                            {
                                dgvMonedas.Rows[6].Cells[1].Value = m05;
                            }
                            //Se muestra la cantidad total de billetes y monedas retiradas
                            txtBilletes.Text = Convert.ToString(b100 + b50 + b20 + b10);
                            txtMonedas.Text = Convert.ToString(m5 + m2 + m1 + m50 + m20 + m10 + m05);
                        }
                    }
                    else
                    {
                        MessageBox.Show("El monto debe ser minimo 0.05.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe escribir un numero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }    
}
