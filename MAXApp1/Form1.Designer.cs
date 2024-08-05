namespace MAXApp1
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
            pbQuit3 = new Button();
            pbitemsDel = new Button();
            pbitemsUpdate = new Button();
            pbitemsNew = new Button();
            pbItemsSelect = new Button();
            dataGridViewItems = new DataGridView();
            pbConnect = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).BeginInit();
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
            tabControl1.Size = new Size(854, 450);
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
            tabPage1.Size = new Size(846, 417);
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
            tabPage2.Size = new Size(846, 417);
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
            tabPage3.Controls.Add(pbQuit3);
            tabPage3.Controls.Add(pbitemsDel);
            tabPage3.Controls.Add(pbitemsUpdate);
            tabPage3.Controls.Add(pbitemsNew);
            tabPage3.Controls.Add(pbItemsSelect);
            tabPage3.Controls.Add(dataGridViewItems);
            tabPage3.Controls.Add(pbConnect);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(846, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "資料庫連結";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pbQuit3
            // 
            pbQuit3.Location = new Point(660, 30);
            pbQuit3.Name = "pbQuit3";
            pbQuit3.Size = new Size(120, 45);
            pbQuit3.TabIndex = 10;
            pbQuit3.Text = "離開";
            pbQuit3.UseVisualStyleBackColor = true;
            pbQuit3.Click += pbQuit3_Click;
            // 
            // pbitemsDel
            // 
            pbitemsDel.Location = new Point(529, 33);
            pbitemsDel.Name = "pbitemsDel";
            pbitemsDel.Size = new Size(109, 42);
            pbitemsDel.TabIndex = 5;
            pbitemsDel.Text = "刪除";
            pbitemsDel.UseVisualStyleBackColor = true;
            pbitemsDel.Click += pbitemsDel_Click;
            // 
            // pbitemsUpdate
            // 
            pbitemsUpdate.Location = new Point(403, 33);
            pbitemsUpdate.Name = "pbitemsUpdate";
            pbitemsUpdate.Size = new Size(109, 42);
            pbitemsUpdate.TabIndex = 4;
            pbitemsUpdate.Text = "修改";
            pbitemsUpdate.UseVisualStyleBackColor = true;
            pbitemsUpdate.Click += pbitemsUpdate_Click_1;
            // 
            // pbitemsNew
            // 
            pbitemsNew.Location = new Point(278, 33);
            pbitemsNew.Name = "pbitemsNew";
            pbitemsNew.Size = new Size(109, 42);
            pbitemsNew.TabIndex = 3;
            pbitemsNew.Text = "新增";
            pbitemsNew.UseVisualStyleBackColor = true;
            pbitemsNew.Click += pbitemsNew_Click;
            // 
            // pbItemsSelect
            // 
            pbItemsSelect.Location = new Point(152, 33);
            pbItemsSelect.Name = "pbItemsSelect";
            pbItemsSelect.Size = new Size(109, 42);
            pbItemsSelect.TabIndex = 2;
            pbItemsSelect.Text = "查詢";
            pbItemsSelect.UseVisualStyleBackColor = true;
            pbItemsSelect.Click += pbItemsSelect_Click;
            // 
            // dataGridViewItems
            // 
            dataGridViewItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewItems.Location = new Point(18, 110);
            dataGridViewItems.Name = "dataGridViewItems";
            dataGridViewItems.Size = new Size(808, 277);
            dataGridViewItems.TabIndex = 1;
            // 
            // pbConnect
            // 
            pbConnect.Location = new Point(37, 33);
            pbConnect.Name = "pbConnect";
            pbConnect.Size = new Size(109, 42);
            pbConnect.TabIndex = 0;
            pbConnect.Text = "資料庫連接";
            pbConnect.UseVisualStyleBackColor = true;
            pbConnect.Visible = false;
            pbConnect.Click += pbConnect_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewItems).EndInit();
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
    }
}
