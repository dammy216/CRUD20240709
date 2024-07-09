namespace TrainCalcSystem
{
    partial class HistoryView
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.historyGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.buyBtn = new System.Windows.Forms.Button();
            this.toBuyHistoryBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.historyGV)).BeginInit();
            this.SuspendLayout();
            // 
            // historyGV
            // 
            this.historyGV.AllowUserToAddRows = false;
            this.historyGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.historyGV.Location = new System.Drawing.Point(174, 142);
            this.historyGV.Name = "historyGV";
            this.historyGV.ReadOnly = true;
            this.historyGV.RowTemplate.Height = 21;
            this.historyGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.historyGV.Size = new System.Drawing.Size(344, 186);
            this.historyGV.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "列車名";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "座席";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "運賃";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(174, 370);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 1;
            this.addBtn.Text = "追加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(424, 369);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "削除";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // buyBtn
            // 
            this.buyBtn.Location = new System.Drawing.Point(617, 159);
            this.buyBtn.Name = "buyBtn";
            this.buyBtn.Size = new System.Drawing.Size(75, 23);
            this.buyBtn.TabIndex = 3;
            this.buyBtn.Text = "購入";
            this.buyBtn.UseVisualStyleBackColor = true;
            this.buyBtn.Click += new System.EventHandler(this.buyBtn_Click);
            // 
            // toBuyHistoryBtn
            // 
            this.toBuyHistoryBtn.Location = new System.Drawing.Point(617, 233);
            this.toBuyHistoryBtn.Name = "toBuyHistoryBtn";
            this.toBuyHistoryBtn.Size = new System.Drawing.Size(75, 23);
            this.toBuyHistoryBtn.TabIndex = 4;
            this.toBuyHistoryBtn.Text = "購入履歴";
            this.toBuyHistoryBtn.UseVisualStyleBackColor = true;
            this.toBuyHistoryBtn.Click += new System.EventHandler(this.toBuyHistoryBtn_Click);
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toBuyHistoryBtn);
            this.Controls.Add(this.buyBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.historyGV);
            this.Name = "HistoryView";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.historyGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView historyGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button buyBtn;
        private System.Windows.Forms.Button toBuyHistoryBtn;
    }
}

