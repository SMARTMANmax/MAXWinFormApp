using Dapper;
using Microsoft.Win32.SafeHandles;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;

namespace MAXApp1
{
    public partial class Form1 : Form
    {
        public string ConnString { get; set; }
        private BindingList<itemsview> itemsList = new BindingList<itemsview>();
        public Form1()
        {
            InitializeComponent();
            ConnString = "Server=localhost;Database=BL;User Id=SYSADM;Password=SYSADM;";
            // 註冊 SelectedIndexChanged 事件
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.Load += new EventHandler(Form1_Load);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // 設置表頭
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            tableLayoutPanel1.Controls.Add(new Label() { Text = "員工編號", Font = new Font("Arial", 10, FontStyle.Bold) }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "中文姓名", Font = new Font("Arial", 10, FontStyle.Bold) }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "生日", Font = new Font("Arial", 10, FontStyle.Bold) }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "身分證號", Font = new Font("Arial", 10, FontStyle.Bold) }, 3, 0);

            // 設置邊框樣式
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            // 根據需要設置 TableLayoutPanel 的其他屬性
            tableLayoutPanel1.AutoSize = true;
            //tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowOnly;
            // 模擬數據加載
            //List<itemsview> items = new List<itemsview>
        //{
        //    new itemsview { Id = "1", Name = "Item1", Description = "Description1", MarketValue = 100, Quantity = 10, Type = "Type1", LastUpdated = DateTime.Now },
        //   new itemsview { Id = "2", Name = "Item2", Description = "Description2", MarketValue = 200, Quantity = 20, Type = "Type2", LastUpdated = DateTime.Now }
        //};

            //dataGridView1.DataSource = items;
            // 初始化 DataGridView 的資料源
            dataGridViewItems.DataSource = itemsList;
            // 3. 清空 dataGridView1 中的資料，但保留列設置
            dataGridViewItems.Rows.Clear();
            // 假設有方法從資料庫中獲取 items 並初始化 itemsList
            LoadItemsFromDatabase();
        }

        private void LoadItemsFromDatabase()
        {
            using (SqlConnection conn = new SqlConnection(ConnString))
            {

                //  dataGridView1 中的資料，但保留列設置
                dataGridViewItems.Rows.Clear();
                conn.Open();
                var items = conn.Query<itemsview>("SELECT * FROM Items").ToList();

                foreach (var item in items)
                {
                    itemsList.Add(item);
                }
                conn.Close();
                dataGridViewItems.Columns["Id"].HeaderText = "ID";
                dataGridViewItems.Columns["Name"].HeaderText = "名稱";
                dataGridViewItems.Columns["Description"].HeaderText = "描述";
                dataGridViewItems.Columns["MarketValue"].HeaderText = "市場價值";
                dataGridViewItems.Columns["Quantity"].HeaderText = "數量";
                dataGridViewItems.Columns["Type"].HeaderText = "類型";
                dataGridViewItems.Columns["LastUpdated"].HeaderText = "最後更新";
            }
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void btQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btSave_Click(object sender, EventArgs e)
        {

            // 獲取輸入資料
            string employeCd = dfEmployeCd.Text;
            string chineseName = dfChineseName.Text;
            string birthday = dfBirthday.Text;
            string idNumber = dfIDNumber.Text;

            // 計算新的行索引
            int newRowIndex = tableLayoutPanel1.RowCount;

            // 增加新的行
            //tableLayoutPanel1.RowCount += 1;
            tableLayoutPanel1.RowCount = tableLayoutPanel1.RowCount + 1;
            // 調整行高樣式確保每行高度一致
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / tableLayoutPanel1.RowCount));
            }

            // 添加資料到新的行
            tableLayoutPanel1.Controls.Add(new Label() { Text = employeCd }, 0, newRowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = chineseName }, 1, newRowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = birthday }, 2, newRowIndex);
            tableLayoutPanel1.Controls.Add(new Label() { Text = idNumber }, 3, newRowIndex);

            // 顯示成功訊息
            MessageBox.Show("存檔成功！");

            // 清空文本框
            dfEmployeCd.Text = string.Empty;
            dfChineseName.Text = string.Empty;
            dfBirthday.Text = string.Empty;
            dfIDNumber.Text = string.Empty;
        }

        private void pbImport_Click(object sender, EventArgs e)
        {
            // 暫停 dataGridView1 的佈局
            dataGridView1.SuspendLayout();

            try
            {
                // 1. 從 tableLayoutPanel1 中讀取資料
                List<string[]> data = new List<string[]>();

                for (int row = 1; row < tableLayoutPanel1.RowCount; row++)
                {
                    List<string> rowData = new List<string>();
                    bool isEmptyRow = true;

                    for (int col = 0; col < tableLayoutPanel1.ColumnCount; col++)
                    {
                        Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
                        if (control != null)
                        {
                            rowData.Add(control.Text);
                            isEmptyRow = false;
                        }
                        else
                        {
                            rowData.Add(string.Empty); // 如果控件為空，添加空字串
                        }
                    }

                    if (!isEmptyRow)
                    {
                        data.Add(rowData.ToArray());
                    }
                }

                // 2. 根據第一個欄位排序
                var sortedData = data.OrderBy(row => row[0]).ToArray();

                // 3. 清空 dataGridView1 中的資料，但保留列設置
                dataGridView1.Rows.Clear();

                // 4. 添加排序後的資料到 dataGridView1
                foreach (var row in sortedData)
                {
                    dataGridView1.Rows.Add(row);
                }
            }
            finally
            {
                // 恢復 dataGridView1 的佈局
                dataGridView1.ResumeLayout();
            }
        }
        private void btQuit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbConnect_Click(object sender, EventArgs e)
        {
            try
            {
                // 測試是否可以連到資料庫
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Server=localhost;Database=BL;User Id=SYSADM;Password=SYSADM;";
                this.ConnString = conn.ConnectionString;
                EmployeeService.ConnString = conn.ConnectionString;
                // 可以或失敗都跳出訊息
                conn.Open();
                MessageBox.Show("連線成功!");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("發生錯誤: " + ex.Message + "哪裡錯?" + ex.StackTrace);
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 檢查是否選中了 tabPage3
            if (tabControl1.SelectedTab == tabPage3)
            {
                // 執行連接資料庫的程式碼
                ConnectToDatabase();
            }
        }
        private void ConnectToDatabase()
        {
            try
            {
                //SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = "Server=localhost;Database=BL;User Id=SYSADM;Password=SYSADM";
                //this.ConnString = conn.ConnectionString;
                //EmployeeService.ConnString = conn.ConnectionString;
                //conn.Open(); // 嘗試打開連接
                //////MessageBox.Show("連接成功");
                //conn.Close(); // 關閉連接
                //LoadItemsFromDatabase();
                // 自動調整欄位寬度
                dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"連接失敗: {ex.Message}");
            }
        }

        private void pbItemsSelect_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = ConnString;
            //conn.Open();
            //List<itemsview> items = new List<itemsview>();
            //items = conn.Query<itemsview>("Select * From items").ToList();
            //conn.Close();
            //dataGridViewItems.DataSource = items;
            //// 設定欄位表頭
            //if (dataGridViewItems.Columns.Count > 0)
            //{
            //    dataGridViewItems.Columns["Id"].HeaderText = "ID";
            //    dataGridViewItems.Columns["Name"].HeaderText = "名稱";
            //    dataGridViewItems.Columns["Description"].HeaderText = "描述";
            //    dataGridViewItems.Columns["MarketValue"].HeaderText = "市場價值";
            //    dataGridViewItems.Columns["Quantity"].HeaderText = "數量";
            //    dataGridViewItems.Columns["Type"].HeaderText = "類型";
            //    dataGridViewItems.Columns["LastUpdated"].HeaderText = "最後更新";
            //    // 自動調整欄位寬度
            //    dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            //}
            LoadItemsFromDatabase();
            //// set so whole row is selected 讓整行被選取
            //dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void pbitemsUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewItems.SelectedRows[0];

                itemsview item = new itemsview
                {
                    Id = selectedRow.Cells["Id"].Value.ToString(),
                    Name = selectedRow.Cells["Name"].Value.ToString(),
                    Description = selectedRow.Cells["Description"].Value.ToString(),
                    MarketValue = Convert.ToInt32(selectedRow.Cells["MarketValue"].Value),
                    Quantity = Convert.ToInt32(selectedRow.Cells["Quantity"].Value),
                    Type = selectedRow.Cells["Type"].Value.ToString(),
                    LastUpdated = Convert.ToDateTime(selectedRow.Cells["LastUpdated"].Value)
                };
                FormUpdate formUpdate = new FormUpdate(item, ConnString)
                {
                    Owner = this
                };
                formUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇一個項目");
            }
        }
        public void UpdateDataGridViewItems(int id, string name, string description, int marketValue, int quantity, string type, DateTime lastUpdated)
        {
            BindingList<itemsview> itemsList = (BindingList<itemsview>)dataGridViewItems.DataSource;
            var existingItem = itemsList.FirstOrDefault(item => item.Id == id.ToString());

            if (existingItem != null)
            {
                // 更新現有行
                existingItem.Name = name;
                existingItem.Description = description;
                existingItem.MarketValue = marketValue;
                existingItem.Quantity = quantity;
                existingItem.Type = type;
                existingItem.LastUpdated = lastUpdated;
            }
            else
            {
                // 新增行
                itemsList.Add(new itemsview
                {
                    Id = id.ToString(),
                    Name = name,
                    Description = description,
                    MarketValue = marketValue,
                    Quantity = quantity,
                    Type = type,
                    LastUpdated = lastUpdated
                });
             }

            // 重新綁定 DataGridView 以顯示最新資料
            dataGridViewItems.DataSource = null;
            dataGridViewItems.DataSource = itemsList;
            // 自動調整欄位寬度
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
        private void pbQuit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbitemsNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConnString);
            conn.Open();

            // 獲取當前 items 表中最大 Id
            //string query = "SELECT ISNULL(MAX(Id), 0) + 1 FROM Items";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //int newId = (int)cmd.ExecuteScalar();
            // 獲取下個要顯示的 Id
            string query = "SELECT IDENT_CURRENT('items') + IDENT_INCR('items')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int newId = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Close();

            // 創建新的 itemsview 實例，並設置新的 Id
            itemsview item = new itemsview
            {
                Id = newId.ToString(),
                Name = string.Empty,
                Description = string.Empty,
                MarketValue = 0,
                Quantity = 0,
                Type = string.Empty,
                LastUpdated = DateTime.Now
            };

            // 打開 FormUpdate 並傳遞 newItem 和 ConnString
            FormUpdate formUpdate = new FormUpdate(item, ConnString)
            {
                Owner = this
            };
            formUpdate.ShowDialog();
        }

        private void pbitemsDel_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取資料
            if (dataGridViewItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇一個項目");
                return;
            }

            // 獲取選中的行
            DataGridViewRow selectedRow = dataGridViewItems.SelectedRows[0];

            // 取得選中的行的 Id 值
            int selectedId;
            if (!int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out selectedId))
            {
                MessageBox.Show("選取的項目無效");
                return;
            }

            // 確認刪除
            DialogResult result = MessageBox.Show($"確定要刪除 Id 為 {selectedId} 的資料嗎？", "確認刪除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // 刪除資料庫中的資料
                using (SqlConnection conn = new SqlConnection(ConnString))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Items WHERE Id = @Id";
                    SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                    deleteCmd.Parameters.AddWithValue("@Id", selectedId);
                    deleteCmd.ExecuteNonQuery();
                    conn.Close();
                }

                // 刪除 DataGridView 中的資料
                //dataGridViewItems.Rows.Remove(selectedRow);
                // 刪除 BindingList 中的資料
                var itemToRemove = itemsList.FirstOrDefault(item => item.Id == selectedId.ToString());
                if (itemToRemove != null)
                {
                    itemsList.Remove(itemToRemove);
                }
                MessageBox.Show("刪除成功！");
            }
        }
    }

}



