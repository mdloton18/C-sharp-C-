using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    public partial class LoginForm : Form
    {
    /// <summary>
    /// </summary>
        private DataAccess Da { set; get; }
        public LoginForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try 
            {

                if (!this.IsValidData())
                {
                    MessageBox.Show(" Please fill up all the information");
                    return;
                }
                string sql = "select * from UserInformation where Id = '" + this.txtUserId.Text + "' and Password = '" + this.txtPassword.Text + "';";
                  /* SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-T9FJPLU\\SQLEXPRESS;Initial Catalog=FoodCourtManagementSystem;User ID=sa;Password=RedwanIfty");
                    sqlcon.Open();
                    SqlCommand sqlcom = new SqlCommand(sql, sqlcon);
                    SqlDataAdapter sda = new SqlDataAdapter(sqlcom);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                   //  */           
                var ds= this.Da.ExecuteQuery(sql);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    this.ClearContent();
                    this.Hide();
                    MessageBox.Show("Login Valid" );
                   // string name = ds.Tables[0].Rows[0][1].ToString();f

                    if (ds.Tables[0].Rows[0][2].ToString() == "Owner")
                    {
                        OwnerForm owner = new OwnerForm(this);
                        owner.Show();
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString() == "Manager")
                    {
                        // member = new FormMember(this, name);
                        //member.Show();
                        ManagerForm manager = new ManagerForm(this);
                        manager.Show();
                    }
                    else if (ds.Tables[0].Rows[0][2].ToString() == "Salesman")
                    {
                        // member = new FormMember(this, name);
                        //member.Show();
                        SalesmanForm salesman = new SalesmanForm(this);
                        salesman.Show();
                    }

                }
                else
                {
                    MessageBox.Show("Login Invalid");
                    this.ClearContent();
                }
              //  sqlcon.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }
        private bool IsValidData()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrWhiteSpace(this.txtUserId.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void ClearContent()
        {
            this.txtUserId.Clear();
            this.txtPassword.Clear();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
        
        }

        
     }
}
