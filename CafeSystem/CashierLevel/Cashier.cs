using CafeSystem.CashierLevel;
using Guna.UI.WinForms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeSystem
{
    public partial class Cashier : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private PictureBox pic;
        private Label price;
        private Label name;
        private CheckBox checkBox;
        private GunaAdvenceButton button;
        public Cashier()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.KeyPreview = true;
            txtSearch.Text = "Search product here";
            lblDate.Text = DateTime.Now.ToLongDateString();
            txtCustomerName.Text = "Input customer name";
            txtOrderType.Text = "Dine In";
            this.Shown += Cashier_Shown;
            dataGridCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        public void getTrans()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");

                string transactno;
                int count;
                conn.Open();
                cm = new SqlCommand("select top 1 transacno from tblCart where transacno like '" + sdate + "%' order by id desc", conn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transactno = dr[0]?.ToString() ?? string.Empty;
                    count = int.Parse(transactno.Substring(8, 6));
                    lblTransu.Text = sdate + (count + 1);
                }
                else
                {
                    transactno = sdate + "100001";
                    lblTransu.Text = transactno;
                }
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        //public decimal ParseDecimalWithoutCurrencySymbol(object value)
        //{
        //    string stringValue = value?.ToString() ?? "0";
        //    stringValue = stringValue.Replace("₱", "").Replace(",", "").Trim();
        //    decimal decimalValue;
        //    if (decimal.TryParse(stringValue, out decimalValue))
        //    {
        //        return decimalValue;
        //    }
        //    return 0;
        //}
        public void LoadDataToGrid()
        {

            try
            {
                decimal total = 0;
                Boolean hasrow = false;
                dataGridCart.Rows.Clear();
                conn.Open();
                int i = 0;
                cm = new SqlCommand("SELECT * FROM tblCart where transacno like '" + lblTransu.Text + "' and status like 'Pending' order by ItemName", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    decimal totalValue = Convert.ToDecimal(dr["total"]);
                    total += totalValue;
                    dataGridCart.Rows.Add(i, dr["id"].ToString(), dr["ItemName"].ToString(), dr["qty"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), Convert.ToDecimal(dr["total"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")));
                    hasrow = true;
                    dataGridCart.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }

                conn.Close();
                dr.Close();
                lblTotalAmount.Text = "₱" + total.ToString("#,##0.00");
                lblTotalAmount1.Text = "₱" + total.ToString("#,##0.00");
                if (hasrow)
                {
                    btnClearCart.Enabled = true;
                    txtCustomerName.Enabled = false;
                    txtOrderType.Enabled = false;
                    btnPayment.Enabled = true;
                    btnApplyDiscount.Enabled = true;
                    btnRemoveDiscount.Enabled = true;

                }
                else
                {
                    btnClearCart.Enabled = false;
                    txtCustomerName.Enabled = true;
                    txtOrderType.Enabled = true;
                    lblDiscountedTotal.Visible = false;
                    lblDiscountAmount.Visible = false;
                    lblDiscountPercent.Visible = false;
                    btnPayment.Enabled = false;
                    btnApplyDiscount.Enabled = false;
                    btnRemoveDiscount.Enabled = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        public void LoadData(string searchKeyword = "")
        {

            try
            {
                flowLayoutPanel2.Controls.Clear();
                flowLayoutPanel1.Controls.Clear();
                conn.Open();
                cm = new SqlCommand("Select p.id, p.image, p.description, c.category, p.AvailOrNot, p.price from tblProduct as p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Active' and p.AvailOrNot = 'Available' and p.description like @searchQuery order by p.description", conn);
                cm.Parameters.AddWithValue("@searchQuery", "%" + searchKeyword + "%");
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    long len = dr.GetBytes(1, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(1, 0, array, 0, System.Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 200;
                    pic.Height = 200;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.Tag = dr["id"].ToString();

                    price = new Label();
                    price.Text = Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH"));
                    price.BackColor = Color.FromArgb(59, 68, 75);
                    price.ForeColor = Color.White;
                    price.Font = new Font("Consolas", 13, FontStyle.Bold);
                    price.Width = 85;
                    price.TextAlign = ContentAlignment.TopLeft;


                    checkBox = new CheckBox();
                    checkBox.Name = "checkedAv";
                    checkBox.Text = dr["AvailOrNot"].ToString();
                    checkBox.ForeColor = Color.White;
                    checkBox.Font = new Font("Consolas", 9, FontStyle.Bold);
                    checkBox.BackColor = Color.FromArgb(59, 68, 75);
                    checkBox.AutoSize = true;
                    // Calculate the location to place the checkbox at the top right, considering its width.
                    int checkBoxX = pic.Width - checkBox.Width - -13; // Adjust this value as needed
                    int checkBoxY = 0; // Adjust if you want it slightly lower
                    checkBox.Location = new Point(checkBoxX, checkBoxY);
                    checkBox.Tag = dr["id"].ToString();

                    name = new Label();
                    name.Text = dr["description"].ToString();
                    name.BackColor = Color.FromArgb(59, 68, 75);
                    name.ForeColor = Color.White;
                    name.Font = new Font("Roboto Mono", 10, FontStyle.Bold);
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    name.Dock = DockStyle.Bottom;


                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;

                    pic.Controls.Add(price);
                    pic.Controls.Add(name);
                    pic.Controls.Add(checkBox);

                    flowLayoutPanel1.Controls.Add(pic);

                    pic.Cursor = Cursors.Hand;

                    checkBox.Click += new EventHandler(onClickCheckBox);
                    pic.Click += new EventHandler(onClick);
                    //name.Click += new EventHandler(onClick);
                    //price.Click += new EventHandler(onClick);
                }
                conn.Close();
                dr.Close();

                conn.Open();
                cm = new SqlCommand("select * from tblCategory where status = 'Active'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    button = new GunaAdvenceButton();
                    button.Text = dr["category"].ToString();
                    button.BaseColor = Color.FromArgb(53, 56, 57);
                    button.ForeColor = Color.White;
                    button.Font = new Font("Consolas", 13, FontStyle.Bold);
                    button.Height = 37;
                    button.Width = 266;
                    button.OnHoverBaseColor = Color.FromArgb(35, 43, 43);
                    button.BorderColor = Color.FromArgb(53, 56, 57);
                    button.OnHoverBorderColor = Color.FromArgb(53, 56, 57);
                    button.OnHoverBorderColor = Color.Transparent;
                    button.Image = null;
                    button.TextAlign = HorizontalAlignment.Center;
                    flowLayoutPanel2.Controls.Add(button);
                    button.Click += new EventHandler(ShowCategoriesOnClick);
                    button.Cursor = Cursors.Hand;
                }
                conn.Close();
                dr.Close();


            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        public void ShowCategoriesOnClick(object sender, EventArgs e)
        {
            try
            {
                GunaAdvenceButton advanceClick = sender as GunaAdvenceButton;
                string tag = ((GunaAdvenceButton)sender).Text.ToString();
                flowLayoutPanel1.Controls.Clear();
                conn.Open();
                cm = new SqlCommand("Select p.id, p.image, p.description, c.category, p.AvailOrNot, p.price from tblProduct as p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Active' and p.AvailOrNot = 'Available' and c.category = @cat order by p.description", conn);
                cm.Parameters.AddWithValue("@cat", tag);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    long len = dr.GetBytes(1, 0, null, 0, 0);
                    byte[] array = new byte[System.Convert.ToInt32(len) + 1];
                    dr.GetBytes(1, 0, array, 0, System.Convert.ToInt32(len));
                    pic = new PictureBox();
                    pic.Width = 200;
                    pic.Height = 200;
                    pic.BackgroundImageLayout = ImageLayout.Stretch;
                    pic.BorderStyle = BorderStyle.FixedSingle;
                    pic.Tag = dr["id"].ToString();

                    price = new Label();
                    price.Text = Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH"));
                    price.BackColor = Color.FromArgb(59, 68, 75);
                    price.ForeColor = Color.White;
                    price.Font = new Font("Consolas", 13, FontStyle.Bold);
                    price.Width = 85;
                    price.TextAlign = ContentAlignment.TopLeft;


                    checkBox = new CheckBox();
                    checkBox.Name = "checkedAv";
                    checkBox.Text = dr["AvailOrNot"].ToString();
                    checkBox.ForeColor = Color.White;
                    checkBox.Font = new Font("Consolas", 9, FontStyle.Bold);
                    checkBox.BackColor = Color.FromArgb(59, 68, 75);
                    checkBox.AutoSize = true;
                    // Calculate the location to place the checkbox at the top right, considering its width.
                    int checkBoxX = pic.Width - checkBox.Width - -13; // Adjust this value as needed
                    int checkBoxY = 0; // Adjust if you want it slightly lower
                    checkBox.Location = new Point(checkBoxX, checkBoxY);
                    checkBox.Tag = dr["id"].ToString();

                    name = new Label();
                    name.Text = dr["description"].ToString();
                    name.BackColor = Color.FromArgb(59, 68, 75);
                    name.ForeColor = Color.White;
                    name.Font = new Font("Roboto Mono", 10, FontStyle.Bold);
                    name.TextAlign = ContentAlignment.MiddleCenter;
                    name.Dock = DockStyle.Bottom;


                    MemoryStream ms = new MemoryStream(array);
                    Bitmap bitmap = new Bitmap(ms);
                    pic.BackgroundImage = bitmap;

                    pic.Controls.Add(price);
                    pic.Controls.Add(name);
                    pic.Controls.Add(checkBox);

                    flowLayoutPanel1.Controls.Add(pic);

                    pic.Cursor = Cursors.Hand;

                    checkBox.Click += new EventHandler(onClickCheckBox);
                    pic.Click += new EventHandler(onClick);

                }
                dr.Close();
                conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
           
        }
    

        public void onClick(object sender, EventArgs e)
        {
            try
            {
                if (lblDiscountPercent.Visible == true)
                {
                    MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCustomerName.Text) || txtCustomerName.Text == "Input customer name")
                {
                    MessageBox.Show("Input customer name to proceed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string tag = ((PictureBox)sender).Tag.ToString();
                string item = ""; decimal price = 0;
                conn.Open();
                cm = new SqlCommand("select description, price from tblProduct where id = @id", conn);
                cm.Parameters.AddWithValue("@id", tag);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    item = dr["description"].ToString();
                    price = Convert.ToDecimal(dr["price"]);
                }
                conn.Close();
                dr.Close();            
                AddToCart add = new AddToCart(price, this);
                add.txtItem.Text = item;
                add.lblPid.Text = tag;
                add.ShowDialog();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void onClickCheckBox(object sender, EventArgs e)
        {
            
            try
            {
                CheckBox clickedCheckBox = sender as CheckBox; // Cast sender to CheckBox
                if (clickedCheckBox != null)
                {
                    if (MessageBox.Show("Do you want to make this product unavailable?", "Unavailable Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(dataGridCart.Rows.Count > 0)
                        {
                            MessageBox.Show("please remove the transaction first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            clickedCheckBox.Checked = false;
                            return;

                        }
                        conn.Open();
                        cm = new SqlCommand("UPDATE tblProduct SET AvailOrNot = @avail WHERE id = @id", conn);
                        cm.Parameters.AddWithValue("@avail", "Not Available");
                        cm.Parameters.AddWithValue("@id", clickedCheckBox.Tag);
                        cm.ExecuteNonQuery();
                        conn.Close();
                        LoadData();
                        MessageBox.Show("Product successfully removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    clickedCheckBox.Checked = false;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
         }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            if(dataGridCart.Rows.Count > 0)
            {
                MessageBox.Show("Unable to logout, please remove the transaction!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Do you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                LogInPage login = new LogInPage();
                login.ShowDialog();
            }
        }

        private void Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnLogout_Click(sender, e);
            }
            if (e.KeyCode == Keys.F6)
            {
                btnPendingOrders_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                LoadData();

            }
            if (e.KeyCode == Keys.F7)
            {
               btnNotAvailProducts_Click(sender, e);

            }
            if (e.KeyCode == Keys.F8)
            {
                btnTransaction_Click(sender, e);

            }
            if (e.KeyCode == Keys.F9)
            {
                btnPayment_Click(sender, e);
            }
            if (e.KeyCode == Keys.F10)
            {
                btnApplyDiscount_Click(sender, e);
            }
            if (e.KeyCode == Keys.F11)
            {
                btnRemoveDiscount_Click(sender, e);
            }


        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search product here")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = "Search product here";
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Focused)
            {
                LoadData(txtSearch.Text);
            }
        }

        private void Cashier_Shown(object sender, EventArgs e)
        {
          
            dataGridCart.BorderStyle = BorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }



        private void dataGridCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                decimal _currentPrice = decimal.Parse(dataGridCart.Rows[e.RowIndex].Cells[4].Value.ToString().Replace("₱", "").Replace(",", "").Trim());
                int qtyToAdd = int.Parse(lblQtyValue.Text);
                int currentQty = int.Parse(dataGridCart.Rows[e.RowIndex].Cells[3].Value.ToString());
                string _cartId = dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString();
                string _price = dataGridCart.Rows[e.RowIndex].Cells[4].Value.ToString();
                string _total = dataGridCart.Rows[e.RowIndex].Cells[5].Value.ToString();
                string _Qty = dataGridCart.Rows[e.RowIndex].Cells[3].Value.ToString();
                string _itemName = dataGridCart.Rows[e.RowIndex].Cells[2].Value.ToString();
                string column = dataGridCart.Columns[e.ColumnIndex].Name;
                if (column == "Delete")
                {
                    if (lblDiscountPercent.Visible == true)
                    {
                        MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show("Do you want to remove this product from the cart?", "Remove Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        conn.Open();
                        cm = new SqlCommand("Delete from tblCart where transacno = @transac and id = @id", conn);
                        cm.Parameters.AddWithValue("@transac", lblTransu.Text);
                        cm.Parameters.AddWithValue("@id", dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.ExecuteNonQuery();                       
                        conn.Close();
                        LoadDataToGrid();
                        MessageBox.Show("Item successfully removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if (column == "Edit")
                {
                    if (lblDiscountPercent.Visible == true)
                    {
                        MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    EditQtyCart edit = new EditQtyCart(this);
                    edit.txtQty.Text = _Qty;
                    edit.lblCartId.Text = _cartId;
                    edit.txtItem.Text = _itemName;
                    edit.txtPrice.Text = _price;
                    edit.txtTotal.Text = _total; 
                    edit.ShowDialog();
                    
                }
                else if (column == "Add")
                {
                    if (lblDiscountPercent.Visible == true)
                    {
                        MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    conn.Open();
                    cm = new SqlCommand("update tblCart set qty = qty + " + qtyToAdd + ", total = (qty + " + qtyToAdd + ") * " + _currentPrice + " where transacno like '" + lblTransu.Text + "' and id like '" + dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();                  
                    conn.Close();
                    LoadDataToGrid();
                }
                else if (column == "Minus")
                {
                    if (lblDiscountPercent.Visible == true)
                    {
                        MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (currentQty == 1)
                    {
                        MessageBox.Show("Can't reduce anymore, the minimum value is 1", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    conn.Open();
                    cm = new SqlCommand("update tblCart set qty = qty - " + qtyToAdd + ", total = (qty - " + qtyToAdd + ") * " + _currentPrice + " where transacno like '" + lblTransu.Text + "' and id like '" + dataGridCart.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    LoadDataToGrid();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
           
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to clear the cart?", "Remove Products from the cart?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("Delete from tblCart where transacno = @trans and status = 'Pending'", conn);
                    cm.Parameters.AddWithValue("@trans", lblTransu.Text);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    LoadDataToGrid();
                    MessageBox.Show("Items from the card remove successfully!", "Items Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getTrans();
                }              

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            if (txtCustomerName.Text == "Input customer name")
            {
                txtCustomerName.Text = "";
                txtCustomerName.ForeColor = Color.Black;
            }
        }
        private void btnPendingOrders_Click(object sender, EventArgs e)
        {
            PendingOrdersList pen = new PendingOrdersList(this);
            pen.LoadPendingOrders();
            pen.ShowDialog();
        }

        private void btnNotAvailProducts_Click(object sender, EventArgs e)
        {
            UnavailableProducts un = new UnavailableProducts(this);
            un.UnavProducts();
            un.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            viewTransactions view = new viewTransactions();
            view.loadTransactGroup();
            view.ShowDialog();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment(this);
            if(lblDiscountPercent.Visible == false)
            {
                pay.txtPercent.Text = "0.00";
                pay.txtDiscountAmount.Text = "₱0.00";
                pay.txtTotal.Text = lblTotalAmount.Text;
                pay.txtSubTotal.Text = lblTotalAmount.Text;

            }
            else if (lblDiscountPercent.Visible == true)
            {
                pay.txtPercent.Text = lblDiscountPercent.Text;
                pay.txtDiscountAmount.Text = lblDiscountAmount.Text;
                pay.txtTotal.Text = lblDiscountedTotal.Text;
                pay.txtSubTotal.Text = lblTotalAmount.Text;
            }
            pay.ShowDialog();
        }

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            if(dataGridCart.Rows.Count <= 0)
            {
                MessageBox.Show("Add product to the cart first!", "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lblDiscountPercent.Visible == false)
            {
                if (MessageBox.Show("Do you want to apply discount?", "Apply Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal discountAmount = 0;
                    decimal discountPercentage = 0;
                    conn.Open();
                    cm = new SqlCommand("select _discountPercent from tblDiscount where _status = 'Active' and id = 1", conn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        discountPercentage = Convert.ToDecimal(dr["_discountPercent"]);
                    }
                    conn.Close();
                    dr.Close();

                    decimal totalamoun = decimal.Parse(lblTotalAmount.Text.Replace("₱", "").Replace(",", "").Trim());

                    discountAmount = totalamoun * discountPercentage / 100m;
                    totalamoun -= discountAmount;
                    //lblTotalAmount.Text = "₱" + totalamoun.ToString("#,##0.00");
                    lblTotalAmount1.Text = "₱" + totalamoun.ToString("#,##0.00");
                    lblDiscountedTotal.Text = "₱" + totalamoun.ToString("#,##0.00");
                    lblDiscountAmount.Text = "₱" + discountAmount.ToString("#,##0.00");
                    lblDiscountPercent.Text = discountPercentage.ToString("0.##") + "%";
                    lblDiscountedTotal.Visible = true;
                    lblDiscountPercent.Visible = true;
                    lblDiscountAmount.Visible = true;
                }
            }
            else if (lblDiscountPercent.Visible == true)
            {
                MessageBox.Show("Discount already applied!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
       

            //lblDiscountedTotal.Visible = tru;
            //lblDiscountPercent.Visible = false;
            //lblDiscountAmount.Text = "₱0.00";


        }

        private void btnRemoveDiscount_Click(object sender, EventArgs e)
        {
            if (lblDiscountPercent.Visible == true)
            {
                if (MessageBox.Show("Do you want to remove discount?", "Remove Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lblDiscountedTotal.Visible = false;
                    lblDiscountAmount.Visible = false;
                    lblDiscountPercent.Visible = false;
                    LoadDataToGrid();
                }
            }
            else
            {
                MessageBox.Show("No discount applied!", "Discount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
