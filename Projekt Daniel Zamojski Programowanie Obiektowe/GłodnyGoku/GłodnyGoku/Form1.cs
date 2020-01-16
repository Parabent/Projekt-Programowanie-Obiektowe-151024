using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GłodnyGoku.Klasy;

using System.Windows.Forms;

namespace GłodnyGoku
{
    public partial class Form1 : Form
    {
        
        bool left;
        bool right;
        int level = Dane.level;
        int score = 0;
        int hp;
        string poziomtrud = Dane.nazwa;
        int ile = 0;
        Image lewy;
        Image prawy;
        Random rndX = new Random();
        Random bean = new Random();
        int czyfasolka;
        PictureBox sensu = new PictureBox();
        PictureBox food1 = new PictureBox();
        PictureBox food2 = new PictureBox();
        PictureBox worm = new PictureBox();
        PictureBox syringe = new PictureBox();
        string nazwapostaci;
        string nazwapostaci1;

        public Form1()
        {
            InitializeComponent();
            koniecgry();
            Constructor();
            
        }
        private void Constructor()
        {
            gameTimer.Enabled = false;
            if(Dane.wyborpostaci==3)
            {
                hp = 3;
            }
            else
            {
                hp = 5;
            }
            
            level = Dane.level;
            poziomtrud = Dane.nazwa;
            if (Dane.wyborpostaci == 1)
            {
                this.character.Image = Properties.Resources.goku4;
                character.Height = 45;
                character.Width = 45;
                lewy = Properties.Resources.goku4;
                prawy = Properties.Resources.goku2;
                nazwapostaci = "Goku";
                nazwapostaci1 = "Goku";
            }
            if (Dane.wyborpostaci==2)
            {
                this.character.Image = Properties.Resources.vegetamalyL;
                character.Height = 35;
                character.Width = 35;
                lewy = Properties.Resources.vegetamalyL;
                prawy = Properties.Resources.vegetamalyP;
                nazwapostaci = "Vegety";
                nazwapostaci1 = "Vegeta";
            }
            if (Dane.wyborpostaci == 3)
            {
                this.character.Image = Properties.Resources.gohanmaly1L;
                character.Height = 30;
                character.Width = 30;
                lewy = Properties.Resources.gohanmaly1L;
                prawy = Properties.Resources.gohanmaly1P;
                nazwapostaci = "Gohana";
                nazwapostaci1 = "Gohan";
            }
            food1.SizeMode = PictureBoxSizeMode.StretchImage;
            food1.Image = Properties.Resources.ramen2;
            food1.Location = new Point(rndX.Next(15, this.ClientSize.Width - food1.Width), 0);
            food1.Height = 30;
            food1.Width = 30;
            food1.BackColor = System.Drawing.Color.Transparent;
            food1.Tag = "GoodFood";
            this.Controls.Add(food1);

            food2.SizeMode = PictureBoxSizeMode.StretchImage;
            food2.Image = Properties.Resources.frytki;
            food2.Location = new Point(rndX.Next(15, this.ClientSize.Width - food1.Width), 0);
            food2.Height = 20;
            food2.Width = 20;
            food2.BackColor = System.Drawing.Color.Transparent;
            food2.Tag = "GoodFood";
            this.Controls.Add(food2);

            worm.SizeMode = PictureBoxSizeMode.StretchImage;
            worm.Image = Properties.Resources.worm;
            worm.Location = new Point(rndX.Next(15, this.ClientSize.Width - food1.Width), 0);
            worm.Height = 25;
            worm.Width = 25;
            worm.BackColor = System.Drawing.Color.Transparent;
            worm.Tag = "Worm";
            this.Controls.Add(worm);


            syringe.SizeMode = PictureBoxSizeMode.StretchImage;
            syringe.Image = Properties.Resources.strzykawka1;
            syringe.Location = new Point(rndX.Next(15, this.ClientSize.Width - food1.Width), 0);
            syringe.Height = 20;
            syringe.Width = 20;
            syringe.BackColor = System.Drawing.Color.Transparent;
            syringe.Tag = "Syringe";
            this.Controls.Add(syringe);



        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gameTimer.Enabled = true;
                label3.Hide();
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
          
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                EkranStartowy f2 = new EkranStartowy();
                f2.ShowDialog();
                this.Close();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            {
                label1.Text = "Punkty" + score;        
                label2.Text = "Zdrowie" + hp;
                label4.Text = "Szybkość" + level;
                if (left == true && character.Left > 0)
                {
                    character.Left -= 13;
                    character.Image = lewy;


                }
                if (right == true && character.Left + character.Width < this.ClientSize.Width)
                {
                    character.Left += 13;
                    character.Image = prawy;

                }

                czyfasolka = bean.Next(10000);
                if (czyfasolka <= 5 && ile==0)
                {
                    sensu.SizeMode = PictureBoxSizeMode.StretchImage;
                    sensu.Image = Properties.Resources.senzu1;
                    sensu.Location = new Point(rndX.Next(15,this.ClientSize.Width-food1.Width), 0);
                    sensu.Height = 40;
                    sensu.Width = 40;
                    sensu.BackColor = System.Drawing.Color.Transparent;
                    sensu.Tag = "sensu";
                    ile = 1;
                    this.Controls.Add(sensu);
                    
                }
                
                foreach (Control X in this.Controls)
                {
                  
                    if (X is PictureBox && X.Tag == "Syringe")
                    {
                        X.Top += level;
                        if (X.Top + X.Height > this.ClientSize.Height)
                        {

                            resetpozycji(X);

                        }
                        if (X.Bounds.IntersectsWith(character.Bounds))
                        {
                            resetpozycji(X);

                            if (Dane.wyborpostaci == 1)
                            {
                                character.Image = Properties.Resources.gokudmg;
                                hp--;
                            }
                            
                        }
                    }
                    if(X is PictureBox && X.Tag == "sensu")
                    {
                        X.Top += level;
                        if (X.Bounds.IntersectsWith(character.Bounds))
                        {
                            if(Dane.wyborpostaci==3)
                            {
                                hp = 3;
                            }
                            else
                            {
                                hp = 5;
                            }
                            
                            X.Top = -1000;
                            
                            ile = 0;
                        }
                        if (X.Top + X.Height > this.ClientSize.Height)
                        {

                            X.Top = -100;
                            ile = 0;

                        }
                        
                    }
                    if(X is PictureBox && X.Tag == "Worm")
                    {
                        X.Top += level;
                        if (X.Top + X.Height > this.ClientSize.Height)
                        {

                            resetpozycji(X);

                        }
                        if (X.Bounds.IntersectsWith(character.Bounds))
                        {
                            resetpozycji(X);

                            if (Dane.wyborpostaci == 2)
                            {
                                character.Image = Properties.Resources.vegetadmg;
                                hp--;
                            }

                        }
                    }
                    if (X is PictureBox && X.Tag == "GoodFood")
                    {
                        X.Top += level;

                        if (X.Top + X.Height > this.ClientSize.Height)
                        {

                            resetpozycji(X);
                            if (Dane.wyborpostaci == 1)
                            {
                                character.Image = Properties.Resources.gokudmg;
                                hp--;
                            }
                            if (Dane.wyborpostaci == 2)
                            {
                                character.Image = Properties.Resources.vegetadmg;
                                hp--;
                            }
                            if (Dane.wyborpostaci == 3)
                            {
                                character.Image = Properties.Resources.gohandmg;
                                hp--;
                            }
                        }
                            if (X.Bounds.IntersectsWith(character.Bounds))
                        {
                            resetpozycji(X);
                            if (poziomtrud == "Łatwy")
                            {
                                score++;
                            }
                            if (poziomtrud == "Średni")
                            {
                                score = score + 2;
                            }
                            if (poziomtrud == "Trudny")
                            {
                                score = score + 3;
                            }
                            
                        }
                        if (score >= 20)
                        {
                            if(poziomtrud == "Łatwy")
                            {
                                level = 8;
                            }
                            if (poziomtrud == "Średni")
                            {
                                level = 10;
                            }
                            if (poziomtrud == "Trudny")
                            {
                                level = 12;
                            }
                        }
                        if (hp == 0)
                        {
                            gameTimer.Stop();
                            if(score<15)
                            {
                                MessageBox.Show("Niestety, nie udało ci się nakarmić " + nazwapostaci + " Spróbuj jeszcze raz");
                            }
                            if(score>=15 && score <40)
                            {
                                MessageBox.Show("Nie było źle, ale na pewno możesz się jeszcze bardziej postarać");
                            }
                            if(score>=40)
                            {
                                MessageBox.Show("Dobra robota! " + nazwapostaci1 + " został nakarmiony, ale tylko na chwilę. Wróć niebawem.");
                            }
                            

                            koniecgry();
                        }


                    }
                }
            }
        }
        private void koniecgry()
        {
            gameTimer.Enabled = false;
            label3.Show();

            foreach (Control X in this.Controls)
            {
                if (X is PictureBox && (X.Tag == "GoodFood" ^ X.Tag == "Syringe" ^ X.Tag == "Worm" ^ X.Tag == "sensu"))
                {
                    X.Top = -50;
                    X.Left = rndX.Next(15, this.ClientSize.Width - X.Width);

                }
            }
            character.Left = this.ClientSize.Width / 2;
            character.Image = lewy;
            score = 0;
            if (Dane.wyborpostaci == 3)
            {
                hp = 3;
            }
            else
            {
                hp = 5;
            }
            level = Dane.level;
            left = false;
            right = false;
            score = 0;

        }
        private void resetpozycji(Control X)
        {
            X.Top = 1;
            X.Left = rndX.Next(15, this.ClientSize.Width - X.Width);
        }

       
    }
}
