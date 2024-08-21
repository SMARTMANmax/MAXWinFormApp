using Dapper;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MAXApp1
{
    public partial class Form1 : Form
    {
        public string ConnString { get; set; }
        // 宣告 DatabaseManager 物件
        public DatabaseManager dbManager;
        private BindingList<itemsview> itemsList = new BindingList<itemsview>();
        private List<itemsview> itemsListForSorting = new List<itemsview>();
        private System.Windows.Forms.SortOrder sortOrder = System.Windows.Forms.SortOrder.Ascending; // 或初始為 Descending
        public Form1()
        {
            InitializeComponent();
            //ConnString = "Server=localhost;Database=BL;User Id=SYSADM;Password=SYSADM;"; 
            //ConnString = "Server=192.168.1.9;Database=_SMARTMANTEST;User Id=SYSADM;Password=SYSADM;";
            // 初始化 DatabaseManager
            dbManager = new DatabaseManager("localhost", "BL", "SYSADM", "SYSADM");
            //dbManager = new DatabaseManager("192.168.1.9", "_SMARTMANTEST", "SYSADM", "SYSADM");
            // 註冊 SelectedIndexChanged 事件
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.Load += new EventHandler(Form1_Load);
            dataGridViewItems.ColumnHeaderMouseDoubleClick += dataGridViewItems_ColumnHeaderMouseDoubleClick;
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
            //dataGridView1.DataSource = items;
            // 初始化 DataGridView 的資料源
            dataGridViewItems.DataSource = itemsList;
            // 3. 清空 dataGridView1 中的資料，但保留列設置
            dataGridViewItems.Rows.Clear();
            // 假設有方法從資料庫中獲取 items 並初始化 itemsList
            LoadItemsFromDatabase();
        }

        public void LoadItemsFromDatabase()
        {
            //using (SqlConnection conn = new SqlConnection(ConnString))
            using (SqlConnection conn = dbManager.OpenConnection())
            {

                // 從資料庫中查詢資料
                var items = conn.Query<itemsview>("SELECT * FROM Items").ToList();

                // 清空 itemsListForSorting 並重新加載資料
                itemsListForSorting.Clear();
                itemsListForSorting.AddRange(items);

                // 清空 BindingList 並重新加載資料
                itemsList.Clear();
                foreach (var item in items)
                {
                    itemsList.Add(item);
                }

                dataGridViewItems.Columns["Id"].HeaderText = "ID";
                dataGridViewItems.Columns["Name"].HeaderText = "名稱";
                dataGridViewItems.Columns["Description"].HeaderText = "描述";
                dataGridViewItems.Columns["MarketValue"].HeaderText = "市場價值";
                dataGridViewItems.Columns["Quantity"].HeaderText = "數量";
                dataGridViewItems.Columns["Type"].HeaderText = "類型";
                dataGridViewItems.Columns["LastUpdated"].HeaderText = "最後更新";
            }
            dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewItems.AllowUserToAddRows = false;
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
                //conn.ConnectionString = "Server=192.168.1.9;Database=_SMARTMANTEST;User Id=SYSADM;Password=SYSADM;";
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
                //// 執行連接資料庫的程式碼
                LoadItemsFromDatabase();
                // 自動調整欄位寬度
                dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            }
        }

        private void pbItemsSelect_Click(object sender, EventArgs e)
        {
            LoadItemsFromDatabase();
            //// set so whole row is selected 讓整行被選取
            //dataGridViewItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        private void pbitemsUpdate_Click_1(object sender, EventArgs e)
        {
            // 將 e 轉換為 DataGridViewCellEventArgs
            DataGridViewCellEventArgs cellEventArgs = e as DataGridViewCellEventArgs;

            // 檢查轉換是否成功
            if (cellEventArgs != null)
            {
                // 檢查是否是標題行
                if (cellEventArgs.RowIndex == -1)
                {
                    // 如果是標題行，則不執行後續邏輯
                    return;
                }
            }
            ItemUpdater updater = new ItemUpdater(this.dbManager);
            updater.UpdateSelectedItem(dataGridViewItems, this);
        }
        public void UpdateDataGridViewItems(int id, string name, string description, int marketValue, int quantity, string type, DateTime lastUpdated)
        {
            BindingList<itemsview> itemsList;

            // 檢查 DataSource 是否為 BindingList<itemsview>
            if (dataGridViewItems.DataSource is BindingList<itemsview> bindingList)
            {
                itemsList = bindingList;
            }
            // 如果 DataSource 是 List<itemsview>，則轉換為 BindingList<itemsview>
            else if (dataGridViewItems.DataSource is List<itemsview> list)
            {
                itemsList = new BindingList<itemsview>(list);
            }
            else
            {
                // 若 DataSource 是其他類型，則初始化一個新的 BindingList<itemsview>
                itemsList = new BindingList<itemsview>();
            }

            // 尋找是否已存在相同的 Id
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
            // 重新設定欄位標題
            dataGridViewItems.Columns["Id"].HeaderText = "ID";
            dataGridViewItems.Columns["Name"].HeaderText = "名稱";
            dataGridViewItems.Columns["Description"].HeaderText = "描述";
            dataGridViewItems.Columns["MarketValue"].HeaderText = "市場價值";
            dataGridViewItems.Columns["Quantity"].HeaderText = "數量";
            dataGridViewItems.Columns["Type"].HeaderText = "類型";
            dataGridViewItems.Columns["LastUpdated"].HeaderText = "最後更新";

            // 自動調整欄位寬度
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }
        private void pbQuit3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbitemsNew_Click(object sender, EventArgs e)
        {
            SqlConnection conn = dbManager.OpenConnection();
            string query = "SELECT IDENT_CURRENT('items') + IDENT_INCR('items')";
            int newId = conn.Query<int>(query).Single();
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
            FormUpdate formUpdate = new FormUpdate(this.dbManager, item)
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
                // 使用 Dapper 刪除資料庫中的資料
                using (SqlConnection conn = dbManager.OpenConnection())
                {
                    string deleteQuery = "DELETE FROM Items WHERE Id = @Id";
                    conn.Execute(deleteQuery, new { Id = selectedId });
                }

                // 刪除 BindingList 中的資料
                var itemToRemove = itemsList.FirstOrDefault(item => item.Id == selectedId.ToString());
                if (itemToRemove != null)
                {
                    itemsList.Remove(itemToRemove);
                }

                MessageBox.Show("刪除成功！");
            }
        }

        //private void dataGridViewItems_ColumnDividerDoubleClick(object sender, DataGridViewColumnDividerDoubleClickEventArgs e)
        //{

        //}

        private void dataGridViewItems_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // 獲取點擊的欄位名稱
            //string sortColumn = dataGridViewItems.Columns[e.ColumnIndex].Name;

            //// 獲取當前的排序方向
            //System.Windows.Forms.SortOrder sortOrder = dataGridViewItems.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection;
            //string sortDirection = sortOrder == System.Windows.Forms.SortOrder.Ascending ? "DESC" : "ASC";

            //// 更新排序圖標方向
            //dataGridViewItems.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = sortOrder == System.Windows.Forms.SortOrder.Ascending ? System.Windows.Forms.SortOrder.Descending : System.Windows.Forms.SortOrder.Ascending;

            //// 使用 Dapper 從資料庫中重新查詢並排序
            //using (SqlConnection conn = dbManager.OpenConnection())
            //{
            //    string query = $"SELECT * FROM Items ORDER BY {sortColumn} {sortDirection}";
            //    var items = conn.Query<itemsview>(query).ToList();

            //    // 將查詢結果綁定到 dataGridViewItems
            //    dataGridViewItems.DataSource = new BindingList<itemsview>(items);
            //}
            string sortColumn = dataGridViewItems.Columns[e.ColumnIndex].Name;

            // 切換排序順序
            if (sortOrder == System.Windows.Forms.SortOrder.Ascending)
            {
                sortOrder = System.Windows.Forms.SortOrder.Descending;
                itemsListForSorting = itemsListForSorting.OrderByDescending(item => item.GetType().GetProperty(sortColumn).GetValue(item, null)).ToList();
            }
            else
            {
                sortOrder = System.Windows.Forms.SortOrder.Ascending;
                itemsListForSorting = itemsListForSorting.OrderBy(item => item.GetType().GetProperty(sortColumn).GetValue(item, null)).ToList();
            }

            // 將排序後的列表轉換為 BindingList
            itemsList = new BindingList<itemsview>(itemsListForSorting);

            // 更新 dataGridViewItems 的顯示
            dataGridViewItems.DataSource = null; // 取消繫結
            dataGridViewItems.DataSource = itemsList; // 重新繫結
            dataGridViewItems.Columns["Id"].HeaderText = "ID";
            dataGridViewItems.Columns["Name"].HeaderText = "名稱";
            dataGridViewItems.Columns["Description"].HeaderText = "描述";
            dataGridViewItems.Columns["MarketValue"].HeaderText = "市場價值";
            dataGridViewItems.Columns["Quantity"].HeaderText = "數量";
            dataGridViewItems.Columns["Type"].HeaderText = "類型";
            dataGridViewItems.Columns["LastUpdated"].HeaderText = "最後更新";
            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }

        private void dfSerch_TextChanged(object sender, EventArgs e)
        {
            string searchText = dfSerch.Text.ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // 如果搜尋框為空，恢復原始資料
                dataGridViewItems.DataSource = itemsListForSorting;
            }
            else
            {
                // 進行篩選
                var filteredList = itemsListForSorting
                    .Where(item => item.GetType().GetProperties()
                        .Any(prop => prop.GetValue(item, null) != null &&
                                     prop.GetValue(item, null).ToString().ToLower().Contains(searchText)))
                    .ToList();

                // 更新 DataSource 為篩選後的列表
                dataGridViewItems.DataSource = new BindingList<itemsview>(filteredList);
            }
        }

        private void dataGridViewItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 檢查是否是標題行
            if (e.RowIndex == -1)
            {
                // 如果是標題行，則不執行後續邏輯
                return;
            }
            ItemUpdater updater = new ItemUpdater(this.dbManager);
            updater.UpdateSelectedItem(dataGridViewItems, this);
        }
        public void ShowTabPage(int index)
        {
            tabControl1.SelectedIndex = index;
        }

        private void pbitemsDel2_Click(object sender, EventArgs e)
        {
            // 檢查是否有選取資料
            if (dataGridViewItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("請選擇至少一個項目");
                return;
            }

            // 確認刪除
            DialogResult result = MessageBox.Show($"確定要刪除選中的 {dataGridViewItems.SelectedRows.Count} 筆資料嗎？", "確認刪除", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = dbManager.OpenConnection())
                {
                    // 開始交易
                    using (var transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            // 遍歷選中的每一行
                            foreach (DataGridViewRow selectedRow in dataGridViewItems.SelectedRows)
                            {
                                // 取得選中的行的 Id 值
                                int selectedId;
                                if (!int.TryParse(selectedRow.Cells["Id"].Value.ToString(), out selectedId))
                                {
                                    MessageBox.Show("選取的項目無效");
                                    return;
                                }

                                // 使用 Dapper 刪除資料庫中的資料
                                string deleteQuery = "DELETE FROM Items WHERE Id = @Id";
                                conn.Execute(deleteQuery, new { Id = selectedId }, transaction);

                                //// 刪除 itemsListForSorting 中的資料
                                var itemToRemove = itemsListForSorting.FirstOrDefault(item => item.Id == selectedId.ToString());
                                if (itemToRemove != null)
                                {
                                    itemsListForSorting.Remove(itemToRemove);
                                }
                            }

                            // 提交交易
                            transaction.Commit();
                            // 更新 DataGridView
                            dataGridViewItems.DataSource = null;
                            dataGridViewItems.DataSource = itemsListForSorting;
                            dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                            MessageBox.Show("刪除成功！");
                            
                        }
                        catch (Exception ex)
                        {
                            // 如果有錯誤，回滾交易
                            transaction.Rollback();
                            MessageBox.Show($"刪除失敗: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void pbImport1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                List<itemsview> items = new List<itemsview>();

                using (SqlConnection conn = dbManager.OpenConnection())
                {
                   
                    for (var i = 1; i < lines.Length; i++)
                    {
                        var splitData = lines[i].Split(',');
                        // 跳過表頭或 "名稱" 開頭的行
                        if (splitData[0] == "名稱")
                        {
                            continue;
                        }

                        int nextId = conn.QuerySingle<int>("SELECT IDENT_CURRENT('items') + IDENT_INCR('items')");

                        itemsview item = new itemsview
                        {
                            Id = nextId++.ToString(),
                            Name = splitData[0],
                            Type = splitData[1],    
                            Description = splitData[4],
                            MarketValue = Convert.ToInt32(splitData[2]),
                            Quantity = Convert.ToInt32(splitData[3]),
                            LastUpdated = DateTime.Now
                        };


                        conn.Execute(@"INSERT INTO Items (Name, Type, Description, MarketValue, Quantity, LastUpdated) 
                               VALUES (@Name, @Type, @Description, @MarketValue, @Quantity, @LastUpdated)",
                            new
                                {
                                Name = item.Name,
                                Type = item.Type,
                                Description = item.Description,
                                MarketValue = item.MarketValue,
                                Quantity = item.Quantity,
                                LastUpdated = DateTime.Now
                                });

                        items.Add(item);
                    }
                }

                // 更新 DataGridView
                itemsListForSorting.AddRange(items);
                dataGridViewItems.DataSource = null;
                dataGridViewItems.DataSource = itemsListForSorting;
                dataGridViewItems.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
        }
    }
}



