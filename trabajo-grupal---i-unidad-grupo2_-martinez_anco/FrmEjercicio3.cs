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
    public partial class FrmEjercicio3 : Form
    {
        public FrmEjercicio3()
        {
            InitializeComponent();
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Validacion de campos vacios
            if (cmbNivel.Text == "")
            {
                MessageBox.Show("Deber seleccionar un Nivel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Mensaje de confirmacion
                DialogResult result = MessageBox.Show("El nivel que escogió es " + cmbNivel.Text + " no podrá cambiar luego de dificultad \n¿Desea continuar?", "Dificultad", MessageBoxButtons.YesNo);
                //si confirma la seleccion del nivel
                if (result == DialogResult.Yes)
                {
                    //Habilita los espacios para llenar el crucigrama y los botones de apoyo al juego
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    textBox4.Enabled = true;
                    textBox5.Enabled = true;
                    textBox6.Enabled = true;
                    textBox7.Enabled = true;
                    textBox8.Enabled = true;
                    textBox9.Enabled = true;
                    textBox10.Enabled = true;
                    textBox11.Enabled = true;
                    textBox12.Enabled = true;
                    textBox13.Enabled = true;
                    textBox14.Enabled = true;
                    textBox15.Enabled = true;
                    textBox16.Enabled = true;
                    textBox17.Enabled = true;
                    textBox18.Enabled = true;
                    textBox19.Enabled = true;
                    textBox20.Enabled = true;
                    textBox21.Enabled = true;
                    textBox22.Enabled = true;
                    textBox23.Enabled = true;
                    textBox24.Enabled = true;
                    textBox25.Enabled = true;
                    textBox26.Enabled = true;
                    textBox27.Enabled = true;
                    textBox28.Enabled = true;
                    textBox29.Enabled = true;
                    textBox30.Enabled = true;
                    textBox31.Enabled = true;
                    textBox32.Enabled = true;
                    textBox33.Enabled = true;
                    textBox34.Enabled = true;

                    btnCompletar.Enabled = true;
                    btnLimpiar.Enabled = true;
                    btnNuevo.Enabled = true;
                    btnPistas.Enabled = true;
                    btnTerminar.Enabled = true;

                    //Deshabilita la seleccion del nivel
                    btnAceptar.Enabled = false;
                    cmbNivel.Enabled = false;
                }
            }
        }

        private void Crucigrama1_Load(object sender, EventArgs e)
        {
            //Llena el combobox para la seleccion del nivel
            cmbNivel.Items.Add("Fácil");
            cmbNivel.Items.Add("Intermedio");
            cmbNivel.Items.Add("Difícil");
        }

        //PARA TODOS LOS "textbox_textChanged" 
        //Si se seleccionó el nivel facil y la letra es la correcta entonces será de color verde 
        //y estará en negrita, si es la letra incorrecta estará en color negro sin negrita
        private void textBox18_TextChanged(object sender, EventArgs e)
        {            
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox18.Text == "I"|| textBox18.Text == "i")
                {
                    textBox18.ForeColor = Color.Green;
                    textBox18.Font = new Font(textBox18.Font, FontStyle.Bold);
                }
                else 
                {
                    textBox18.ForeColor = Color.Black;
                    textBox18.Font = new Font(textBox18.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox19.Text == "N" || textBox19.Text == "n")
                {
                    textBox19.ForeColor = Color.Green;
                    textBox19.Font = new Font(textBox19.Font, FontStyle.Bold);
                }
                else
                {
                    textBox19.ForeColor = Color.Black;
                    textBox19.Font = new Font(textBox19.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox20.Text == "G" || textBox20.Text == "g")
                {
                    textBox20.ForeColor = Color.Green;
                    textBox20.Font = new Font(textBox20.Font, FontStyle.Bold);
                }
                else
                {
                    textBox20.ForeColor = Color.Black;
                    textBox20.Font = new Font(textBox20.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox15.Text == "E" || textBox15.Text == "e")
                {
                    textBox15.ForeColor = Color.Green;
                    textBox15.Font = new Font(textBox15.Font, FontStyle.Bold);
                }
                else
                {
                    textBox15.ForeColor = Color.Black;
                    textBox15.Font = new Font(textBox15.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox16.Text == "N" || textBox16.Text == "n")
                {
                    textBox16.ForeColor = Color.Green;
                    textBox16.Font = new Font(textBox16.Font, FontStyle.Bold);
                }
                else
                {
                    textBox16.ForeColor = Color.Black;
                    textBox16.Font = new Font(textBox16.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox14.Text == "I" || textBox14.Text == "i")
                {
                    textBox14.ForeColor = Color.Green;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Bold);
                }
                else
                {
                    textBox14.ForeColor = Color.Black;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox13.Text == "E" || textBox13.Text == "e")
                {
                    textBox13.ForeColor = Color.Green;
                    textBox13.Font = new Font(textBox13.Font, FontStyle.Bold);
                }
                else
                {
                    textBox13.ForeColor = Color.Black;
                    textBox13.Font = new Font(textBox13.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox22.Text == "R" || textBox22.Text == "r")
                {
                    textBox22.ForeColor = Color.Green;
                    textBox22.Font = new Font(textBox22.Font, FontStyle.Bold);
                }
                else
                {
                    textBox22.ForeColor = Color.Black;
                    textBox22.Font = new Font(textBox22.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox23.Text == "I" || textBox23.Text == "i")
                {
                    textBox23.ForeColor = Color.Green;
                    textBox23.Font = new Font(textBox23.Font, FontStyle.Bold);
                }
                else
                {
                    textBox23.ForeColor = Color.Black;
                    textBox23.Font = new Font(textBox23.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox8.Text == "A" || textBox8.Text == "a")
                {
                    textBox8.ForeColor = Color.Green;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Bold);
                }
                else
                {
                    textBox8.ForeColor = Color.Black;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
                }
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Se vacian todos los espacios del crucigrama y vuelven al estilo color negro y sin negrita
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox22.Clear();
            textBox23.Clear();
            textBox24.Clear();
            textBox25.Clear();
            textBox26.Clear();
            textBox27.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox33.Clear();
            textBox34.Clear();
            textBox18.ForeColor = Color.Black;
            textBox18.Font = new Font(textBox18.Font, FontStyle.Regular);
            textBox19.ForeColor = Color.Black;
            textBox19.Font = new Font(textBox19.Font, FontStyle.Regular);
            textBox20.ForeColor = Color.Black;
            textBox20.Font = new Font(textBox20.Font, FontStyle.Regular);
            textBox15.ForeColor = Color.Black;
            textBox15.Font = new Font(textBox15.Font, FontStyle.Regular);
            textBox16.ForeColor = Color.Black;
            textBox16.Font = new Font(textBox16.Font, FontStyle.Regular);
            textBox14.ForeColor = Color.Black;
            textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
            textBox13.ForeColor = Color.Black;
            textBox13.Font = new Font(textBox13.Font, FontStyle.Regular);
            textBox22.ForeColor = Color.Black;
            textBox22.Font = new Font(textBox22.Font, FontStyle.Regular);
            textBox23.ForeColor = Color.Black;
            textBox23.Font = new Font(textBox23.Font, FontStyle.Regular);
            textBox8.ForeColor = Color.Black;
            textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
            textBox24.ForeColor = Color.Black;
            textBox24.Font = new Font(textBox24.Font, FontStyle.Regular);
            textBox14.ForeColor = Color.Black;
            textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
            textBox26.ForeColor = Color.Black;
            textBox26.Font = new Font(textBox26.Font, FontStyle.Regular);
            textBox27.ForeColor = Color.Black;
            textBox27.Font = new Font(textBox27.Font, FontStyle.Regular);
            textBox28.ForeColor = Color.Black;
            textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
            textBox29.ForeColor = Color.Black;
            textBox29.Font = new Font(textBox29.Font, FontStyle.Regular);
            textBox30.ForeColor = Color.Black;
            textBox30.Font = new Font(textBox30.Font, FontStyle.Regular);
            textBox25.ForeColor = Color.Black;
            textBox25.Font = new Font(textBox25.Font, FontStyle.Regular);
            textBox34.ForeColor = Color.Black;
            textBox34.Font = new Font(textBox34.Font, FontStyle.Regular);
            textBox33.ForeColor = Color.Black;
            textBox33.Font = new Font(textBox33.Font, FontStyle.Regular);
            textBox17.ForeColor = Color.Black;
            textBox17.Font = new Font(textBox17.Font, FontStyle.Regular);
            textBox21.ForeColor = Color.Black;
            textBox21.Font = new Font(textBox21.Font, FontStyle.Regular);
            textBox28.ForeColor = Color.Black;
            textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
            textBox32.ForeColor = Color.Black;
            textBox32.Font = new Font(textBox32.Font, FontStyle.Regular);
            textBox31.ForeColor = Color.Black;
            textBox31.Font = new Font(textBox31.Font, FontStyle.Regular);
            textBox2.ForeColor = Color.Black;
            textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
            textBox1.ForeColor = Color.Black;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            textBox3.ForeColor = Color.Black;
            textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
            textBox4.ForeColor = Color.Black;
            textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
            textBox7.ForeColor = Color.Black;
            textBox7.Font = new Font(textBox7.Font, FontStyle.Regular);
            textBox8.ForeColor = Color.Black;
            textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
            textBox5.ForeColor = Color.Black;
            textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
            textBox6.ForeColor = Color.Black;
            textBox6.Font = new Font(textBox6.Font, FontStyle.Regular);
            textBox11.ForeColor = Color.Black;
            textBox11.Font = new Font(textBox11.Font, FontStyle.Regular);
            textBox12.ForeColor = Color.Black;
            textBox12.Font = new Font(textBox12.Font, FontStyle.Regular);
            textBox9.ForeColor = Color.Black;
            textBox9.Font = new Font(textBox9.Font, FontStyle.Regular);
            textBox10.ForeColor = Color.Black;
            textBox10.Font = new Font(textBox10.Font, FontStyle.Regular);
        }
        private void btnPistas_Click(object sender, EventArgs e)
        {
            //Si se seleccionó el nivel Intermedio, al completar una palabra del crucigrama y el jugador desea saber si es la correcta, dará clic en el botón Pistas y se pondrá de color verde
            //y en negrita si la palabra es correcta (todas las letras deben estan correctas), caso contrario regresará a color negro y sin negrita
            if (cmbNivel.SelectedIndex == 1)
            {
                if (((((textBox18.Text == "I" || textBox18.Text == "i") && (textBox19.Text == "N" || textBox19.Text == "n")) && ((textBox20.Text == "G" || textBox20.Text == "g") && (textBox15.Text == "E" || textBox15.Text == "e"))) && 
                    (((textBox16.Text == "N" || textBox16.Text == "n") && (textBox14.Text == "I" || textBox14.Text == "i")) && ((textBox13.Text == "E" || textBox13.Text == "e") && (textBox22.Text == "R" || textBox22.Text == "r")))) && 
                    ((textBox23.Text == "I" || textBox23.Text == "i") && (textBox8.Text == "A" || textBox8.Text == "a")))
                {
                    textBox18.ForeColor = Color.Green;
                    textBox18.Font = new Font(textBox18.Font, FontStyle.Bold);
                    textBox19.ForeColor = Color.Green;
                    textBox19.Font = new Font(textBox19.Font, FontStyle.Bold);
                    textBox20.ForeColor = Color.Green;
                    textBox20.Font = new Font(textBox20.Font, FontStyle.Bold);
                    textBox15.ForeColor = Color.Green;
                    textBox15.Font = new Font(textBox15.Font, FontStyle.Bold);
                    textBox16.ForeColor = Color.Green;
                    textBox16.Font = new Font(textBox16.Font, FontStyle.Bold);
                    textBox14.ForeColor = Color.Green;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Bold);
                    textBox13.ForeColor = Color.Green;
                    textBox13.Font = new Font(textBox13.Font, FontStyle.Bold);
                    textBox22.ForeColor = Color.Green;
                    textBox22.Font = new Font(textBox22.Font, FontStyle.Bold);
                    textBox23.ForeColor = Color.Green;
                    textBox23.Font = new Font(textBox23.Font, FontStyle.Bold);
                    textBox8.ForeColor = Color.Green;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Bold);
                }
                else
                {
                    textBox18.ForeColor = Color.Black;
                    textBox18.Font = new Font(textBox18.Font, FontStyle.Regular);
                    textBox19.ForeColor = Color.Black;
                    textBox19.Font = new Font(textBox19.Font, FontStyle.Regular);
                    textBox20.ForeColor = Color.Black;
                    textBox20.Font = new Font(textBox20.Font, FontStyle.Regular);
                    textBox15.ForeColor = Color.Black;
                    textBox15.Font = new Font(textBox15.Font, FontStyle.Regular);
                    textBox16.ForeColor = Color.Black;
                    textBox16.Font = new Font(textBox16.Font, FontStyle.Regular);
                    textBox14.ForeColor = Color.Black;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
                    textBox13.ForeColor = Color.Black;
                    textBox13.Font = new Font(textBox13.Font, FontStyle.Regular);
                    textBox22.ForeColor = Color.Black;
                    textBox22.Font = new Font(textBox22.Font, FontStyle.Regular);
                    textBox23.ForeColor = Color.Black;
                    textBox23.Font = new Font(textBox23.Font, FontStyle.Regular);
                    textBox8.ForeColor = Color.Black;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
                }
                if ((((textBox24.Text == "S" || textBox24.Text == "s") && (textBox14.Text == "I" || textBox14.Text == "i")) && ((textBox26.Text == "S" || textBox26.Text == "s") && (textBox27.Text == "T" || textBox27.Text == "t"))) &&
                    (((textBox28.Text == "E" || textBox28.Text == "e") && (textBox29.Text == "M" || textBox29.Text == "m")) && ((textBox30.Text == "A" || textBox30.Text == "a") && (textBox25.Text == "S" || textBox25.Text == "s"))))
                {
                    textBox24.ForeColor = Color.Green;
                    textBox24.Font = new Font(textBox24.Font, FontStyle.Bold);
                    textBox14.ForeColor = Color.Green;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Bold);
                    textBox26.ForeColor = Color.Green;
                    textBox26.Font = new Font(textBox26.Font, FontStyle.Bold);
                    textBox27.ForeColor = Color.Green;
                    textBox27.Font = new Font(textBox27.Font, FontStyle.Bold);
                    textBox28.ForeColor = Color.Green;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Bold);
                    textBox29.ForeColor = Color.Green;
                    textBox29.Font = new Font(textBox29.Font, FontStyle.Bold);
                    textBox30.ForeColor = Color.Green;
                    textBox30.Font = new Font(textBox30.Font, FontStyle.Bold);
                    textBox25.ForeColor = Color.Green;
                    textBox25.Font = new Font(textBox25.Font, FontStyle.Bold);
                }
                else
                {
                    textBox24.ForeColor = Color.Black;
                    textBox24.Font = new Font(textBox24.Font, FontStyle.Regular);
                    textBox14.ForeColor = Color.Black;
                    textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
                    textBox26.ForeColor = Color.Black;
                    textBox26.Font = new Font(textBox26.Font, FontStyle.Regular);
                    textBox27.ForeColor = Color.Black;
                    textBox27.Font = new Font(textBox27.Font, FontStyle.Regular);
                    textBox28.ForeColor = Color.Black;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
                    textBox29.ForeColor = Color.Black;
                    textBox29.Font = new Font(textBox29.Font, FontStyle.Regular);
                    textBox30.ForeColor = Color.Black;
                    textBox30.Font = new Font(textBox30.Font, FontStyle.Regular);
                    textBox25.ForeColor = Color.Black;
                    textBox25.Font = new Font(textBox25.Font, FontStyle.Regular);
                }
                if ((((textBox34.Text == "E" || textBox34.Text == "e") && (textBox33.Text == "S" || textBox33.Text == "s")) && ((textBox17.Text == "C" || textBox17.Text == "c") && (textBox21.Text == "U" || textBox21.Text == "u"))) &&
                    (((textBox28.Text == "E" || textBox28.Text == "e") && (textBox32.Text == "L" || textBox32.Text == "l")) && (textBox31.Text == "A" || textBox31.Text == "a")))
                {
                    textBox34.ForeColor = Color.Green;
                    textBox34.Font = new Font(textBox34.Font, FontStyle.Bold);
                    textBox33.ForeColor = Color.Green;
                    textBox33.Font = new Font(textBox33.Font, FontStyle.Bold);
                    textBox17.ForeColor = Color.Green;
                    textBox17.Font = new Font(textBox17.Font, FontStyle.Bold);
                    textBox21.ForeColor = Color.Green;
                    textBox21.Font = new Font(textBox21.Font, FontStyle.Bold);
                    textBox28.ForeColor = Color.Green;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Bold);
                    textBox32.ForeColor = Color.Green;
                    textBox32.Font = new Font(textBox32.Font, FontStyle.Bold);
                    textBox31.ForeColor = Color.Green;
                    textBox31.Font = new Font(textBox31.Font, FontStyle.Bold);
                }
                else
                {
                    textBox34.ForeColor = Color.Black;
                    textBox34.Font = new Font(textBox34.Font, FontStyle.Regular);
                    textBox33.ForeColor = Color.Black;
                    textBox33.Font = new Font(textBox33.Font, FontStyle.Regular);
                    textBox17.ForeColor = Color.Black;
                    textBox17.Font = new Font(textBox17.Font, FontStyle.Regular);
                    textBox21.ForeColor = Color.Black;
                    textBox21.Font = new Font(textBox21.Font, FontStyle.Regular);
                    textBox28.ForeColor = Color.Black;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
                    textBox32.ForeColor = Color.Black;
                    textBox32.Font = new Font(textBox32.Font, FontStyle.Regular);
                    textBox31.ForeColor = Color.Black;
                    textBox31.Font = new Font(textBox31.Font, FontStyle.Regular);
                }
                if (((((textBox2.Text == "P" || textBox2.Text == "p") && (textBox1.Text == "R" || textBox1.Text == "r")) && ((textBox3.Text == "O" || textBox3.Text == "o") && (textBox4.Text == "G" || textBox4.Text == "g"))) &&
                    (((textBox7.Text == "R" || textBox7.Text == "r") && (textBox8.Text == "A" || textBox8.Text == "a")) && ((textBox5.Text == "M" || textBox5.Text == "m") && (textBox6.Text == "A" || textBox6.Text == "a")))) &&
                    (((textBox11.Text == "C" || textBox11.Text == "c") && (textBox12.Text == "I" || textBox12.Text == "i")) && ((textBox9.Text == "O" || textBox9.Text == "o") && (textBox10.Text == "N" || textBox10.Text == "n"))))
                {
                    textBox2.ForeColor = Color.Green;
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                    textBox1.ForeColor = Color.Green;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                    textBox3.ForeColor = Color.Green;
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                    textBox4.ForeColor = Color.Green;
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Bold);
                    textBox7.ForeColor = Color.Green;
                    textBox7.Font = new Font(textBox7.Font, FontStyle.Bold);
                    textBox8.ForeColor = Color.Green;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Bold);
                    textBox5.ForeColor = Color.Green;
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Bold);
                    textBox6.ForeColor = Color.Green;
                    textBox6.Font = new Font(textBox6.Font, FontStyle.Bold);
                    textBox11.ForeColor = Color.Green;
                    textBox11.Font = new Font(textBox11.Font, FontStyle.Bold);
                    textBox12.ForeColor = Color.Green;
                    textBox12.Font = new Font(textBox12.Font, FontStyle.Bold);
                    textBox9.ForeColor = Color.Green;
                    textBox9.Font = new Font(textBox9.Font, FontStyle.Bold);
                    textBox10.ForeColor = Color.Green;
                    textBox10.Font = new Font(textBox10.Font, FontStyle.Bold);
                }
                else
                {
                    textBox2.ForeColor = Color.Black;
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                    textBox1.ForeColor = Color.Black;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                    textBox3.ForeColor = Color.Black;
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                    textBox4.ForeColor = Color.Black;
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
                    textBox7.ForeColor = Color.Black;
                    textBox7.Font = new Font(textBox7.Font, FontStyle.Regular);
                    textBox8.ForeColor = Color.Black;
                    textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
                    textBox5.ForeColor = Color.Black;
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
                    textBox6.ForeColor = Color.Black;
                    textBox6.Font = new Font(textBox6.Font, FontStyle.Regular);
                    textBox11.ForeColor = Color.Black;
                    textBox11.Font = new Font(textBox11.Font, FontStyle.Regular);
                    textBox12.ForeColor = Color.Black;
                    textBox12.Font = new Font(textBox12.Font, FontStyle.Regular);
                    textBox9.ForeColor = Color.Black;
                    textBox9.Font = new Font(textBox9.Font, FontStyle.Regular);
                    textBox10.ForeColor = Color.Black;
                    textBox10.Font = new Font(textBox10.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox24.Text == "S" || textBox24.Text == "s")
                {
                    textBox24.ForeColor = Color.Green;
                    textBox24.Font = new Font(textBox24.Font, FontStyle.Bold);
                }
                else
                {
                    textBox24.ForeColor = Color.Black;
                    textBox24.Font = new Font(textBox24.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox25.Text == "S" || textBox25.Text == "s")
                {
                    textBox25.ForeColor = Color.Green;
                    textBox25.Font = new Font(textBox25.Font, FontStyle.Bold);
                }
                else
                {
                    textBox25.ForeColor = Color.Black;
                    textBox25.Font = new Font(textBox25.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox26.Text == "S" || textBox26.Text == "s")
                {
                    textBox26.ForeColor = Color.Green;
                    textBox26.Font = new Font(textBox26.Font, FontStyle.Bold);
                }
                else
                {
                    textBox26.ForeColor = Color.Black;
                    textBox26.Font = new Font(textBox26.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox27.Text == "T" || textBox27.Text == "t")
                {
                    textBox27.ForeColor = Color.Green;
                    textBox27.Font = new Font(textBox27.Font, FontStyle.Bold);
                }
                else
                {
                    textBox27.ForeColor = Color.Black;
                    textBox27.Font = new Font(textBox27.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox28.Text == "E" || textBox28.Text == "e")
                {
                    textBox28.ForeColor = Color.Green;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Bold);
                }
                else
                {
                    textBox28.ForeColor = Color.Black;
                    textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox29.Text == "M" || textBox29.Text == "m")
                {
                    textBox29.ForeColor = Color.Green;
                    textBox29.Font = new Font(textBox29.Font, FontStyle.Bold);
                }
                else
                {
                    textBox29.ForeColor = Color.Black;
                    textBox29.Font = new Font(textBox29.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox30.Text == "A" || textBox30.Text == "a")
                {
                    textBox30.ForeColor = Color.Green;
                    textBox30.Font = new Font(textBox30.Font, FontStyle.Bold);
                }
                else
                {
                    textBox30.ForeColor = Color.Black;
                    textBox30.Font = new Font(textBox30.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox34.Text == "E" || textBox34.Text == "e")
                {
                    textBox34.ForeColor = Color.Green;
                    textBox34.Font = new Font(textBox34.Font, FontStyle.Bold);
                }
                else
                {
                    textBox34.ForeColor = Color.Black;
                    textBox34.Font = new Font(textBox34.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox33.Text == "S" || textBox33.Text == "s")
                {
                    textBox33.ForeColor = Color.Green;
                    textBox33.Font = new Font(textBox33.Font, FontStyle.Bold);
                }
                else
                {
                    textBox33.ForeColor = Color.Black;
                    textBox33.Font = new Font(textBox33.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox17.Text == "C" || textBox17.Text == "c")
                {
                    textBox17.ForeColor = Color.Green;
                    textBox17.Font = new Font(textBox17.Font, FontStyle.Bold);
                }
                else
                {
                    textBox17.ForeColor = Color.Black;
                    textBox17.Font = new Font(textBox17.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox21.Text == "U" || textBox21.Text == "u")
                {
                    textBox21.ForeColor = Color.Green;
                    textBox21.Font = new Font(textBox21.Font, FontStyle.Bold);
                }
                else
                {
                    textBox21.ForeColor = Color.Black;
                    textBox21.Font = new Font(textBox21.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox32.Text == "L" || textBox32.Text == "l")
                {
                    textBox32.ForeColor = Color.Green;
                    textBox32.Font = new Font(textBox32.Font, FontStyle.Bold);
                }
                else
                {
                    textBox32.ForeColor = Color.Black;
                    textBox32.Font = new Font(textBox32.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox31.Text == "A" || textBox31.Text == "a")
                {
                    textBox31.ForeColor = Color.Green;
                    textBox31.Font = new Font(textBox31.Font, FontStyle.Bold);
                }
                else
                {
                    textBox31.ForeColor = Color.Black;
                    textBox31.Font = new Font(textBox31.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox2.Text == "P" || textBox2.Text == "p")
                {
                    textBox2.ForeColor = Color.Green;
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Bold);
                }
                else
                {
                    textBox2.ForeColor = Color.Black;
                    textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox1.Text == "R" || textBox1.Text == "r")
                {
                    textBox1.ForeColor = Color.Green;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
                }
                else
                {
                    textBox1.ForeColor = Color.Black;
                    textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox3.Text == "O" || textBox3.Text == "o")
                {
                    textBox3.ForeColor = Color.Green;
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Bold);
                }
                else
                {
                    textBox3.ForeColor = Color.Black;
                    textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox4.Text == "G" || textBox4.Text == "g")
                {
                    textBox4.ForeColor = Color.Green;
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Bold);
                }
                else
                {
                    textBox4.ForeColor = Color.Black;
                    textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox7.Text == "R" || textBox7.Text == "r")
                {
                    textBox7.ForeColor = Color.Green;
                    textBox7.Font = new Font(textBox7.Font, FontStyle.Bold);
                }
                else
                {
                    textBox7.ForeColor = Color.Black;
                    textBox7.Font = new Font(textBox7.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox5.Text == "M" || textBox5.Text == "m")
                {
                    textBox5.ForeColor = Color.Green;
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Bold);
                }
                else
                {
                    textBox5.ForeColor = Color.Black;
                    textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox6.Text == "A" || textBox6.Text == "a")
                {
                    textBox6.ForeColor = Color.Green;
                    textBox6.Font = new Font(textBox6.Font, FontStyle.Bold);
                }
                else
                {
                    textBox6.ForeColor = Color.Black;
                    textBox6.Font = new Font(textBox6.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox11.Text == "C" || textBox11.Text == "c")
                {
                    textBox11.ForeColor = Color.Green;
                    textBox11.Font = new Font(textBox11.Font, FontStyle.Bold);
                }
                else
                {
                    textBox11.ForeColor = Color.Black;
                    textBox11.Font = new Font(textBox11.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox12.Text == "I" || textBox12.Text == "i")
                {
                    textBox12.ForeColor = Color.Green;
                    textBox12.Font = new Font(textBox12.Font, FontStyle.Bold);
                }
                else
                {
                    textBox12.ForeColor = Color.Black;
                    textBox12.Font = new Font(textBox12.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox9.Text == "O" || textBox9.Text == "o")
                {
                    textBox9.ForeColor = Color.Green;
                    textBox9.Font = new Font(textBox9.Font, FontStyle.Bold);
                }
                else
                {
                    textBox9.ForeColor = Color.Black;
                    textBox9.Font = new Font(textBox9.Font, FontStyle.Regular);
                }
            }
        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (cmbNivel.SelectedIndex == 0)
            {
                if (textBox10.Text == "N" || textBox10.Text == "n")
                {
                    textBox10.ForeColor = Color.Green;
                    textBox10.Font = new Font(textBox10.Font, FontStyle.Bold);
                }
                else
                {
                    textBox10.ForeColor = Color.Black;
                    textBox10.Font = new Font(textBox10.Font, FontStyle.Regular);
                }
            }
        }
        private void btnCompletar_Click(object sender, EventArgs e)
        {
            //Se rellenan todos los espacios del crucigrama con los valores correctos
            textBox18.Text = "i";
            textBox19.Text = "n";
            textBox20.Text = "g";
            textBox15.Text = "e";
            textBox16.Text = "n";
            textBox14.Text = "i";
            textBox13.Text = "e";
            textBox22.Text = "r";
            textBox23.Text = "i";
            textBox8.Text = "a";

            textBox24.Text = "s";
            textBox14.Text = "i";
            textBox26.Text = "s";
            textBox27.Text = "t";
            textBox28.Text = "e";
            textBox29.Text = "m";
            textBox30.Text = "a";
            textBox25.Text = "s";

            textBox34.Text = "e";
            textBox33.Text = "s";
            textBox17.Text = "c";
            textBox21.Text = "u";
            textBox28.Text = "e";
            textBox32.Text = "l";
            textBox31.Text = "a";

            textBox2.Text = "p";
            textBox1.Text = "r";
            textBox3.Text = "o";
            textBox4.Text = "g";
            textBox7.Text = "r";
            textBox8.Text = "a";
            textBox5.Text = "m";
            textBox6.Text = "a";
            textBox11.Text = "c";
            textBox12.Text = "i";
            textBox9.Text = "o";
            textBox10.Text = "n";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //Mensaje de confirmacion
            DialogResult result = MessageBox.Show("¿Seguro que desea volver a iniciar?", "Reiniciar", MessageBoxButtons.YesNo);
            //si confirma el reinicio, entonces regresará al formato de inicio de juego.
            if (result == DialogResult.Yes)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();
                textBox13.Clear();
                textBox14.Clear();
                textBox15.Clear();
                textBox16.Clear();
                textBox17.Clear();
                textBox18.Clear();
                textBox19.Clear();
                textBox20.Clear();
                textBox21.Clear();
                textBox22.Clear();
                textBox23.Clear();
                textBox24.Clear();
                textBox25.Clear();
                textBox26.Clear();
                textBox27.Clear();
                textBox28.Clear();
                textBox29.Clear();
                textBox30.Clear();
                textBox31.Clear();
                textBox32.Clear();
                textBox33.Clear();
                textBox34.Clear();
                cmbNivel.Text = "";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
                textBox17.Enabled = false;
                textBox18.Enabled = false;
                textBox19.Enabled = false;
                textBox20.Enabled = false;
                textBox21.Enabled = false;
                textBox22.Enabled = false;
                textBox23.Enabled = false;
                textBox24.Enabled = false;
                textBox25.Enabled = false;
                textBox26.Enabled = false;
                textBox27.Enabled = false;
                textBox28.Enabled = false;
                textBox29.Enabled = false;
                textBox30.Enabled = false;
                textBox31.Enabled = false;
                textBox32.Enabled = false;
                textBox33.Enabled = false;
                textBox34.Enabled = false;
                cmbNivel.Enabled = true;
                textBox18.ForeColor = Color.Black;
                textBox18.Font = new Font(textBox18.Font, FontStyle.Regular);
                textBox19.ForeColor = Color.Black;
                textBox19.Font = new Font(textBox19.Font, FontStyle.Regular);
                textBox20.ForeColor = Color.Black;
                textBox20.Font = new Font(textBox20.Font, FontStyle.Regular);
                textBox15.ForeColor = Color.Black;
                textBox15.Font = new Font(textBox15.Font, FontStyle.Regular);
                textBox16.ForeColor = Color.Black;
                textBox16.Font = new Font(textBox16.Font, FontStyle.Regular);
                textBox14.ForeColor = Color.Black;
                textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
                textBox13.ForeColor = Color.Black;
                textBox13.Font = new Font(textBox13.Font, FontStyle.Regular);
                textBox22.ForeColor = Color.Black;
                textBox22.Font = new Font(textBox22.Font, FontStyle.Regular);
                textBox23.ForeColor = Color.Black;
                textBox23.Font = new Font(textBox23.Font, FontStyle.Regular);
                textBox8.ForeColor = Color.Black;
                textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
                textBox24.ForeColor = Color.Black;
                textBox24.Font = new Font(textBox24.Font, FontStyle.Regular);
                textBox14.ForeColor = Color.Black;
                textBox14.Font = new Font(textBox14.Font, FontStyle.Regular);
                textBox26.ForeColor = Color.Black;
                textBox26.Font = new Font(textBox26.Font, FontStyle.Regular);
                textBox27.ForeColor = Color.Black;
                textBox27.Font = new Font(textBox27.Font, FontStyle.Regular);
                textBox28.ForeColor = Color.Black;
                textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
                textBox29.ForeColor = Color.Black;
                textBox29.Font = new Font(textBox29.Font, FontStyle.Regular);
                textBox30.ForeColor = Color.Black;
                textBox30.Font = new Font(textBox30.Font, FontStyle.Regular);
                textBox25.ForeColor = Color.Black;
                textBox25.Font = new Font(textBox25.Font, FontStyle.Regular);
                textBox34.ForeColor = Color.Black;
                textBox34.Font = new Font(textBox34.Font, FontStyle.Regular);
                textBox33.ForeColor = Color.Black;
                textBox33.Font = new Font(textBox33.Font, FontStyle.Regular);
                textBox17.ForeColor = Color.Black;
                textBox17.Font = new Font(textBox17.Font, FontStyle.Regular);
                textBox21.ForeColor = Color.Black;
                textBox21.Font = new Font(textBox21.Font, FontStyle.Regular);
                textBox28.ForeColor = Color.Black;
                textBox28.Font = new Font(textBox28.Font, FontStyle.Regular);
                textBox32.ForeColor = Color.Black;
                textBox32.Font = new Font(textBox32.Font, FontStyle.Regular);
                textBox31.ForeColor = Color.Black;
                textBox31.Font = new Font(textBox31.Font, FontStyle.Regular);
                textBox2.ForeColor = Color.Black;
                textBox2.Font = new Font(textBox2.Font, FontStyle.Regular);
                textBox1.ForeColor = Color.Black;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
                textBox3.ForeColor = Color.Black;
                textBox3.Font = new Font(textBox3.Font, FontStyle.Regular);
                textBox4.ForeColor = Color.Black;
                textBox4.Font = new Font(textBox4.Font, FontStyle.Regular);
                textBox7.ForeColor = Color.Black;
                textBox7.Font = new Font(textBox7.Font, FontStyle.Regular);
                textBox8.ForeColor = Color.Black;
                textBox8.Font = new Font(textBox8.Font, FontStyle.Regular);
                textBox5.ForeColor = Color.Black;
                textBox5.Font = new Font(textBox5.Font, FontStyle.Regular);
                textBox6.ForeColor = Color.Black;
                textBox6.Font = new Font(textBox6.Font, FontStyle.Regular);
                textBox11.ForeColor = Color.Black;
                textBox11.Font = new Font(textBox11.Font, FontStyle.Regular);
                textBox12.ForeColor = Color.Black;
                textBox12.Font = new Font(textBox12.Font, FontStyle.Regular);
                textBox9.ForeColor = Color.Black;
                textBox9.Font = new Font(textBox9.Font, FontStyle.Regular);
                textBox10.ForeColor = Color.Black;
                textBox10.Font = new Font(textBox10.Font, FontStyle.Regular);
                btnCompletar.Enabled = false;
                btnLimpiar.Enabled = false;
                btnNuevo.Enabled = false;
                btnPistas.Enabled = false;
                btnTerminar.Enabled = false;
                btnAceptar.Enabled = true;
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            //Si todas las espacios del crucigrama son correctos entonces, el jugador habrá ganado
            if (((((((textBox18.Text == "I" || textBox18.Text == "i") && (textBox19.Text == "N" || textBox19.Text == "n")) && ((textBox20.Text == "G" || textBox20.Text == "g") && (textBox15.Text == "E" || textBox15.Text == "e"))) &&
                    (((textBox16.Text == "N" || textBox16.Text == "n") && (textBox14.Text == "I" || textBox14.Text == "i")) && ((textBox13.Text == "E" || textBox13.Text == "e") && (textBox22.Text == "R" || textBox22.Text == "r")))) &&
                    ((textBox23.Text == "I" || textBox23.Text == "i") && (textBox8.Text == "A" || textBox8.Text == "a")))&& ((((textBox24.Text == "S" || textBox24.Text == "s") && (textBox14.Text == "I" || textBox14.Text == "i")) && ((textBox26.Text == "S" || textBox26.Text == "s") && (textBox27.Text == "T" || textBox27.Text == "t"))) &&
                (((textBox28.Text == "E" || textBox28.Text == "e") && (textBox29.Text == "M" || textBox29.Text == "m")) && ((textBox30.Text == "A" || textBox30.Text == "a") && (textBox25.Text == "S" || textBox25.Text == "s")))))&&(((((textBox34.Text == "E" || textBox34.Text == "e") && (textBox33.Text == "S" || textBox33.Text == "s")) && ((textBox17.Text == "C" || textBox17.Text == "c") && (textBox21.Text == "U" || textBox21.Text == "u"))) &&
                (((textBox28.Text == "E" || textBox28.Text == "e") && (textBox32.Text == "L" || textBox32.Text == "l")) && (textBox31.Text == "A" || textBox31.Text == "a")))&& (((((textBox2.Text == "P" || textBox2.Text == "p") && (textBox1.Text == "R" || textBox1.Text == "r")) && ((textBox3.Text == "O" || textBox3.Text == "o") && (textBox4.Text == "G" || textBox4.Text == "g"))) &&
                (((textBox7.Text == "R" || textBox7.Text == "r") && (textBox8.Text == "A" || textBox8.Text == "a")) && ((textBox5.Text == "M" || textBox5.Text == "m") && (textBox6.Text == "A" || textBox6.Text == "a")))) &&
                (((textBox11.Text == "C" || textBox11.Text == "c") && (textBox12.Text == "I" || textBox12.Text == "i")) && ((textBox9.Text == "O" || textBox9.Text == "o") && (textBox10.Text == "N" || textBox10.Text == "n"))))))
            {
                MessageBox.Show("¡¡¡¡¡¡FELICITACIONES!!!!!!\nUsted ha completado el crucigrama correctamente.", "GANADOR", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Ha completado incorrectamente el crucigrama.\nSiga intentando.", "SIGA INTENTANDO", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
