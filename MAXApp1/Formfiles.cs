using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAXApp1
{
    public partial class Formfiles : Form
    {
        // 物品陣列
        List<item> items = new List<item>();
        public Formfiles()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            //開啟檔案
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            var resuit = openFileDialog.ShowDialog();
            if (resuit == DialogResult.OK)
            {
                labFileName.Text = openFileDialog.FileName;
                string[] lines = File.ReadAllLines(openFileDialog.FileName);
                listBoxFIleData.Items.Clear();
                foreach (var item in lines)
                {
                    listBoxFIleData.Items.Add(item);
                }
                //List<item> items = new List<item>();
                for (var i = 0; i < lines.Length; i++)
                {
                    // 跳過第0個
                    if (i == 0)
                    {
                        continue; // continue可以跳過這一圈，直接進入下一圈
                    }
                    var splidate = lines[i].Split(",");
                    item item = new item();
                    item.Name = splidate[0];
                    item.Type = splidate[1];
                    item.Description = splidate[2];
                    item.MarketValue = splidate[3];
                    item.Quantity = splidate[4];
                    items.Add(item); // 把建立好的 item 加到 items 陣列
                }
                dataGridFileData.DataSource = items;
            }

        }

    }
}
