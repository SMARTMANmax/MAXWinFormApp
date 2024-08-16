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
                List<item> items = new List<item>();
                for (var i = 1; i < lines.Length; i++)
                {
                    var splidate = lines[i].Split(",");
                    item item = new item();
                    item.Name = splidate[0];
                    item.Type = splidate[1];
                    item.Description = splidate[2];
                    item.MarketValue = splidate[3];
                    item.Quantity = splidate[4];
                    items.Add(item);
                }
                dataGridFileDate.DataSource = items;
            }

        }

    }
}
