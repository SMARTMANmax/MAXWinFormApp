using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

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
                dataGridFileData.DataSource = items;// 把 items 顯示在 grid 上面
            }

        }

        private void pbCreateFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            var result = saveFileDialog.ShowDialog();
            List<string> lines = new List<string>();
            if (result == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                lines.Add("名稱,種類,價值,數量,描述");
                foreach (var item in items)
                {
                    string singleLineData = item.Name + "," + item.Type + "," + item.MarketValue + "," + item.Quantity.ToString() + "," + item.Description;
                    lines.Add(singleLineData);
                }
                File.WriteAllLines(fileName, lines, Encoding.UTF8);
                MessageBox.Show("儲存到" + fileName + "了");

                ProcessStartInfo processStartInfo = new ProcessStartInfo()
                {
                    FileName = fileName,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
            }


        }

        private void pbChangeForm1_Click(object sender, EventArgs e)
        {
            // 創建新的 Form1 實例
            Form1 form1 = new Form1();

            // 顯示 Form1 的 tabPage3
            form1.ShowTabPage(2); // 假設 tabPage3 是第三個 tabPage，索引從 0 開始

            // 顯示 Form1 視窗
            form1.Show();

            // 隱藏當前視窗
            this.Hide();
        }
    }
}
