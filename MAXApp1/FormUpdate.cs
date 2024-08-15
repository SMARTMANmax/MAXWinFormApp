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
using System.Xml.Linq;

namespace MAXApp1
{
    public partial class FormUpdate : Form
    {
        // Employee 容器
        //itemsview item;
        private string connString;
        private itemsview item;
        private DatabaseManager dbManager;
        public FormUpdate(DatabaseManager dbManager, itemsview item, string connString)
        {
            InitializeComponent();
            this.item = item;
            InitializeFields();
            this.connString = connString;
            this.dbManager = dbManager;
        }
        private void InitializeFields()
        {
            dfID.Text = item.Id;
            dfName.Text = item.Name;
            dfDescription.Text = item.Description;
            dfMarketValue.Text = item.MarketValue.ToString();
            dfQuantity.Text = item.Quantity.ToString();
            dfType.Text = item.Type;
            dfID.ReadOnly = true;
        }
        // 建構子 constructor
        //internal FormUpdate(itemsview item)
        //{
        //  InitializeComponent();
        //  this.item = item;
        //  // 初始化資料
        //  this.dfID.Text = item.Id.ToString();
        //  this.dfName.Text = item.Name;
        //  this.dfDescription.Text = item.Description;
        //  this.dfMarketValue.Text = item.MarketValue.ToString();
        //  this.dfQuantity.Text = item.Quantity.ToString();
        //  this.dfType.Text = item.Type;
        //}

        private void pbQuit4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbItemsNewSave_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dfMarketValue.Text, out int marketValue))
            {
                MessageBox.Show("Market Value 必須是數字");
                dfMarketValue.Focus();
                return;
            }

            if (!int.TryParse(dfQuantity.Text, out int quantity))
            {
                MessageBox.Show("Quantity 必須是數字");
                dfQuantity.Focus();
                return;
            }
            // 獲取輸入的資料
            int id = int.Parse(dfID.Text);
            string name = dfName.Text;
            string description = dfDescription.Text;
            string type = dfType.Text;
            DateTime lastUpdated = DateTime.Now;

            // 保存項目
            SaveItem(id, name, description, marketValue, quantity, type, lastUpdated);

            // 關閉當前表單
            this.Close();
        }

        private void SaveItem(int id, string name, string description, int marketValue, int quantity, string type, DateTime lastUpdated)
        {
            // 獲取輸入的資料
            int inputId = int.Parse(dfID.Text);
            //string name = dfName.Text;
            //string description = dfDescription.Text;
            //string type = dfType.Text;
            //DateTime lastUpdated = DateTime.Now;

            //int id; // 這裡宣告一個新的變數 id，用於存儲最終的 ID

            //using (SqlConnection conn = new SqlConnection(connString)) 
            using (SqlConnection conn = dbManager.OpenConnection())
            {
                //conn.Open();

                // 檢查 ID 是否存在
                string checkQuery = "SELECT COUNT(*) FROM Items WHERE Id = @Id";
                SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@Id", inputId);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // 更新現有資料
                    string updateQuery = "UPDATE Items SET Name = @Name, Description = @Description, MarketValue = @MarketValue, Quantity = @Quantity, Type = @Type, LastUpdated = @LastUpdated WHERE Id = @Id";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@Id", inputId);
                    updateCmd.Parameters.AddWithValue("@Name", name);
                    updateCmd.Parameters.AddWithValue("@Description", description);
                    updateCmd.Parameters.AddWithValue("@MarketValue", marketValue);
                    updateCmd.Parameters.AddWithValue("@Quantity", quantity);
                    updateCmd.Parameters.AddWithValue("@Type", type);
                    updateCmd.Parameters.AddWithValue("@LastUpdated", lastUpdated);
                    updateCmd.ExecuteNonQuery();

                    id = inputId; // 如果更新資料，ID 保持不變
                }
                else
                {
                    // 新增資料，不插入 Id
                    string insertQuery = "INSERT INTO Items (Name, Description, MarketValue, Quantity, Type, LastUpdated) OUTPUT INSERTED.Id VALUES (@Name, @Description, @MarketValue, @Quantity, @Type, @LastUpdated)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.Parameters.AddWithValue("@Description", description);
                    insertCmd.Parameters.AddWithValue("@MarketValue", marketValue);
                    insertCmd.Parameters.AddWithValue("@Quantity", quantity);
                    insertCmd.Parameters.AddWithValue("@Type", type);
                    insertCmd.Parameters.AddWithValue("@LastUpdated", lastUpdated);
                    id = (int)insertCmd.ExecuteScalar(); // 獲取新插入記錄的 Id
                }

                conn.Close();
            }

            // 更新 dataGridViewItems
            if (Owner != null)
            {
                ((Form1)Owner).UpdateDataGridViewItems(id, name, description, marketValue, quantity, type, lastUpdated);
            }
            else
            {
                MessageBox.Show("Owner 未設定。無法更新 DataGridViewItems。");
            }

            // 關閉當前表單
            this.Close();
        }

        private void dfMarketValue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dfMarketValue.Text, out _))
            {
                MessageBox.Show("Market Value 必須是數字");
                dfMarketValue.Focus();
            }
        }

        private void dfQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(dfQuantity.Text, out _))
            {
                MessageBox.Show("Quantity 必須是數字");
                dfQuantity.Focus();
            }
        }
    }
}
