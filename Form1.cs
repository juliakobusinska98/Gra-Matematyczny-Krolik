using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematyczny_Krolik
{
    public partial class Form1 : Form
    {
        public int punkty = 0;
        public int cyfra1 = 0;
        public int cyfra2 = 0;
        public Class1 obiekt;
        public int ilosc_marchewek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void zatwierdz_MouseClick(object sender, MouseEventArgs e)
        {
            punkty++;
            label_punkty.Text = "Punkty:  " + Convert.ToString(punkty);
            obiekt = new Matematyczny_Krolik.Class1(cyfra1, cyfra2);

            obiekt.Losowanie();
            if (obiekt.x + obiekt.y <= 100)
            { label_dzialanie.Text = Convert.ToString(obiekt.x) + "  +  " + Convert.ToString(obiekt.y); }
            else
            {
                if (obiekt.x > obiekt.y)
                {
                    label_dzialanie.Text = Convert.ToString(obiekt.x) + "  -  " + Convert.ToString(obiekt.y);
                }
                else
                {
                    label_dzialanie.Text = Convert.ToString(obiekt.x) + "  -  " + Convert.ToString(obiekt.y);
                }
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Point p1 = new Point();
            p1 = krolik.Location;
            krolik.Location = p1;
            void Czy_dotyka(PictureBox p2)
            {

                if (krolik.Bounds.IntersectsWith(p2.Bounds))
                {
                    if (p2.Visible == true)
                    {
                        p2.Visible = false;
                        krolik.Image = System.Drawing.Image.FromFile(@"C:\Users\Julia\Desktop\orig.gif");

                        ilosc_marchewek++; 
                        label_ilosc_marchewek.Text = "Dotychczas zebrane marchewki:  " + ilosc_marchewek;
                    }
                }
            }
            if (keyData == Keys.Up)
            {
                if (p1.Y > 0)
                {
                    krolik.Location = new Point(p1.X, p1.Y - 20);
                    Czy_dotyka(marchewka1);
                }
                return true;
            }
            if (keyData == Keys.Down)
            {
                if (p1.Y < 670)
                {
                    krolik.Location = new Point(p1.X, p1.Y + 20);
                    krolik.Image = Image.FromFile(@"C:\Users\Julia\Desktop\krol.gif");
                    Czy_dotyka(marchewka1);
                }
                return true;
            }
            if (keyData == Keys.Left)
            {
                if (p1.X > 0)
                {
                    krolik.Location = new Point(p1.X - 20, p1.Y);
                    krolik.Image = Image.FromFile(@"C:\Users\Julia\Desktop\krol.gif");
                    Czy_dotyka(marchewka1);
                }
                return true;
            }
            if (keyData == Keys.Right)
            {
                if (p1.X < 780)
                {
                    krolik.Location = new Point(p1.X + 20, p1.Y);
                    krolik.Image = Image.FromFile(@"C:\Users\Julia\Desktop\krol.gif");
                    Czy_dotyka(marchewka1);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);



        }
    }
}
