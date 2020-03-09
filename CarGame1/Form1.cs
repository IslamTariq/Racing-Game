using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarGame1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible=false ;            
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemycar(gamespeed);
            gameover();
            coins(gamespeed);

            coinscollection();
        }

        int collectioncoin = 0;

        Random r = new Random();
        int x, y;
        void enemycar(int speed)
        {
            if (enemycar1.Top >= 317)
            {
                x = r.Next(10, 140);
                enemycar1.Location = new Point(x, 0);
            }
            else
            { enemycar1.Top += speed; }

            if (enemycar2.Top >= 317)
            {
                x = r.Next(150, 300);
                enemycar2.Location = new Point(x, 0);
            }
            else
            { enemycar2.Top += speed; }

        }

        void coins(int speed)
        {

            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);

            }
            else
            { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);

            }
            else
            { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);

            }
            else
            { coin3.Top += speed; }
        }
    

    void gameover()
        {
            if (car.Bounds.IntersectsWith(enemycar1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }

            if (car.Bounds.IntersectsWith(enemycar2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }
        }
        void moveline(int speed)

        {
            if (pictureBox1.Top >= 550)
            {
                pictureBox1.Top = 0;
            }
            else
            { pictureBox1.Top += speed; }

            if (pictureBox3.Top >= 550)
            {
                pictureBox3.Top = 0;
            }
            else

            {
                pictureBox3.Top += speed;
            }
            if (pictureBox2.Top >= 550)
            {
                pictureBox2.Top = 0;
            }
            else

            {
                pictureBox2.Top += speed;
            }
            if (pictureBox4.Top >= 550)
            {
                pictureBox4.Top = 0;
            }
            else

            {
                pictureBox4.Top += speed;
            }
           



        }



        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {

                collectioncoin++;

                label1.Text = "Coins=" + collectioncoin.ToString();

                x = r.Next(0, 200);
                coin1.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {

                collectioncoin++;

                label1.Text = "Coins=" + collectioncoin.ToString();

                x = r.Next(0, 200);
                coin2.Location = new Point(x, 0);
            }
            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {

                collectioncoin++;

                label1.Text = "Coins=" + collectioncoin.ToString();
                x = r.Next(0, 200);
                coin3.Location = new Point(x, 0);
            }
        }

            int gamespeed=0;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 5)
                    car.Left += -8;

            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 317)
                    car.Left += 8;

            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                }
            }
        }
    }
}
