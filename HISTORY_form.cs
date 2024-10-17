using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EASYCALCULATOR_project
{
    public partial class HISTORY_form : Form
    {
        public HISTORY_form(List<string> h_list)
        {
            InitializeComponent();

            // LOAD

            foreach (string i in h_list) { history_text_box.Text += i + "\r\n"; } 
        }
        public HISTORY_form(string text)
        {
            InitializeComponent();
            history_text_box.Text = text;
        }

    }
}
