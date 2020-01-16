using System;
using GłodnyGoku.Klasy;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace GłodnyGoku
{
    public partial class EkranStartowy : Form
    {
        int licznik=1;
        private SoundPlayer music;
        
        public EkranStartowy()
        {
            InitializeComponent();
            music = new SoundPlayer("Stickerbush Symphony.wav");
            music.PlayLooping();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Dane.level = 5;
                Dane.nazwa = "Łatwy";
                
            }
            if(checkBox2.Checked)
            {
                Dane.level = 7;
                Dane.nazwa = "Średni";
            }
            if(checkBox3.Checked)
            {
                Dane.level = 10;
                Dane.nazwa = "Trudny";

            }
            if(checkBox1.Checked == true && checkBox2.Checked == true)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jeden poziom trudności!");
                
                return;


            }
            if (checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jeden poziom trudności!");
               
                return;


            }
            if (checkBox1.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jeden poziom trudności!");
                
                return;


            }
            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jeden poziom trudności!");
                
                return;


            }
            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Proszę zaznaczyć poziom trudności!");

                return;


            }

            this.Hide();
            WyborPostaci f1 = new WyborPostaci();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel Zamojski");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pomoz Goku , Vegecie i Gohanowi z ich potężnym głodem. Spróbuj zjeść jak najwiecej. Pamietaj, że Goku boi sie strzykawek, a Vegeta robaków !");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(licznik == 0)
            {
                button5.Text = "Muzyka: Stickerbush Symphony";
                music = new SoundPlayer("Stickerbush Symphony.wav");
                music.PlayLooping();
                licznik=1;
            }
           else if(licznik == 1)
            {
                button5.Text = "Muzyka: Forest Interlude";
                music = new SoundPlayer("Forest Interlude.wav");
                music.PlayLooping();
                licznik=0;
            }
        }
    }
}
