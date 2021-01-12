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
using System.Drawing.Printing;
using System.Data.SqlClient;
using System.Data;

namespace Userdatabase
{
    /// <summary>
    /// Class:      UserList : Form
    /// Developer:  Chase Dickerson
    /// Date:       12/14/2017
    /// Purpose:    This form displays the correct database information based on user
    ///             and user access
    /// </summary>
    public partial class UserList : Form
    {
        // Declaring a new DataSet
        DataSet ds = new DataSet();

        public UserList()
        {
            InitializeComponent();
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cd0860807DataSet.UserDatabaseTable' table. You can move, or remove it, as needed.
            this.userDatabaseTableTableAdapter.Fill(this.cd0860807DataSet.UserDatabaseTable);

            // Connectng to the SQL Server
            string connectionString = "Server = cis-sql.otc.edu\\sql,9191; Database = cd0860807; " +
            "Trusted_Connection = True; ";

            string sql = "SELECT UserKey,UserLastName,UserFirstName,UserDept,UserAccessLevel,UserSalary FROM UserDatabaseTable";

            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            connection.Open();
            dataadapter.Fill(ds, "UserDatabaseTable");
            connection.Close();

            userDatabaseTableDataGridView.DataSource = ds.Tables[0];

            int temp = Login.accessLevel;

            ///
            /// This code filters the datagridview and ensure the correct data
            /// is showing based off user login information
            ///
            if (temp == 1 && Login.name == "John")
            {
                lblLevel.Text = "General Use View";
                DataView dv;
                dv = new DataView(ds.Tables[0], "UserKey = '1' ", "UserAccessLevel Desc", DataViewRowState.CurrentRows);
                userDatabaseTableDataGridView.DataSource = dv;
            }

            else if (temp == 1 && Login.name == "Jane")
            {
                lblLevel.Text = "General Use View";
                DataView dv;
                dv = new DataView(ds.Tables[0], "UserKey = '2' ", "UserAccessLevel Desc", DataViewRowState.CurrentRows);                
                userDatabaseTableDataGridView.DataSource = dv;
            }

            else if (temp == 2 && Login.deptClass == 22)
            {
                lblLevel.Text = "Manager of Laces Dept. View";
                DataView dv;
                dv = new DataView(ds.Tables[0], "UserDept = 'Laces' ", "UserAccessLevel Desc", DataViewRowState.CurrentRows);
                userDatabaseTableDataGridView.DataSource = dv;
            }
            else if (temp == 2 && Login.deptClass == 33)
            {
                lblLevel.Text = "Manager of Wheels Dept. View";
                DataView dv;
                dv = new DataView(ds.Tables[0], "UserDept = 'Wheels' ", "UserAccessLevel Desc", DataViewRowState.CurrentRows);
                userDatabaseTableDataGridView.DataSource = dv;
            }
            else
            {
                lblLevel.Text = "Administrative View";
            }

            // This piece of code is used to close the form once it has been opened for 5 minutes
            Timer MyTimer = new Timer();
            MyTimer.Interval = (5 * 60 * 1000); 
            MyTimer.Tick += new EventHandler(MyTimerTick);
            MyTimer.Start();
        }

        // Method used to close form in 5 minutes
        private void MyTimerTick(object sender, EventArgs e)
        {
            MessageBox.Show("The form will now be closed.", "Time Elapsed");
            this.Close();
        }


        private void userDatabaseTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userDatabaseTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cd0860807DataSet);
            
        }

        // Opens the About form
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About f4 = new About();
            f4.ShowDialog();
        }

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Closes the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Prints the current info in datagridview
        private void btnPrint_Click(object sender, EventArgs e)
        {
            print();
        }

        // Print method
        public void print()
        {
            string textout = "";
            PrintDocument p = new PrintDocument();
            p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
            {
                e1.Graphics.DrawString(textout, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

            };
            try
            {
                p.Print();
                MessageBox.Show("Invoice Printed!");
            }
            catch (Exception ex)
            {
                throw new Exception("Exception Occurred While Printing", ex);
            }
        }

        // Prints the current info in datagridview
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print();
        }

        private void userDatabaseTableDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
