using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Userdatabase.GUI;

namespace Userdatabase.GUI
{
    /// <summary>
    /// Class:      Login : Form
    /// Developer:  Chase Dickerson
    /// Date:       12/14/2017
    /// Purpose:    This form propmts for login, checks password and user name, and decides access level
    /// </summary>
    public partial class Login : Form
    {
        // Declaring global variables
        UserClass level = new UserClass();
        UserClass dept = new UserClass();
        public static int accessLevel;
        public static int deptClass;
        public static string name;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO
            //
            // create a "principal context" - e.g. your domain (could be machine, too)
            //
            //using (PrincipalContext pc = new PrincipalContext(ContextType.Domain, "YOURDOMAIN"))
            //{
                  //validate the credentials
            //    bool isValid = pc.ValidateCredentials("myuser", "mypassword");
            //}

            ///
            /// This code checks the username and password and assigns name/dept and access level
            /// It also opens the UserList form 
            /// 
            if(txtBxUserName.Text == "generalUser1")
            {
                if(txtBxPassword.Text == "johnDoe1")
                {
                    name = "John";
                    accessLevel = level.setLevelOneAccess();
                    this.Hide();
                    UserList f3 = new UserList();
                    f3.ShowDialog();
                    
                }
                else if(txtBxPassword.Text == "janeDoe1")
                {
                    name = "Jane";
                    accessLevel = level.setLevelOneAccess();
                    this.Hide();
                    UserList f3 = new UserList();
                    f3.ShowDialog();
                }
                else
                {
                    lblMessage.Text = "Error: Either username or password is incorrect.";
                }
            }
            else if(txtBxUserName.Text == "managerUser2")
            {
                if(txtBxPassword.Text == "cBratton2")
                {
                    accessLevel = level.setLevelTwoAccess();
                    deptClass = dept.setLacesDept();
                    this.Hide();
                    UserList f3 = new UserList();
                    f3.ShowDialog();
                }
                if(txtBxPassword.Text == "dShrute2")
                {
                    accessLevel = level.setLevelTwoAccess();
                    deptClass = dept.setWheelsDept();
                    this.Hide();
                    UserList f3 = new UserList();
                    f3.ShowDialog();
                }
                else
                {
                    lblMessage.Text = "Error: Either username or password is incorrect.";
                }
            }
            else if(txtBxUserName.Text == "Admin")
            {
                if(txtBxPassword.Text == "userLevel3")
                {
                    accessLevel = level.setLevelThreeAccess();
                    this.Hide();
                    UserList f3 = new UserList();
                    f3.ShowDialog();
                }
                else
                {
                    lblMessage.Text = "Error: Either username or password is incorrect.";
                }
            }
            else
            {
                lblMessage.Text = "Error: Either username or password is incorrect.";
            }

        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
