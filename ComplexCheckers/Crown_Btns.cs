using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComplexCheckers
{
    public class Crown_Btns
    {
        public Button Btn;
        

        public Crown_Btns next;

        public Crown_Btns(int x, int y)
        {
            Btn = new Button();
            Btn.BackColor = System.Drawing.Color.Red;
          
           Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
           Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
           Btn.Location = new System.Drawing.Point(x, y);
           Btn.Name = "hhh";
           Btn.Size = new System.Drawing.Size(72, 72);
           Btn.TabIndex = 45;
           Btn.UseVisualStyleBackColor = false;
           Btn.Visible = true;
            
          // Btn.Click += new System.EventHandler(this.button4_Click);

        }
    }
}
