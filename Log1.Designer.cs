namespace iSintu_Bookings
{
    partial class Log1
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
            groupBox1 = new GroupBox();
            Hide_cbx = new CheckBox();
            groupBox2 = new GroupBox();
            Create_btn = new Button();
            label5 = new Label();
            label3 = new Label();
            Login_btn = new Button();
            label2 = new Label();
            label1 = new Label();
            Passw_txt = new TextBox();
            User_txt = new TextBox();
            Clear_btn = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.AppWorkspace;
            groupBox1.Controls.Add(Hide_cbx);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(Login_btn);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Passw_txt);
            groupBox1.Controls.Add(User_txt);
            groupBox1.Controls.Add(Clear_btn);
            groupBox1.Location = new Point(27, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(481, 441);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // Hide_cbx
            // 
            Hide_cbx.AutoSize = true;
            Hide_cbx.Location = new Point(353, 197);
            Hide_cbx.Name = "Hide_cbx";
            Hide_cbx.Size = new Size(104, 19);
            Hide_cbx.TabIndex = 17;
            Hide_cbx.Text = "Hide Password";
            Hide_cbx.UseVisualStyleBackColor = true;
            Hide_cbx.CheckedChanged += Hide_cbx_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(Create_btn);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(105, 315);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(323, 49);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // Create_btn
            // 
            Create_btn.Location = new Point(143, 11);
            Create_btn.Name = "Create_btn";
            Create_btn.Size = new Size(121, 32);
            Create_btn.TabIndex = 20;
            Create_btn.Text = "Create An Account";
            Create_btn.UseVisualStyleBackColor = true;
            Create_btn.Click += Create_btn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 19);
            label5.Name = "label5";
            label5.Size = new Size(143, 15);
            label5.TabIndex = 19;
            label5.Text = "New to Isintu Bookings?   ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(160, 42);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 16;
            label3.Text = "Sign in to Isintu Bookings ";
            // 
            // Login_btn
            // 
            Login_btn.Location = new Point(105, 253);
            Login_btn.Name = "Login_btn";
            Login_btn.Size = new Size(120, 36);
            Login_btn.TabIndex = 15;
            Login_btn.Text = "Login";
            Login_btn.UseVisualStyleBackColor = true;
            Login_btn.Click += Login_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 195);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 14;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 125);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 13;
            label1.Text = "Username";
            // 
            // Passw_txt
            // 
            Passw_txt.Location = new Point(226, 195);
            Passw_txt.Name = "Passw_txt";
            Passw_txt.Size = new Size(121, 23);
            Passw_txt.TabIndex = 12;
            // 
            // User_txt
            // 
            User_txt.Location = new Point(226, 125);
            User_txt.Name = "User_txt";
            User_txt.Size = new Size(121, 23);
            User_txt.TabIndex = 11;
            // 
            // Clear_btn
            // 
            Clear_btn.Location = new Point(261, 253);
            Clear_btn.Name = "Clear_btn";
            Clear_btn.Size = new Size(102, 36);
            Clear_btn.TabIndex = 10;
            Clear_btn.Text = "Clear";
            Clear_btn.UseVisualStyleBackColor = true;
            Clear_btn.Click += Clear_btn_Click;
            // 
            // Log1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 514);
            Controls.Add(groupBox1);
            Name = "Log1";
            Text = "Login";
            Load += Log1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox Hide_cbx;
        private GroupBox groupBox2;
        private Button Create_btn;
        private Label label5;
        private Label label3;
        private Button Login_btn;
        private Label label2;
        private Label label1;
        private TextBox Passw_txt;
        private TextBox User_txt;
        private Button Clear_btn;
    }
}