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
    public partial class Form1 : Form
    {
        private bool state;
        private int bp_counter, wp_counter;
        MainMenu menu;
        bool gameOver;
        public Form1(MainMenu tmp)
        {
            InitializeComponent();

            state = false;
            bp_counter = 0;
            wp_counter = 0;
            menu = tmp;
        }
        public void receive()
        {
            state = playing1.send_state();
            bp_counter = playing1.send_bp_num();
            wp_counter=playing1.send_wp_num();
            gameOver = playing1.game_over();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            menu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            receive();
            if (gameOver)
            {
                this.timer1.Stop();
            }

            label3.Text = Convert.ToString(wp_counter);
            label4.Text = Convert.ToString(bp_counter);

            if (state)
            {
                label1.Location = new System.Drawing.Point(853, 310);
                label2.Location = new System.Drawing.Point(853, 412);
                
            }
            else
            {
                label2.Location = new System.Drawing.Point(853, 310);
                label1.Location = new System.Drawing.Point(853, 412);
            }
            
        }
    }
}
