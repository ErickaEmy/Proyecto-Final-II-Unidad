using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Anco_Martinez
{
    public partial class FrmEjercicio5 : Form
    {
        DateTime today = DateTime.Today;
        ArrayList descFact = new ArrayList();
        int numeroFactura=1;
        int i = 0, aux = 0,j=0;
        ArrayList importes = new ArrayList();
        ArrayList nombres = new ArrayList();
        ArrayList descuentos = new ArrayList();
        double importe,valorFact=0;
        //Declarar las matrices de articulos y clientes
        string[,] articulos = new string[100, 3];
        string[,] clientes = new string[100, 3];
        //Declarar array de las rutas de las imagenes de los articulos
        string[] imgRutas = new string[100];
        string ruta;
        //Declarar titulo como columnas de la tabla para los articulos en venta
        private DataGridViewColumn[] titulo = new DataGridViewColumn[5];
        int indexRow;

        public FrmEjercicio5()
        {
            InitializeComponent();
            //Establecer la fecha actual en la factura
            label13.Text = DateTime.Today.ToString("dd-MM-yyyy");
            lblNumFactura.Text = "N° 001 - " + Convert.ToString(numeroFactura);

            //Crear la tabla del DataGridView en la Factura
            titulo[0] = new DataGridViewTextBoxColumn();
            titulo[0].HeaderText = "Cant.";
            titulo[0].Name = "colCant";
            titulo[0].Width = 50;
            titulo[1] = new DataGridViewTextBoxColumn();
            titulo[1].HeaderText = "Descripción";
            titulo[1].Name = "colDescripcion";
            titulo[1].Width = 120;
            titulo[2] = new DataGridViewTextBoxColumn();
            titulo[2].HeaderText = "Precio Unit.";
            titulo[2].Name = "colPrecio";
            titulo[2].Width = 80;
            titulo[3] = new DataGridViewTextBoxColumn();
            titulo[3].HeaderText = "Descuento (%)";
            titulo[3].Name = "colDescuento";
            titulo[3].Width = 80;
            titulo[4] = new DataGridViewTextBoxColumn();
            titulo[4].HeaderText = "Valor Venta";
            titulo[4].Name = "colValor";
            titulo[4].Width = 110;
            dgvArticulosFact.Columns.AddRange(titulo);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            //Validacion de textboxs vacios
            if ((txtRUC.Text == "" || txtNombre.Text == "")|| txtDireccion.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Ingresa valores a la matriz "clientes", en este caso se trabajo como una tabla, las filas son los 
                //clientes que se irán agreando y las columnas estan establecidas como RUC, Nombre y Direccion
                clientes[j, 0] = txtRUC.Text;
                clientes[j, 1] = txtNombre.Text;
                clientes[j, 2] = txtDireccion.Text;
                MessageBox.Show("Ha registrado un cliente.", "GUARDADO", MessageBoxButtons.OK);
                j++;
                txtRUCCompra.Enabled = true;
                btnBuscarRUC.Enabled = true;
            }
            //Limpia los textboxs, para volver a registrar
            txtRUC.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            //Validacion de textboxs vacios
            if ((txtCodigoArt.Text == "" || txtNombreArt.Text == "")|| txtPrecioArt.Text == "")
            {
                MessageBox.Show("Debe rellenar todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Ingresa valores a la matriz "articulos", en este caso se trabajo como una tabla, las filas son los 
                //articulos que se irán agreando y las columnas estan establecidas como Codigo, Nombre y Precio
                articulos[i, 0] = txtCodigoArt.Text;
                articulos[i, 1] = txtNombreArt.Text;
                articulos[i, 2] = txtPrecioArt.Text;
                //Se ingresa la ruta de la imagen del articulo al array "imgRutas"
                imgRutas[i] = ruta;
                MessageBox.Show("Ha registrado un Articulo.", "GUARDADO", MessageBoxButtons.OK);
                i++;
                btnAgregarArticulo.Enabled = false;
            }
            //Limpia los textboxs, para volver a registrar
            txtCodigoArt.Clear();
            txtNombreArt.Clear();
            txtPrecioArt.Clear();
            pbArtCompra.Image = null;
        }

        private void btnBuscarRUC_Click(object sender, EventArgs e)
        {
            aux = 0;
            //Validacion de textbox vacio
            if (txtRUCCompra.Text == "")
            {
                MessageBox.Show("Debe ingresar un RUC a buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //for para recorrer las filas de la matriz clientes
                for (int fC = 0; fC < j; fC++)
                {
                    //si la el ruc del cliente de la fila 'fC' es igual al valor ingresado por el textbox, entonces:
                    if (clientes[fC, 0].Equals(txtRUCCompra.Text))
                    {
                        //Confirmacion de la selección del cliente
                        DialogResult result = MessageBox.Show("El cliente es " + clientes[fC, 1] + ".\r\n No podrá cambiar luego, ¿Desea continuar?", "CLIENTE", MessageBoxButtons.YesNo);
                        //Si escoge el cliente, entonces:
                        if (result == DialogResult.Yes)
                        {
                            //Extrae el ruc, nombre y direccion de la matriz cliente y lo imprime en la factura
                            txtRUCFact.Text = clientes[fC, 0];
                            txtClienteFact.Text = clientes[fC, 1];
                            txtDireccionFact.Text = clientes[fC, 2];
                            //Auxiliar para indicar que si se encontró el Ruc buscado
                            aux = 1;
                            //Se desbloquean los componentes para realizar la venta
                            btnAgregarCompra.Enabled = true;
                            btnEliminarCompra.Enabled = true;
                            btnLimpiarCompra.Enabled = true;
                            txtCodCompra.Enabled = true;
                            txtCantCompra.Enabled = true;
                            txtPrecioCompra.Enabled = true;
                            txtNomCompra.Enabled = true;
                            txtRUCCompra.Enabled = false;
                            btnBuscarRUC.Enabled = false;
                        }
                    }
                }
                //Si no se encontró el Ruc en la matriz clientes, entonces:
                if (aux == 0)
                {
                    MessageBox.Show("No existe el cliente con el RUC " + txtRUCCompra.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            double precioventa,descuentotemp,igv;
            int cantidadtemp;
            int indice = 0,aux2=0;
            valorFact = 0;
            //Validacion de textboxs vacios
            if (txtCodCompra.Text == ""|| txtCantCompra.Text == "")
            {
                MessageBox.Show("Debe completar los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    //Validación que la cantidad ingresada debe ser mayor o igual que 1
                    if (Convert.ToInt32(txtCantCompra.Text) >= 1)
                    {
                        importe = Convert.ToDouble(txtPrecioCompra.Text) * Convert.ToDouble(txtCantCompra.Text);
                        //for para recorrer el ArrayList "nombres", donde se almacenan las descripciones de la factura
                        foreach (var descripcion in nombres)
                        {
                            //si una descripcion de la factura coincide con el nombre a ingresar, entonces:
                            if (descripcion.Equals(txtNomCompra.Text))
                            {
                                //si el descuento del producto de la fila seleccionada es "-" (vacío), entonces:
                                if (dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value.Equals("-") == true)
                                {
                                    //se sumará el importe del articulo agregado, al importe (valor venta de la factura) ya existente, 
                                    //de igual modo con la cantidad de productos en la factura
                                    precioventa = Convert.ToDouble(importes[indice]) + importe;
                                    importes[indice] = precioventa;
                                    dgvArticulosFact.Rows[indice].Cells[4].Value = precioventa;
                                    cantidadtemp = Convert.ToInt32(dgvArticulosFact.Rows[indice].Cells[0].Value);
                                    cantidadtemp += Convert.ToInt32(txtCantCompra.Text);
                                    dgvArticulosFact.Rows[indice].Cells[0].Value = cantidadtemp;
                                    //Auxiliar para indicar que se encontró una descripcion igual al nombre del articulo a ingresar
                                    aux2 = 1;
                                }
                                //si hay un descuento establecido en el articulo, entonces:
                                else
                                {
                                    //extraer el valor del descuento del DataGridView
                                    descuentotemp = Convert.ToDouble(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value);
                                    //Se calculara el importe nuevo a ingresar restandole el descuento, posteriormente se agregará el resultado 
                                    //al importe del articulo ya existente en la factura
                                    precioventa = Convert.ToDouble(importes[indice]) + (importe-(importe*descuentotemp/100));
                                    importes[indice] = precioventa;
                                    aux2 = 1;
                                    dgvArticulosFact.Rows[indice].Cells[4].Value = precioventa;
                                    //se sumará la cantidad del articulo agregado, a la cantidad de articulos ya existentes en la factura 
                                    cantidadtemp = Convert.ToInt32(dgvArticulosFact.Rows[indice].Cells[0].Value);
                                    cantidadtemp += Convert.ToInt32(txtCantCompra.Text);
                                    dgvArticulosFact.Rows[indice].Cells[0].Value = cantidadtemp;
                                }
                            }
                            indice++;
                        }
                        //si no se encontró el articulo en la factura, es decir, se agregara un articulo NUEVO, entonces:
                        if (aux2 == 0)
                        {
                            //se agrega una fila al DataGridView con el valor de los textboxs de la venta
                            dgvArticulosFact.Rows.Add(txtCantCompra.Text, txtNomCompra.Text, txtPrecioCompra.Text, "-", importe);
                            //Se agregaran los valores de los importes, descuentos y nombres(descripciones) de la factura en ArrayList
                            importes.Add(importe);
                            descuentos.Add(0);
                            nombres.Add(txtNomCompra.Text);
                        }
                        //for para calular el subtotal, siendo la suma de todos los importes de la factura
                        foreach(var precios in importes)
                        {
                            valorFact += Convert.ToDouble( precios);
                        }
                        //se calcula el igv y total, para una mejor percepcion, se redondea a dos decimales
                        valorFact = Math.Round(valorFact, 2);
                        txtSubtotal.Text = Convert.ToString(valorFact);
                        igv = Math.Round(valorFact*0.18, 2);
                        txtIGV.Text = Convert.ToString(igv);
                        txtTotal.Text = Convert.ToString(igv + valorFact);
                        //Limpiar los textboxs de la venta, para seguir agregando articulos
                        txtCodCompra.Clear();
                        txtNomCompra.Clear();
                        txtPrecioCompra.Clear();
                        txtCantCompra.Text = "1";
                        pbArtCompra.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("La cantidad debe ser mínimo 1.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //si no se ingresan numeros en el codigo del articulo o la cantidad de articulos
                catch (Exception ex)
                {
                    MessageBox.Show("Debe ingresar un numero entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtCodCompra_TextChanged(object sender, EventArgs e)
        {
            aux = 0;
            //Validacion si el codigo del articulo no es vacio
            if (txtCodCompra.Text.Equals("") == false)
            {
                //se recorrerá la matriz de articulos
                for (int fA = 0; fA < i; fA++)
                {
                    //cuando el valor registrado del codigo en la matriz sea igual al ingresado por el texbox, entonces:
                    if (articulos[fA, 0].Equals(txtCodCompra.Text))
                    {
                        //rellenar los valores de nombre, precio y la imagen del articulo
                        txtNomCompra.Text = articulos[fA, 1];
                        txtPrecioCompra.Text = articulos[fA, 2];
                        pbArtCompra.ImageLocation = imgRutas[fA];
                        //Auxliar para indicar que se encontró el articulo
                        aux = 1;
                    }
                }
                //si no se encontró el articulo
                if (aux == 0)
                {
                    //limpia los texboxs
                    txtCodCompra.Clear();
                    txtNomCompra.Clear();
                    txtPrecioCompra.Clear();
                    txtCantCompra.Text="1";
                    pbArtCompra.Image = null;
                    MessageBox.Show("No existe el articulo con el codigo " + txtCodCompra.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //si no escribio ningun codigo, limpia los textboxs
            else
            {
                txtCodCompra.Clear();
                txtNomCompra.Clear();
                txtPrecioCompra.Clear();
                txtCantCompra.Text = "1";
                pbArtCompra.Image = null;
            }
        }

        private void btnEliminarCompra_Click(object sender, EventArgs e)
        {
            double st,igv;
            int indice = 0,indic=0;
            string nomFactu;
            //Mensaje de confirmacion
            DialogResult result = MessageBox.Show("¿Esta seguro de eliminar el articulo?","Eliminar", MessageBoxButtons.YesNo);
            //si confirma la eliminacion, entonces:
            if (result == DialogResult.Yes)
            {
                //validar que se seleccionó un articulo
                if (dgvArticulosFact.SelectedRows.Count > 0)
                {
                    //extraer la descripcion de la factura, de la fila seleccionada
                    nomFactu = Convert.ToString(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[1].Value);
                    //for para encontrar la coindicencia en las descripciones de la factura con el elemento seleccionado
                    foreach (var descripcion in nombres)
                    {
                        if (descripcion.Equals(nomFactu))
                        {
                            //si encuentra el nombre del articulo, entonces almacena el indice
                            indic = indice;
                        }
                        indice++;
                    }
                    //Extrae el valor subtotal actual y luego le resta el importe del articulo eliminado
                    st = Convert.ToDouble(txtSubtotal.Text);
                    st = st - Convert.ToDouble(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[4].Value);
                    //Redondea el subtotal a dos decimales y asigna los valor de igv y total en la factura
                    st = Math.Round(st, 2);
                    txtSubtotal.Text = Convert.ToString(st);
                    igv = Math.Round(st*0.18, 2);
                    txtIGV.Text = Convert.ToString(igv);
                    txtTotal.Text = Convert.ToString(igv+st);
                    //Elimina los valores de la fila seleccionada en los arrayList
                    nombres.RemoveAt(indic);
                    importes.RemoveAt(indic);
                    descuentos.RemoveAt(indic);
                    //Elimina la fila seleccionada
                    dgvArticulosFact.Rows.RemoveAt(this.dgvArticulosFact.CurrentRow.Index);
                }
            }
        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            if (txtSubtotal.Text.Equals("")==false)
            {
                //si subtotal no es vacio y es mayor a 0, entonces:
                if (Convert.ToDouble(txtSubtotal.Text) > 0)
                {
                    //Habilita la la seccion de promociones y las opciones de terminar o reiniciar factura
                    btnReiniciar.Enabled = true;
                    btnTerminar.Enabled = true;
                    txtDescuento.Enabled = true;
                    btnAplicar.Enabled = true;
                    btnQuitar.Enabled = true;
                }
                else
                {
                    //Deshabilita la la seccion de promociones y las opciones de terminar o reiniciar factura
                    btnReiniciar.Enabled = false;
                    btnTerminar.Enabled = false;
                    txtDescuento.Enabled = false;
                    btnAplicar.Enabled = false;
                    btnQuitar.Enabled = false;
                }
            }
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmacion
            DialogResult result = MessageBox.Show("¿Está seguro de generar la factura?", "FACTURA", MessageBoxButtons.YesNo);
            //si confirma la eliminacion, entonces:
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("FACTURA "+lblNumFactura.Text+" generada satisfactoriamente. ", "FACTURA", MessageBoxButtons.OK);
                //incrementa el numero de factura y lo imprime en la factura
                numeroFactura++;
                lblNumFactura.Text = "N° 001 - " + Convert.ToString(numeroFactura);
                //Habilita la seleccion del cliente para la factura
                txtRUCCompra.Enabled = true;
                btnBuscarRUC.Enabled = true;
                //Deshabilita la seccion para agregar productos, la seccion de promociones y las opciones de terminar o reiniciar factura
                btnReiniciar.Enabled = false;
                btnTerminar.Enabled = false;
                txtCodCompra.Enabled = false;
                txtNomCompra.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtCantCompra.Enabled = false;
                btnEliminarCompra.Enabled = false;
                btnAgregarCompra.Enabled = false;
                btnLimpiarCompra.Enabled = false;
                txtRUCFact.Clear();
                txtClienteFact.Clear();
                txtDireccionFact.Clear();
                txtSubtotal.Clear();
                txtIGV.Clear();
                txtTotal.Clear();
                dgvArticulosFact.Rows.Clear();
                importes.Clear();
                nombres.Clear();
                descuentos.Clear();
                btnReiniciar.Enabled = false;
                btnTerminar.Enabled = false;
                txtDescuento.Enabled = false;
                btnAplicar.Enabled = false;
                btnQuitar.Enabled = false;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string nomBusqueda;
            int indice = 0;
            double descuento,valorneto,sumaimportes=0,igv;
            //validacion de campos incompletos
            if (txtDescuento.Text == "")
            {
                MessageBox.Show("Debe ingresar un número para aplicar el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //almacena el descuentro ingresado en una variable temporal
                descuento = Convert.ToDouble(txtDescuento.Text);
                //extrae la descripcion y el importe de la factura del articulo seleccionado
                nomBusqueda = Convert.ToString(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[1].Value);
                valorneto = Convert.ToDouble(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[4].Value);
                //Vacia los valores de subtotal,igv y total
                txtSubtotal.Clear();
                txtIGV.Clear();
                txtTotal.Clear();
                //si el descuento no es vacio, entonces: 
                if (dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value.Equals("-")==false)
                {
                    MessageBox.Show("Este producto ya tiene descuento. ", "DESCUENTO", MessageBoxButtons.OK);

                }
                //si el descuento es vacio, entonces: 
                else
                {
                    //for para buscar la coincidencia del nombre del articulo seleccionado con las descripciones de la factura
                    foreach (var descripcion in nombres)
                    {
                        if (descripcion.Equals(nomBusqueda))
                        {
                            //si encuentra la coincidencia, entonces el importe del articulo seleccionado se le restará el porcentaje de descuento
                            valorneto = valorneto - (valorneto * descuento / 100);
                            importes[indice] = valorneto;
                            //se cambiará el importe del articulo de la factura por el nuevo importe con el descuento
                            //y se ingresara el descuento que se hizo en el DataGridView
                            dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[4].Value = valorneto;
                            dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value = txtDescuento.Text;
                        }
                        indice++;
                    }
                }
                //se sumaran todos los importes de la factura para calular el subtotal,igv y total, que se redondearán a dos decimales
                foreach (var precios in importes)
                {
                    sumaimportes += Convert.ToDouble(precios);
                }
                sumaimportes = Math.Round(sumaimportes, 2);
                txtSubtotal.Text = Convert.ToString(sumaimportes);
                igv = Math.Round(sumaimportes * 0.18, 2);
                txtIGV.Text = Convert.ToString(igv);
                txtTotal.Text = Convert.ToString(igv + sumaimportes);
                txtDescuento.Clear();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            double nuevImporte,sumaimportes=0,igv;
            int indice=0;
            //extrae la descripcion de la factura del articulo seleccionado
            string nomBusqueda =Convert.ToString( dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[1].Value);
            //si el descuento del articulo seleccionado es vacio, entonces:
            if (dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value.Equals("-") == true)
            {
                MessageBox.Show("Este producto no tiene descuento. ", "DESCUENTO", MessageBoxButtons.OK);
            }
            //si el descuento del articulo seleccionado no es vacio, entonces:
            else
            {
                //for para buscar la coincidencia del nombre del articulo seleccionado con las descripciones de la factura
                foreach (var descripcion in nombres)
                {
                    if (descripcion.Equals(nomBusqueda))
                    {
                        //se calcula un nuevo importe, siendo el precio unitario por la cantidad de articulos
                        nuevImporte = Convert.ToDouble(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[0].Value) * Convert.ToDouble(dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[2].Value);
                        //descuento de vuelve vacio
                        descuentos[indice] = "-";
                        //se cambia el valor del importe del arrayList
                        importes[indice] = nuevImporte;
                        //se cambian los valores del importe y descuento del articulo en la factura
                        dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[4].Value = nuevImporte;
                        dgvArticulosFact.Rows[dgvArticulosFact.CurrentRow.Index].Cells[3].Value = "-";
                    }
                    indice++;
                }
                //se sumaran todos los importes de la factura para calular el subtotal,igv y total, que se redondearán a dos decimales
                foreach (var precios in importes)
                {
                    sumaimportes += Convert.ToDouble(precios);
                }
                sumaimportes = Math.Round(sumaimportes, 2);
                txtSubtotal.Text = Convert.ToString(sumaimportes);
                igv = Math.Round(sumaimportes * 0.18, 2);
                txtIGV.Text = Convert.ToString(igv);
                txtTotal.Text = Convert.ToString(igv + sumaimportes);
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            // Mensaje de confirmacion
            DialogResult result = MessageBox.Show("¿Está seguro de volver a empezar la factura?", "FACTURA", MessageBoxButtons.YesNo);
            //si confirma el reinicio, entonces:
            if (result == DialogResult.Yes)
            {
                //el numero de factura no cambia
                lblNumFactura.Text = "N° 001 - " + Convert.ToString(numeroFactura);
                //Habilita la seleccion del cliente para la factura
                txtRUCCompra.Enabled = true;
                btnBuscarRUC.Enabled = true;
                //Deshabilita la seccion para agregar productos, la seccion de promociones y las opciones de terminar o reiniciar factura
                btnReiniciar.Enabled = false;
                btnTerminar.Enabled = false;
                txtCodCompra.Enabled = false;
                txtNomCompra.Enabled = false;
                txtPrecioCompra.Enabled = false;
                txtCantCompra.Enabled = false;
                btnEliminarCompra.Enabled = false;
                btnAgregarCompra.Enabled = false;
                btnLimpiarCompra.Enabled = false;
                txtRUCFact.Clear();
                txtClienteFact.Clear();
                txtDireccionFact.Clear();
                txtSubtotal.Clear();
                txtIGV.Clear();
                txtTotal.Clear();
                dgvArticulosFact.Rows.Clear();
                importes.Clear();
                nombres.Clear();
                descuentos.Clear();
                btnReiniciar.Enabled = false;
                btnTerminar.Enabled = false;
                txtDescuento.Enabled = false;
                btnAplicar.Enabled = false;
                btnQuitar.Enabled = false;

            }
        }

        private void dgvArticulosFact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIGV_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarCompra_Click(object sender, EventArgs e)
        {
            //Se vacian los valores en la seccion de agregar productos para la factura
            txtCodCompra.Clear();
            txtNomCompra.Clear();
            txtPrecioCompra.Clear(); 
            txtCantCompra.Text = "1";
            pbArtCompra.Image = null;
        }

        private void btnBuscarArt_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //se instancia getImage para la ventana de seleccion
            OpenFileDialog getImage = new OpenFileDialog();
            //Se inicializa la ruta en el disco D
            getImage.InitialDirectory = "D:\\";
            //Se aceptarán siguientes extensiones para la imagen:
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";
            //si se seleccionó una imagen
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                //se llena el picturebox y se almancena la ruta
                pbImagenArt.ImageLocation = getImage.FileName;
                ruta = getImage.FileName;
                btnAgregarArticulo.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se seleccionó una imegen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
