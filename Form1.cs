using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator28may19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // coding for add
        static String Add(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number + second_number;
            return result.ToString();
        }
        // coding for sub
        static String Sub(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number - second_number;
            return result.ToString();
        }

        // coding for mult
        static String Mult(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number * second_number;
            return result.ToString();
        }

        // coding for div
        static String Div(String FirstNumber, String SecondNumber)
        {
            int first_Number = int.Parse(FirstNumber);
            int second_number = int.Parse(SecondNumber);
            int result = first_Number / second_number;
            return result.ToString();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            txt_result.Text = Add(txt_firstnumber.Text, txt_secondnumber.Text);
        }

        private void Btn_click_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void Btn_sub_Click(object sender, EventArgs e)
        {
            txt_result.Text = Sub(txt_firstnumber.Text, txt_secondnumber.Text);
        }

        private void Btn_mult_Click(object sender, EventArgs e)
        {
            txt_result.Text = Mult(txt_firstnumber.Text, txt_secondnumber.Text);
        }

        private void Btn_div_Click(object sender, EventArgs e)
        {
            txt_result.Text = Div(txt_firstnumber.Text, txt_secondnumber.Text);
        }
    }
}
