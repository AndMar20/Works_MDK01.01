using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class SearchForm : Form
    {
        public Action<string> action;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void replaceTextBox_TextChanged(object sender, EventArgs e)
        {
            action(replaceTextBox.Text);
        }

        
    }
}
