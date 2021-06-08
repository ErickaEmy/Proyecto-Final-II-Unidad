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
    public partial class FrmEjercicio9 : Form
    {
        public FrmEjercicio9()
        {
            InitializeComponent();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //Declaracion de variables para los digitos de los numeros Romanos
            int miles, resto, centena, decena, unidad, n;
            //declaracion de variable donde se almacenara el numero romano
            string romano = "";
            //Validacion para que solo acepte numeros enteros
            try
            {
                //Validacion de campos vacios
                if (txtNumero.Text == "")
                {
                    MessageBox.Show("Debe ingresar el numero a convertir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    n = Convert.ToInt32(txtNumero.Text);
                    //Validacion del limite de conversion
                    if (n > 3000)
                    {
                        MessageBox.Show("Ingrese un numero menor o igual a 3000", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //Se irá dividiendo el numero, los cocientes seran los digitos y los residuos será el restante del numero
                        //Arabigo para seguir extrayendo los digitos, segun miles, centenas, decenas y unidades
                        miles = n / 1000;
                        resto = n % 1000;
                        centena = resto / 100;
                        resto = resto % 100;
                        decena = resto / 10;
                        resto = resto % 10;
                        unidad = resto;
                        //Se irán agregando los digitos del numero romano segun el valor de las variables 
                        //miles, centenas, decenas y unidades
                        switch (miles)
                        {
                            case 1: romano += "M"; break;
                            case 2: romano += "MM"; break;
                            case 3: romano += "MMM"; break;
                        }
                        switch (centena)
                        {
                            case 1: romano += "C"; break;
                            case 2: romano += "CC"; break;
                            case 3: romano += "CCC"; break;
                            case 4: romano += "CD"; break;
                            case 5: romano += "D"; break;
                            case 6: romano += "DC"; break;
                            case 7: romano += "DCC"; break;
                            case 8: romano += "DCCC"; break;
                            case 9: romano += "CM"; break;
                        }
                        switch (decena)
                        {
                            case 1: romano += "X"; break;
                            case 2: romano += "XX"; break;
                            case 3: romano += "XXX"; break;
                            case 4: romano += "XL"; break;
                            case 5: romano += "L"; break;
                            case 6: romano += "LX"; break;
                            case 7: romano += "LXX"; break;
                            case 8: romano += "LXXX"; break;
                            case 9: romano += "XC"; break;
                        }
                        switch (unidad)
                        {
                            case 1: romano += "I"; break;
                            case 2: romano += "II"; break;
                            case 3: romano += "III"; break;
                            case 4: romano += "IV"; break;
                            case 5: romano += "V"; break;
                            case 6: romano += "VI"; break;
                            case 7: romano += "VII"; break;
                            case 8: romano += "VIII"; break;
                            case 9: romano += "IX"; break;
                        }
                        //Asignar el valor del numero romano
                        txtRomano.Text = romano;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe ingresar un numero entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = "";
            txtRomano.Text = "";
        }
    }
}
