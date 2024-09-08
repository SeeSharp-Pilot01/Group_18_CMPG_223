namespace iSintu_Bookings
{
    partial class Cost_Summary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cost_Summary));
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            costA_lbl = new Label();
            Act_lbl = new Label();
            costAct_lbl = new Label();
            Area_lbl = new Label();
            CostH_lbl = new Label();
            House_lbl = new Label();
            User_lbl = new Label();
            Total_lbl = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = (Image)resources.GetObject("groupBox1.BackgroundImage");
            groupBox1.BackgroundImageLayout = ImageLayout.Center;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(36, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "RECEIPT";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel1.Controls.Add(costA_lbl, 2, 3);
            tableLayoutPanel1.Controls.Add(Act_lbl, 1, 4);
            tableLayoutPanel1.Controls.Add(costAct_lbl, 2, 4);
            tableLayoutPanel1.Controls.Add(Area_lbl, 1, 3);
            tableLayoutPanel1.Controls.Add(Total_lbl, 2, 5);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(User_lbl, 0, 3);
            tableLayoutPanel1.Controls.Add(House_lbl, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 1, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(CostH_lbl, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 2, 2);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.04504F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 54.95496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 103F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(306, 373);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // costA_lbl
            // 
            costA_lbl.AutoSize = true;
            costA_lbl.Location = new Point(215, 183);
            costA_lbl.Name = "costA_lbl";
            costA_lbl.Size = new Size(0, 15);
            costA_lbl.TabIndex = 14;
            // 
            // Act_lbl
            // 
            Act_lbl.AutoSize = true;
            Act_lbl.Location = new Point(109, 251);
            Act_lbl.Name = "Act_lbl";
            Act_lbl.Size = new Size(0, 15);
            Act_lbl.TabIndex = 11;
            // 
            // costAct_lbl
            // 
            costAct_lbl.AutoSize = true;
            costAct_lbl.Location = new Point(215, 251);
            costAct_lbl.Name = "costAct_lbl";
            costAct_lbl.Size = new Size(0, 15);
            costAct_lbl.TabIndex = 15;
            // 
            // Area_lbl
            // 
            Area_lbl.AutoSize = true;
            Area_lbl.Location = new Point(109, 183);
            Area_lbl.Name = "Area_lbl";
            Area_lbl.Size = new Size(0, 15);
            Area_lbl.TabIndex = 10;
            // 
            // CostH_lbl
            // 
            CostH_lbl.AutoSize = true;
            CostH_lbl.Location = new Point(3, 0);
            CostH_lbl.Name = "CostH_lbl";
            CostH_lbl.Size = new Size(0, 15);
            CostH_lbl.TabIndex = 13;
            // 
            // House_lbl
            // 
            House_lbl.AutoSize = true;
            House_lbl.Location = new Point(3, 354);
            House_lbl.Name = "House_lbl";
            House_lbl.Size = new Size(0, 15);
            House_lbl.TabIndex = 9;
            // 
            // User_lbl
            // 
            User_lbl.AutoSize = true;
            User_lbl.Location = new Point(3, 183);
            User_lbl.Name = "User_lbl";
            User_lbl.Size = new Size(0, 15);
            User_lbl.TabIndex = 8;
            // 
            // Total_lbl
            // 
            Total_lbl.AutoSize = true;
            Total_lbl.Location = new Point(215, 354);
            Total_lbl.Name = "Total_lbl";
            Total_lbl.Size = new Size(63, 15);
            Total_lbl.TabIndex = 1;
            Total_lbl.Text = "Total: R800";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 4;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 5;
            label3.Text = "House:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 251);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 55);
            label5.Name = "label5";
            label5.Size = new Size(93, 30);
            label5.TabIndex = 7;
            label5.Text = "bonganitabu@gmail.com";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(215, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Costs:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 440);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(228, 440);
            button2.Name = "button2";
            button2.Size = new Size(162, 36);
            button2.TabIndex = 2;
            button2.Text = "Calculate Total Price ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 123);
            label6.Name = "label6";
            label6.Size = new Size(69, 30);
            label6.TabIndex = 16;
            label6.Text = "Explorer Guesthouse";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(215, 123);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 17;
            label7.Text = "R800";
            // 
            // Cost_Summary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(516, 541);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.InfoText;
            Name = "Cost_Summary";
            Text = "Cost Summary";
            Load += Cost_Summary_Load_1;
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private Button button2;
        private Label Total_lbl;
        private TableLayoutPanel tableLayoutPanel1;
        private Label User_lbl;
        private Label House_lbl;
        private Label Area_lbl;
        private Label Act_lbl;
        private Label costA_lbl;
        private Label CostH_lbl;
        private Label costAct_lbl;
        private Label label5;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label7;
    }
}