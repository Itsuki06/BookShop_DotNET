using Microsoft.Data.SqlClient;
using System.Data;

namespace BookShop
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
            ShowData();
        }

        Connect connect = new Connect();
        float gridTotal = 0;
        int stock = 0;
        int key = 0;
        int n = 0;

        private void ShowData()
        {
            String query = "SELECT * FROM Books";

            using (SqlConnection conn = connect.GetConnection())
            {
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);
                dgvList.DataSource = ds.Tables[0];

                conn.Close();
            }
        }

        private void UpdateBook()
        {
            int newQty = stock - Convert.ToInt32(tbQuantity.Text);

            string query = "UPDATE Books SET BQty = " + newQty + " WHERE BId = " + key + ";";
            try
            {
                using (SqlConnection conn = connect.GetConnection())
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book Updated Successfully!");
                    ShowData();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            tbBookName.Text = "";
            tbQuantity.Text = "";
            tbClientName.Text = "";
            tbPrice.Text = "";

            key = 0; // Reset giá trị khóa
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbQuantity.Text == "" || Convert.ToInt32(tbQuantity.Text) > stock || Convert.ToInt32(tbQuantity.Text) == 0)
            {
                MessageBox.Show("No Enough Stock!");
            }
            else if (tbBookName.Text == "" || tbQuantity.Text == "" || tbClientName.Text == "" || tbPrice.Text == "")
            {
                MessageBox.Show("Info Missing!");
            }
            else
            {
                int quantity = Convert.ToInt32(tbQuantity.Text);
                float price;
                bool isValidPrice = float.TryParse(tbPrice.Text, out price);

                float total = quantity * price;

                DataGridViewRow newRow = new DataGridViewRow();        
                
                // Đảm bảo rằng các cột trong dgvBill đã được tạo
                if (dgvBill.Columns.Count == 0)
                {
                    dgvBill.Columns.Add("Column1", "ID");
                    dgvBill.Columns.Add("Column2", "Books");
                    dgvBill.Columns.Add("Column3", "Quantity");
                    dgvBill.Columns.Add("Column4", "Price");
                    dgvBill.Columns.Add("Column5", "Total");
                }

                newRow.CreateCells(dgvBill);

                newRow.Cells[0].Value = ++n;
                newRow.Cells[1].Value = tbBookName.Text;
                newRow.Cells[2].Value = tbQuantity.Text;
                newRow.Cells[3].Value = tbPrice.Text;
                newRow.Cells[4].Value = total;

                dgvBill.Rows.Add(newRow);

                UpdateBook();

                gridTotal = gridTotal + total;
                lblTotal.Text = "Total: " + gridTotal;

                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvList.SelectedRows.Count > 0) // Kiểm tra có hàng nào được chọn
            {

                tbBookName.Text = dgvList.SelectedRows[0].Cells[1].Value.ToString();
                tbQuantity.Text = dgvList.SelectedRows[0].Cells[4].Value.ToString();
                tbPrice.Text = dgvList.SelectedRows[0].Cells[5].Value.ToString();
                
                key = Convert.ToInt32(dgvList.SelectedRows[0].Cells[0].Value.ToString());
                stock = Convert.ToInt32(dgvList.SelectedRows[0].Cells[4].Value.ToString());
            }
            else
            {
                key = 0;
                stock = 0;
            }
        }
    }
}
