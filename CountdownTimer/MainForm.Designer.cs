namespace CountdownTimer
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barTime = new System.Windows.Forms.ProgressBar();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.lbRemainingTime = new System.Windows.Forms.Label();
            this.cbDailyTask = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // barTime
            // 
            this.barTime.Location = new System.Drawing.Point(13, 13);
            this.barTime.Name = "barTime";
            this.barTime.Size = new System.Drawing.Size(379, 23);
            this.barTime.TabIndex = 0;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(13, 47);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(45, 22);
            this.txtHour.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "小時";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "分";
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(99, 46);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(45, 22);
            this.txtMinute.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "秒";
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(173, 46);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(45, 22);
            this.txtSecond.TabIndex = 5;
            // 
            // btnOnOff
            // 
            this.btnOnOff.BackColor = System.Drawing.Color.Lime;
            this.btnOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnOff.Location = new System.Drawing.Point(262, 44);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(156, 23);
            this.btnOnOff.TabIndex = 7;
            this.btnOnOff.Text = "開始";
            this.btnOnOff.UseVisualStyleBackColor = false;
            this.btnOnOff.Click += new System.EventHandler(this.btnOnOff_Click);
            // 
            // lbRemainingTime
            // 
            this.lbRemainingTime.AutoSize = true;
            this.lbRemainingTime.Location = new System.Drawing.Point(185, 18);
            this.lbRemainingTime.Name = "lbRemainingTime";
            this.lbRemainingTime.Size = new System.Drawing.Size(0, 12);
            this.lbRemainingTime.TabIndex = 8;
            // 
            // cbDailyTask
            // 
            this.cbDailyTask.AutoSize = true;
            this.cbDailyTask.Location = new System.Drawing.Point(403, 18);
            this.cbDailyTask.Name = "cbDailyTask";
            this.cbDailyTask.Size = new System.Drawing.Size(15, 14);
            this.cbDailyTask.TabIndex = 9;
            this.cbDailyTask.UseVisualStyleBackColor = true;
            this.cbDailyTask.CheckedChanged += new System.EventHandler(this.cbDailyTask_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 81);
            this.Controls.Add(this.cbDailyTask);
            this.Controls.Add(this.lbRemainingTime);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHour);
            this.Controls.Add(this.barTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "倒數計時器 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar barTime;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button btnOnOff;
        private System.Windows.Forms.Label lbRemainingTime;
        private System.Windows.Forms.CheckBox cbDailyTask;
    }
}

