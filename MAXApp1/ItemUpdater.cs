using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAXApp1
{
    internal class ItemUpdater
    {
        private DatabaseManager dbManager;
        //private string connString;

        public ItemUpdater(DatabaseManager dbManager)
        {
            this.dbManager = dbManager;
        }

        public void UpdateSelectedItem(DataGridView dataGridViewItems, Form owner)
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

                FormUpdate formUpdate = new FormUpdate(dbManager, item)
                {
                    Owner = owner // 設定 Owner 為傳入的 Form
                };
                formUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("請選擇一個項目");
            }
        }
    }
}
