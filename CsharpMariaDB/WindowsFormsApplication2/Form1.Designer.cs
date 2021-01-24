namespace WindowsFormsApplication2
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
            this.A_box = new System.Windows.Forms.TextBox();
            this.B_box = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updatebutton = new System.Windows.Forms.Button();
            this.selectbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.inx_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // A_box
            // 
            this.A_box.Location = new System.Drawing.Point(271, 166);
            this.A_box.Name = "A_box";
            this.A_box.Size = new System.Drawing.Size(206, 25);
            this.A_box.TabIndex = 0;
            this.A_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // B_box
            // 
            this.B_box.Location = new System.Drawing.Point(271, 211);
            this.B_box.Name = "B_box";
            this.B_box.Size = new System.Drawing.Size(206, 25);
            this.B_box.TabIndex = 1;
            this.B_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // insertbutton
            // 
            this.insertbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.insertbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.insertbutton.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.insertbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.insertbutton.Location = new System.Drawing.Point(189, 268);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(107, 36);
            this.insertbutton.TabIndex = 2;
            this.insertbutton.Text = "INSERT";
            this.insertbutton.UseVisualStyleBackColor = false;
            this.insertbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(206, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(206, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "B";
            // 
            // updatebutton
            // 
            this.updatebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.updatebutton.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.updatebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.updatebutton.Location = new System.Drawing.Point(370, 268);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(107, 36);
            this.updatebutton.TabIndex = 9;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = false;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // selectbutton
            // 
            this.selectbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.selectbutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.selectbutton.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.selectbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectbutton.Location = new System.Drawing.Point(189, 325);
            this.selectbutton.Name = "selectbutton";
            this.selectbutton.Size = new System.Drawing.Size(107, 36);
            this.selectbutton.TabIndex = 12;
            this.selectbutton.Text = "SELECT";
            this.selectbutton.UseVisualStyleBackColor = false;
            this.selectbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.deletebutton.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.deletebutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.deletebutton.Location = new System.Drawing.Point(370, 325);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(107, 36);
            this.deletebutton.TabIndex = 17;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = false;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // inx_box
            // 
            this.inx_box.Location = new System.Drawing.Point(271, 120);
            this.inx_box.Name = "inx_box";
            this.inx_box.Size = new System.Drawing.Size(206, 25);
            this.inx_box.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(184, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 26);
            this.label7.TabIndex = 23;
            this.label7.Text = "INDEX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("에스코어 드림 9 Black", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(202, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 53);
            this.label3.TabIndex = 24;
            this.label3.Text = "C# - MariaDB";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 405);
            this.splitter1.TabIndex = 25;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(689, 405);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inx_box);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.selectbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.B_box);
            this.Controls.Add(this.A_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inx_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button selectbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
    }
}

