using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing.Drawing2D;


namespace Paint_Project
{
    public partial class Form1 : Form
    {
        int? prevX = null;
        int? prevY = null;
        int x, y, ty , tx ;
        bool zografizo = false;
        leitourgia tora;
        bool allaxe = false;
        Image xioni = Image.FromFile("imgress.png");

        public Form1()
        {
            InitializeComponent();
        }
        public enum leitourgia // ti mporoume na sxediasoume kathws kai leitourgies
        {
            grammi , tetragono , kuklos ,  bourtsa , molivi , goma , katharismos , snowflake
         }
      

        private void Form1_Load(object sender, EventArgs e)// arxikopoiw to xroma kai to megethos  twn ergaliwn, to background,ton kersora
        {
            pictureBox1.BackColor = Color.Turquoise;
            pictureBox2.BackColor = Color.Black;
            pictureBox3.BackColor = Color.White;
            toolStripTextBox1.Text = "1";
            this.Cursor = Cursors.Hand;
            button10.BackgroundImage = Image.FromFile("imgress.png");
            toolStripTextBox2.Text = "50";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) 
        {
      
            zografizo = true;
            x = e.X;
            y = e.Y;


            //delete

            if (zografizo)
            {
                Graphics g = pictureBox1.CreateGraphics();
                switch (tora)
                {
                    case leitourgia.tetragono:
                        g.FillRectangle(new SolidBrush(pictureBox2.BackColor), x, y, e.X - x, e.Y - y);
                        break;
                    case leitourgia.kuklos:
                        g.FillEllipse(new SolidBrush(pictureBox2.BackColor), x, y, e.X - x, e.Y - y);
                        break;
                    case leitourgia.bourtsa:
                        g.FillEllipse(new SolidBrush(pictureBox2.BackColor), e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                        break;
                    case leitourgia.molivi:
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        Pen molivi = new Pen(pictureBox2.BackColor, float.Parse(toolStripTextBox1.Text));
                        g.DrawLine(molivi, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                        prevX = e.X;
                        prevY = e.Y;
                        break;
                    case leitourgia.goma:
                        g.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                        break;
                    case leitourgia.snowflake:
                        g.DrawImage(xioni, x, y, Convert.ToInt32(toolStripTextBox2.Text), Convert.ToInt32(toolStripTextBox2.Text));
                        break;


                }
                g.Dispose();

            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) 
        {
            zografizo = false;
            tx = e.X;
            ty = e.Y;
            prevX = null;
            prevY = null;

            if (tora == leitourgia.grammi) //  eu8ugrammo tmhma
            {
                Graphics g = pictureBox1.CreateGraphics();
                g.DrawLine(new Pen(new SolidBrush(pictureBox2.BackColor)), new Point(x, y), new Point(tx, ty));
                g.Dispose();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //  leitourgies otan eimai panw sth forma
        {
            
            if (zografizo)
            {
                Graphics g = pictureBox1.CreateGraphics();
                switch (tora)
                { 
                    case leitourgia.tetragono:
                        g.FillRectangle(new SolidBrush(pictureBox2.BackColor), x, y, e.X - x, e.Y - y);     
                        break;
                    case leitourgia.kuklos:
                        g.FillEllipse(new SolidBrush(pictureBox2.BackColor), x, y, e.X - x,e.Y- y);
                        break;
                    case leitourgia.bourtsa:
                        g.FillEllipse(new SolidBrush(pictureBox2.BackColor), e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                        break;
                    case leitourgia.molivi:
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        Pen molivi = new Pen(pictureBox2.BackColor, float.Parse(toolStripTextBox1.Text));
                        g.DrawLine(molivi, new Point(prevX ?? e.X , prevY ?? e.Y), new Point(e.X, e.Y));
                        prevX = e.X;
                        prevY = e.Y;
                        break;
                    case leitourgia.goma:
                        g.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, Convert.ToInt32(toolStripTextBox1.Text), Convert.ToInt32(toolStripTextBox1.Text));
                        break;
                    case leitourgia.snowflake:
                        g.DrawImage(xioni, x, y , Convert.ToInt32(toolStripTextBox2.Text), Convert.ToInt32(toolStripTextBox2.Text));
                        break;
                   

                }
                g.Dispose();
              
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // epilego leitourgia eu8ugrammou tmhmatos
        {
            tora = leitourgia.grammi;
        }

        private void button2_Click(object sender, EventArgs e) // epilego dhmiourgia tetragonou 
        {
            tora = leitourgia.tetragono;
        }

        private void button3_Click(object sender, EventArgs e) // epiloego dhmiourgia elleipshs
        {
            tora = leitourgia.kuklos;
        }

        private void button4_Click(object sender, EventArgs e) // epilego xrhsh vourtsas
        {
            tora = leitourgia.bourtsa;
           
        }

        private void button5_Click(object sender, EventArgs e) //  epilego xrhsi moluviou  
        {
            tora = leitourgia.molivi;
        }

        private void button6_Click(object sender, EventArgs e) //  xrisi gomas
        {
            tora = leitourgia.goma;
        }

        private void button7_Click(object sender, EventArgs e) // epilego xroma tou ergaliou opou xrhsimopoiw , einai arxikopoihmeno mayro
        {
            ColorDialog xroma = new ColorDialog();
            if (xroma.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.BackColor = xroma.Color;
              
            }
        }

        private void button8_Click(object sender, EventArgs e) // epilego background xroma , einai arxikopoihmeno aspro
        {
            ColorDialog xroma = new ColorDialog();
            if (xroma.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.BackColor = xroma.Color;
                pictureBox1.BackColor = xroma.Color;

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e) // kanei clear 
        {
            tora = leitourgia.katharismos;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            g.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tora = leitourgia.snowflake;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) //allazei kersora otan mpainw sth forma
        {
            allaxe = true;
            if (allaxe)
            {
                this.Cursor = Cursors.Cross;
            }

        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) // allazei otan vgainw apo th forma
        {
            this.Cursor = Cursors.Hand;
            allaxe = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
         //  Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);//to create bmp of same size as panel
          //  Rectangle rect = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height); //to set bounds to image
          //  pictureBox1.DrawToBitmap(bmp, rect);      // drawing panel1 imgae into bmp of bounds of rect
         //   bmp.Save("C:\\Users\\Dahakashow\\Desktop\\a.png", System.Drawing.Imaging.ImageFormat.Png); //save location and type

           // pictureBox1.Image.Save("C:\\Users\\Dahakashow\\Desktop\\aa", ImageFormat.Jpeg);

            using (SaveFileDialog sfdlg = new SaveFileDialog())
            {
                sfdlg.Title = "Save Dialog";
                sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
                if (sfdlg.ShowDialog(this) == DialogResult.OK)
                {
                    using (Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height))
                    {
                        pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image.Save("C:\\Users\\Dahakashow\\Desktop\\asds.Jpg");
                        bmp.Save(sfdlg.FileName);
                        MessageBox.Show("Saved Successfully.....");

                    }
                }
            }
        }

       
    }
}
