namespace iSintu_Bookings
{
    partial class ManageBookings
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBookings));
            dataGridView1 = new DataGridView();
            button1 = new Button();
            Delete_btn = new Button();
            Display_btn = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            Report_btn = new Button();
            ASC_btn = new Button();
            DESC_btn = new Button();
            Name_txt = new TextBox();
            label2 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Surname_txt = new TextBox();
            Passw_txt = new TextBox();
            Email_Txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(712, 242);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(71, 302);
            button1.Name = "button1";
            button1.Size = new Size(98, 35);
            button1.TabIndex = 1;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Delete_btn
            // 
            Delete_btn.Location = new Point(197, 302);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(98, 35);
            Delete_btn.TabIndex = 2;
            Delete_btn.Text = "Delete";
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // Display_btn
            // 
            Display_btn.Location = new Point(323, 302);
            Display_btn.Name = "Display_btn";
            Display_btn.Size = new Size(98, 35);
            Display_btn.TabIndex = 3;
            Display_btn.Text = "Display All";
            Display_btn.UseVisualStyleBackColor = true;
            Display_btn.Click += Display_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(554, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 4;
            label1.Text = "Search for name:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(656, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // Report_btn
            // 
            Report_btn.Location = new Point(657, 302);
            Report_btn.Name = "Report_btn";
            Report_btn.Size = new Size(126, 35);
            Report_btn.TabIndex = 7;
            Report_btn.Text = "Detailed Report";
            Report_btn.UseVisualStyleBackColor = true;
            Report_btn.Click += Report_btn_Click;
            // 
            // ASC_btn
            // 
            ASC_btn.Location = new Point(439, 302);
            ASC_btn.Name = "ASC_btn";
            ASC_btn.Size = new Size(98, 35);
            ASC_btn.TabIndex = 8;
            ASC_btn.Text = "Sort(ASC)";
            ASC_btn.UseVisualStyleBackColor = true;
            ASC_btn.Click += ASC_btn_Click;
            // 
            // DESC_btn
            // 
            DESC_btn.Location = new Point(553, 302);
            DESC_btn.Name = "DESC_btn";
            DESC_btn.Size = new Size(98, 35);
            DESC_btn.TabIndex = 9;
            DESC_btn.Text = "Sort(DESC)";
            DESC_btn.UseVisualStyleBackColor = true;
            DESC_btn.Click += DESC_btn_Click;
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(195, 350);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(100, 23);
            Name_txt.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 358);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 11;
            label2.Text = "Edit/Delete Name";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Surname_txt
            // 
            Surname_txt.Location = new Point(195, 379);
            Surname_txt.Name = "Surname_txt";
            Surname_txt.Size = new Size(100, 23);
            Surname_txt.TabIndex = 13;
            // 
            // Passw_txt
            // 
            Passw_txt.Location = new Point(195, 408);
            Passw_txt.Name = "Passw_txt";
            Passw_txt.Size = new Size(100, 23);
            Passw_txt.TabIndex = 14;
            // 
            // Email_Txt
            // 
            Email_Txt.Location = new Point(195, 437);
            Email_Txt.Name = "Email_Txt";
            Email_Txt.Size = new Size(100, 23);
            Email_Txt.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 445);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 16;
            label3.Text = "Edit/Delete email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 416);
            label4.Name = "label4";
            label4.Size = new Size(118, 15);
            label4.TabIndex = 17;
            label4.Text = "Edit/Delete Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 387);
            label5.Name = "label5";
            label5.Size = new Size(115, 15);
            label5.TabIndex = 18;
            label5.Text = "Edit/Delete Surname";
            // 
            // ManageBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(871, 490);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Email_Txt);
            Controls.Add(Passw_txt);
            Controls.Add(Surname_txt);
            Controls.Add(label2);
            Controls.Add(Name_txt);
            Controls.Add(DESC_btn);
            Controls.Add(ASC_btn);
            Controls.Add(Report_btn);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Display_btn);
            Controls.Add(Delete_btn);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "ManageBookings";
            Text = "Manage Bookings";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button Delete_btn;
        private Button Display_btn;
        private Label label1;
        private TextBox textBox1;
        private Button Report_btn;
        private Button ASC_btn;
        private Button DESC_btn;
        private TextBox Name_txt;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox Surname_txt;
        private TextBox Passw_txt;
        private TextBox Email_Txt;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}