using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Berke_Mete
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int sayac = 0;
        int flag = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            button1.Visible = false;

            Point pnt1 = new Point();
            Point pnt2 = new Point();

            

            if(sayac==2&&flag==0)
            {
                pictureBox1.Visible = true;
            }
            if (sayac== 4&&flag == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            if (sayac == 6&&flag == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            if (sayac == 8 && flag == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
            }
            if (sayac == 10 && flag == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            if (sayac == 12 && flag == 0)
            {

                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false; 
                pictureBox6.Visible = true;
                
            }

            if(sayac == 14 && flag == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                sayac = 0;
                flag = 1;
                
            }
            pnt1.X = sayac*150;
            pnt1.Y = 10;
            pnt2.X = 1000;
            pnt2.Y = 10;

            pictureBox7.Location = pnt1;
            pictureBox8.Location = pnt2;

            if(pnt1.X > 1000 && flag==1)
            {
                timer1.Stop();
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                
            }

        }

        
    }
}
