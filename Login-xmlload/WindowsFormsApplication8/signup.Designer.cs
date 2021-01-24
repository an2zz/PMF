namespace WindowsFormsApplication8
{
    partial class signup
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
            this.ID_box = new System.Windows.Forms.TextBox();
            this.PW_box = new System.Windows.Forms.TextBox();
            this.username_box = new System.Windows.Forms.TextBox();
            this.email_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.role_box = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ID_box
            // 
            this.ID_box.Location = new System.Drawing.Point(128, 104);
            this.ID_box.Name = "ID_box";
            this.ID_box.Size = new System.Drawing.Size(256, 25);
            this.ID_box.TabIndex = 0;
            // 
            // PW_box
            // 
            this.PW_box.Location = new System.Drawing.Point(128, 161);
            this.PW_box.Name = "PW_box";
            this.PW_box.PasswordChar = '●';
            this.PW_box.Size = new System.Drawing.Size(256, 25);
            this.PW_box.TabIndex = 1;
            // 
            // username_box
            // 
            this.username_box.Location = new System.Drawing.Point(128, 216);
            this.username_box.Name = "username_box";
            this.username_box.Size = new System.Drawing.Size(256, 25);
            this.username_box.TabIndex = 2;
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(128, 274);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(256, 25);
            this.email_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(53, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(53, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(53, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "e-mail";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(246, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "creat account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(56, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(53, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "role";
            // 
            // role_box
            // 
            this.role_box.FormattingEnabled = true;
            this.role_box.Items.AddRange(new object[] {
            "0",
            "1"});
            this.role_box.Location = new System.Drawing.Point(128, 329);
            this.role_box.Name = "role_box";
            this.role_box.Size = new System.Drawing.Size(256, 23);
            this.role_box.TabIndex = 12;
            this.role_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("에스코어 드림 9 Black", 24F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(144, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(184, 56);
            this.label6.TabIndex = 13;
            this.label6.Text = "SIGN-IN";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 508);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.role_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.username_box);
            this.Controls.Add(this.PW_box);
            this.Controls.Add(this.ID_box);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID_box;
        private System.Windows.Forms.TextBox PW_box;
        private System.Windows.Forms.TextBox username_box;
        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox role_box;
        private System.Windows.Forms.Label label6;
    }
}