using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Properties;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    BindingList<User> users = new BindingList<User>();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource1.LastName;
            lblFirstName.Text = Resource1.FirstName;
            btnAdd.Text = Resource1.Add;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
