namespace StudentForm
{
    partial class Form1
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
            this.tName = new System.Windows.Forms.TextBox();
            this.tAge = new System.Windows.Forms.TextBox();
            this.tStid = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lAge = new System.Windows.Forms.Label();
            this.lStid = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.bUd = new System.Windows.Forms.Button();
            this.bDel = new System.Windows.Forms.Button();
            this.bSel = new System.Windows.Forms.Button();
            this.bCle = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Haettenschweiler", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tName.Location = new System.Drawing.Point(92, 61);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(187, 20);
            this.tName.TabIndex = 0;
            // 
            // tAge
            // 
            this.tAge.Location = new System.Drawing.Point(92, 87);
            this.tAge.Name = "tAge";
            this.tAge.Size = new System.Drawing.Size(187, 21);
            this.tAge.TabIndex = 1;
            // 
            // tStid
            // 
            this.tStid.Location = new System.Drawing.Point(92, 114);
            this.tStid.Name = "tStid";
            this.tStid.Size = new System.Drawing.Size(187, 21);
            this.tStid.TabIndex = 2;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lName.Location = new System.Drawing.Point(30, 58);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(37, 15);
            this.lName.TabIndex = 3;
            this.lName.Text = "이름";
            // 
            // lAge
            // 
            this.lAge.AutoSize = true;
            this.lAge.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lAge.Location = new System.Drawing.Point(31, 87);
            this.lAge.Name = "lAge";
            this.lAge.Size = new System.Drawing.Size(37, 15);
            this.lAge.TabIndex = 4;
            this.lAge.Text = "나이";
            // 
            // lStid
            // 
            this.lStid.AutoSize = true;
            this.lStid.Font = new System.Drawing.Font("Gulim", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lStid.Location = new System.Drawing.Point(32, 117);
            this.lStid.Name = "lStid";
            this.lStid.Size = new System.Drawing.Size(37, 15);
            this.lStid.TabIndex = 5;
            this.lStid.Text = "학번";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(25, 154);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(48, 31);
            this.bAdd.TabIndex = 6;
            this.bAdd.Text = "등록";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bUd
            // 
            this.bUd.Location = new System.Drawing.Point(79, 154);
            this.bUd.Name = "bUd";
            this.bUd.Size = new System.Drawing.Size(49, 31);
            this.bUd.TabIndex = 7;
            this.bUd.Text = "수정";
            this.bUd.UseVisualStyleBackColor = true;
            this.bUd.Click += new System.EventHandler(this.bUd_Click);
            // 
            // bDel
            // 
            this.bDel.Location = new System.Drawing.Point(134, 154);
            this.bDel.Name = "bDel";
            this.bDel.Size = new System.Drawing.Size(47, 31);
            this.bDel.TabIndex = 8;
            this.bDel.Text = "삭제";
            this.bDel.UseVisualStyleBackColor = true;
            this.bDel.Click += new System.EventHandler(this.bDel_Click);
            // 
            // bSel
            // 
            this.bSel.Location = new System.Drawing.Point(189, 154);
            this.bSel.Name = "bSel";
            this.bSel.Size = new System.Drawing.Size(46, 31);
            this.bSel.TabIndex = 9;
            this.bSel.Text = "조회";
            this.bSel.UseVisualStyleBackColor = true;
            this.bSel.Click += new System.EventHandler(this.bSel_Click);
            // 
            // bCle
            // 
            this.bCle.Location = new System.Drawing.Point(241, 154);
            this.bCle.Name = "bCle";
            this.bCle.Size = new System.Drawing.Size(42, 31);
            this.bCle.TabIndex = 10;
            this.bCle.Text = "지우";
            this.bCle.UseVisualStyleBackColor = true;
            this.bCle.Click += new System.EventHandler(this.bCle_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 12;
            this.listBox.Location = new System.Drawing.Point(25, 205);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(257, 208);
            this.listBox.TabIndex = 11;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 487);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.bCle);
            this.Controls.Add(this.bSel);
            this.Controls.Add(this.bDel);
            this.Controls.Add(this.bUd);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lStid);
            this.Controls.Add(this.lAge);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tStid);
            this.Controls.Add(this.tAge);
            this.Controls.Add(this.tName);
            this.Name = "Form1";
            this.Text = "StufrntForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tAge;
        private System.Windows.Forms.TextBox tStid;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lAge;
        private System.Windows.Forms.Label lStid;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bUd;
        private System.Windows.Forms.Button bDel;
        private System.Windows.Forms.Button bSel;
        private System.Windows.Forms.Button bCle;
        private System.Windows.Forms.ListBox listBox;
    }
}

