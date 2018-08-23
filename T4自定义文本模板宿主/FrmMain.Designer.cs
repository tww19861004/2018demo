namespace T4Generator
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtNameSpace = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDB);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtPwd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.txtNameSpace);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTableName);
            this.panel1.Controls.Add(this.txtServer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 141);
            this.panel1.TabIndex = 0;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(88, 12);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(175, 21);
            this.txtServer.TabIndex = 5;
            this.txtServer.Text = "192.168.1.101";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "表名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "服务器：";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(88, 66);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(175, 21);
            this.txtTableName.TabIndex = 6;
            this.txtTableName.Text = "Base_Person";
            // 
            // txtNameSpace
            // 
            this.txtNameSpace.Location = new System.Drawing.Point(88, 93);
            this.txtNameSpace.Name = "txtNameSpace";
            this.txtNameSpace.Size = new System.Drawing.Size(175, 21);
            this.txtNameSpace.TabIndex = 8;
            this.txtNameSpace.Text = "CodeGenerator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "命名空间：";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(297, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "生成";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 93);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCode
            // 
            this.txtCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCode.Location = new System.Drawing.Point(0, 141);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(726, 304);
            this.txtCode.TabIndex = 1;
            this.txtCode.Text = "";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(317, 12);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(84, 21);
            this.txtUser.TabIndex = 12;
            this.txtUser.Text = "sa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "用户：";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(464, 12);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(84, 21);
            this.txtPwd.TabIndex = 14;
            this.txtPwd.Text = "123qwe!@#";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "密码：";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(88, 39);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(175, 21);
            this.txtDB.TabIndex = 16;
            this.txtDB.Text = "DB_Test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "数据库：";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 445);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T4生成器";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameSpace;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label6;

    }
}

