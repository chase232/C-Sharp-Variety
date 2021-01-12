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

namespace Userdatabase
{
    /// <summary>
    /// Class:      Splash : Form
    /// Developer:  Chase Dickerson 
    /// Date:       12/14/2017
    /// Purpose:    Introduction screen to program
    /// </summary>
    public partial class Splash : Form
    {
        
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        // Takes user to login screen
        private void btnGoToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login f2 = new Login();

            f2.ShowDialog();
        }
    }
}
