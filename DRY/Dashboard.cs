using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRY
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        // create a method that returns void
        private void generateEmployeeIDButton_Click(object sender, EventArgs e)
        {
            // when button is pushed put "employee ID (containing first name last name and time) in the box"
            string employeeId = $@"{firstNameText.Text.Substring(0,4)}{lastNameText.Text.Substring(0,4)}{DateTime.Now.Millisecond}";
            employeeIdText.Text = employeeId;
        }

    }
}
