using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        private float numeral1 = 0;
        private float numeral2 = 0;
        private float numeral3 = 0;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         Button bt = (Button)sender;
            if (label1.Text == "0"){
                label1.Text = bt.Text;
            }else{               
                label1.Text = label1.Text + bt.Text;
            }
            if (label1.Text.Length >= 13)
            {
                label1.Text = "Error        ";
            }           
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains(",")){
                label1.Text = "Error        ";

            }
            else{
                label1.Text = label1.Text + ",";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            label3.Text = bt.Text;
            if (label2.Text == "0" && label1.Text != "Error        ")
            {
                label2.Text = label1.Text;
                label1.Text = "0";
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "+";
        }
        private void button18_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Error        ")
            {
                label1.Text = "0";
            }

            if (label1.Text != "Error        "&& label1.Text.Length>=1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }

            if(label1.Text.Length < 1)
            {
                label1.Text = "0";
            }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {          
            if (label1.Text == "Error        ")
            {
                label1.Text = "0";

            }                      
            
            if (label3.Text == "+"){
                label2.Text = (float.Parse(label2.Text) + float.Parse(label1.Text)).ToString();
            }

            if (label3.Text == "-") {
                label2.Text = (float.Parse(label2.Text) - float.Parse(label1.Text)).ToString();
            }

            if (label3.Text == "*") {
                label2.Text = (float.Parse(label2.Text) * float.Parse(label1.Text)).ToString();               
            }

            if (label3.Text == "/") {
                label2.Text = (float.Parse(label2.Text) / float.Parse(label1.Text)).ToString();
                
            }
           
        }

       
    }
}
