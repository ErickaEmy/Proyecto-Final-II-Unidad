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
    public partial class MDIPrincipal : Form
    {
        
        public MDIPrincipal()
        {
            InitializeComponent();
            
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio1 Frm1 = new FrmEjercicio1();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio2 Frm1 = new FrmEjercicio2();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio3 Frm1 = new FrmEjercicio3();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio4 Frm1 = new FrmEjercicio4();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio5 Frm1 = new FrmEjercicio5();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio6 Frm1 = new FrmEjercicio6();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio7 Frm1 = new FrmEjercicio7();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio8 Frm1 = new FrmEjercicio8();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio9 Frm1 = new FrmEjercicio9();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjercicio10 Frm10 = new FrmEjercicio10();
            Frm10.MdiParent = this;
            Frm10.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            pnl11.Visible = false;
            FrmEjercicio1 Frm1 = new FrmEjercicio1();
            Frm1.MdiParent = this;
            Frm1.Show();
        }

        private void ejercicio11ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl11.Visible = true;
            cboCantidad.Text = "2";
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            txtJugador1.Enabled = true;
            cboCarro1.Enabled = true;
            cboCarro2.Enabled = true;
            txtJugador2.Enabled = true;
            if (cboCantidad.Text == "3")
            {
                txtJugador3.Enabled = true;
                cboCarro3.Enabled = true;
                lblCarro3.Visible = true;
            }
            else
            {
                txtJugador3.Enabled = false;
                cboCarro3.Enabled = false;
                lblCarro3.Visible = false;
            }
        }

        int carros = 2, sorteo;
        int[] velocidades = { 2, 2, 2 };
        

        private void cboCarro1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarro1.Visible = true;
            if(cboCarro1.Text=="Auto de Carreras"){ lblCarro1.Text = "🏎"; }
            else if (cboCarro1.Text == "Autobús") { lblCarro1.Text = "🚌"; }
            else if (cboCarro1.Text == "Ambulancia") { lblCarro1.Text = "🚑"; }
            else if (cboCarro1.Text == "Auto de Policía") { lblCarro1.Text = "🚓"; }
            else if (cboCarro1.Text == "Camión") { lblCarro1.Text = "🚛"; }
            else if (cboCarro1.Text == "Moto") { lblCarro1.Text = "🏍"; }


        }
        private void cboCarro2_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarro2.Visible = true;
            if (cboCarro2.Text == "Auto de Carreras") { lblCarro2.Text = "🏎"; }
            else if (cboCarro2.Text == "Autobús") { lblCarro2.Text = "🚌"; }
            else if (cboCarro2.Text == "Ambulancia") { lblCarro2.Text = "🚑"; }
            else if (cboCarro2.Text == "Auto de Policía") { lblCarro2.Text = "🚓"; }
            else if (cboCarro2.Text == "Camión") { lblCarro2.Text = "🚛"; }
            else if (cboCarro2.Text == "Moto") { lblCarro2.Text = "🏍"; }
        }

        private void cboCarro3_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCarro3.Visible = true;
            if (cboCarro3.Text == "Auto de Carreras") { lblCarro3.Text = "🏎"; }
            else if (cboCarro3.Text == "Autobús") { lblCarro3.Text = "🚌"; }
            else if (cboCarro3.Text == "Ambulancia") { lblCarro3.Text = "🚑"; }
            else if (cboCarro3.Text == "Auto de Policía") { lblCarro3.Text = "🚓"; }
            else if (cboCarro3.Text == "Camión") { lblCarro3.Text = "🚛"; }
            else if (cboCarro3.Text == "Moto") { lblCarro3.Text = "🏍"; }
        }

        
        

        private void button1_Click(object sender, EventArgs e)
        {
            lblCarro1.Location = new System.Drawing.Point(650, 4);
            lblCarro2.Location = new System.Drawing.Point(650, 57);
            lblCarro3.Location = new System.Drawing.Point(650, 112);
            lblTrofeo1.Visible = false;
            lblTrofeo2.Visible = false;
            lblTrofeo3.Visible = false;
            txtGanador1.Clear();
            txtGanador2.Clear();
            txtGanador3.Clear();
            int llave1 = 0, llave2 = 0;
            if (cboCantidad.Text == "2" && (txtJugador1.Text.Equals("") || txtJugador2.Text.Equals("")))
            {
                MessageBox.Show("Los jugadores no pueden tener nombres vacíos.",
                "DON YOTO´S RACING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(cboCantidad.Text == "3" && txtJugador3.Text == "")
            {
                MessageBox.Show("Los jugadores no pueden tener nombres vacíos.",
                "DON YOTO´S RACING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llave1 = 1;
            }

            if (cboCantidad.Text == "2" && (lblCarro1.Text.Equals("-") || lblCarro2.Text.Equals( "-")))
            {
                MessageBox.Show("Los jugadores deben escoger sus autos.",
                "DON YOTO´S RACING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(cboCantidad.Text=="3" && lblCarro3.Text.Equals("-"))
            {
                MessageBox.Show("Los jugadores deben escoger sus autos.",
                "DON YOTO´S RACING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                llave2 = 1;
            }

            if (cboCantidad.Text == "3")
            {
                carros = 3;
            }
            else
            {
                carros = 2;
            }
            if(llave1==1 && llave2 == 1)
            {
                timer1.Enabled = true;
            }

            if (carros == 3)
            {
                if (cboCarro2.Text == "Auto de Carreras") { sorteo = 1; }
                else if (cboCarro2.Text == "Autobús") { sorteo = 2; }
                else if (cboCarro2.Text == "Ambulancia") { sorteo = 3; }
                else if (cboCarro2.Text == "Auto de Policía") { sorteo = 1; }
                else if (cboCarro2.Text == "Camión") { sorteo = 2; }
                else if (cboCarro2.Text == "Moto") { sorteo=3; }
            }
            else
            {
                if (cboCarro1.Text == "Auto de Carreras") { sorteo = 1; }
                else if (cboCarro1.Text == "Autobús") { sorteo = 2; }
                else if (cboCarro1.Text == "Ambulancia") { sorteo = 1; }
                else if (cboCarro1.Text == "Auto de Policía") { sorteo = 2; }
                else if (cboCarro1.Text == "Camión") { sorteo = 1; }
                else if (cboCarro1.Text == "Moto") { sorteo = 2; }
            }
        }

        private void pnl11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl11.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (lblCarro1.Location.X <= 350)
            {
                if (carros == 2)
                {
                    if (sorteo == 1)
                    {
                        lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 6, 4);
                        lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 10, 57);
                        if (lblCarro1.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo1.Visible = true;
                            txtGanador1.Text = txtJugador1.Text;
                            txtGanador2.Text = txtJugador2.Text;
                        }
                        if (lblCarro2.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo2.Visible = true;
                            txtGanador1.Text = txtJugador2.Text;
                            txtGanador2.Text = txtJugador1.Text;
                        }
                    }
                    else if (sorteo == 2)
                    {
                        lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 10, 4);
                        lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 6, 57);
                        if (lblCarro1.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo1.Visible = true;
                            txtGanador1.Text = txtJugador1.Text;
                            txtGanador2.Text = txtJugador2.Text;
                        }
                        if (lblCarro2.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo2.Visible = true;
                            txtGanador1.Text = txtJugador2.Text;
                            txtGanador2.Text = txtJugador1.Text;
                        }
                    }
                }
                else
                {
                    if (sorteo == 1)
                    {
                        lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 6, 4);
                        lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 10, 57);
                        lblCarro3.Location = new System.Drawing.Point(lblCarro3.Location.X - 15, 112);
                        if (lblCarro1.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo1.Visible = true;
                            txtGanador1.Text = txtJugador3.Text;
                            txtGanador2.Text = txtJugador2.Text;
                            txtGanador3.Text = txtJugador1.Text;
                        }
                        if (lblCarro2.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo2.Visible = true;
                            txtGanador1.Text = txtJugador3.Text;
                            txtGanador2.Text = txtJugador2.Text;
                            txtGanador3.Text = txtJugador1.Text;
                        }
                        if (lblCarro3.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo3.Visible = true;
                            txtGanador1.Text = txtJugador3.Text;
                            txtGanador2.Text = txtJugador2.Text;
                            txtGanador3.Text = txtJugador1.Text;
                        }
                    }
                    else if (sorteo == 2)
                    {
                        lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 15, 4);
                        lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 6, 57);
                        lblCarro3.Location = new System.Drawing.Point(lblCarro3.Location.X - 10, 112);
                        if (lblCarro1.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo3.Visible = true;
                            txtGanador1.Text = txtJugador1.Text;
                            txtGanador2.Text = txtJugador3.Text;
                            txtGanador3.Text = txtJugador2.Text;
                        }
                        if (lblCarro2.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo2.Visible = true;
                        }
                        if (lblCarro3.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo3.Visible = true;
                        }
                    }
                    else if (sorteo == 3)
                    {
                        lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 10, 4);
                        lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 15, 57);
                        lblCarro3.Location = new System.Drawing.Point(lblCarro3.Location.X - 6, 112);
                        if (lblCarro1.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo3.Visible = true;
                        }
                        if (lblCarro2.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo2.Visible = true;
                            txtGanador1.Text = txtJugador2.Text;
                            txtGanador2.Text = txtJugador1.Text;
                            txtGanador3.Text = txtJugador3.Text;
                        }
                        if (lblCarro3.Location.X == 80)
                        {
                            timer1.Enabled = false;
                            lblTrofeo3.Visible = true;
                        }
                    }
                }
            }
            else
            {
                if (carros == 2)
                {
                    lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 5, 4);
                    lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 5, 57);
                }
                else
                {
                    lblCarro1.Location = new System.Drawing.Point(lblCarro1.Location.X - 5, 4);
                    lblCarro2.Location = new System.Drawing.Point(lblCarro2.Location.X - 5, 57);
                    lblCarro3.Location = new System.Drawing.Point(lblCarro3.Location.X - 5, 112);
                }
            }
        }
    }
}
