using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace More_Arrays
{
    public partial class Form1 : Form
    {

        string[] arrayName = new string[3];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)

        {
            for (int i = 0; i < 3; i++ )
            {
                arrayName[i] = Interaction.InputBox("Enter Name: ","inputBox","Defalt",-1,-1);

            }

            
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDisplay_Click_1(object sender, EventArgs e)
        {
            redOut.Text = "Names \n";

            for (int i = 0; i < 3; i++)
            {
                redOut.AppendText( arrayName[i]+"\n");
            }

            MessageBox.Show("Second name is"+redOut.Lines[2]);
        }
    }
}
