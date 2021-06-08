using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Anco_Martinez
{
    public partial class FrmEjercicio10 : Form
    {
        //declaracion de los arraylists (orden de llegadas, duracion de procesos y tiempo de espera
        ArrayList ordLlegada = new ArrayList();
        ArrayList duracion = new ArrayList();
        ArrayList tmpEspera = new ArrayList();
        private DataGridViewColumn[] titulo = new DataGridViewColumn[2];
        Random rnd = new Random();
        int cantProcesos, tiempo, orden, contProcesos = 0, durac, tiempoespera, suma = 0;

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            //se asignan de nuevo las propiedades a los componentes
            dgvProcesos.Rows.Clear();
            dgvDiagrama.Columns.Clear();
            txtProcesos.Clear();
            txtValor.Clear();
            txtEspera.Clear();
            txtMediaEspera.Clear();
            txtProcesos.ReadOnly = false;
            txtValor.ReadOnly = false;
            txtProcesos.Enabled = true;
            txtValor.Enabled = true;
            cmbTipo.Enabled = true;
            btnAgregar.Enabled = true;
            txtEspera.Enabled = false;
            txtMediaEspera.Enabled = false;
            btnCalcularEsp.Enabled = false;
            btnCalcularMedEsp.Enabled = false;
            btnVer.Enabled = false;
            tmpEspera.Clear();
            tmpLlegada.Clear();
            ordLlegada.Clear();
            duracion.Clear();
            contProcesos = 0;
            suma = 0;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            int durtotal, color, indice = 0;
            //for para recorrer la cantidad de procesos
            for (int i = 0; i < cantProcesos; i++)
            {
                //numero aleatorio del 1 al 13 para elegir el color de relleno
                color = rnd.Next(1, 14);
                //seleccionamos la duracion del proceso [i]
                durtotal = Convert.ToInt32(duracion[i]);
                //for para recorrer la duracion y asi añadir los espacios del diagrama de grant (cada columna es 1 de duracion del proceso)
                for (int j = 0; j < durtotal; j++)
                {
                    dgvDiagrama.Columns.Add("", "P" + (i+1).ToString());
                    switch (color)
                    {
                        case 1: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Red; break;
                        case 2: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Orange; break;
                        case 3: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.SkyBlue; break;
                        case 4: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Yellow; break;
                        case 5: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.LightGreen; break;
                        case 6: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Purple; break;
                        case 7: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Brown; break;
                        case 8: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Pink; break;
                        case 9: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Blue; break;
                        case 10: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Black; break;
                        case 11: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.BurlyWood; break;
                        case 12: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.DarkGreen; break;
                        case 13: dgvDiagrama.Columns[indice].DefaultCellStyle.BackColor = Color.Gold; break;
                    }
                    indice++;
                }
            }
            //se agrega una sola fila para el diagrama de grant
            dgvDiagrama.Rows.Add();
        }

        private void dgvDiagrama_SelectionChanged(object sender, EventArgs e)
        {
            //para que no se seleccione una celda
            dgvDiagrama.ClearSelection();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //limpia el proceso de tiempo de espera y tiempo medio de espera
            txtEspera.Clear();
            txtMediaEspera.Clear();
        }

        ArrayList tmpLlegada = new ArrayList();

        private void btnCalcularEsp_Click(object sender, EventArgs e)
        {
            //Se habilita la sección de tiempo medio de espera
            txtMediaEspera.Enabled = true;
            btnCalcularMedEsp.Enabled = true;
            //for para recorrer la cantidad de procesos
            for (int i = 0; i < cantProcesos; i++)
            {
                //como recien inicia, no hay tiempo de espera
                if (i == 0)
                {
                    txtEspera.Text += " - P" + (i + 1).ToString() + " = 0 (Inicio)\r\n\r\n";
                    tmpEspera.Add(0);
                }
                //el tiempo de espera es igual a la suma de la duracion del proceso anterior mas el tiempo de espera del proceso anterior
                else
                {
                    txtEspera.Text += " - P" + (i + 1).ToString() + " = Duracion de P" + i + " + Tiempo de espera de P" + i + "\r\n";
                    tiempoespera = Convert.ToInt32(duracion[i - 1]) + Convert.ToInt32(tmpEspera[i - 1]);
                    txtEspera.Text += "   P" + (i + 1).ToString() + " = " + Convert.ToString(tiempoespera) + "\r\n\r\n";
                    tmpEspera.Add(tiempoespera);
                }
            }
        }

        private void btnCalcularMedEsp_Click(object sender, EventArgs e)
        {
            double media;
            txtMediaEspera.Text += "Tiempo medio de espera = \r\n";
            //for para imprimir de manera teorica el desarrollo del tiempo medio de espera
            //El tiempo de espera es el promedio de los tiempos de espera
            for (int i = 0; i < cantProcesos; i++)
            {
                if (i == cantProcesos - 1)
                {
                    txtMediaEspera.Text += "Tiempo de espera P" + (i + 1).ToString() + " ) / " + cantProcesos + "\r\n\r\n";
                }
                else if (i == 0)
                {
                    txtMediaEspera.Text += " ( Tiempo de espera P" + (i + 1).ToString() + " + ";
                }
                else
                {
                    txtMediaEspera.Text += "Tiempo de espera P" + (i + 1).ToString() + " + ";
                }
            }
            //for para imprimir los tiempos de espera de los procesos
            txtMediaEspera.Text += "Tiempo medio de espera = \r\n";
            for (int i = 0; i < cantProcesos; i++)
            {
                if (i == cantProcesos - 1)
                {
                    txtMediaEspera.Text += tmpEspera[i] + " ) / " + cantProcesos + "\r\n\r\n";
                }
                else if (i == 0)
                {
                    txtMediaEspera.Text += " ( " + tmpEspera[i] + " + ";
                }
                else
                {
                    txtMediaEspera.Text += tmpEspera[i] + " + ";
                }
                suma += Convert.ToInt32(tmpEspera[i]);
            }
            //se realiza el promedio y se imprime en el desarrollo
            txtMediaEspera.Text += "Tiempo medio de espera = ( " + suma + " ) / " + cantProcesos + "\r\n\r\n";
            media = suma / cantProcesos;
            media = Math.Round(media, 2);
            txtMediaEspera.Text += "Tiempo medio de espera = " + Convert.ToString(media);
        }

        public FrmEjercicio10()
        {
            InitializeComponent();
            //asignar las columnas del DataGridView de la tabla basica de procesos
            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Procesos";
            titulo[0].Name = "colProcesos";
            titulo[0].Width = 80;
            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Duración";
            titulo[1].Name = "colDuracion";
            titulo[1].Width = 80;
            dgvProcesos.Columns.AddRange(titulo);

            cmbTipo.Items.Add("Tiempo de llegada");
            cmbTipo.Items.Add("Orden de llegada");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Validacion de campos vacios
            if ((txtProcesos.Text == "" || txtValor.Text == "") || cmbTipo.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Validacion para aceptar solo numeros enteros
                try
                {
                    
                    cantProcesos = Convert.ToInt32(txtProcesos.Text);
                    //Validacion, no se puede realizar el algoritmo de planificacion de procesos con menos de 2 procesos
                        if (cantProcesos > 1)
                        {
                            //Mensaje de confirmacion, para seleccionar el tipo y la cantidad de procesos
                            DialogResult result = MessageBox.Show("Cantidad de procesos = " + txtProcesos.Text + "\r\nEscogió '" + cmbTipo.Text + "', valor = " + txtValor.Text + ", ya no podrá cambiar.\r\n¿Desea continuar?", "REGISTRO PROCESOS", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                            //Deshabilita el ingreso de cant de procesos y la seleccion del tipo
                                txtProcesos.ReadOnly = true;
                                cmbTipo.Enabled = false;
                                //Contador para permitir ingresar los valores respetando la cantidad de procesos 
                                if (contProcesos < cantProcesos)
                                {   
                                    //se comprueba el tipo de llegada y se va agregando a los arraylists
                                    if (cmbTipo.Text == "Tiempo de llegada")
                                    {
                                        tiempo = Convert.ToInt32(txtValor.Text);
                                        tmpLlegada.Add(tiempo);
                                    }
                                    if (cmbTipo.Text == "Orden de llegada")
                                    {
                                        orden = Convert.ToInt32(txtValor.Text);
                                        ordLlegada.Add(orden);
                                    }
                                    contProcesos++;
                                    txtValor.Clear();
                                }
                                //cuando llegue a la cantidad de procesos, se desahilitara la seccion registro y se habilitará la seccion de tiempos de espera y el diagrama de grant
                                if (contProcesos == cantProcesos)
                                {
                                    txtValor.ReadOnly = true;
                                    btnAgregar.Enabled = false;
                                    btnCalcularEsp.Enabled = true;
                                    txtEspera.Enabled = true;
                                    btnCalcularEsp.Enabled = true;
                                    dgvDiagrama.Enabled = true;
                                    btnVer.Enabled = true;
                                    //si se selecciono el tiempo de llegada, se ordena de mayor a menor y se llena consecutivamente el arraylist de orden de llegada
                                    if (cmbTipo.Text == "Tiempo de llegada")
                                    {
                                        tmpLlegada.Sort();
                                        for (int i = 0; i < cantProcesos; i++)
                                        {
                                            ordLlegada.Add(i + 1);
                                        }
                                    }
                                    //si se selecciono el orden de llegada, se ordena de mayor a menor y se llena el tiempo de llegada de manera aleatoria, respetando el orden
                                    if (cmbTipo.Text == "Orden de llegada")
                                    {
                                        ordLlegada.Sort();
                                        for (int i = 0; i < cantProcesos; i++)
                                        {
                                            tmpLlegada.Add(rnd.Next(1, 20));
                                        }
                                        tmpLlegada.Sort();
                                    }
                                    //una vez llenados los tiempos de llegada, se establecen la duracion de cada proceso
                                    for (int i = 0; i < cantProcesos; i++)
                                    {
                                        //la duracion y el tiempo de llegada del primer proceso seran iguales
                                        if (i == 0)
                                        {
                                            duracion.Add(Convert.ToInt32(tmpLlegada[i]));
                                        }
                                        //para los siguientes se le iran restando el tiempo de llegada del proceso anterior y se almacenara en un arraylist
                                        else
                                        {
                                            durac = Convert.ToInt32(tmpLlegada[i]) - Convert.ToInt32(tmpLlegada[i - 1]);
                                            duracion.Add(durac);
                                        }
                                    }
                                    //se llena la tabla de procesos
                                    for (int i = 0; i < cantProcesos; i++)
                                    {
                                        dgvProcesos.Rows.Add("P" + (i + 1), duracion[i]);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe tener de 2 a más procesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ingrese numeros enteros en procesos y valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
