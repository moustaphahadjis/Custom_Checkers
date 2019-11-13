using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComplexCheckers
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.Show();
            
            this.Hide();
        }
        public MainMenu fermer()
        {
            return this;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
