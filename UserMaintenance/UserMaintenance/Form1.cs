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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Text;
using System.IO;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            btnSave.Text = Resource1.Save;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var u = new User()
            {
                FullName = txtFullName.Text,
            };
            users.Add(u);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filename;

            SaveFileDialog sfd = new SaveFileDialog();
     
            sfd.DefaultExt = "txt";
            sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.RestoreDirectory = true;

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filename = sfd.FileName;

                using (StreamWriter sw = new StreamWriter(filename + ".csv"))
                {
                    foreach (var item in users)
                    {
                        sw.WriteLine(item.ID + ";" + item.FullName);
                    }
                    sw.Close();
                }
            }
        }
    }
}
