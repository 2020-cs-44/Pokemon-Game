using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Game
{
    public partial class Round : Form
    {
        public Round()
        {
            InitializeComponent();
        }

        private void Round1_Click(object sender, EventArgs e)
        {
            var newForm = new Play();
            newForm.Show();
        }

        private void Round2_Click(object sender, EventArgs e)
        {
            var newForm = new Play1();
            newForm.Show();
        }

        private void Round3_Click(object sender, EventArgs e)
        {
            var newForm = new Play2();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
