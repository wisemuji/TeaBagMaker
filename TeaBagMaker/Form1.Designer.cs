namespace TeaBagMaker
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbList = new System.Windows.Forms.ComboBox();
            this.timeStr = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.timeLeftStr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbList
            // 
            this.cbList.FormattingEnabled = true;
            this.cbList.Location = new System.Drawing.Point(33, 29);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(173, 20);
            this.cbList.TabIndex = 0;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.CbList_SelectedIndexChanged_1);
            // 
            // timeStr
            // 
            this.timeStr.AutoSize = true;
            this.timeStr.Location = new System.Drawing.Point(217, 32);
            this.timeStr.Name = "timeStr";
            this.timeStr.Size = new System.Drawing.Size(171, 12);
            this.timeStr.TabIndex = 1;
            this.timeStr.Text = "초ssssssssssssssssssssss";
            this.timeStr.Click += new System.EventHandler(this.TimeStr_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(33, 67);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(355, 57);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "담그기!";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "2019-05-21 제작, 3604 김수현";
            // 
            // timeLeftStr
            // 
            this.timeLeftStr.AutoSize = true;
            this.timeLeftStr.Location = new System.Drawing.Point(296, 151);
            this.timeLeftStr.Name = "timeLeftStr";
            this.timeLeftStr.Size = new System.Drawing.Size(0, 12);
            this.timeLeftStr.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 175);
            this.Controls.Add(this.timeLeftStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.timeStr);
            this.Controls.Add(this.cbList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbList;
        private System.Windows.Forms.Label timeStr;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLeftStr;
    }
}

