using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Roz_Kalkylator
{
    public partial class Form1 : Form
    {

        Double value = 0;
        string operation = "";
        bool operation_pressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, EventArgs e)
        {
            if ((TextBox.Text == "0")|| (operation_pressed))
                TextBox.Clear();

            operation_pressed = false;
            Button b = (Button) sender;
           TextBox.Text = TextBox.Text + b.Text ;
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse (TextBox.Text);
            operation_pressed = true;
            label1.Text = value + "" + operation;
           
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            


            label1.Text = "";
            switch (operation)
            {
                case "+":
                    TextBox.Text = (value + Double.Parse(TextBox.Text)).ToString ();
                    break;

                case "-":
                    TextBox.Text = (value - Double.Parse(TextBox.Text)).ToString();
                    break;

                case "*":
                    TextBox.Text = (value * Double.Parse(TextBox.Text)).ToString();
                    break;

                case "/":
                    TextBox.Text = (value / Double.Parse(TextBox.Text)).ToString();
                    break;


               
                case "1/X":
                   TextBox.Text = (1 / Double.Parse(TextBox.Text)).ToString();
                    break;

                case "⎷":

                    TextBox.Text = (Math.Sqrt(TextBox.Text)).ToString();
                    break;

                case "x^2":

                    TextBox.Text = (Convert.ToDouble (TextBox.Text)* Convert.ToDouble(TextBox.Text)).ToString(); 
                    break;


                case "%":

                    TextBox.Text = ( Double.Parse(TextBox.Text) / 100).ToString();
                    break;

                

                default:
                    break;
            }
            
        }

        


        private void Button17_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
            value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonde(object sender, EventArgs e)
        {
            if(TextBox.Text.Length > 0)
            {
                TextBox.Text = TextBox.Text.Remove(TextBox.Text.Length - 1, 1);
            }
            if (TextBox.Text == "")
            {


                TextBox.Text = "0";
            }
        }
    }
}
