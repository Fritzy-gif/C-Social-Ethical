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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void startButton1_Click_1(object sender, EventArgs e)
        {
            //when the 'Intructions' button is clicked, Form1 will go invisible and move to Form2
            this.Visible = false; //note that the 'Visible' property is a boolean
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
