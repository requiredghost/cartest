using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*********************************

    I made this code in 2020, most likely around September or August. This game was made for a assignment I don't remember what exactly what it was but somehow I passed it considering looking at it now as a current software developer. I am surprised how this game works at all considering it's in WinForms.
    Have a good look at this if you want to, it's a whole bunch of nothing really but it's a cool concept to think I actually made a game in WinForms for that matter lol.

**********************************/

namespace car_racing_game_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            overLabel.Visible = false;
            label2.Visible = false;
            pictureBox1.Visible = false;
            pictureBox7.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            car.Visible = false;
            coin1.Visible = false;
            coin2.Visible = false;
            coin3.Visible = false;
            coin4.Visible = false;
            spikes1.Visible = false;
            spikes2.Visible = false;
            spikes3.Visible = false;
            label1.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            enemy(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
        }
        int collectedcoin = 0;

        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (spikes1.Top >= 500)
            {
                x = r.Next(0, 200);

                spikes1.Location = new Point(x, y);
            }

            else { spikes1.Top += speed; }

            if (spikes2.Top >= 500)
            {
                x = r.Next(0, 400);

                spikes2.Location = new Point(x, y);
            }

            else { spikes2.Top += speed; }

            if (spikes3.Top >= 500)
            {
                x = r.Next(200, 350);

                spikes3.Location = new Point(x, y);
            }

            else { spikes3.Top += speed; }
        }

        void coins(int speed)
        {
            if (coin1.Top >= 500)
            {
                x = r.Next(0, 200);

                coin1.Location = new Point(x, y);
            }
            else { coin1.Top += speed; }

            if (coin2.Top >= 500)
            {
                x = r.Next(0, 200);

                coin2.Location = new Point(x, y);
            }
            else { coin2.Top += speed; }

            if (coin3.Top >= 500)
            {
                x = r.Next(0, 200);

                coin3.Location = new Point(x, y);
            }
            else { coin3.Top += speed; }

            if (coin4.Top >= 500)
            {
                x = r.Next(0, 200);

                coin4.Location = new Point(x, y);
            }
            else { coin4.Top += speed; }


        }

        void gameover()
        {
            if (car.Bounds.IntersectsWith(spikes1.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                label2.Visible = true;
            }

            if (car.Bounds.IntersectsWith(spikes2.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                label2.Visible = true;
            }

            if (car.Bounds.IntersectsWith(spikes3.Bounds))
            {
                timer1.Enabled = false;
                overLabel.Visible = true;
                label2.Visible = true;
            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            { pictureBox1.Top = 0; }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            { pictureBox2.Top = 0; }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            { pictureBox3.Top = 0; }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            { pictureBox4.Top = 0; }
            else { pictureBox4.Top += speed; }


            pictureBox7.Top += speed;
            pictureBox2.Top += speed;
            pictureBox3.Top += speed;
            pictureBox4.Top += speed;
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }

        int gamespeed = 0;

        private void overLabel_Click(object sender, EventArgs e)
        {
            label1.Text = "Coins = 0";
            timer1.Enabled = true;
            overLabel.Visible = false;
            if (label2.Visible = false)
            { overLabel.Visible = false; }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label1.Text = "Coins = 0";
            timer1.Enabled = true;
            overLabel.Visible = false;
            label2.Visible = false;
            if (overLabel.Visible = false) ;
            { label2.Visible = false; }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            gametitle.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            pictureBox1.Visible = true;
            pictureBox7.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            car.Visible = true;
            coin1.Visible = true;
            coin2.Visible = true;
            coin3.Visible = true
            coin4.Visible = true;
            spikes1.Visible = true;
            spikes2.Visible = true;
            spikes3.Visible = true;
            label1.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left > 0)
                    car.Left += -20;
            }

            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 380)
                    car.Left += 20;
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                { gamespeed++; }
            }

            if (e.KeyCode == Keys.Down)
                if (gamespeed > 0)
                { gamespeed--; }
        }
        }
    }

