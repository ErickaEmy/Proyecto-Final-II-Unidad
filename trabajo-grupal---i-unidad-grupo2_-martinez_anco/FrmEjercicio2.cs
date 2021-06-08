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
    public partial class FrmEjercicio2 : Form
    {
        public FrmEjercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Limpiamos el contenido del txtProceso cada vez que se presiones Calcular.
            txtProceso.Clear();
            //Strings que almacenarán el conjunto de números enteros y decimales.
            string enteros = "", decimales = "";
            string x = "", y = "";
            //Variables Int que almacenarán el valor convertido a int de enteros y decimales.
            int nenteros = 0, ndecimales = 0;
            int contador = 0;
            double a = 0;
            //If para validar si lo ingresado a txtNumero se puede convertir a double
            if (Double.TryParse(txtNumero.Text, out a))
            {

                //DECIMAL A BINARIO
                //If para validar si el radio button de BINARIO fue seleccionado
                if (rbtnBinario.Checked == true)
                {
                    txtProceso.Text = "=======    PARTE ENTERA    =======\r\n\r\n";
                    lblBase.Text = "2";
                    //For para recorrer el número ingresado, separar los enteros de los decimales ya sea con "," o ".".
                    for (int i = 0; i < txtNumero.Text.Length; i++)
                    {
                        //Bucamos el índice "." o ",", y lo comparamos el valor actual de "i".
                        if (txtNumero.Text.IndexOf(".") == i || txtNumero.Text.IndexOf(",") == i)
                        {
                            //For para recorrer las posiciones desde cero hasta la posición "i".
                            //Los caracteres se van sumando a la cadena "enteros" o "decimales" según corresponda.
                            for (int j = 0; j < i; j++)
                            {
                                char caracterentero = txtNumero.Text[j];
                                enteros = enteros + Convert.ToString(caracterentero);
                            }
                            //For para recorrer las posiciones desde "i" hasta la cantidad de caracteres ingresados, parte decimal.
                            for (int k = i + 1; k < txtNumero.Text.Length; k++)
                            {
                                char caracterdecimal = txtNumero.Text[k];
                                decimales = decimales + Convert.ToString(caracterdecimal);
                            }
                        }
                    }
                    //Verificamos si las cadenas enteros y decimales están vacías.
                    //A
                    if (enteros == "" && decimales == "")
                    {
                        //Si las cadenas están vacías, la cadena enteros será igual a txtNumero.Text
                        enteros = txtNumero.Text;
                        nenteros = Convert.ToInt32(enteros);
                    }
                    else
                    {
                        nenteros = Convert.ToInt32(enteros);
                        ndecimales = Convert.ToInt32(decimales);
                    }
                    //Do while para realizar la operación de conversión hasta que el cociente sea menor que la base.
                    do
                    {
                        txtProceso.Text = txtProceso.Text + Convert.ToString(nenteros) + " ÷ 2 " + "\t->    Residuo = ";
                        if (nenteros % 2 == 0)
                        {
                            x = "0" + x;
                            txtProceso.Text = txtProceso.Text + "0\r\n    ↙\r\n";

                        }
                        else
                        {
                            x = "1" + x;
                            txtProceso.Text = txtProceso.Text + "1\r\n    ↙\r\n";
                            nenteros = nenteros - 1;
                        }
                        nenteros = nenteros / 2;
                    } while (nenteros > 1);
                    x = "1" + x;
                    txtProceso.Text = txtProceso.Text + "1";
                    txtResultado.Text = x;
                    //Con este If verificamos si tenemos algún valor almacenado en ndecimales.
                    if (ndecimales != 0)
                    {
                        txtProceso.Text = txtProceso.Text + "\r\n\r\n======= PARTE FRACCIONARIA =======\r\n\r\n";
                        double auxiliar = Convert.ToDouble("0," + decimales);
                        for (int i = 0; i < Convert.ToInt32(cboExacto.Text); i++)
                        {
                            txtProceso.Text = txtProceso.Text + Convert.ToString(auxiliar) + " * 2 = " + Convert.ToString(auxiliar * 2) + "\r\n\r\n";
                            auxiliar = auxiliar * 2;
                            if (auxiliar >= 1)
                            {
                                y = y + "1";
                                auxiliar = auxiliar - 1;
                            }
                            else
                            {
                                y = y + "0";
                            }
                        }
                        txtProceso.Text = txtProceso.Text + y;
                        txtResultado.Text = txtResultado.Text + "." + y;
                    }
                    txtIngreso.Text = txtNumero.Text;
                    lblBase2.Text = "10";
                }

                //N A DECIMAL:
                //Condicional Else if para verificar si DrbtnDecimal está activado

                else if (rbtnDecimal.Checked == true)
                {
                    int acumuladordecimal = 0; double acumuladorf = 0;
                    int baseactual = Convert.ToInt32(cboBase.Text);
                    txtProceso.Text = "======= PARTE ENTERA =======\r\n\r\n";
                    lblBase.Text = "10";
                    //For para recorrer los índices de cada caracter en txtNumero.

                    for (int i = 0; i < txtNumero.Text.Length; i++)
                    {
                        //Bucamos el índice "." o ",", y lo comparamos el valor actual de "i".
                        if (txtNumero.Text.IndexOf(".") == i || txtNumero.Text.IndexOf(",") == i)
                        {
                            //For para volver a recorrer los índices previos a encontrar el "." o ",".
                            for (int j = 0; j < i; j++)
                            {
                                //Proceso de multiplicación y potencia para cada caracter.
                                char caracterentero = txtNumero.Text[j];
                                int aux = i - (j + 1);
                                int potencia = Convert.ToInt32(Math.Pow(Convert.ToDouble(baseactual), aux));
                                int resultado = Convert.ToInt32(Convert.ToString(caracterentero)) * potencia;
                                acumuladordecimal = acumuladordecimal + resultado;
                                //Impresión de cada fila desarrollada.
                                txtProceso.Text = txtProceso.Text + Convert.ToString(caracterentero) + " * " + Convert.ToString(baseactual) + "^" + Convert.ToString(aux) + " = " + Convert.ToString(resultado) + "\r\n\r\n";
                                txtResultado.Text = Convert.ToString(acumuladordecimal);
                            }
                            txtProceso.Text = txtProceso.Text + "Suma de parte entera: " + Convert.ToString(acumuladordecimal) + "\r\n\r\n";
                            txtProceso.Text = txtProceso.Text + "\r\n\r\n======= PARTE FRACCIONARIA =======\r\n\r\n";
                            //For para recorrer los índices posteriores a encontrar el "." o ",".
                            for (int k = i + 1; k < txtNumero.Text.Length; k++)
                            {
                                //Proceso de multiplicación y potencia para cada caracter.
                                char caracterdecimal = txtNumero.Text[k];
                                int aux = -(k - i);
                                double potencia = Convert.ToDouble(Math.Pow(Convert.ToDouble(baseactual), aux));
                                double resultado = Convert.ToDouble(Convert.ToString(caracterdecimal)) * potencia;
                                acumuladorf = acumuladorf + resultado;
                                txtProceso.Text = txtProceso.Text + Convert.ToString(caracterdecimal) + " * " + Convert.ToString(baseactual) + "^" + Convert.ToString(aux) + " = " + Convert.ToString(resultado) + "\r\n\r\n";
                            }
                            double final = acumuladordecimal + acumuladorf;
                            txtProceso.Text = txtProceso.Text + "Suma de parte decimal: " + Convert.ToString(acumuladorf) + "\r\n\r\n";
                            txtResultado.Text = Convert.ToString(final);
                        }
                    }

                    //Condición para determinar si el txtProceso está vacío. De ser así, significa que
                    //no se encontraro "." o "," por lo que es un número entero.
                    if (txtProceso.Text == "======= PARTE ENTERA =======\r\n\r\n")
                    {
                        //Recorremos todos los índices hasta llegar a la cantidad de caracteres.
                        for (int i = 0; i < txtNumero.Text.Length; i++)
                        {
                            //Proceso de multiplicación y potencia para cada caracter.
                            char caracterentero = txtNumero.Text[i];
                            int aux = txtNumero.Text.Length - (i + 1);
                            int potencia = Convert.ToInt32(Math.Pow(Convert.ToDouble(baseactual), aux));
                            int resultado = Convert.ToInt32(Convert.ToString(caracterentero)) * potencia;
                            acumuladordecimal = acumuladordecimal + resultado;
                            //Impresión de la línea.
                            txtProceso.Text = txtProceso.Text + Convert.ToString(caracterentero) + " * " + Convert.ToString(baseactual) + "^" + Convert.ToString(txtNumero.Text.Length - (i + 1)) + "\r\n\r\n";
                            txtResultado.Text = Convert.ToString(acumuladordecimal);
                        }
                        txtProceso.Text = txtProceso.Text + "Suma de parte entera: " + Convert.ToString(acumuladordecimal) + "\r\n\r\n";
                    }
                    txtIngreso.Text = txtNumero.Text;
                    lblBase2.Text = cboBase.Text;
                }

                //DECIMAL A OCTAL
                //Condicional para determinar si el rbtnOctal fue seleccionado.
                else if (rbtnOctal.Checked == true)
                {
                    txtProceso.Text = "======= PARTE ENTERA =======\r\n\r\n";
                    lblBase.Text = "8";
                    //Recorremos los índices hasta la cantidad de caracteres que tenga el numero ingresado.
                    for (int i = 0; i < txtNumero.Text.Length; i++)
                    {
                        //Ejecutamos cuando el índice de "." o "," sea igual al valor actual de i.
                        if (txtNumero.Text.IndexOf(".") == i || txtNumero.Text.IndexOf(",") == i)
                        {
                            contador++;
                            if (contador > 1)
                            {
                                txtProceso.Clear();
                                MessageBox.Show("Ingrese un número válido.",
                                "Ejercicio 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //For para recorrer los índices previos al punto o coma.
                                for (int j = 0; j < i; j++)
                                {
                                    char caracterentero = txtNumero.Text[j];
                                    enteros = enteros + Convert.ToString(caracterentero);
                                }
                                //For para recorrer los índices posteriores al punto o coma.
                                for (int k = i + 1; k < txtNumero.Text.Length; k++)
                                {
                                    char caracterdecimal = txtNumero.Text[k];
                                    decimales = decimales + Convert.ToString(caracterdecimal);
                                }
                            }

                        }
                    }
                    if (enteros == "" && decimales == "")
                    {
                        enteros = txtNumero.Text;
                        nenteros = Convert.ToInt32(enteros);
                    }
                    else
                    {
                        nenteros = Convert.ToInt32(enteros);
                        ndecimales = Convert.ToInt32(decimales);
                    }
                    //do while para ejecutar las operaciones mientras sea mayor a 7
                    do
                    {
                        txtProceso.Text = txtProceso.Text + Convert.ToString(nenteros) + " ÷ 8 " + "\t->    Residuo = " + Convert.ToString(nenteros % 8) + "\r\n    ↙\r\n";
                        x = Convert.ToString(nenteros % 8) + x;
                        nenteros = (nenteros - (nenteros % 8)) / 8;
                    } while (nenteros > 7);
                    x = Convert.ToString(nenteros) + x;
                    txtProceso.Text = txtProceso.Text + Convert.ToString(nenteros);
                    txtResultado.Text = x;
                    if (ndecimales != 0)
                    {
                        txtProceso.Text = txtProceso.Text + "\r\n\r\n======= PARTE FRACCIONARIA =======\r\n\r\n";
                        double auxiliar = Convert.ToDouble("0," + decimales);
                        for (int i = 0; i < Convert.ToInt32(cboExacto2.Text); i++)
                        {
                            txtProceso.Text = txtProceso.Text + Convert.ToString(auxiliar) + " * 8 = " + Convert.ToString(auxiliar * 8) + "\r\n\r\n";
                            auxiliar = auxiliar * 8;
                            y = y + Convert.ToString(Math.Truncate(auxiliar));
                            auxiliar = auxiliar - Math.Truncate(auxiliar);
                        }
                        txtProceso.Text = txtProceso.Text + y;
                        txtResultado.Text = txtResultado.Text + "." + y;
                    }
                    txtIngreso.Text = txtNumero.Text;
                    lblBase2.Text = "10";
                }

                //DECIMAL A HEXADECIMAL
                //Verificamos si rbtnHexadecimal está seleccionado.
                else if (rbtnHexadecimal.Checked == true)
                {
                    txtProceso.Text = "======= PARTE ENTERA =======\r\n\r\n";
                    lblBase.Text = "16";
                    //Recorremos los índices hasta la cantidad de caracteres que tenga el numero ingresado.
                    for (int i = 0; i < txtNumero.Text.Length; i++)
                    {
                        //Ejecutamos cuando el índice de "." o "," sea igual al valor actual de i.
                        if (txtNumero.Text.IndexOf(".") == i || txtNumero.Text.IndexOf(",") == i)
                        {
                            contador++;
                            if (contador > 1)
                            {
                                txtProceso.Clear();
                                MessageBox.Show("Ingrese un número válido.",
                                "Ejercicio 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //For para recorrer los índices previos al punto o coma.
                                for (int j = 0; j < i; j++)
                                {
                                    char caracterentero = txtNumero.Text[j];
                                    enteros = enteros + Convert.ToString(caracterentero);
                                }
                                //For para recorrer los índices posteriores al punto o coma.
                                for (int k = i + 1; k < txtNumero.Text.Length; k++)
                                {
                                    char caracterdecimal = txtNumero.Text[k];
                                    decimales = decimales + Convert.ToString(caracterdecimal);
                                }
                            }

                        }
                    }
                    if (enteros == "" && decimales == "")
                    {
                        enteros = txtNumero.Text;
                        nenteros = Convert.ToInt32(enteros);
                    }
                    else
                    {
                        nenteros = Convert.ToInt32(enteros);
                        ndecimales = Convert.ToInt32(decimales);
                    }
                    //do while para ejecutar las operaciones mientras sea mayor a 15
                    do
                    {
                        txtProceso.Text = txtProceso.Text + Convert.ToString(nenteros) + " ÷ 16 " + "\t->    Residuo = " + Convert.ToString(nenteros % 16) + "\r\n    ↙\r\n";
                        //Reemplazamos por letras los valores a partir de 10.
                        if (nenteros % 16 == 10)
                        {
                            x = "A" + x;
                        }
                        else if (nenteros % 16 == 11)
                        {
                            x = "B" + x;
                        }
                        else if (nenteros % 16 == 12)
                        {
                            x = "C" + x;
                        }
                        else if (nenteros % 16 == 13)
                        {
                            x = "D" + x;
                        }
                        else if (nenteros % 16 == 14)
                        {
                            x = "E" + x;
                        }
                        else if (nenteros % 16 == 15)
                        {
                            x = "F" + x;
                        }
                        else
                        {
                            x = Convert.ToString(nenteros % 16) + x;
                        }
                        nenteros = (nenteros - (nenteros % 16)) / 16;
                    } while (nenteros > 15);
                    x = Convert.ToString(nenteros) + x;
                    txtProceso.Text = txtProceso.Text + Convert.ToString(nenteros);
                    txtResultado.Text = x;
                    //If para verificar si hay o no decimales.
                    if (ndecimales != 0)
                    {
                        txtProceso.Text = txtProceso.Text + "\r\n\r\n======= PARTE FRACCIONARIA =======\r\n\r\n";
                        double auxiliar = Convert.ToDouble("0," + decimales);
                        for (int i = 0; i < Convert.ToInt32(cboExacto3.Text); i++)
                        {
                            txtProceso.Text = txtProceso.Text + Convert.ToString(auxiliar) + " * 16 = " + Convert.ToString(auxiliar * 16) + "\r\n\r\n";
                            auxiliar = auxiliar * 16;
                            //Reemplazamos por letras los valores a partir de 10.
                            if (Math.Truncate(auxiliar) == 10)
                            {
                                y = y + "A";
                            }
                            else if (Math.Truncate(auxiliar) == 11)
                            {
                                y = y + "B";
                            }
                            else if (Math.Truncate(auxiliar) == 12)
                            {
                                y = y + "C";
                            }
                            else if (Math.Truncate(auxiliar) == 13)
                            {
                                y = y + "D";
                            }
                            else if (Math.Truncate(auxiliar) == 14)
                            {
                                y = y + "E";
                            }
                            else if (Math.Truncate(auxiliar) == 15)
                            {
                                y = y + "F";
                            }
                            else
                            {
                                y = y + Convert.ToString(Math.Truncate(auxiliar));
                            }
                            auxiliar = auxiliar - Math.Truncate(auxiliar);
                        }
                        txtProceso.Text = txtProceso.Text + y;
                        txtResultado.Text = txtResultado.Text + "." + y;
                    }
                    txtIngreso.Text = txtNumero.Text;
                    lblBase2.Text = "10";
                }
                else
                {
                    MessageBox.Show("Seleccione una opción.",
                    "Ejercicio 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número válido.",
                "Ejercicio 2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnBinario_CheckedChanged(object sender, EventArgs e)
        {
            cboExacto.Enabled = true;
            cboExacto2.Enabled = false;
            cboBase.Enabled = false;
            cboExacto3.Enabled = false;
        }

        private void rbtnOctal_CheckedChanged(object sender, EventArgs e)
        {
            cboExacto.Enabled = false;
            cboExacto2.Enabled = true;
            cboBase.Enabled = false;
            cboExacto3.Enabled = false;
        }

        private void rbtnDecimal_CheckedChanged(object sender, EventArgs e)
        {
            cboExacto.Enabled = false;
            cboExacto2.Enabled = false;
            cboBase.Enabled = true;
            cboExacto3.Enabled = false;
        }

        private void rbtnHexadecimal_CheckedChanged(object sender, EventArgs e)
        {
            cboExacto.Enabled = false;
            cboExacto2.Enabled = false;
            cboBase.Enabled = false;
            cboExacto3.Enabled = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rbtnBinario.Checked = false;
            rbtnDecimal.Checked = false;
            rbtnOctal.Checked = false;
            rbtnHexadecimal.Checked = false;
            cboExacto.Enabled = false;
            cboExacto2.Enabled = false;
            cboBase.Enabled = false;
            cboExacto3.Enabled = false;
            txtNumero.Clear();
            txtIngreso.Clear();
            txtResultado.Clear();
            txtProceso.Clear();
            cboExacto.Text = "1";
            cboExacto2.Text = "1";
            cboExacto3.Text = "1";
            cboBase.Text = "2";
        }
    }
}
