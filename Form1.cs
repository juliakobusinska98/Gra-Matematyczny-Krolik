using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                        if (p2 == marchewka1 || p2 == marchewka2 || p2 == marchewka3 || p2 == marchewka4 || p2 == marchewka5 || p2 == marchewka6 || p2 == marchewka7 || p2 == marchewka8 || p2 == marchewka9 || p2 == marchewka10)
                        {
                            ilosc_marchewek++; 
                        }
                        else if (p2 == marchewki1 || p2 == marchewki2 || p2 == marchewki3 || p2 == marchewki4 || p2 == marchewki5 || p2 == marchewki6 || p2 == marchewki7 || p2 == marchewki8 || p2 == marchewki9 || p2 == marchewki10 || p2 == marchewki11 || p2 == marchewki12 || p2 == marchewki13 || p2 == marchewki14 || p2 == marchewki15 || p2==marchewki16 || p2==marchewki17 || p2==marchewki18 )
                        {
                            ilosc_marchewek = ilosc_marchewek + 5;
                         
                        }
                        else if (p2==ciastko1 || p2==ciastko2 || p2==ciastko3 ||p2==ciastko4)
                        {
                            punkty--;
                        }
                        label_punkty.Text = "Punkty:  " + Convert.ToString(punkty);
                        label_ilosc_marchewek.Text = "Dotychczas zebrane marchewki:  " + ilosc_marchewek;
                       
                    }
                }
             
              
            }
            bool strzalki(PictureBox p)
            {
                if (keyData == Keys.Up)
                { 
                    if (p1.Y > 0)
                    {
                        krolik.Location = new Point(p1.X, p1.Y - 20);
                        Czy_dotyka(p);
                    }
                    return true;
                }
                if (keyData == Keys.Down)
                {
                    if (p1.Y < 670)
                    {
                        krolik.Location = new Point(p1.X, p1.Y + 20);
                        Czy_dotyka(p);
                        
                    }
                    return true;
                }
                if (keyData == Keys.Left)
                {
                    if (p1.X > 0)
                    {
                        krolik.Location = new Point(p1.X - 20, p1.Y);
                        Czy_dotyka(p);
                        
                    }
                    return true;
                }
                if (keyData == Keys.Right)
                {
                    if (p1.X < 780)
                    {
                        krolik.Location = new Point(p1.X + 20, p1.Y);
                        Czy_dotyka(p);
                        
                    }
                    return true;
                    
                }
                return true;
            }
            strzalki(marchewka1);
            strzalki(marchewka2);
            strzalki(marchewka3);
            strzalki(marchewka4);
            strzalki(marchewka5);
            strzalki(marchewka6);
            strzalki(marchewka7);
            strzalki(marchewka8);
            strzalki(marchewka9);
            strzalki(marchewka10);
            strzalki(marchewki1);
            strzalki(marchewki2);
            strzalki(marchewki3);
            strzalki(marchewki4);
            strzalki(marchewki5);
            strzalki(marchewki6);
            strzalki(marchewki7);
            strzalki(marchewki8);
            strzalki(marchewki9);
            strzalki(marchewki10);
            strzalki(marchewki11);
            strzalki(marchewki12);
            strzalki(marchewki13);
            strzalki(marchewki14);
            strzalki(marchewki15);
            strzalki(marchewki16);
            strzalki(marchewki17);
            strzalki(marchewki18);
            strzalki(ciastko1);
            strzalki(ciastko2);
            strzalki(ciastko3);
            strzalki(ciastko4);
            return base.ProcessCmdKey(ref msg, keyData);
        }


     }
    }

