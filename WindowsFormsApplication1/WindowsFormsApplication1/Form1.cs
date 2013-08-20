using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ControlLift c;
        public int nb = 0;
        public int state = 2;
        public bool arrived = true;
        public Form1()
        {

            InitializeComponent();

            c = new ControlLift(3, 10, 10);
            c.Size = new Size(300, 800);
            panel1.Controls.Add(c);

            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            this.timer1.Interval = 10;
            c.list_call.Add(0);
            timer1.Start();
            



        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
            textBox1.Text = "2";
            
            c.list_call.Add(194);
                              
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            c.list_call.Add(97);

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";

            c.list_call.Add(0);
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "2";

            c.list_call.Add(194);
                      

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            
                if (c.nbFloor < c.list_call.First())
                {
                    c.nbFloor += 1;

                    c.Invalidate();

                }

                if (c.nbFloor > c.list_call.First())
                {
                    c.nbFloor -= 1;

                    c.Invalidate();

                }
                if (checkBox1.Checked && c.nbFloor == 194)
                {
                    
                    checkBox1.Checked = false;
                 
                }
                if (checkBox2.Checked && c.nbFloor == 97)
                {
                    checkBox2.Checked = false;
                }
                if (checkBox3.Checked && c.nbFloor == 0)
                {
                    checkBox3.Checked = false;
                }

            if(c.nbFloor == c.list_call.ElementAt(0))
            
            {
                if (state == 0)
                {
                    //Console.WriteLine("+");
                    c.translate += 1;
                    c.Invalidate();
                    if (c.translate == 48)
                    {
                        state = 1;
                    }
                }
                else if (state == 1)
                {
                   // Console.WriteLine("-");
                    c.translate -= 1;
                    c.Invalidate();
                    if (c.translate == 0)
                    {
                        state = 2;
                    }
                } 
        }

            Console.WriteLine("floor" + c.nbFloor + "count" + c.list_call.Count());
                if (c.list_call.Count() >= 2 && c.nbFloor == c.list_call.First())
                {

                    //ouverture des portes

                    
                          
                   if (state == 2)
                        {
                            
                            c.list_call.Remove(c.nbFloor);
                            Console.Write("Done ");
                            if (c.list_call.Count() >= 2 || c.nbFloor != c.list_call.First())  state = 0;
                            
                        }                    
                    //}

                        //c.list_call.Remove(c.nbFloor);

                    }           

                if (nb < 50)
                {
                    nb++;
                }
                else
                {
                    nb = 0;

                    for (int i = 0; i < c.list_call.Count; i++)
                    {
                        Console.WriteLine("element " + i + " : " + c.list_call.ElementAt(i));
                    }

                    Console.WriteLine("floor " + c.nbFloor);
                    Console.WriteLine("count " + c.list_call.Count());

                }

                
                c.Invalidate();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "1";
            c.list_call.Add(97);
            /*
            if (c.list_call.Count() >= 1 && c.nbFloor == c.list_call.First())
            {

                c.list_call.Add(97);
                state = 0;
            }
            */
                    
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            c.list_call.Add(0);
            /*
            if (c.list_call.Count() >= 1 && c.nbFloor == c.list_call.First())
            {
                c.list_call.Add(0);
                state = 0;
            }*/

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

