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
    public partial class FrmEjercicio6 : Form
    {
        private DataGridViewColumn[] titulo = new DataGridViewColumn[2];
        public FrmEjercicio6()
        {
            InitializeComponent();
            //Creamos dos columnas para nuestro data grid view.
            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Pregunta";
            titulo[0].Name = "colPre";
            titulo[0].Width = 193;
            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Resp.";
            titulo[1].Name = "colRes";
            titulo[1].Width = 50;
            dgvProceso.Columns.AddRange(titulo);

        }


        //El btnSi se encargará de ejecutar las acciones siguientes a presionar "Sí" en el test.
        private void btnSi_Click(object sender, EventArgs e)
        {
            //Verificamos el valor actual del título.
            if (lblTitulo.Text == "CONTACTO ESTRECHO")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Contacto estrecho.", "Sí");
                lblTitulo.Text = "PRESENCIA DE SÍNTOMAS";
                lblPregunta.Text = "¿Presenta usted algún síntoma?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "PRESENCIA DE SÍNTOMAS")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Presencia de síntomas.", "Sí");
                lblTitulo.Text = "DURACIÓN DE LOS SÍNTOMAS";
                lblPregunta.Text = "¿Hace más de 14 días que comenzaron los síntomas?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "DURACIÓN DE LOS SÍNTOMAS")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Duración de los síntomas.", "Sí");
                //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                lblDiagnostico.Visible = true;
                lblDiag.Visible = true;
                lblDiag.Text = "La COVID-19 es una enfermedad aguda,\r\npor lo tanto los síntomas que presenta\r\nahora, podrían deberse a una causa diferente.";
                btnSi.Enabled = false;
                btnNo.Enabled = false;
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "DIFICULTAD RESPIRATORIA")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Dificultad respiratoria.", "Sí");
                //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                lblDiagnostico.Visible = true;
                lblDiag.Visible = true;
                lblDiag.Text = "Sus síntomas parecen indicar gravedad.\r\nComuníquese con una entidad de salud y\r\nexplique que tuvo contacto estrecho con\r\nun caso de COVID-19.";
                btnSi.Enabled = false;
                btnNo.Enabled = false;
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text== "FIEBRE > 37,7°C")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Fiebre > 37,7°C", "Sí");
                lblTitulo.Text = "FIEBRE > 39°C";
                lblPregunta.Text = "¿Presenta fiebre de más de 39°C?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "FIEBRE > 39°C")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Fiebre > 39°C", "Sí");
                lblPregunta.Text = "Podría presentar síntomas como:\r\nTos Persistente - Alteración del gusto u olfato\r\nMalestar general - Dolor de garganta/congestión nasal\r\nDolor de cabeza - Dolor abdominal";
                //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                lblDiagnostico.Visible = true;
                lblDiag.Visible = true;
                lblDiag.Text = "Identifique los síntomas mencionados y\r\ncomuníquese con una entidad de salud\r\nExplique sus síntomas.";
                btnSi.Enabled = false;
                btnNo.Enabled = false;
            }
        }


        //El btnNo se encargará de ejecutar las acciones siguientes a presionar "No" en el test.
        private void btnNo_Click(object sender, EventArgs e)
        {
            //Verificamos el valor actual del título.
            if (lblTitulo.Text == "CONTACTO ESTRECHO")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Contacto estrecho.", "No");
                //Cambiamos el texto 
                lblTitulo.Text = "PRESENCIA DE SÍNTOMAS";
                lblPregunta.Text = "¿Presenta usted algún síntoma?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "PRESENCIA DE SÍNTOMAS")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Presencia de síntomas.", "No");
                if (Convert.ToString(dgvProceso.Rows[0].Cells[1].Value) == "No")
                {
                    //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                    lblDiagnostico.Visible = true;
                    lblDiag.Visible = true;
                    lblDiag.Text = "En este momento, su situación no requiere asistencia\r\nsanitaria. Recuerde seguir respetando las normas\r\nde distanciamiento social.";
                    btnSi.Enabled = false;
                    btnNo.Enabled = false;
                }
                else if (Convert.ToString(dgvProceso.Rows[0].Cells[1].Value) == "Sí")
                {
                    if (Convert.ToString(dgvProceso.Rows[1].Cells[1].Value) == "No")
                    {
                        //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                        lblDiagnostico.Visible = true;
                        lblDiag.Visible = true;
                        lblDiag.Text = "Usted estuvo en contacto con un caso de COVID-19\r\npor lo tanto, debe permanecer en casa y evitar\r\nel contacto con otras personas.";
                        btnSi.Enabled = false;
                        btnNo.Enabled = false;
                    }
                    else
                    {
                        lblTitulo.Text = "DURACIÓN DE LOS SÍNTOMAS";
                        lblPregunta.Text = "¿Hace más de 14 días que comenzaron los síntomas?";
                    }
                }
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "DURACIÓN DE LOS SÍNTOMAS")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Duración de los síntomas.", "No");
                lblTitulo.Text = "DIFICULTAD RESPIRATORIA";
                lblPregunta.Text = "¿Tiene dificultad repentina para respirar, o\r\nnota que le falta aire?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text=="DIFICULTAD RESPIRATORIA")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Dificultad respiratoria.", "No");
                lblTitulo.Text = "FIEBRE > 37,7°C";
                lblPregunta.Text = "¿Presenta fiebre de más de 37,7°C?";
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "FIEBRE > 37,7°C")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Fiebre > 37,7°C", "No");
                lblTitulo.Text = "OTROS SÍNTOMAS"; 
                lblPregunta.Text = "Podría presentar síntomas como:\r\nTos Persistente - Alteración del gusto u olfato\r\nMalestar general - Dolor de garganta/congestión nasal\r\nDolor de cabeza - Dolor abdominal";
                //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                lblDiagnostico.Visible = true;
                lblDiag.Visible = true;
                lblDiag.Text = "Identifique los síntomas mencionados y\r\ncomuníquese con una entidad de salud\r\nExplique sus síntomas.";
                btnSi.Enabled = false;
                btnNo.Enabled = false;
            }
            //Verificamos el valor actual del título.
            else if (lblTitulo.Text == "FIEBRE > 39°C")
            {
                //Agregamos una fila a nustro dgvProgreso, almacenando la respuesta.
                dgvProceso.Rows.Add("Fiebre > 39°C", "No");
                lblTitulo.Text = "OTROS SÍNTOMAS";
                lblPregunta.Text = "Podría presentar síntomas como:\r\nTos Persistente - Alteración del gusto u olfato\r\nMalestar general - Dolor de garganta/congestión nasal\r\nDolor de cabeza - Dolor abdominal";
                //Mostramos los textos de diagnóstico, deshabilitaremos los botones de Sí y No.
                lblDiagnostico.Visible = true;
                lblDiag.Visible = true;
                lblDiag.Text = "Identifique los síntomas mencionados y\r\ncomuníquese con una entidad de salud\r\nExplique sus síntomas.";
                btnSi.Enabled = false;
                btnNo.Enabled = false;
            }
        }

        //Botón para Iniciar o Reiniciar el test.
        private void button1_Click(object sender, EventArgs e)
        {
            //If para verificar el estado del test, comparando con el texto del botón.
            if(btnIniciar.Text=="INICIAR TEST")
            {
                btnIniciar.Text = "REINICIAR TEST";
            }
            else
            {
                //Limpiamos el dgv, y ocultamos los textos de diagnóstico.
                dgvProceso.Rows.Clear();
                lblDiagnostico.Visible = false;
                lblDiag.Visible = false;

            }
            //Hacemos visibles los textos de título y pregunta.
            lblTitulo.Visible = true;
            lblPregunta.Visible = true;
            //Mostramos y habilitamos los botones de Sí y No.
            btnSi.Visible = true;
            btnNo.Visible = true;
            btnSi.Enabled = true;
            btnNo.Enabled = true;
            //Colocamos el título y pregunta inicial.
            lblPregunta.Text = "¿Tuviste algún contacto a menos de 2 metros durante\r\nun mínimo de 15 minutos o convives/cuidas a alguna\r\npersona con COVID-19 sin medidas de protección?";
            lblTitulo.Text = "CONTACTO ESTRECHO";
        }

        
    }
}
