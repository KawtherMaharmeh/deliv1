using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deliv1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btn_create_Click(object sender, EventArgs e)
        {

        }

        private void cmb1_Click(object sender, EventArgs e)
        {

        }
        private void cmb1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int counter = Convert.ToInt32(txtNum.Text);


            String result = cmb1.Text;
            if (result == "ComboBox ")
            {

                panel2.Controls.Clear();
                for (int i = 0; i < counter; i++)
                {



                    ComboBox cmb1 = new ComboBox();
                    cmb1.Name = "KAWTHER" + (i + 1);
                    cmb1.Text = "kawther" + (i + 1);
                    cmb1.Location = new Point(25, (i * 50));
                    cmb1.Size = new Size(100, 40);
                    panel2.Controls.Add(cmb1);

                }
            }
            else if (result == "Button ")
            {
                panel2.Controls.Clear();


                for (int i = 0; i < counter; i++)
                {
                    Button btn1 = new Button();

                    btn1.Text = "kawther" + (i + 1);
                    btn1.Location = new Point(25, (i * 50));
                    btn1.Size = new Size(100, 40);
                    panel2.Controls.Add(btn1);

                }
            }
            else if (result == "TextBox ")
            {
                panel2.Controls.Clear();
                for (int i = 0; i < counter; i++)
                {
                    TextBox txt1 = new TextBox();

                    txt1.Text = "kawther" + (i + 1);
                    txt1.Location = new Point(25, (i * 50));
                    txt1.Size = new Size(100, 40);
                    panel2.Controls.Add(txt1);
                }
            }

        }
    }
}
