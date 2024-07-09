namespace TrainCalcSystem
{
    partial class AddView
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
            this.trainCB = new System.Windows.Forms.ComboBox();
            this.seatCB = new System.Windows.Forms.ComboBox();
            this.distanceTB = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // trainCB
            // 
            this.trainCB.FormattingEnabled = true;
            this.trainCB.Items.AddRange(new object[] {
            "電車A",
            "電車B",
            "電車C"});
            this.trainCB.Location = new System.Drawing.Point(99, 82);
            this.trainCB.Name = "trainCB";
            this.trainCB.Size = new System.Drawing.Size(121, 20);
            this.trainCB.TabIndex = 0;
            // 
            // seatCB
            // 
            this.seatCB.FormattingEnabled = true;
            this.seatCB.Items.AddRange(new object[] {
            "自由席",
            "指定席",
            "グリーン席"});
            this.seatCB.Location = new System.Drawing.Point(99, 140);
            this.seatCB.Name = "seatCB";
            this.seatCB.Size = new System.Drawing.Size(121, 20);
            this.seatCB.TabIndex = 1;
            // 
            // distanceTB
            // 
            this.distanceTB.Location = new System.Drawing.Point(99, 213);
            this.distanceTB.Name = "distanceTB";
            this.distanceTB.Size = new System.Drawing.Size(100, 19);
            this.distanceTB.TabIndex = 2;
            this.distanceTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.distanceTB_KeyPress);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(238, 381);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "追加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(379, 380);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "キャンセル";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(493, 143);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 16);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(493, 191);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 16);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.distanceTB);
            this.Controls.Add(this.seatCB);
            this.Controls.Add(this.trainCB);
            this.Name = "AddView";
            this.Text = "AddView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox trainCB;
        private System.Windows.Forms.ComboBox seatCB;
        private System.Windows.Forms.TextBox distanceTB;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}