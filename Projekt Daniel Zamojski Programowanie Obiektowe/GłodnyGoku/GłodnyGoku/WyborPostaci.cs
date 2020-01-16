using System;
using GłodnyGoku.Klasy;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GłodnyGoku
{
    public partial class WyborPostaci : Form
    {
        public WyborPostaci()
        {
            InitializeComponent();
        }

        private void ButtonGoku_Click(object sender, EventArgs e)
        {
            Dane.wyborpostaci = 1;
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
            
        }

        private void ButtonVegeta_Click(object sender, EventArgs e)
        {
            Dane.wyborpostaci = 2;
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
            
        }

        private void ButtonGohan_Click(object sender, EventArgs e)
        {
            Dane.wyborpostaci = 3;
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
            
        }
    }
}
