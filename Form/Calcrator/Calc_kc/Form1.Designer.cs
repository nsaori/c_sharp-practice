namespace Calc
{
    partial class FormCalc
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
            this.labelContent = new System.Windows.Forms.Label();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdiy = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.XX = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.ee = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잘라내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.찾기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.참색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelContent
            // 
            this.labelContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelContent.Location = new System.Drawing.Point(12, 23);
            this.labelContent.Name = "labelContent";
            this.labelContent.Size = new System.Drawing.Size(228, 45);
            this.labelContent.TabIndex = 0;
            this.labelContent.Text = "0.0";
            this.labelContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(14, 93);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(43, 43);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.su_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(75, 93);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(43, 43);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.su_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(138, 93);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(43, 43);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.su_Click);
            // 
            // bdiy
            // 
            this.bdiy.Location = new System.Drawing.Point(197, 93);
            this.bdiy.Name = "bdiy";
            this.bdiy.Size = new System.Drawing.Size(43, 43);
            this.bdiy.TabIndex = 4;
            this.bdiy.Text = "/";
            this.bdiy.UseVisualStyleBackColor = true;
            this.bdiy.Click += new System.EventHandler(this.op_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(14, 142);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(43, 43);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.su_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(75, 142);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(43, 43);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.su_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(138, 142);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(43, 43);
            this.b6.TabIndex = 6;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.su_Click);
            // 
            // XX
            // 
            this.XX.Location = new System.Drawing.Point(197, 142);
            this.XX.Name = "XX";
            this.XX.Size = new System.Drawing.Size(43, 43);
            this.XX.TabIndex = 8;
            this.XX.Text = "X";
            this.XX.UseVisualStyleBackColor = true;
            this.XX.Click += new System.EventHandler(this.op_Click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(14, 191);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(43, 43);
            this.b1.TabIndex = 9;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.su_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(75, 191);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(43, 43);
            this.b2.TabIndex = 10;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.su_Click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(138, 191);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(43, 43);
            this.b3.TabIndex = 11;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.su_Click);
            // 
            // sub
            // 
            this.sub.Location = new System.Drawing.Point(197, 191);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(43, 43);
            this.sub.TabIndex = 12;
            this.sub.Text = "ㅡ";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Click += new System.EventHandler(this.op_Click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(14, 240);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(43, 43);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.su_Click);
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(75, 240);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(43, 43);
            this.bdot.TabIndex = 14;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            this.bdot.Click += new System.EventHandler(this.su_Click);
            // 
            // ee
            // 
            this.ee.Location = new System.Drawing.Point(138, 240);
            this.ee.Name = "ee";
            this.ee.Size = new System.Drawing.Size(43, 43);
            this.ee.TabIndex = 15;
            this.ee.Text = "=";
            this.ee.UseVisualStyleBackColor = true;
            this.ee.Click += new System.EventHandler(this.op_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(197, 240);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(43, 43);
            this.Add.TabIndex = 16;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.op_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(247, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기ToolStripMenuItem,
            this.열기ToolStripMenuItem,
            this.toolStripSeparator1,
            this.닫기ToolStripMenuItem,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.잘라내기ToolStripMenuItem,
            this.복사ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭제ToolStripMenuItem,
            this.toolStripSeparator2,
            this.찾기ToolStripMenuItem,
            this.참색ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기ToolStripMenuItem,
            this.정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 새로만들기ToolStripMenuItem
            // 
            this.새로만들기ToolStripMenuItem.Name = "새로만들기ToolStripMenuItem";
            this.새로만들기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.새로만들기ToolStripMenuItem.Text = "새로만들기";
            // 
            // 열기ToolStripMenuItem
            // 
            this.열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            this.열기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.열기ToolStripMenuItem.Text = "열기";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // 닫기ToolStripMenuItem
            // 
            this.닫기ToolStripMenuItem.Name = "닫기ToolStripMenuItem";
            this.닫기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.닫기ToolStripMenuItem.Text = "닫기";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 잘라내기ToolStripMenuItem
            // 
            this.잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
            this.잘라내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.잘라내기ToolStripMenuItem.Text = "잘라내기";
            // 
            // 복사ToolStripMenuItem
            // 
            this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            this.복사ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 삭제ToolStripMenuItem
            // 
            this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
            this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.삭제ToolStripMenuItem.Text = "삭제";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // 찾기ToolStripMenuItem
            // 
            this.찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            this.찾기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.찾기ToolStripMenuItem.Text = "찾기";
            // 
            // 참색ToolStripMenuItem
            // 
            this.참색ToolStripMenuItem.Name = "참색ToolStripMenuItem";
            this.참색ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.참색ToolStripMenuItem.Text = "탐색";
            // 
            // 도움말보기ToolStripMenuItem
            // 
            this.도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem";
            this.도움말보기ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.도움말보기ToolStripMenuItem.Text = "도움말보기";
            // 
            // 정보ToolStripMenuItem
            // 
            this.정보ToolStripMenuItem.Name = "정보ToolStripMenuItem";
            this.정보ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.정보ToolStripMenuItem.Text = "정보";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 287);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(247, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "OK";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel1.Text = "OK";
            // 
            // FormCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 309);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ee);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.XX);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bdiy);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.labelContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormCalc";
            this.Text = "계산기";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContent;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bdiy;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button XX;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button ee;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 닫기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 찾기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 참색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정보ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

