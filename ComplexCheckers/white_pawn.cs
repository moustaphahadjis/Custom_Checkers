using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComplexCheckers
{
    class White_Pawn
    {
        public bool on_target;
        public PictureBox Pawn;
        public White_Pawn next;
        public bool crown;

        public White_Pawn()
        {
            on_target = false;
        }
    }
}
