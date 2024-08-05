namespace MAXApp1
{
    partial class FormUpdate
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
            dfID = new TextBox();
            lbID = new Label();
            lbName = new Label();
            dfName = new TextBox();
            dfDescription = new TextBox();
            lbDescription = new Label();
            dfMarketValue = new TextBox();
            lbMarketValue = new Label();
            dfQuantity = new TextBox();
            lbQuantity = new Label();
            dfType = new TextBox();
            lbType = new Label();
            pbItemsNewSave = new Button();
            pbQuit4 = new Button();
            SuspendLayout();
            // 
            // dfID
            // 
            dfID.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfID.Location = new Point(197, 43);
            dfID.Name = "dfID";
            dfID.Size = new Size(182, 29);
            dfID.TabIndex = 0;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbID.Location = new Point(50, 43);
            lbID.Name = "lbID";
            lbID.Size = new Size(26, 20);
            lbID.TabIndex = 1;
            lbID.Text = "ID";
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbName.Location = new Point(50, 93);
            lbName.Name = "lbName";
            lbName.Size = new Size(73, 20);
            lbName.TabIndex = 2;
            lbName.Text = "物品名稱";
            // 
            // dfName
            // 
            dfName.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfName.Location = new Point(197, 90);
            dfName.Name = "dfName";
            dfName.Size = new Size(182, 29);
            dfName.TabIndex = 3;
            // 
            // dfDescription
            // 
            dfDescription.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfDescription.Location = new Point(197, 139);
            dfDescription.Name = "dfDescription";
            dfDescription.Size = new Size(182, 29);
            dfDescription.TabIndex = 5;
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbDescription.Location = new Point(50, 142);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(73, 20);
            lbDescription.TabIndex = 4;
            lbDescription.Text = "物品描述";
            // 
            // dfMarketValue
            // 
            dfMarketValue.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfMarketValue.Location = new Point(197, 197);
            dfMarketValue.Name = "dfMarketValue";
            dfMarketValue.Size = new Size(182, 29);
            dfMarketValue.TabIndex = 7;
            // 
            // lbMarketValue
            // 
            lbMarketValue.AutoSize = true;
            lbMarketValue.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbMarketValue.Location = new Point(50, 200);
            lbMarketValue.Name = "lbMarketValue";
            lbMarketValue.Size = new Size(41, 20);
            lbMarketValue.TabIndex = 6;
            lbMarketValue.Text = "價值";
            // 
            // dfQuantity
            // 
            dfQuantity.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfQuantity.Location = new Point(197, 249);
            dfQuantity.Name = "dfQuantity";
            dfQuantity.Size = new Size(182, 29);
            dfQuantity.TabIndex = 9;
            // 
            // lbQuantity
            // 
            lbQuantity.AutoSize = true;
            lbQuantity.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbQuantity.Location = new Point(50, 252);
            lbQuantity.Name = "lbQuantity";
            lbQuantity.Size = new Size(41, 20);
            lbQuantity.TabIndex = 8;
            lbQuantity.Text = "數量";
            // 
            // dfType
            // 
            dfType.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            dfType.Location = new Point(197, 301);
            dfType.Name = "dfType";
            dfType.Size = new Size(182, 29);
            dfType.TabIndex = 11;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            lbType.Location = new Point(50, 304);
            lbType.Name = "lbType";
            lbType.Size = new Size(73, 20);
            lbType.TabIndex = 10;
            lbType.Text = "物品種類";
            // 
            // pbItemsNewSave
            // 
            pbItemsNewSave.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            pbItemsNewSave.Location = new Point(50, 359);
            pbItemsNewSave.Name = "pbItemsNewSave";
            pbItemsNewSave.Size = new Size(105, 60);
            pbItemsNewSave.TabIndex = 12;
            pbItemsNewSave.Text = "存檔";
            pbItemsNewSave.UseVisualStyleBackColor = true;
            pbItemsNewSave.Click += pbItemsNewSave_Click;
            // 
            // pbQuit4
            // 
            pbQuit4.Font = new Font("微軟正黑體", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            pbQuit4.Location = new Point(197, 359);
            pbQuit4.Name = "pbQuit4";
            pbQuit4.Size = new Size(105, 60);
            pbQuit4.TabIndex = 13;
            pbQuit4.Text = "離開";
            pbQuit4.UseVisualStyleBackColor = true;
            pbQuit4.Click += pbQuit4_Click;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 472);
            Controls.Add(pbQuit4);
            Controls.Add(pbItemsNewSave);
            Controls.Add(dfType);
            Controls.Add(lbType);
            Controls.Add(dfQuantity);
            Controls.Add(lbQuantity);
            Controls.Add(dfMarketValue);
            Controls.Add(lbMarketValue);
            Controls.Add(dfDescription);
            Controls.Add(lbDescription);
            Controls.Add(dfName);
            Controls.Add(lbName);
            Controls.Add(lbID);
            Controls.Add(dfID);
            Name = "FormUpdate";
            Text = "Items新增";
            ResumeLayout(false);
            PerformLayout();
            // 其他初始化代碼
            this.dfMarketValue.TextChanged += new System.EventHandler(this.dfMarketValue_TextChanged);
            this.dfQuantity.TextChanged += new System.EventHandler(this.dfQuantity_TextChanged);
            this.pbItemsNewSave.Click += new System.EventHandler(this.pbItemsNewSave_Click);
        }

        #endregion

        private TextBox dfID;
        private Label lbID;
        private Label lbName;
        private TextBox dfName;
        private TextBox dfDescription;
        private Label lbDescription;
        private TextBox dfMarketValue;
        private Label lbMarketValue;
        private TextBox dfQuantity;
        private Label lbQuantity;
        private TextBox dfType;
        private Label lbType;
        private Button pbItemsNewSave;
        private Button pbQuit4;
    }
}