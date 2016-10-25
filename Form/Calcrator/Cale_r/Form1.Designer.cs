namespace Cale
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
            this.label1 = new System.Windows.Forms.Label();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bdiv = new System.Windows.Forms.Button();
            this.bmul = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.bsub = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.badd = new System.Windows.Forms.Button();
            this.bequ = new System.Windows.Forms.Button();
            this.bdot = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(26, 61);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(35, 29);
            this.b7.TabIndex = 1;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(95, 61);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(35, 29);
            this.b8.TabIndex = 2;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(165, 61);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(35, 29);
            this.b9.TabIndex = 3;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            // 
            // bdiv
            // 
            this.bdiv.Location = new System.Drawing.Point(230, 61);
            this.bdiv.Name = "bdiv";
            this.bdiv.Size = new System.Drawing.Size(32, 29);
            this.bdiv.TabIndex = 4;
            this.bdiv.Text = "/";
            this.bdiv.UseVisualStyleBackColor = true;
            // 
            // bmul
            // 
            this.bmul.Location = new System.Drawing.Point(228, 116);
            this.bmul.Name = "bmul";
            this.bmul.Size = new System.Drawing.Size(32, 29);
            this.bmul.TabIndex = 8;
            this.bmul.Text = "x";
            this.bmul.UseVisualStyleBackColor = true;
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(163, 116);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(35, 29);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(93, 116);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(35, 29);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(24, 116);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(35, 29);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            // 
            // bsub
            // 
            this.bsub.Location = new System.Drawing.Point(228, 163);
            this.bsub.Name = "bsub";
            this.bsub.Size = new System.Drawing.Size(32, 29);
            this.bsub.TabIndex = 12;
            this.bsub.Text = "-";
            this.bsub.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(163, 163);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(35, 29);
            this.b3.TabIndex = 11;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(93, 163);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(35, 29);
            this.b2.TabIndex = 10;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(24, 163);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(35, 29);
            this.b1.TabIndex = 9;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(228, 210);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(32, 29);
            this.badd.TabIndex = 16;
            this.badd.Text = "0";
            this.badd.UseVisualStyleBackColor = true;
            // 
            // bequ
            // 
            this.bequ.Location = new System.Drawing.Point(163, 210);
            this.bequ.Name = "bequ";
            this.bequ.Size = new System.Drawing.Size(35, 29);
            this.bequ.TabIndex = 15;
            this.bequ.Text = "=";
            this.bequ.UseVisualStyleBackColor = true;
            // 
            // bdot
            // 
            this.bdot.Location = new System.Drawing.Point(93, 210);
            this.bdot.Name = "bdot";
            this.bdot.Size = new System.Drawing.Size(35, 29);
            this.bdot.TabIndex = 14;
            this.bdot.Text = ".";
            this.bdot.UseVisualStyleBackColor = true;
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(24, 210);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(35, 29);
            this.b0.TabIndex = 13;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.bequ);
            this.Controls.Add(this.bdot);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bsub);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bmul);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bdiv);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bdiv;
        private System.Windows.Forms.Button bmul;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button bsub;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bequ;
        private System.Windows.Forms.Button bdot;
        private System.Windows.Forms.Button b0;
    }
}

