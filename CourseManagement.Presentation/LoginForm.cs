using CourseManagement.Business;
using CourseManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtcontraseña.Text != ""))
            {
                if ((txtusuario.Text == "admin") && (txtcontraseña.Text == "admin"))
                {
                    MateriasForm logeo = new MateriasForm();
                    logeo.Show();
                    this.Hide();
                }
            }
        }
    }
}
