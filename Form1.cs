using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDI
{
    public partial class Form1 : Form
    {
         StringBuilder actions = new StringBuilder() ;
        public Form1()
        {
            InitializeComponent();
        } 

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //private void newToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //     Form2 newMDIChild = new Form2();
        //     // Set the Parent Form of the Child window.
        //     newMDIChild.MdiParent = this;
        //     // Display the new form.
        //     newMDIChild.Show();

        //}

        private void Selection1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "SELECTION1";
            textBox2.Text = "completed";
            textBox2.ForeColor = Color.Green;
            label3.Text = "SELECTion1 is selected";
        }

        private void Selection1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SELECTION1";
              textBox2.Text = "completed";
                textBox2.ForeColor = Color.Green;
           
            actions.Append("SELECTion1 is selected \n") ;
            label3.Text = actions.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SELECTION2";
            textBox2.Text = "FAILED";
            textBox2.ForeColor = Color.Red;
            lblStatusbar.Text = "'SELECTION2";
            actions.Append("SELECTion2 is selected</br>");
            label3.Text = actions.ToString();
        }

       
       

       

       

        

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnClearresult_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            lblStatusbar.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox2.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            actions.Append(" Press Cancel  \n");
            label3.Text = actions.ToString();
        }

        private void btnRuntest_Click(object sender, EventArgs e)
        {
            actions.Append(" Press Run Test \n");
            label3.Text = actions.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblSelection1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SELECTION1";
            textBox2.Text = "COMPLETED";
            textBox2.ForeColor = Color.Green;
            richTextBox2.Text = "Send Message :OK \n Receive Ack :OK \n Receive Message :OK\n All mandatory fields :OK\n Validating Field : OK ";
            lblStatusbar.Text = "SELECTION 1";
            actions.Append(" Select SELECTION 1 \n");
            label3.Text = actions.ToString();

        }

        private void lblselection2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SELECTION2";
            textBox2.Text = " NOT EXECUTED";
            textBox2.ForeColor = Color.Black;
            richTextBox2.Text = "";
            lblStatusbar.Text = "SELECTION 2";
            actions.Append(" Select SELECTION 2  \n");
            label3.Text = actions.ToString();

        }

        private void lblSelection3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "SELECTION3";
            textBox2.Text = "FAILED";
            textBox2.ForeColor = Color.Red;
            richTextBox2.Text = "Send Message :OK \n Receive Ack :OK \n Receive Message :OK\n All mandatory fields :OK\n Validating Field : OK \n  Receive Ack :OK \n Receive Message :OK\nAll mandatory fields :Missing 2 Fields \n Validating Field \n Field Value1 contains invalid Info \n Field Value2  is missing \n Field Value 5 is missing";
            lblStatusbar.Text = "SELECTION 3";
            actions.Append(" Select SELECTION 3 \n");
            label3.Text = actions.ToString();
        }
    }
}
