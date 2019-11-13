using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ComplexCheckers
{
    public partial class playing : UserControl
    {
        private White_Pawn wp_head;
        private Black_Pawn bp_head;
        private White_Pawn pawn_selected;
        private Black_Pawn pawn_selected2;

        private Btns btn_head;
        private bool switching;

        private Crown_Btns crown_btn_head;


        public playing()
        {
            InitializeComponent();
            switching = false;
            crown_btn_head = null;
            for (int i = 0; i < 20; i++)
            {
                if (i == 0)
                    wp_create(i, pictureBox1);
                if (i == 1)
                    wp_create(i, pictureBox2);
                if (i == 2)
                    wp_create(i, pictureBox3);
                if (i == 3)
                    wp_create(i, pictureBox4);
                if (i == 4)
                    wp_create(i, pictureBox5);
                if (i == 5)
                    wp_create(i, pictureBox6);
                if (i == 6)
                    wp_create(i, pictureBox7);
                if (i == 7)
                    wp_create(i, pictureBox8);
                if (i == 8)
                    wp_create(i, pictureBox9);
                if (i == 9)
                    wp_create(i, pictureBox10);
                if (i == 10)
                    wp_create(i, pictureBox11);
                if (i == 11)
                    wp_create(i, pictureBox12);
                if (i == 12)
                    wp_create(i, pictureBox13);
                if (i == 13)
                    wp_create(i, pictureBox14);
                if (i == 14)
                    wp_create(i, pictureBox15);
                if (i == 15)
                    wp_create(i, pictureBox16);
                if (i == 16)
                    wp_create(i, pictureBox17);
                if (i == 17)
                    wp_create(i, pictureBox18);
                if (i == 18)
                    wp_create(i, pictureBox19);
                if (i == 19)
                    wp_create(i, pictureBox20);
            }

            for (int i = 0; i < 20; i++)
            {
                if (i == 0)
                    bp_create(i, pictureBox21);
                if (i == 1)
                    bp_create(i, pictureBox22);
                if (i == 2)
                    bp_create(i, pictureBox23);
                if (i == 3)
                    bp_create(i, pictureBox24);
                if (i == 4)
                    bp_create(i, pictureBox25);
                if (i == 5)
                    bp_create(i, pictureBox26);
                if (i == 6)
                    bp_create(i, pictureBox27);
                if (i == 7)
                    bp_create(i, pictureBox28);
                if (i == 8)
                    bp_create(i, pictureBox29);
                if (i == 9)
                    bp_create(i, pictureBox30);
                if (i == 10)
                    bp_create(i, pictureBox31);
                if (i == 11)
                    bp_create(i, pictureBox32);
                if (i == 12)
                    bp_create(i, pictureBox33);
                if (i == 13)
                    bp_create(i, pictureBox34);
                if (i == 14)
                    bp_create(i, pictureBox35);
                if (i == 15)
                    bp_create(i, pictureBox36);
                if (i == 16)
                    bp_create(i, pictureBox37);
                if (i == 17)
                    bp_create(i, pictureBox38);
                if (i == 18)
                    bp_create(i, pictureBox39);
                if (i == 19)
                    bp_create(i, pictureBox40);

            }

            for (int i = 0; i < 4; i++)
            {
                if (i == 0)
                    btn_create(i, button1);
                if (i == 1)
                    btn_create(i, button2);
                if (i == 2)
                    btn_create(i, button3);
                if (i == 3)
                    btn_create(i, button4);
            }
        }
        private void wp_create(int num, PictureBox pawn)
        {
            White_Pawn ptr, tmp;
            tmp = new White_Pawn
            {
                next = null, Pawn = pawn, on_target = false, crown = false
            };
            if (num == 0)
            {
                wp_head = tmp;
            }
            else
            {
                ptr = wp_head;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                
                ptr.next = tmp;
            }
        }
        private void bp_create(int num, PictureBox pawn)
        {
            Black_Pawn ptr, tmp;
            tmp = new Black_Pawn
            {
                next = null, Pawn = pawn, on_target = false, crown = false
            };
            if (num == 0)
            {
                bp_head = tmp;
            }
            else
            {
                ptr = bp_head;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = tmp;
            }

        }
        private void btn_create(int num, Button tmp_btn)
        {
            Btns ptr, tmp;
            tmp = new Btns
            {
                next=null, btn=tmp_btn
            };
            if (num == 0)
                btn_head = tmp;
            else
            {
                ptr = btn_head;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = tmp;
            }
            
        }
       private void Create_crown_btn( int x, int y)
        {
            Crown_Btns ptr, tmp;
            tmp = new Crown_Btns(x,y)
            {
                 next=null
            };
            tmp.Btn.Location = new System.Drawing.Point(x, y);
            if (crown_btn_head == null)
            {
                crown_btn_head = tmp;
            }
            else
            {
                ptr = crown_btn_head;
                while (ptr.next != null)
                {
                    ptr = ptr.next;
                }
                ptr.next = tmp;
            }

        }
        private void free_spot_crown(PictureBox pawn, bool comp)
        {
            int a=0, b=0;
            int[] X=new int[20];
            int[] Y=new int[20];
            int count = 0;
            for (int i = pawn.Location.X; i >= 0; i -= 72)
            {
                X[count] = i;
                count++;
            }
            
            for (int i = pawn.Location.X; i <= 720; i += 72)
            {
                X[count] = i;
                count++;
            }
            count = 0;
            for (int i = pawn.Location.Y; i >= 0; i -= 72)
            {
                Y[count] = i;
                count++;
            }
            
            for (int i = pawn.Location.Y; i <= 720; i += 72)
            {
                Y[count] = i;
                count++;
            }

            while ((X[a]>0 && Y[a]>0))
            {
                Create_crown_btn(X[a], Y[a]);
                a++;  
            }
            Crown_Btns ptr=crown_btn_head;

            for (int i = 0; i < a; i++)
            {
                ptr.Btn.Visible = true;
                ptr.Btn.BackgroundImage = button1.BackgroundImage;
                this.Controls.Add(ptr.Btn);

                ptr = ptr.next;
            }
        }
        private void free_spot(PictureBox pawn, bool comp)
        {
            Btns ptr;
            ptr = btn_head;
           
            for (int i = 0; i < 4; i++)
            {
                ptr.btn.Visible = true;
                if (i == 0)
                {


                    if (switching && comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X - 72, pawn.Location.Y - 72);
                        White_Pawn ptr2 = wp_head;



                        Black_Pawn ptr3;
                        ptr3 = bp_head;
                        
                        for (int j = 0; j < 20; j++)
                        {


                            if (!pawn_selected.crown)
                            {
                                ptr.btn.Visible = false;
                            }
                            else
                            {
                                ptr.btn.Visible = true;
                            }

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target )
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }

                            }



                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location==ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y==648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X==0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr3 = ptr3.next;
                            ptr2 = ptr2.next;
                        }
                    }
                    else if (!switching && !comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X - 72, pawn.Location.Y - 72);
                        Black_Pawn ptr2 = bp_head;

                        White_Pawn ptr3;
                        ptr3 = wp_head;
                        for (int j = 0; j < 20; j++)
                        {
                           


                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }
                                
                            }



                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 0 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr3 = ptr3.next;
                            ptr2 = ptr2.next;
                        }
                    }

                    else
                    {
                        ptr.btn.Visible = false;
                    }

                    }
                if (i == 1)
                {


                    if (switching && comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X + 72, pawn.Location.Y - 72);
                        White_Pawn ptr2 = wp_head;
                        Black_Pawn ptr3;
                        ptr3 = bp_head;
                        for (int j = 0; j < 20; j++)
                        {
                            if (!pawn_selected.crown)
                            {
                                ptr.btn.Visible = false;
                            }
                            else
                            {
                                ptr.btn.Visible = true;
                            }
                            

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }
                                
                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else if (!switching && !comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X + 72, pawn.Location.Y - 72);
                        Black_Pawn ptr2 = bp_head;
                        White_Pawn ptr3;
                        ptr3 = wp_head;
                        for (int j = 0; j < 20; j++)
                        {

                           

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y - 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }

                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 0 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else
                    {
                        ptr.btn.Visible = false;
                    }
                }
                if (i == 2)
                {

                    if (switching && comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X - 72, pawn.Location.Y + 72);
                        White_Pawn ptr2 = wp_head;
                        Black_Pawn ptr3;
                        ptr3 = bp_head;
                        for (int j = 0; j < 20; j++)
                        {


                            
                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }
                                
                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else if (!switching && !comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X - 72, pawn.Location.Y + 72);
                        
                        Black_Pawn ptr2 = bp_head;
                        White_Pawn ptr3;
                        ptr3 = wp_head;
                        for (int j = 0; j < 20; j++)
                        {
                            if (!pawn_selected2.crown)
                            {
                                ptr.btn.Visible = false;
                            }
                            else
                            {
                                ptr.btn.Visible = true;
                            }

                            

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X - 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }

                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 0 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }
                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else
                    {
                        ptr.btn.Visible = false;
                    }
                }
                if (i == 3)
                {
                    if (switching && comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X + 72, pawn.Location.Y + 72);
                        White_Pawn ptr2 = wp_head;

                        Black_Pawn ptr3;
                        ptr3 = bp_head;
                        for (int j = 0; j < 20; j++)
                        {

                            

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }
                                
                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }

                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else if (!switching && !comp)
                    {
                        ptr.btn.Location = new System.Drawing.Point(pawn.Location.X + 72, pawn.Location.Y + 72);
                        Black_Pawn ptr2 = bp_head;

                        White_Pawn ptr3;
                        ptr3 = wp_head;
                        for (int j = 0; j < 20; j++)
                        {
                            if (!pawn_selected2.crown)
                            {
                                ptr.btn.Visible = false;
                            }
                            else
                            {
                                ptr.btn.Visible = true;
                            }

                            if (ptr.btn.Location == ptr3.Pawn.Location && !ptr3.on_target)
                            {
                                White_Pawn tmp1;
                                Black_Pawn tmp2;

                                tmp1 = wp_head;
                                tmp2 = bp_head;
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp1.on_target && tmp1.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp1.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp1 = tmp1.next;
                                }
                                for (int n = 0; n < 20; n++)
                                {

                                    if (!tmp2.on_target && tmp2.Pawn.Location.X == (ptr.btn.Location.X + 72) && tmp2.Pawn.Location.Y == (ptr.btn.Location.Y + 72))
                                    {
                                        ptr.btn.Visible = false;
                                        break;
                                    }
                                    tmp2 = tmp2.next;
                                }

                            }
                            if (ptr2.Pawn.Location == ptr.btn.Location && !ptr2.on_target)
                            {
                                ptr.btn.Visible = false;
                            }
                            if ((ptr3.Pawn.Location.X == 648 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.Y == 0 && ptr.btn.Location == ptr3.Pawn.Location) || (ptr3.Pawn.Location.X == 0 && ptr.btn.Location == ptr3.Pawn.Location))
                            {
                                ptr.btn.Visible = false;
                            }

                            ptr2 = ptr2.next;
                            ptr3 = ptr3.next;
                        }
                    }
                    else
                    {
                        ptr.btn.Visible = false;
                    }
                }
                ptr = ptr.next;
            }
        }
        private White_Pawn wp_traverse(PictureBox pawn)
        {
            White_Pawn ptr, result;
            ptr = wp_head;
            result = wp_head;
            for (int i = 0; i < 20; i++)
            {
                if (ptr.Pawn == pawn)
                {
                    result = ptr;
                    break;
                }
                ptr = ptr.next;
            }
            return result;
        }
        private Black_Pawn bp_traverse(PictureBox pawn)
        {
            Black_Pawn ptr, result;
            ptr = bp_head;
            result = bp_head;
            for (int i = 0; i < 20; i++)
            {
                if (ptr.Pawn == pawn)
                {
                    result = ptr;
                    break;
                }
                ptr = ptr.next;
            }
            return result;
        }
        private void move(Button btn, PictureBox pawn)
        {
            
            pawn.Location = btn.Location;
        }
        private void playing_Load(object sender, EventArgs e)
        {
            //free_spot_crown(pictureBox40, true);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox1) ;
            free_spot(pictureBox1, true);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox2);
            free_spot(pictureBox2, true);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox3);
            free_spot(pictureBox3, true);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox4);
            free_spot(pictureBox4, true);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox5);
            free_spot(pictureBox5, true);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox9);
            free_spot(pictureBox9, true);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox7);
            free_spot(pictureBox7, true);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox10);
            free_spot(pictureBox10, true);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox8);
            free_spot(pictureBox8, true);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox6);
            free_spot(pictureBox6, true);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox14);
            free_spot(pictureBox14, true);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox19);
            free_spot(pictureBox19, true);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox17);
            free_spot(pictureBox17, true);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox20);
            free_spot(pictureBox20, true);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox18);
            free_spot(pictureBox18, true);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox16);
            free_spot(pictureBox16, true);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox39);
            free_spot(pictureBox39, false);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox37);
            free_spot(pictureBox37, false);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox40);
            free_spot(pictureBox40, false);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox38);
            free_spot(pictureBox38, false);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox36);
            free_spot(pictureBox36, false);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox24);
            free_spot(pictureBox24, false);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox22);
            free_spot(pictureBox22, false);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox25);
            free_spot(pictureBox25, false);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox23);
            free_spot(pictureBox23, false);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox21);
            free_spot(pictureBox21, false);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox29);
            free_spot(pictureBox29, false);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox27);
            free_spot(pictureBox27, false);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox30);
            free_spot(pictureBox30, false);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox28);
            free_spot(pictureBox28, false);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox26);
            free_spot(pictureBox26, false);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox34);
            free_spot(pictureBox34, false);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox32);
            free_spot(pictureBox32, false);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox35);
            free_spot(pictureBox35, false);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox33);
            free_spot(pictureBox33, false);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            pawn_selected2 = bp_traverse(pictureBox34);
            free_spot(pictureBox31, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (switching)
            {
                Btns ptr;
                ptr = btn_head;

                Black_Pawn ptr2=bp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button1.Location)
                    {
                        pawn_selected.Pawn.Location = new System.Drawing.Point(button1.Location.X - 72, button1.Location.Y - 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected.Pawn.Location = button1.Location;
                    }
                    ptr2= ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;



                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
            else
            {
                Btns ptr;
                ptr = btn_head;

                White_Pawn ptr2 = wp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button1.Location)
                    {
                        pawn_selected2.Pawn.Location = new System.Drawing.Point(button1.Location.X - 72, button1.Location.Y - 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected2.Pawn.Location = button1.Location;
                        
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;


                
                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (switching)
            {
                Btns ptr;
                ptr = btn_head;

                Black_Pawn ptr2 = bp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button2.Location)
                    {
                        pawn_selected.Pawn.Location = new System.Drawing.Point(button2.Location.X + 72, button2.Location.Y - 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected.Pawn.Location = button2.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;



                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
            else
            {
                Btns ptr;
                ptr = btn_head;

                White_Pawn ptr2 = wp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button2.Location)
                    {
                        pawn_selected2.Pawn.Location = new System.Drawing.Point(button2.Location.X + 72, button2.Location.Y - 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected2.Pawn.Location = button2.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;


                
                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (switching)
            {
                Btns ptr;
                ptr = btn_head;

                Black_Pawn ptr2 = bp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button3.Location)
                    {
                        pawn_selected.Pawn.Location = new System.Drawing.Point(button3.Location.X - 72, button3.Location.Y + 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected.Pawn.Location = button3.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;



                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
            else
            {
                Btns ptr;
                ptr = btn_head;

                White_Pawn ptr2 = wp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button3.Location)
                    {
                        pawn_selected2.Pawn.Location = new System.Drawing.Point(button3.Location.X - 72, button3.Location.Y + 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected2.Pawn.Location = button3.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;


                
                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (switching)
            {
                Btns ptr;
                ptr = btn_head;

                Black_Pawn ptr2 = bp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button4.Location)
                    {
                        pawn_selected.Pawn.Location = new System.Drawing.Point(button4.Location.X + 72, button4.Location.Y + 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected.Pawn.Location = button4.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;



                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
            else
            {
                Btns ptr;
                ptr = btn_head;

                White_Pawn ptr2 = wp_head;
                for (int i = 0; i < 20; i++)
                {
                    if (ptr2.Pawn.Location == button4.Location)
                    {
                        pawn_selected2.Pawn.Location = new System.Drawing.Point(button4.Location.X + 72, button4.Location.Y + 72);

                        ptr2.Pawn.Visible = false;
                        ptr2.on_target = true;
                        break;
                    }
                    else
                    {
                        pawn_selected2.Pawn.Location = button4.Location;
                    }
                    ptr2 = ptr2.next;
                }
                switching = !switching;
                //pawn_selected.Pawn.Location = button1.Location;


                
                for (int i = 0; i < 4; i++)
                {
                    ptr.btn.Visible = false;
                    ptr = ptr.next;
                }
            }
        }
        public bool game_over()
        {
            if (send_bp_num() == 20)
            {
                MessageBox.Show("Black Lost");
                return true;
            }
            else if (send_wp_num() == 20)
            {
                MessageBox.Show("White Lost");
                return true;
            }
            else
                return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_over())
            {
                this.timer1.Stop();
            }
            Black_Pawn ptr = bp_head;
            for (int i = 0; i < 20; i++)
            {
                
                    if (ptr.on_target)
                {
                    ptr.Pawn.Location = new System.Drawing.Point(10000, 10000);
                }
                if (ptr.Pawn.Location.Y == 0 && !ptr.crown)
                {
                    ptr.crown = true;
                    ptr.Pawn.BackgroundImage = black_crown.BackgroundImage;
                }
                if (pawn_selected2 != null && ptr.Pawn == pawn_selected2.Pawn)
                {
                    ptr.Pawn.BackColor = System.Drawing.Color.Green;
                }
                else
                {
                    ptr.Pawn.BackColor = System.Drawing.Color.Transparent;
                }
                ptr = ptr.next;
            }
            White_Pawn ptr2 = wp_head;
            for (int i = 0; i < 20; i++)
            {
                if (ptr2.on_target)
                {
                    ptr2.Pawn.Location = new System.Drawing.Point(10000, 10000);
                }
                if (ptr2.Pawn.Location.Y == 648 && !ptr2.crown)
                {
                    ptr2.crown = true;
                    ptr2.Pawn.BackgroundImage = white_crown.BackgroundImage;
                }
               
                if (pawn_selected != null && ptr2.Pawn == pawn_selected.Pawn)
                {
                    ptr2.Pawn.BackColor = System.Drawing.Color.Red;
                }
                else
                {
                    ptr2.Pawn.BackColor = System.Drawing.Color.Transparent;
                }
                ptr2 = ptr2.next;
            }
        }
        public int send_bp_num()
        {
            White_Pawn ptr = wp_head;
            int num=0;
            for(int i=0;i<20;i++)
            {
                if (ptr.on_target)
                    num++;
                ptr = ptr.next;
            }
            return num;
        }
        public int send_wp_num()
        {
            Black_Pawn ptr = bp_head;
            int num = 0;
            for (int i = 0; i < 20; i++)
            {
                if (ptr.on_target)
                    num++;
                ptr = ptr.next;
            }
            return num;
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox15);
            free_spot(pictureBox15, true);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox13);
            free_spot(pictureBox13, true);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox11);
            free_spot(pictureBox11, true);
        }
        public bool send_state()
        {
            return switching;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pawn_selected = wp_traverse(pictureBox12);
            free_spot(pictureBox12, true);
        }
    }
}
