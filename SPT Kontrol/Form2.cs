using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SPT_Kontrol
{
    public partial class Form2 : Form
    {
        private bool isCollapsed;
        private bool isCollapsedSecond;
        private bool isCollapsedThird;
        private bool isCollapsedFourth;
        private bool isCollapsedFifth;
        private bool isCollapsedSixth;
        private bool isCollapsedSeventh;
        public Form2()
        {
            InitializeComponent();
            panelElement.Hide();
            tabControlElement.Hide();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }



            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelDropDownSecond_Click(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSecond)
            {
                panelDropDownSecond.Height += 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = false;
                }
            }
            else
            {
                panelDropDownSecond.Height -= 10;
                if (panelDropDownSecond.Size == panelDropDownSecond.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsedSecond = true;
                }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsedThird)
            {
                panelDropDownThird.Height += 10;
                if (panelDropDownThird.Size == panelDropDownThird.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = false;
                }
            }
            else
            {
                panelDropDownThird.Height -= 10;
                if (panelDropDownThird.Size == panelDropDownThird.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsedThird = true;
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFourth)
            {
                panelDropDownFourth.Height += 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = false;
                }
            }
            else
            {
                panelDropDownFourth.Height -= 10;
                if (panelDropDownFourth.Size == panelDropDownFourth.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsedFourth = true;
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsedFifth)
            {
                panelDropDownFifth.Height += 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = false;
                }
            }
            else
            {
                panelDropDownFifth.Height -= 10;
                if (panelDropDownFifth.Size == panelDropDownFifth.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsedFifth = true;
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSixth)
            {
                panelDropDownSixth.Height += 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MaximumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = false;
                }
            }
            else
            {
                panelDropDownSixth.Height -= 10;
                if (panelDropDownSixth.Size == panelDropDownSixth.MinimumSize)
                {
                    timer6.Stop();
                    isCollapsedSixth = true;
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer6.Start();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            if (isCollapsedSeventh)
            {
                panelDropDownSeventh.Height += 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MaximumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = false;
                }
            }
            else
            {
                panelDropDownSeventh.Height -= 10;
                if (panelDropDownSeventh.Size == panelDropDownSeventh.MinimumSize)
                {
                    timer7.Stop();
                    isCollapsedSeventh = true;
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timer7.Start();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            panelElement.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                tabControlElement.Show();
            }
        }



    }
}
