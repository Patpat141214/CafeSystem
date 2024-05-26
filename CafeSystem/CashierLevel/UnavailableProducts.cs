using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.CashierLevel
{
    public partial class UnavailableProducts : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Cashier frm;
        private readonly string search = "search here";
        public UnavailableProducts(Cashier frm1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            frm = frm1;
            dataGridUnavailable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            txtSearch.Text = "search here";
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void UnavProducts()
        {
            try
            {
                dataGridUnavailable.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.description, c.category, p.AvailOrNot, p.status from tblProduct as p INNER JOIN tblCategory as c on p.catid = c.id where p.AvailOrNot = 'Not Available' and p.status = 'Active'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridUnavailable.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), dr["AvailOrNot"].ToString());
                    dataGridUnavailable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                conn.Close();
                dr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
          
        }

        private void dataGridUnavailable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }
            string column = dataGridUnavailable.Columns[e.ColumnIndex].Name;
            string pid = dataGridUnavailable.Rows[e.RowIndex].Cells[1].Value.ToString();
            try
            {
                if (MessageBox.Show("Do you want to make this item available?", "Available item?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("UPDATE tblProduct set AvailOrNot = @avail where id = @id", conn);
                    cm.Parameters.AddWithValue("@id", pid);
                    cm.Parameters.AddWithValue("@avail", "Available");
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("The item is now available.", "Item Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.LoadData();                  
                    UnavProducts();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridUnavailable.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridUnavailable.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridUnavailable.CurrentCell = cell;
                            dataGridUnavailable.Rows[cell.RowIndex].Selected = true;
                            found = true;
                            break; // Break out of inner loop once a match is found
                        }
                    }

                    if (found)
                    {
                        break; // Break out of outer loop if a match is found
                    }
                }

                if (!found)
                {
                    dataGridUnavailable.ClearSelection();
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == search)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = search;
            txtSearch.ForeColor = Color.Black;
        }
    }
}
