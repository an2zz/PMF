namespace WindowsFormsApplication8
{
    partial class mainform_0
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.searchresult1 = new System.Windows.Forms.ListView();
            this.searchinput1 = new System.Windows.Forms.TextBox();
            this.ini = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("에스코어 드림 9 Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 83);
            this.label1.TabIndex = 3;
            this.label1.Text = "ㅎ ^오^ ㅎ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("에스코어 드림 5 Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Items.AddRange(new object[] {
            "안재형",
            "정빵윤",
            "전수봐리",
            "안호영",
            "애드워드, 알폰스"});
            this.listBox1.Location = new System.Drawing.Point(25, 117);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 25);
            this.listBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(472, 229);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(334, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOAD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(334, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 35);
            this.button2.TabIndex = 7;
            this.button2.Text = "BACK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchresult1
            // 
            this.searchresult1.Location = new System.Drawing.Point(516, 117);
            this.searchresult1.Name = "searchresult1";
            this.searchresult1.Size = new System.Drawing.Size(442, 260);
            this.searchresult1.TabIndex = 8;
            this.searchresult1.UseCompatibleStateImageBehavior = false;
            // 
            // searchinput1
            // 
            this.searchinput1.Location = new System.Drawing.Point(550, 76);
            this.searchinput1.Name = "searchinput1";
            this.searchinput1.Size = new System.Drawing.Size(290, 25);
            this.searchinput1.TabIndex = 9;
            // 
            // INI
            // 
            this.ini.AutoSize = true;
            this.ini.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ini.Location = new System.Drawing.Point(512, 73);
            this.ini.Name = "INI";
            this.ini.Size = new System.Drawing.Size(32, 24);
            this.ini.TabIndex = 10;
            this.ini.Text = "INI";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("에스코어 드림 7 ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(856, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 35);
            this.button3.TabIndex = 11;
            this.button3.Text = "LOAD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mainform_0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 393);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ini);
            this.Controls.Add(this.searchinput1);
            this.Controls.Add(this.searchresult1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "mainform_0";
            this.Text = "mainform_0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView searchresult1;
        private System.Windows.Forms.TextBox searchinput1;
        private System.Windows.Forms.Label ini;
        private System.Windows.Forms.Button button3;
    }
}