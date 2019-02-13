using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakalarka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            VymazanieTextu();
            this.BackgroundImage = Properties.Resources.menu;

        }

        private void Viditelnost()
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }
            
    
        private void VymazanieTextu()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
            label21.Text = "";
            label22.Text = "";
            label23.Text = "";
            label24.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            label34.Text = "";
            label35.Text = "";
            label36.Text = "";
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            label40.Text = "";
            label41.Text = "";
            label42.Text = "";
            label43.Text = "";
            label44.Text = "";
            label45.Text = "";
            label46.Text = "";
            label47.Text = "";
            label48.Text = "";
            label49.Text = "";
            label50.Text = "";
        }

        private void korene()
        {
            label37.Text = ("s6+");
            label38.Text = ("s5+");
            label39.Text = ("s4+");
            label40.Text = ("s3+");
            label41.Text = ("s2+");
            label42.Text = ("s+");
        }

        private void VymazanieBoxov()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double k6 = 0;
            double k5 = 0;
            double k4 = 0;
            double k3 = 0;
            double k2 = 0;                      // vytvorenie premennych
            double k1 = 0;
            double k0 = 0;
            double kon1 = 0;
            double kon2 = 0;
            double kon3 = 0;
            double kon4 = 0;

            if ((textBox1.Visible == false) && (textBox2.Visible == false) && (textBox3.Visible == false))           
            {
                if ((textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);
                    kon1 = k3 / k2;
                    double v1 = (k3 - k2 * kon1);
                    double v2 = (k1 - k0 * kon1);

                    label5.Text = v1.ToString("#0.00");           // riesenie pre 4 clenz RS kriteria
                    label6.Text = k2.ToString("#0.00");
                    label7.Text = v2.ToString("#0.00");
                    label8.Text = k0.ToString("#0.00");
                    label46.Text = k3.ToString("#0.00");
                    label47.Text = k2.ToString("#0.00");
                    label48.Text = k1.ToString("#0.00");
                    label49.Text = k0.ToString("#0.00");
                    label50.Text = ("Konštanty");

                    if ((v1 >= 0) && (v2 >= 0) && (k2 >= 0) && (k0 >= 0))
                    {
                        label1.Text = ("Obvod je stabilný");
                    }
                    else
                    {
                        label1.Text = ("Obvod nie je stabilný");
                    }

                }
            }

            if ((textBox1.Visible == false) && (textBox2.Visible == false) && (textBox3.Visible == true))
            {
                if ((textBox3.TextLength != 0) && (textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {
                    k4 = double.Parse(textBox3.Text);
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);
                    kon1 = k4 / k3;
                    double v1 = (k4 - k3 * kon1);
                    double v2 = (k2 - k1 * kon1);
                    kon2 = k3 / v2;                                            // riesenie pre 5 clenov RS kriteria
                    double v21 = (k3 - v2 * kon2);
                    double v22 = (k1 - k0 * kon2);

                    label4.Text = v1.ToString("#0.00");
                    label5.Text = k3.ToString("#0.00");
                    label6.Text = v2.ToString("#0.00");
                    label7.Text = k1.ToString("#0.00");
                    label8.Text = k0.ToString("#0.00");
                    label24.Text = kon1.ToString("#0.00");
                    label11.Text = v21.ToString("#0.00");
                    label12.Text = v2.ToString("#0.00");
                    label13.Text = v22.ToString("#0.00");
                    label14.Text = k0.ToString("#0.00");
                    label25.Text = kon2.ToString("#0.00");
                    label45.Text = k4.ToString("#0.00");
                    label46.Text = k3.ToString("#0.00");
                    label47.Text = k2.ToString("#0.00");
                    label48.Text = k1.ToString("#0.00");
                    label49.Text = k0.ToString("#0.00");
                    label50.Text = ("Konštanty");

                    if ((v21 >= 0) && (v2 >= 0) && (v22 >= 0) && (k0 >= 0))
                    {
                        label1.Text = ("Obvod je stabilný");
                    }
                    else
                    {
                        label1.Text = ("Obvod nie je stabilný");
                    }

                }
            }

            if (textBox1.Visible == false && textBox2.Visible == true && textBox3.Visible == true)
            {
                if ((textBox2.TextLength != 0) && (textBox3.TextLength != 0) && (textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {

                    k5 = double.Parse(textBox2.Text);
                    k4 = double.Parse(textBox3.Text);
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);
                    kon1 = k5 / k4;                                         // R-S kriterium pre 6 clenov
                    double v1 = (k5 - k4 * kon1);
                    double v2 = (k3 - k2 * kon1);
                    double v3 = (k1 - k0 * kon1);
                    kon2 = k4 / v2;
                    double v21 = (k4 - v2 * kon2);
                    double v22 = (k2 - v3 * kon2);
                    kon3 = v2 / v22;
                    double v31 = (v2 - v22 * kon3);
                    double v32 = (v3 - k0 * kon3);

                    label3.Text = v1.ToString("#0.00");
                    label4.Text = k5.ToString("#0.00");
                    label5.Text = v2.ToString("#0.00");
                    label6.Text = k2.ToString("#0.00");
                    label7.Text = k1.ToString("#0.00");
                    label8.Text = k0.ToString("#0.00");
                    label10.Text = v21.ToString("#0.00");
                    label11.Text = v2.ToString("#0.00");
                    label12.Text = v22.ToString("#0.00");
                    label13.Text = v3.ToString("#0.00");
                    label14.Text = k0.ToString("#0.00");
                    label16.Text = v31.ToString("#0.00");
                    label17.Text = v22.ToString("#0.00");
                    label18.Text = v32.ToString("#0.00");
                    label19.Text = k0.ToString("#0.00");
                    label24.Text = kon1.ToString("#0.00");
                    label25.Text = kon2.ToString("#0.00");
                    label26.Text = kon3.ToString("#0.00");
                    label44.Text = k5.ToString("#0.00");
                    label45.Text = k4.ToString("#0.00");
                    label46.Text = k3.ToString("#0.00");
                    label47.Text = k2.ToString("#0.00");
                    label48.Text = k1.ToString("#0.00");
                    label49.Text = k0.ToString("#0.00");
                    label50.Text = ("Konštanty");

                    if ((v31 >= 0) && (v22 >= 0) && (v32 >= 0) && (k0 >= 0))
                    {
                        label1.Text = ("Obvod je stabilný");
                    }
                    else
                    {
                        label1.Text = ("Obvod nie je stabilný");
                    }



                }
            }


                if (textBox1.Visible == true && textBox2.Visible == true && textBox3.Visible == true)
                {

                    if ((textBox1.TextLength != 0) && (textBox2.TextLength != 0) && (textBox3.TextLength != 0) && (textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                    {
                        k6 = double.Parse(textBox1.Text);
                        k5 = double.Parse(textBox2.Text);
                        k4 = double.Parse(textBox3.Text);
                        k3 = double.Parse(textBox4.Text);
                        k2 = double.Parse(textBox5.Text);
                        k1 = double.Parse(textBox6.Text);
                        k0 = double.Parse(textBox7.Text);
                        kon1 = k6 / k5;
                        double v1 = (k6 - k5 * kon1);
                        double v2 = (k4 - k3 * kon1);                                            // routh-shurovo kriterium pre 7 clenov
                        double v3 = (k2 - k1 * kon1);
                        kon2 = k5 / v2;
                        double v21 = (k5 - v2 * kon2);
                        double v22 = (k3 - v3 * kon2);
                        double v23 = (k1 - k0 * kon2);
                        kon3 = v2 / v22;
                        double v31 = (v2 - v22 * kon3);
                        double v32 = (v3 - v23 * kon3);
                        kon4 = v22 / v32;
                        double v41 = (v22 - v32 * kon4);
                        double v42 = (v23 - k0 * kon4);

                        label2.Text = v1.ToString("#0.00");
                        label3.Text = k5.ToString("#0.00");
                        label4.Text = v2.ToString("#0.00");
                        label5.Text = k3.ToString("#0.00");
                        label6.Text = v3.ToString("#0.00");
                        label7.Text = k1.ToString("#0.00");
                        label8.Text = k0.ToString("#0.00");
                        label9.Text = v21.ToString("#0.00");
                        label10.Text = v2.ToString("#0.00");
                        label11.Text = v22.ToString("#0.00");
                        label12.Text = v3.ToString("#0.00");
                        label13.Text = v23.ToString("#0.00");
                        label14.Text = k0.ToString("#0.00");                            // vypis riesenia RS pre 7 clenov
                        label15.Text = v31.ToString("#0.00");
                        label16.Text = v22.ToString("#0.00");
                        label17.Text = v32.ToString("#0.00");
                        label18.Text = v23.ToString("#0.00");
                        label19.Text = k0.ToString("#0.00");
                        label20.Text = v41.ToString("#0.00");
                        label21.Text = v32.ToString("#0.00");
                        label22.Text = v42.ToString("#0.00");
                        label23.Text = k0.ToString("#0.00");
                        label24.Text = kon1.ToString("#0.00");
                        label25.Text = kon2.ToString("#0.00");
                        label26.Text = kon3.ToString("#0.00");
                        label27.Text = kon4.ToString("#0.00");
                        label43.Text = k6.ToString("#0.00");
                        label44.Text = k5.ToString("#0.00");
                        label45.Text = k4.ToString("#0.00");
                        label46.Text = k3.ToString("#0.00");
                        label47.Text = k2.ToString("#0.00");
                        label48.Text = k1.ToString("#0.00");
                        label49.Text = k0.ToString("#0.00");
                        label50.Text = ("Konštanty");


                    if ((v41 >= 0) && (v32 >= 0) && (v42 >= 0) && (k0 >= 0))
                        {
                            label1.Text = ("Obvod je stabilný");
                        }
                        else
                        {
                            label1.Text = ("Obvod nie je stabilný");
                        }
                    }


                }




        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();   // menu pre 7 celnov R-S
            VymazanieBoxov();
            korene();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            

            Image myimage = new Bitmap(@"C:\Users\kubit\Desktop\RU kritérium.jpg");
            this.BackgroundImage = myimage;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Viditelnost();
            textBox1.Visible = false;        // menu pre 6 clenov R-S            
            VymazanieTextu();
            VymazanieBoxov();
            korene();
            label37.Text = "";            
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;                    //Povolenie zadavať do text boxu len cisla a bodku začiatok
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;                    // končia podmienky pre zadavanie znakov
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 5 celenov RS kriteria
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";            
            textBox1.Visible = false;
            textBox2.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;


        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 4 celeny RS kriteria
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";            
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            double k5 = 0;
            double k4 = 0;
            double k3 = 0;
            double k2 = 0;                      // vytvorenie premennych
            double k1 = 0;
            double k0 = 0;

            if (textBox2.Visible == true)
            {
                if ((textBox2.TextLength != 0) && (textBox3.TextLength != 0) && (textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {
                    k5 = double.Parse(textBox2.Text);
                    k4 = double.Parse(textBox3.Text);
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);



                    label5.Text = k4.ToString("#0.00");
                    label12.Text = k3.ToString("#0.00");
                    label18.Text = k2.ToString("#0.00");
                    label23.Text = k1.ToString("#0.00");
                    label33.Text = k0.ToString("#0.00");
                    label11.Text = k5.ToString("#0.00");
                    label17.Text = k4.ToString("#0.00");
                    label22.Text = k3.ToString("#0.00");
                    label32.Text = k2.ToString("#0.00");
                    label6.Text = k2.ToString("#0.00");
                    label13.Text = k1.ToString("#0.00");
                    label19.Text = k0.ToString("#0.00");      // riesenie pre 6 clenov Hur kriteria (zatial len vypis do velkej matice treba doriesit pocitanie)
                    label21.Text = k5.ToString("#0.00");
                    label31.Text = k4.ToString("#0.00");
                    label7.Text = k0.ToString("#0.00");
                    label16.Text = ("0.00");
                    label20.Text = ("0.00");
                    label29.Text = ("0.00");
                    label30.Text = ("0.00");
                    label28.Text = ("0.00");
                    label27.Text = ("0.00");
                    label26.Text = ("0.00");
                    label25.Text = ("0.00");
                    label8.Text = ("0.00");
                    label14.Text = ("0.00");
                }

            }

            if ((textBox2.Visible == false) && (textBox3.Visible == true))
            {
                if ((textBox3.TextLength != 0) && (textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {
                    k4 = double.Parse(textBox3.Text);
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);

                    double h3 = ((k3 * k2 * k1) - (k0 * k3 * k3) - (k4 * k1 * k1));
                    double h2 = ((k3 * k2) - (k4 * k1));
                    double h1 = k3;

                    label5.Text = k3.ToString("#0.00");
                    label12.Text = k2.ToString("#0.00");
                    label18.Text = k1.ToString("#0.00");
                    label23.Text = k0.ToString("#0.00");
                    label11.Text = k4.ToString("#0.00");
                    label17.Text = k3.ToString("#0.00");
                    label22.Text = k2.ToString("#0.00");
                    label6.Text = k1.ToString("#0.00");                        // riesenie pre 5 clenov Hur 
                    label13.Text = k0.ToString("#0.00");
                    label21.Text = k4.ToString("#0.00");
                    label16.Text = ("0.00");
                    label20.Text = ("0.00");
                    label7.Text = ("0.00");
                    label8.Text = ("0.00");
                    label14.Text = ("0.00");
                    label19.Text = ("0.00");
                    label34.Text = h3.ToString("#0.00");
                    label35.Text = h2.ToString("#0.00");
                    label36.Text = h1.ToString("#0.00");

                   

                    if (h3>0 && h2 > 0 && h1 > 0)
                    {
                        label1.Text = ("Obvod je stabilný");
                    }
                    else
                    {
                        label1.Text = ("Obvod nie je stabilný");
                    }
                }

            }

            if ((textBox2.Visible == false) && (textBox3.Visible == false))
            {
                if ((textBox4.TextLength != 0) && (textBox5.TextLength != 0) && (textBox6.TextLength != 0) && (textBox7.TextLength != 0))
                {
                    k3 = double.Parse(textBox4.Text);
                    k2 = double.Parse(textBox5.Text);
                    k1 = double.Parse(textBox6.Text);
                    k0 = double.Parse(textBox7.Text);

                    double h2= ((k2 * k1) - (k3 * k0));
                    double h1 = k2;

                    label5.Text = k2.ToString("#0.00");
                    label6.Text = k0.ToString("#0.00");
                    label12.Text = k1.ToString("#0.00");
                    label18.Text = k0.ToString("#0.00");                         //riesenie pre 4 clenz HUR kriteria
                    label11.Text = k3.ToString("#0.00");
                    label17.Text = k2.ToString("#0.00");
                    label16.Text = ("0.00");
                    label13.Text = ("0.00");
                    label7.Text = ("0.00");                    
                    label35.Text = h2.ToString("#0.00");
                    label36.Text = h1.ToString("#0.00");

                    if (h2 > 0 && h1 > 0)
                    {
                        label1.Text = ("Obvod je stabilný");
                    }
                    else
                    {
                        label1.Text = ("Obvod nie je stabilný");
                    }
                                                         
                }
            }

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 6 celeny Hur kriteria
            VymazanieBoxov();
            korene();
            label37.Text = "";           
            textBox1.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
                                 

            Image myimage = new Bitmap(@"C:\Users\kubit\Desktop\HU kritérium.jpg");
            this.BackgroundImage = myimage;



        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 5 celenov Hur kriteria
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";            
            textBox1.Visible = false;
            textBox2.Visible = false;           
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;

            Image myimage = new Bitmap(@"C:\Users\kubit\Desktop\HU kritérium.jpg");
            this.BackgroundImage = myimage;
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 4 celeny Hur kriteria
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 6 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";            
            textBox1.Visible = false;            
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 5 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";            
            textBox1.Visible = false;
            textBox2.Visible = false;            
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 4 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button4.Visible = false;
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 6 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";            
            textBox1.Visible = false;            
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 5 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";           
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Viditelnost();
            VymazanieTextu();           // menu pre 4 celeny Nyquist
            VymazanieBoxov();
            korene();
            label37.Text = "";
            label38.Text = "";
            label39.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }
    }
}