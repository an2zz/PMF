namespace WindowsFormsApplication8
{
    partial class mainform_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.searchinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.searchresult = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("에스코어 드림 9 Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(108, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "ㅎ ^오^ ㅎ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(273, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "create account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(55, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(993, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Load";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchinput
            // 
            this.searchinput.Location = new System.Drawing.Point(617, 31);
            this.searchinput.Name = "searchinput";
            this.searchinput.Size = new System.Drawing.Size(370, 25);
            this.searchinput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(546, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "pointno";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(136, 51);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 30);
            this.button4.TabIndex = 7;
            this.button4.Text = "기분이 좋아지는 버튼 ^^";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(993, 54);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 36);
            this.button5.TabIndex = 8;
            this.button5.Text = "Detail";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // searchresult
            // 
            this.searchresult.Location = new System.Drawing.Point(558, 96);
            this.searchresult.Name = "searchresult";
            this.searchresult.Size = new System.Drawing.Size(528, 286);
            this.searchresult.TabIndex = 6;
            this.searchresult.UseCompatibleStateImageBehavior = false;
            this.searchresult.View = System.Windows.Forms.View.List;
            // 
            // mainform_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 403);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.searchresult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchinput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "mainform_1";
            this.Text = "mainform_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox searchinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListView searchresult;
    }
}