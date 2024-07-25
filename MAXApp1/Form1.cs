namespace MAXApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }

}


