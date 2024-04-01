namespace fExSandbox
{
    partial class Connect4
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn10 = new Button();
            btn11 = new Button();
            btn12 = new Button();
            btn13 = new Button();
            btn14 = new Button();
            btn15 = new Button();
            btn16 = new Button();
            btnNG = new Button();
            txtDisp = new TextBox();
            chkAI = new CheckBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = Color.White;
            btn1.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn1.BackgroundImageLayout = ImageLayout.Stretch;
            btn1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn1.Location = new Point(12, 12);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 80);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += col1Click;
            // 
            // btn2
            // 
            btn2.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn2.BackgroundImageLayout = ImageLayout.Stretch;
            btn2.Location = new Point(98, 12);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 80);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += col2Click;
            // 
            // btn3
            // 
            btn3.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn3.BackgroundImageLayout = ImageLayout.Stretch;
            btn3.Location = new Point(184, 12);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 80);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += col3Click;
            // 
            // btn4
            // 
            btn4.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn4.BackgroundImageLayout = ImageLayout.Stretch;
            btn4.Location = new Point(270, 12);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 80);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += col4Click;
            // 
            // btn5
            // 
            btn5.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn5.BackgroundImageLayout = ImageLayout.Stretch;
            btn5.Location = new Point(12, 98);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 80);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += col1Click;
            // 
            // btn6
            // 
            btn6.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn6.BackgroundImageLayout = ImageLayout.Stretch;
            btn6.Location = new Point(98, 98);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 80);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += col2Click;
            // 
            // btn7
            // 
            btn7.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn7.BackgroundImageLayout = ImageLayout.Stretch;
            btn7.Location = new Point(184, 98);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 80);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += col3Click;
            // 
            // btn8
            // 
            btn8.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn8.BackgroundImageLayout = ImageLayout.Stretch;
            btn8.Location = new Point(270, 98);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 80);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += col4Click;
            // 
            // btn9
            // 
            btn9.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn9.BackgroundImageLayout = ImageLayout.Stretch;
            btn9.Location = new Point(12, 184);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 80);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += col1Click;
            // 
            // btn10
            // 
            btn10.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn10.BackgroundImageLayout = ImageLayout.Stretch;
            btn10.Location = new Point(98, 184);
            btn10.Name = "btn10";
            btn10.Size = new Size(80, 80);
            btn10.TabIndex = 9;
            btn10.UseVisualStyleBackColor = true;
            btn10.Click += col2Click;
            // 
            // btn11
            // 
            btn11.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn11.BackgroundImageLayout = ImageLayout.Stretch;
            btn11.Location = new Point(184, 184);
            btn11.Name = "btn11";
            btn11.Size = new Size(80, 80);
            btn11.TabIndex = 10;
            btn11.UseVisualStyleBackColor = true;
            btn11.Click += col3Click;
            // 
            // btn12
            // 
            btn12.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn12.BackgroundImageLayout = ImageLayout.Stretch;
            btn12.Location = new Point(270, 184);
            btn12.Name = "btn12";
            btn12.Size = new Size(80, 80);
            btn12.TabIndex = 11;
            btn12.UseVisualStyleBackColor = true;
            btn12.Click += col4Click;
            // 
            // btn13
            // 
            btn13.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn13.BackgroundImageLayout = ImageLayout.Stretch;
            btn13.Location = new Point(12, 270);
            btn13.Name = "btn13";
            btn13.Size = new Size(80, 80);
            btn13.TabIndex = 12;
            btn13.UseVisualStyleBackColor = true;
            btn13.Click += col1Click;
            // 
            // btn14
            // 
            btn14.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn14.BackgroundImageLayout = ImageLayout.Stretch;
            btn14.Location = new Point(98, 270);
            btn14.Name = "btn14";
            btn14.Size = new Size(80, 80);
            btn14.TabIndex = 13;
            btn14.UseVisualStyleBackColor = true;
            btn14.Click += col2Click;
            // 
            // btn15
            // 
            btn15.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn15.BackgroundImageLayout = ImageLayout.Stretch;
            btn15.Location = new Point(184, 270);
            btn15.Name = "btn15";
            btn15.Size = new Size(80, 80);
            btn15.TabIndex = 14;
            btn15.UseVisualStyleBackColor = true;
            btn15.Click += col3Click;
            // 
            // btn16
            // 
            btn16.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn16.BackgroundImageLayout = ImageLayout.Stretch;
            btn16.Location = new Point(270, 270);
            btn16.Name = "btn16";
            btn16.Size = new Size(80, 80);
            btn16.TabIndex = 15;
            btn16.UseVisualStyleBackColor = true;
            btn16.Click += col4Click;
            // 
            // btnNG
            // 
            btnNG.Location = new Point(270, 356);
            btnNG.Name = "btnNG";
            btnNG.Size = new Size(75, 23);
            btnNG.TabIndex = 16;
            btnNG.Text = "New Game";
            btnNG.UseVisualStyleBackColor = true;
            btnNG.Click += btnNG_Click;
            // 
            // txtDisp
            // 
            txtDisp.Enabled = false;
            txtDisp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisp.Location = new Point(12, 356);
            txtDisp.Name = "txtDisp";
            txtDisp.Size = new Size(209, 23);
            txtDisp.TabIndex = 17;
            txtDisp.Text = "Ready to play!";
            // 
            // chkAI
            // 
            chkAI.AutoSize = true;
            chkAI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkAI.Location = new Point(227, 359);
            chkAI.Name = "chkAI";
            chkAI.Size = new Size(38, 19);
            chkAI.TabIndex = 18;
            chkAI.Text = "AI";
            chkAI.UseVisualStyleBackColor = true;
            chkAI.CheckedChanged += chkAI_CheckedChanged;
            // 
            // Connect4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 394);
            Controls.Add(chkAI);
            Controls.Add(txtDisp);
            Controls.Add(btnNG);
            Controls.Add(btn16);
            Controls.Add(btn15);
            Controls.Add(btn14);
            Controls.Add(btn13);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Connect4";
            Text = "Connect 4";
            TransparencyKey = Color.IndianRed;
            Load += Connect4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn15;
        private Button btn16;
        private Button btnNG;
        private TextBox txtDisp;
        private CheckBox chkAI;
    }
}