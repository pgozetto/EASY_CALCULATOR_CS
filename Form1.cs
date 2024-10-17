using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EASYCALCULATOR_project
{
    public partial class Form1 : Form
    {
        public List<string> HISTORY = new List<string>();
        public static double Evaluate(string expression)
        {
            try
            {
                DataTable table = new System.Data.DataTable();
                table.Columns.Add("expression", string.Empty.GetType(), expression);
                DataRow row = table.NewRow();
                table.Rows.Add(row);
                return double.Parse((string)row["expression"]);
            }
            catch (Exception)
            {  
               return -1;
            }
        }
        public Form1()
        {
            InitializeComponent();
            result_label.Text = "";
        }
        private void equal_button_Click(object sender, EventArgs e)
        {
            if (Evaluate(result_label.Text) == -1) { result_label.Text = ""; MessageBox.Show("You made something wrong...", "ERROR MESSAGE"); }
            else
            {
                HISTORY.Add(result_label.Text);
                string result = Convert.ToString(Evaluate(result_label.Text));
                result_label.Text = result.Replace(",", ".");
                
            }
            
        }
        private void sum_button_Click(object sender, EventArgs e)
        {
            result_label.Text += "+";
        }

        private void mod_button_Click(object sender, EventArgs e)
        {
            result_label.Text += "%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result_label.Text += "3";
        }

        private void dot_button_Click(object sender, EventArgs e)
        {
            result_label.Text += ".";
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            result_label.Text = "";
        }

        private void divi_button_Click(object sender, EventArgs e)
        {
            result_label.Text += "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            result_label.Text += ")";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            result_label.Text += "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            result_label.Text += "(";
        }

        private void mult_button_Click(object sender, EventArgs e)
        {
            result_label.Text += "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result_label.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            result_label.Text += "8";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            result_label.Text += "7";
        }

        private void sub_button_Click(object sender, EventArgs e)
        {
            result_label.Text += "-";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result_label.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result_label.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result_label.Text += "4";
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            if (result_label.Text == "") { result_label.Text = ""; }
            else { string new_string = result_label.Text.Remove(result_label.Text.Length - 1, 1);
                result_label.Text = new_string;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result_label.Text += "2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result_label.Text += "1";
        }
        private void hISTORYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (HISTORY.Count == 0)
            {
                HISTORY_form history_form = new HISTORY_form("Nothing in History...");
                history_form.ShowDialog();
            }
            else
            {

                HISTORY_form history_form = new HISTORY_form(HISTORY);
                history_form.ShowDialog();

            }
        }

        private void cLOSEAPPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // NOT IMPLEMENTED
        }
    }
}
