﻿namespace MAXApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            btQuit = new Button();
            btSave = new Button();
            dfIDNumber = new TextBox();
            dfBirthday = new TextBox();
            dfChineseName = new TextBox();
            dfEmployeCd = new TextBox();
            lbIDNumber = new Label();
            lbBirthday = new Label();
            lbChineseName = new Label();
            lbEmployeCd = new Label();
            tabPage2 = new TabPage();
            btQuit2 = new Button();
            pbImport = new Button();
            dataGridView1 = new DataGridView();
            colEmployeCd = new DataGridViewTextBoxColumn();
            colChineseName = new DataGridViewTextBoxColumn();
            coBirthday = new DataGridViewTextBoxColumn();
            colIDNumber = new DataGridViewTextBoxColumn();
            tabPage3 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pbItemsSelect = new Button();
            pbitemsNew = new Button();
            pbitemsUpdate = new Button();
            pbitemsDel = new Button();
            pbitemsDel2 = new Button();
            pbQuit3 = new Button();
            pbConnect = new Button();
            dataGridViewItems = new DataGridView();
            flowLayoutPanel2 = new FlowLayoutPanel();
            lbSerch = new Label();
            dfSerch = new TextBox();
            pbImport1 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(991, 617);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Controls.Add(btQuit);
            tabPage1.Controls.Add(btSave);
            tabPage1.Controls.Add(dfIDNumber);
            tabPage1.Controls.Add(dfBirthday);
            tabPage1.Controls.Add(dfChineseName);
            tabPage1.Controls.Add(dfEmployeCd);
            tabPage1.Controls.Add(lbIDNumber);
            tabPage1.Controls.Add(lbBirthday);
            tabPage1.Controls.Add(lbChineseName);
            tabPage1.Controls.Add(lbEmployeCd);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(983, 584);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "資料建檔";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Location = new Point(335, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(378, 115);
            tableLayoutPanel1.TabIndex = 5;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // btQuit
            // 
            btQuit.Location = new Point(175, 240);
            btQuit.Name = "btQuit";
            btQuit.Size = new Size(120, 45);
            btQuit.TabIndex = 9;
            btQuit.Text = "離開";
            btQuit.UseVisualStyleBackColor = true;
            btQuit.Click += btQuit_Click;
            // 
            // btSave
            // 
            btSave.Location = new Point(29, 240);
            btSave.Name = "btSave";
            btSave.Size = new Size(120, 45);
            btSave.TabIndex = 8;
            btSave.Text = "存檔";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // dfIDNumber
            // 
            dfIDNumber.Location = new Point(175, 183);
            dfIDNumber.Name = "dfIDNumber";
            dfIDNumber.Size = new Size(100, 29);
            dfIDNumber.TabIndex = 7;
            // 
            // dfBirthday
            // 
            dfBirthday.Location = new Point(175, 136);
            dfBirthday.Name = "dfBirthday";
            dfBirthday.Size = new Size(100, 29);
            dfBirthday.TabIndex = 6;
            // 
            // dfChineseName
            // 
            dfChineseName.Location = new Point(175, 94);
            dfChineseName.Name = "dfChineseName";
            dfChineseName.Size = new Size(100, 29);
            dfChineseName.TabIndex = 5;
            // 
            // dfEmployeCd
            // 
            dfEmployeCd.Location = new Point(175, 52);
            dfEmployeCd.Name = "dfEmployeCd";
            dfEmployeCd.Size = new Size(100, 29);
            dfEmployeCd.TabIndex = 4;
            // 
            // lbIDNumber
            // 
            lbIDNumber.AutoSize = true;
            lbIDNumber.Location = new Point(29, 183);
            lbIDNumber.Name = "lbIDNumber";
            lbIDNumber.Size = new Size(73, 20);
            lbIDNumber.TabIndex = 3;
            lbIDNumber.Text = "身分證號";
            // 
            // lbBirthday
            // 
            lbBirthday.AutoSize = true;
            lbBirthday.Location = new Point(29, 136);
            lbBirthday.Name = "lbBirthday";
            lbBirthday.Size = new Size(41, 20);
            lbBirthday.TabIndex = 2;
            lbBirthday.Text = "生日";
            // 
            // lbChineseName
            // 
            lbChineseName.AutoSize = true;
            lbChineseName.Location = new Point(29, 94);
            lbChineseName.Name = "lbChineseName";
            lbChineseName.Size = new Size(73, 20);
            lbChineseName.TabIndex = 1;
            lbChineseName.Text = "中文姓名";
            // 
            // lbEmployeCd
            // 
            lbEmployeCd.AutoSize = true;
            lbEmployeCd.Location = new Point(29, 52);
            lbEmployeCd.Name = "lbEmployeCd";
            lbEmployeCd.Size = new Size(73, 20);
            lbEmployeCd.TabIndex = 0;
            lbEmployeCd.Text = "員工編號";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btQuit2);
            tabPage2.Controls.Add(pbImport);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(983, 584);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "資料維護";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btQuit2
            // 
            btQuit2.Location = new Point(54, 161);
            btQuit2.Name = "btQuit2";
            btQuit2.Size = new Size(151, 44);
            btQuit2.TabIndex = 10;
            btQuit2.Text = "離開";
            btQuit2.UseVisualStyleBackColor = true;
            btQuit2.Click += btQuit2_Click;
            // 
            // pbImport
            // 
            pbImport.Location = new Point(54, 85);
            pbImport.Name = "pbImport";
            pbImport.Size = new Size(151, 47);
            pbImport.TabIndex = 1;
            pbImport.Text = "轉入";
            pbImport.UseVisualStyleBackColor = true;
            pbImport.Click += pbImport_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colEmployeCd, colChineseName, coBirthday, colIDNumber });
            dataGridView1.Location = new Point(278, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(446, 300);
            dataGridView1.TabIndex = 0;
            // 
            // colEmployeCd
            // 
            colEmployeCd.HeaderText = "員工編號";
            colEmployeCd.Name = "colEmployeCd";
            // 
            // colChineseName
            // 
            colChineseName.HeaderText = "中文姓名";
            colChineseName.Name = "colChineseName";
            // 
            // coBirthday
            // 
            coBirthday.HeaderText = "生日";
            coBirthday.Name = "coBirthday";
            // 
            // colIDNumber
            // 
            colIDNumber.HeaderText = "身分證號";
            colIDNumber.Name = "colIDNumber";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel2);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(983, 584);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "資料庫連結";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridViewItems, 0, 2);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(983, 584);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pbItemsSelect);
            flowLayoutPanel1.Controls.Add(pbitemsNew);
            flowLayoutPanel1.Controls.Add(pbitemsUpdate);
            flowLayoutPanel1.Controls.Add(pbitemsDel);
            flowLayoutPanel1.Controls.Add(pbitemsDel2);
            flowLayoutPanel1.Controls.Add(pbImport1);
            flowLayoutPanel1.Controls.Add(pbQuit3);
            flowLayoutPanel1.Controls.Add(pbConnect);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(977, 51);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pbItemsSelect
            // 
            pbItemsSelect.Location = new Point(3, 3);
            pbItemsSelect.Name = "pbItemsSelect";
            pbItemsSelect.Size = new Size(109, 42);
            pbItemsSelect.TabIndex = 2;
            pbItemsSelect.Text = "查詢";
            pbItemsSelect.UseVisualStyleBackColor = true;
            pbItemsSelect.Click += pbItemsSelect_Click;
            // 
            // pbitemsNew
            // 
            pbitemsNew.Location = new Point(118, 3);
            pbitemsNew.Name = "pbitemsNew";
            pbitemsNew.Size = new Size(109, 42);
            pbitemsNew.TabIndex = 3;
            pbitemsNew.Text = "新增";
            pbitemsNew.UseVisualStyleBackColor = true;
            pbitemsNew.Click += pbitemsNew_Click;
            // 
            // pbitemsUpdate
            // 
            pbitemsUpdate.Location = new Point(233, 3);
            pbitemsUpdate.Name = "pbitemsUpdate";
            pbitemsUpdate.Size = new Size(109, 42);
            pbitemsUpdate.TabIndex = 4;
            pbitemsUpdate.Text = "修改";
            pbitemsUpdate.UseVisualStyleBackColor = true;
            pbitemsUpdate.Click += pbitemsUpdate_Click_1;
            // 
            // pbitemsDel
            // 
            pbitemsDel.Location = new Point(348, 3);
            pbitemsDel.Name = "pbitemsDel";
            pbitemsDel.Size = new Size(109, 42);
            pbitemsDel.TabIndex = 5;
            pbitemsDel.Text = "刪除";
            pbitemsDel.UseVisualStyleBackColor = true;
            pbitemsDel.Click += pbitemsDel_Click;
            // 
            // pbitemsDel2
            // 
            pbitemsDel2.Location = new Point(463, 3);
            pbitemsDel2.Name = "pbitemsDel2";
            pbitemsDel2.Size = new Size(109, 42);
            pbitemsDel2.TabIndex = 11;
            pbitemsDel2.Text = "多筆刪除";
            pbitemsDel2.UseVisualStyleBackColor = true;
            pbitemsDel2.Click += pbitemsDel2_Click;
            // 
            // pbQuit3
            // 
            pbQuit3.Location = new Point(693, 3);
            pbQuit3.Name = "pbQuit3";
            pbQuit3.Size = new Size(120, 45);
            pbQuit3.TabIndex = 10;
            pbQuit3.Text = "離開";
            pbQuit3.UseVisualStyleBackColor = true;
            pbQuit3.Click += pbQuit3_Click;
            // 
            // pbConnect
            // 
            pbConnect.Location = new Point(819, 3);
            pbConnect.Name = "pbConnect";
            pbConnect.Size = new Size(109, 42);
            pbConnect.TabIndex = 0;
            pbConnect.Text = "資料庫連接";
            pbConnect.UseVisualStyleBackColor = true;
            pbConnect.Visible = false;
            pbConnect.Click += pbConnect_Click;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(3, 110);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.Size = new Size(977, 470);
            dataGridViewItems.TabIndex = 1;
            dataGridViewItems.CellDoubleClick += dataGridViewItems_CellDoubleClick;
            dataGridViewItems.ColumnHeaderMouseDoubleClick += dataGridViewItems_ColumnHeaderMouseDoubleClick;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(lbSerch);
            flowLayoutPanel2.Controls.Add(dfSerch);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(3, 60);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(977, 44);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // lbSerch
            // 
            lbSerch.AutoSize = true;
            lbSerch.Location = new Point(3, 0);
            lbSerch.Name = "lbSerch";
            lbSerch.Size = new Size(73, 20);
            lbSerch.TabIndex = 11;
            lbSerch.Text = "篩選內容";
            // 
            // dfSerch
            // 
            dfSerch.Location = new Point(82, 3);
            dfSerch.Name = "dfSerch";
            dfSerch.Size = new Size(109, 29);
            dfSerch.TabIndex = 12;
            dfSerch.TextChanged += dfSerch_TextChanged;
            // 
            // pbImport1
            // 
            pbImport1.Location = new Point(578, 3);
            pbImport1.Name = "pbImport1";
            pbImport1.Size = new Size(109, 42);
            pbImport1.TabIndex = 12;
            pbImport1.Text = "多筆轉入";
            pbImport1.UseVisualStyleBackColor = true;
            pbImport1.Click += pbImport1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 617);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label lbIDNumber;
        private Label lbBirthday;
        private Label lbChineseName;
        private Label lbEmployeCd;
        private TextBox dfIDNumber;
        private TextBox dfBirthday;
        private TextBox dfChineseName;
        private TextBox dfEmployeCd;
        private Button btSave;
        private Button btQuit;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colEmployeCd;
        private DataGridViewTextBoxColumn colChineseName;
        private DataGridViewTextBoxColumn coBirthday;
        private DataGridViewTextBoxColumn colIDNumber;
        private Button pbImport;
        private Button btQuit2;
        private TabPage tabPage3;
        private Button pbConnect;
        private DataGridView dataGridViewItems;
        private Button pbItemsSelect;
        private Button pbitemsNew;
        private Button pbitemsDel;
        private Button pbitemsUpdate;
        private Button pbQuit3;
        private Label lbSerch;
        private TextBox dfSerch;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button pbitemsDel2;
        private Button pbImport1;
    }
}
