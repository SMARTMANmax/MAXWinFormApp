namespace MAXApp1
{
    partial class Formfiles
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            listBoxFIleData = new ListBox();
            tabPage2 = new TabPage();
            dataGridFileData = new DataGridView();
            panel1 = new Panel();
            pbChangeForm1 = new Button();
            labFileName = new Label();
            pbCreateFile = new Button();
            buttonOpenFile = new Button();
            tableLayoutPanel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridFileData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AccessibleName = "d";
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.Controls.Add(tabControl1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 103);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(794, 344);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(listBoxFIleData);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(786, 316);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "原始內容";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxFIleData
            // 
            listBoxFIleData.Dock = DockStyle.Fill;
            listBoxFIleData.FormattingEnabled = true;
            listBoxFIleData.ItemHeight = 15;
            listBoxFIleData.Location = new Point(3, 3);
            listBoxFIleData.Name = "listBoxFIleData";
            listBoxFIleData.Size = new Size(780, 310);
            listBoxFIleData.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridFileData);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(786, 316);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "表格顯示";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridFileData
            // 
            dataGridFileData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridFileData.Dock = DockStyle.Fill;
            dataGridFileData.Location = new Point(3, 3);
            dataGridFileData.Name = "dataGridFileData";
            dataGridFileData.Size = new Size(780, 310);
            dataGridFileData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pbChangeForm1);
            panel1.Controls.Add(labFileName);
            panel1.Controls.Add(pbCreateFile);
            panel1.Controls.Add(buttonOpenFile);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(794, 94);
            panel1.TabIndex = 1;
            // 
            // pbChangeForm1
            // 
            pbChangeForm1.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            pbChangeForm1.Location = new Point(364, 24);
            pbChangeForm1.Name = "pbChangeForm1";
            pbChangeForm1.Size = new Size(133, 44);
            pbChangeForm1.TabIndex = 3;
            pbChangeForm1.Text = "切換視窗";
            pbChangeForm1.UseVisualStyleBackColor = true;
            pbChangeForm1.Click += pbChangeForm1_Click;
            // 
            // labFileName
            // 
            labFileName.AutoSize = true;
            labFileName.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            labFileName.Location = new Point(25, 70);
            labFileName.Name = "labFileName";
            labFileName.Size = new Size(86, 24);
            labFileName.TabIndex = 2;
            labFileName.Text = "檔案路徑";
            // 
            // pbCreateFile
            // 
            pbCreateFile.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            pbCreateFile.Location = new Point(201, 24);
            pbCreateFile.Name = "pbCreateFile";
            pbCreateFile.Size = new Size(133, 44);
            pbCreateFile.TabIndex = 1;
            pbCreateFile.Text = "產出按鈕";
            pbCreateFile.UseVisualStyleBackColor = true;
            pbCreateFile.Click += pbCreateFile_Click;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Font = new Font("微軟正黑體", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            buttonOpenFile.Location = new Point(25, 24);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(142, 44);
            buttonOpenFile.TabIndex = 0;
            buttonOpenFile.Text = "讀取檔案";
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // Formfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Formfiles";
            Text = "Formfiles";
            tableLayoutPanel1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridFileData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Button pbCreateFile;
        private Button buttonOpenFile;
        private Label labFileName;
        private ListBox listBoxFIleData;
        private DataGridView dataGridFileData;
        private Button pbChangeForm1;
    }
}