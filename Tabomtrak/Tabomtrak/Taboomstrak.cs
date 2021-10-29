using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabomtrak
{
    public partial class Taboomstrak : Form
    {
        public Taboomstrak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 game = new Form1();
            game.Show();
            this.Close();
        }
    }
}
