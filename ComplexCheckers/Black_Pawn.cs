using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComplexCheckers
{
    public class Black_Pawn
    {
        public bool on_target;
        public PictureBox Pawn;
        public Black_Pawn next;
        public bool crown;

        public Black_Pawn()
        {
            on_target = false;
        }
    }
}
