using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;
using UserMaintenance.Properties;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();

            txtLastName.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            btnWrite.Text = Resource1.Write;
            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
            var u = new User()
            {
                FullName = txtLastName.Text,
            };
            users.Add(u);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {

        }
    }
}
