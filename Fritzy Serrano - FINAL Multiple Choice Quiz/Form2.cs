using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fritzy_Serrano___FINAL_Multiple_Choice_Quiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //When the 'Start Quiz' button is clicked, Form2 will be hidden and Form3 will be opened
            this.Visible = false;
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
