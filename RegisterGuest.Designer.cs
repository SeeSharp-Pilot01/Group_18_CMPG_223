namespace iSintu_Bookings
{
    partial class RegisterGuest
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
            Surname_txt = new TextBox();
            Email_txt = new TextBox();
            Name_txt = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            label2 = new Label();
            label6 = new Label();
            Cell_txt = new TextBox();
            label1 = new Label();
            Address_txt = new TextBox();
            label7 = new Label();
            Nationality_txt = new TextBox();
            label8 = new Label();
            Preferences_txt = new TextBox();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            Password_txt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Surname_txt
            // 
            Surname_txt.Location = new Point(350, 128);
            Surname_txt.Name = "Surname_txt";
            Surname_txt.Size = new Size(186, 23);
            Surname_txt.TabIndex = 1;
            // 
            // Email_txt
            // 
            Email_txt.Location = new Point(350, 173);
            Email_txt.Name = "Email_txt";
            Email_txt.Size = new Size(186, 23);
            Email_txt.TabIndex = 2;
            // 
            // Name_txt
            // 
            Name_txt.Location = new Point(350, 84);
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(186, 23);
            Name_txt.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(216, 173);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 84);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 8;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 128);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 9;
            label5.Text = "Surname";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(372, 488);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 10;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 33);
            label2.Name = "label2";
            label2.Size = new Size(368, 21);
            label2.TabIndex = 11;
            label2.Text = "Create an account with us on Isintu Bookings ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 219);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 12;
            label6.Text = "Phone Number";
            label6.Click += label6_Click;
            // 
            // Cell_txt
            // 
            Cell_txt.Location = new Point(350, 219);
            Cell_txt.Name = "Cell_txt";
            Cell_txt.Size = new Size(186, 23);
            Cell_txt.TabIndex = 13;
            Cell_txt.TextChanged += Cell_txt_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 270);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 14;
            label1.Text = "Address";
            label1.Click += label1_Click;
            // 
            // Address_txt
            // 
            Address_txt.Location = new Point(350, 270);
            Address_txt.Name = "Address_txt";
            Address_txt.Size = new Size(186, 23);
            Address_txt.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 324);
            label7.Name = "label7";
            label7.Size = new Size(98, 15);
            label7.TabIndex = 16;
            label7.Text = "Guest Nationality";
            // 
            // Nationality_txt
            // 
            Nationality_txt.Location = new Point(350, 324);
            Nationality_txt.Name = "Nationality_txt";
            Nationality_txt.Size = new Size(186, 23);
            Nationality_txt.TabIndex = 17;
            Nationality_txt.TextChanged += textBox1_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 378);
            label8.Name = "label8";
            label8.Size = new Size(101, 15);
            label8.TabIndex = 18;
            label8.Text = "Guest Preferences";
            // 
            // Preferences_txt
            // 
            Preferences_txt.Location = new Point(350, 378);
            Preferences_txt.Name = "Preferences_txt";
            Preferences_txt.Size = new Size(186, 23);
            Preferences_txt.TabIndex = 19;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(664, 314);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(213, 432);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 21;
            label9.Text = "Password";
            // 
            // Password_txt
            // 
            Password_txt.Location = new Point(350, 432);
            Password_txt.Name = "Password_txt";
            Password_txt.Size = new Size(186, 23);
            Password_txt.TabIndex = 22;
            // 
            // RegisterGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 542);
            Controls.Add(Password_txt);
            Controls.Add(label9);
            Controls.Add(dataGridView1);
            Controls.Add(Preferences_txt);
            Controls.Add(label8);
            Controls.Add(Nationality_txt);
            Controls.Add(label7);
            Controls.Add(Address_txt);
            Controls.Add(label1);
            Controls.Add(Cell_txt);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Name_txt);
            Controls.Add(Email_txt);
            Controls.Add(Surname_txt);
            Name = "RegisterGuest";
            Text = "RegisterGuest";
            Load += RegisterGuest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Surname_txt;
        private TextBox Email_txt;
        private TextBox Name_txt;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Label label2;
        private Label label6;
        private TextBox Cell_txt;
        private Label label1;
        private TextBox Address_txt;
        private Label label7;
        private TextBox Nationality_txt;
        private Label label8;
        private TextBox Preferences_txt;
        private DataGridView dataGridView1;
        private Label label9;
        private TextBox Password_txt;
    }
}