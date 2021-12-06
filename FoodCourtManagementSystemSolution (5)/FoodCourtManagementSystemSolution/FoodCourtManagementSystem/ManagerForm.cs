using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodCourtManagementSystem
{
    public partial class ManagerForm : Form
    {
        private LoginForm Fl { get; set; }
        private DataAccess Da { get; set; }

        public ManagerForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            //this.FoodInfo();
       
        }
        public ManagerForm(LoginForm f1):this()
        {
            //InitializeComponent();
            this.Fl = f1;
        }

        private void ManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closing App");
            Application.Exit();
        }
     /*   private void FoodInfo(string sql = "select * from FoodInfo")
        {
            var ds = this.Da.ExecuteQuery(sql);
            this.lblLebon.Text = ds.Tables[0].Rows[0][1].ToString();
            this.lblLebonPrice.Text = ds.Tables[0].Rows[0][2].ToString();
            this.lblPasta.Text = ds.Tables[0].Rows[1][1].ToString();
            this.lblPastaPrice.Text = ds.Tables[0].Rows[1][2].ToString();
            this.lblIceCreame.Text = ds.Tables[0].Rows[2][1].ToString();
            this.lblIceCreamePrice.Text = ds.Tables[0].Rows[2][2].ToString();
            this.lblFrices.Text = ds.Tables[0].Rows[3][1].ToString();
            this.lblFricePrice.Text = ds.Tables[0].Rows[3][2].ToString();
            this.lblBurger.Text = ds.Tables[0].Rows[4][1].ToString();
            this.lblBurgerPrice.Text = ds.Tables[0].Rows[4][2].ToString();
            this.lblChikenPot.Text = ds.Tables[0].Rows[5][1].ToString();
            this.lblChikenPotPrice.Text = ds.Tables[0].Rows[5][2].ToString();
            this.lblChi.Text = ds.Tables[0].Rows[6][1].ToString();
            this.lblBreadPrice.Text = ds.Tables[0].Rows[6][2].ToString();

        }*/
       /* private void ClearQuantity()
        {
            this.cmbLebonQuantity.Text = "0";
            this.cmbPastaQuantity.Text = "0";
            this.cmbIceCreameQuantity.Text = "0";
            this.cmbFricesQuantity.Text = "0";
            this.cmbBurgerQuantity.Text = "0";
            this.cmbChikenQuantity.Text = "0";
            this.cmbBreadQuantity.Text = "0";


            this.lblBillAmount.Text = " ";
        }

        */


       /* private void btnbill_Click(object sender, EventArgs e)
        {
            double totalBill;
            totalBill = (Convert.ToDouble(this.cmbLebonQuantity.Text)) * (Convert.ToDouble(this.lblLebonPrice.Text)) + (Convert.ToDouble(this.cmbPastaQuantity.Text)) * (Convert.ToDouble(this.lblPastaPrice.Text))
                + (Convert.ToDouble(this.cmbIceCreameQuantity.Text)) * (Convert.ToDouble(this.lblIceCreamePrice.Text)) + (Convert.ToDouble(this.cmbFricesQuantity.Text)) * (Convert.ToDouble(this.lblFricePrice.Text)) +
                (Convert.ToDouble(this.cmbBurgerQuantity.Text)) * (Convert.ToDouble(this.lblBurgerPrice.Text))
                + (Convert.ToDouble(this.cmbChikenQuantity.Text)) * (Convert.ToDouble(this.lblChikenPotPrice.Text)) + (Convert.ToDouble(this.cmbBreadQuantity.Text)) * (Convert.ToDouble(this.lblBreadPrice.Text));

            //MessageBox.Show("Total bill is "+total.ToString()+" Tk");
            /// 
            this.lblBillAmount.Text = totalBill.ToString() + " Tk";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearQuantity();
        }
        */
        private void btnLogout_Click(object sender, EventArgs e)
        {

            this.Hide();
            MessageBox.Show("Log Out Complete");
            this.Fl.Show();
        }

        private void btnfoodSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from FoodInfo where FoodName = '" + this.txtSearch.Text + "';";
                this.PopulateGridViewFood(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        
        }
        private void PopulateGridViewFood(string sql = "select * from FoodInfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvFoodInfo.AutoGenerateColumns = false;
            this.dgvFoodInfo.DataSource = ds.Tables[0];
        }

        private void btnClearFoodInfo_Click(object sender, EventArgs e)
        {
            this.txtSearch.Clear();
        }

        private void btnShowFoodInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridViewFood();

        }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from UserInformation where UserName like'" + this.txtSalesmanName.Text + "%' or id like'" + this.txtId + "%';";
            this.PopulateGridView(sql);

        }
        private void PopulateGridView(string sql = "select * from UserInformation where Role='Salesman';")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvUserInfo.AutoGenerateColumns = false;
            this.dgvUserInfo.DataSource = ds.Tables[0];
        }

        private void dgvUserInfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtSalesmanName.Text = this.dgvUserInfo.CurrentRow.Cells["UserName"].Value.ToString();
            this.txtId.Text = this.dgvUserInfo.CurrentRow.Cells["Id"].Value.ToString();
            this.txtRole.Text = this.dgvUserInfo.CurrentRow.Cells["Role"].Value.ToString();
            this.txtPassword.Text = this.dgvUserInfo.CurrentRow.Cells["Password"].Value.ToString();
            this.txtCity.Text = this.dgvUserInfo.CurrentRow.Cells["City"].Value.ToString();
            this.txtCountry.Text = this.dgvUserInfo.CurrentRow.Cells["Country"].Value.ToString();
            this.txtSalary.Text = this.dgvUserInfo.CurrentRow.Cells["Salary"].Value.ToString();
            this.dtpJoinningDate.Text = this.dgvUserInfo.CurrentRow.Cells["JoinningDate"].Value.ToString();
       
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvUserInfo.CurrentRow.Cells[1].Value.ToString();
                var name = this.dgvUserInfo.CurrentRow.Cells[0].Value.ToString();

                var sql = "delete from UserInformation where Id = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }
        private bool IsValidToSaveEmployeeData()
        {
            if (String.IsNullOrEmpty(this.txtSalesmanName.Text) || String.IsNullOrEmpty(this.txtId.Text) ||
                String.IsNullOrEmpty(this.txtRole.Text) || String.IsNullOrEmpty(this.txtPassword.Text) ||
                String.IsNullOrEmpty(this.txtCity.Text) || String.IsNullOrEmpty(this.txtCountry.Text) ||
                String.IsNullOrEmpty(this.txtSalary.Text) || String.IsNullOrWhiteSpace(this.txtId.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnSaveEmployeeInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveEmployeeData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from UserInformation where  Id= '" + this.txtId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update UserInformation set UserName='" + this.txtSalesmanName.Text + "',Role ='" + this.txtRole.Text + "',Password=" + this.txtPassword.Text + ",City='" + this.txtCity.Text + "',Country='" + this.txtCountry.Text + "',JoinningDate='" + this.dtpJoinningDate.Text + "' where Id='" + this.txtId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into UserInformation values ('" + this.txtSalesmanName.Text + "','" + this.txtId.Text + "','" + this.txtRole.Text + "'," + this.txtPassword.Text + ",'" + this.txtCity.Text + "','" + this.txtCountry.Text + "'," + this.txtSalary.Text + ",'" + this.dtpJoinningDate.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.RefreshEmployeeContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

        }
        private void RefreshEmployeeContent()
        {
            this.txtSalesmanName.Clear();
            this.txtId.Clear();
            this.txtRole.Clear();
            this.txtPassword.Text = "";
            this.txtCity.Clear();
            this.txtCountry.Clear();
            this.txtSalary.Clear();
            this.dtpJoinningDate.Text = "";
        }

        private void btnClearEmployeeInfo_Click(object sender, EventArgs e)
        {
            this.RefreshEmployeeContent();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Log Out Successful");
            this.Fl.Show();
        }

        private void btnShowDailySales_Click(object sender, EventArgs e)
        {
            this.PopulateGridViewDailySales();
        }
        private void PopulateGridViewDailySales(string sql = "select * from DailySales;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvDailySales.AutoGenerateColumns = false;
            this.dgvDailySales.DataSource = ds.Tables[0];
        }

        private void btnShowMonthlySales_Click(object sender, EventArgs e)
        {
            this.PopulateGridViewMonthlySales();
        }
        private void PopulateGridViewMonthlySales(string sql = "select * from MonthlySales;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvMonthlySales.AutoGenerateColumns = false;
            this.dgvMonthlySales.DataSource = ds.Tables[0];


        }
        
      
    }
}
