using System.CodeDom;
using System.Diagnostics.Eventing.Reader;

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
            btn50 = new Button();
            btn51 = new Button();
            btn52 = new Button();
            btn53 = new Button();
            btnNG = new Button();
            txtDisp = new TextBox();
            chkAI = new CheckBox();
            btn56 = new Button();
            btn55 = new Button();
            btn54 = new Button();
            btn46 = new Button();
            btn45 = new Button();
            btn44 = new Button();
            btn36 = new Button();
            btn35 = new Button();
            btn34 = new Button();
            btn26 = new Button();
            btn25 = new Button();
            btn24 = new Button();
            btn16 = new Button();
            btn14 = new Button();
            btn13 = new Button();
            btn12 = new Button();
            btn11 = new Button();
            btn10 = new Button();
            btn06 = new Button();
            btn05 = new Button();
            btn04 = new Button();
            btn03 = new Button();
            btn02 = new Button();
            btn01 = new Button();
            btn00 = new Button();
            btn40 = new Button();
            btn41 = new Button();
            btn42 = new Button();
            btn43 = new Button();
            btn30 = new Button();
            btn31 = new Button();
            btn32 = new Button();
            btn33 = new Button();
            btn20 = new Button();
            btn21 = new Button();
            btn22 = new Button();
            btn23 = new Button();
            btn15 = new Button();
            btnerror = new Button();
            SuspendLayout();
            // 
            // btn50
            // 
            btn50.BackColor = Color.White;
            btn50.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn50.BackgroundImageLayout = ImageLayout.Stretch;
            btn50.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn50.Location = new Point(14, 16);
            btn50.Margin = new Padding(3, 4, 3, 4);
            btn50.Name = "btn50";
            btn50.Size = new Size(91, 107);
            btn50.TabIndex = 0;
            btn50.UseVisualStyleBackColor = false;
            btn50.Click += col1Click;
            // 
            // btn51
            // 
            btn51.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn51.BackgroundImageLayout = ImageLayout.Stretch;
            btn51.Location = new Point(112, 16);
            btn51.Margin = new Padding(3, 4, 3, 4);
            btn51.Name = "btn51";
            btn51.Size = new Size(91, 107);
            btn51.TabIndex = 1;
            btn51.UseVisualStyleBackColor = true;
            btn51.Click += col2Click;
            // 
            // btn52
            // 
            btn52.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn52.BackgroundImageLayout = ImageLayout.Stretch;
            btn52.Location = new Point(210, 16);
            btn52.Margin = new Padding(3, 4, 3, 4);
            btn52.Name = "btn52";
            btn52.Size = new Size(91, 107);
            btn52.TabIndex = 2;
            btn52.UseVisualStyleBackColor = true;
            btn52.Click += col3Click;
            // 
            // btn53
            // 
            btn53.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn53.BackgroundImageLayout = ImageLayout.Stretch;
            btn53.Location = new Point(309, 16);
            btn53.Margin = new Padding(3, 4, 3, 4);
            btn53.Name = "btn53";
            btn53.Size = new Size(91, 107);
            btn53.TabIndex = 3;
            btn53.UseVisualStyleBackColor = true;
            btn53.Click += col4Click;
            // 
            // btnNG
            // 
            btnNG.Location = new Point(307, 719);
            btnNG.Margin = new Padding(3, 4, 3, 4);
            btnNG.Name = "btnNG";
            btnNG.Size = new Size(86, 31);
            btnNG.TabIndex = 16;
            btnNG.Text = "New Game";
            btnNG.UseVisualStyleBackColor = true;
            btnNG.Click += btnNG_Click;
            // 
            // txtDisp
            // 
            txtDisp.Enabled = false;
            txtDisp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisp.Location = new Point(12, 719);
            txtDisp.Margin = new Padding(3, 4, 3, 4);
            txtDisp.Name = "txtDisp";
            txtDisp.Size = new Size(238, 27);
            txtDisp.TabIndex = 17;
            txtDisp.Text = "Ready to play!";
            txtDisp.TextChanged += txtDisp_TextChanged;
            // 
            // chkAI
            // 
            chkAI.AutoSize = true;
            chkAI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkAI.Location = new Point(257, 723);
            chkAI.Margin = new Padding(3, 4, 3, 4);
            chkAI.Name = "chkAI";
            chkAI.Size = new Size(47, 24);
            chkAI.TabIndex = 18;
            chkAI.Text = "AI";
            chkAI.UseVisualStyleBackColor = true;
            chkAI.CheckedChanged += chkAI_CheckedChanged;
            // 
            // btn56
            // 
            btn56.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn56.BackgroundImageLayout = ImageLayout.Stretch;
            btn56.Location = new Point(605, 16);
            btn56.Margin = new Padding(3, 4, 3, 4);
            btn56.Name = "btn56";
            btn56.Size = new Size(91, 107);
            btn56.TabIndex = 21;
            btn56.UseVisualStyleBackColor = true;
            // 
            // btn55
            // 
            btn55.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn55.BackgroundImageLayout = ImageLayout.Stretch;
            btn55.Location = new Point(507, 16);
            btn55.Margin = new Padding(3, 4, 3, 4);
            btn55.Name = "btn55";
            btn55.Size = new Size(91, 107);
            btn55.TabIndex = 20;
            btn55.UseVisualStyleBackColor = true;
            // 
            // btn54
            // 
            btn54.BackColor = Color.White;
            btn54.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn54.BackgroundImageLayout = ImageLayout.Stretch;
            btn54.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn54.Location = new Point(409, 16);
            btn54.Margin = new Padding(3, 4, 3, 4);
            btn54.Name = "btn54";
            btn54.Size = new Size(91, 107);
            btn54.TabIndex = 19;
            btn54.UseVisualStyleBackColor = false;
            // 
            // btn46
            // 
            btn46.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn46.BackgroundImageLayout = ImageLayout.Stretch;
            btn46.Location = new Point(605, 131);
            btn46.Margin = new Padding(3, 4, 3, 4);
            btn46.Name = "btn46";
            btn46.Size = new Size(91, 107);
            btn46.TabIndex = 24;
            btn46.UseVisualStyleBackColor = true;
            // 
            // btn45
            // 
            btn45.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn45.BackgroundImageLayout = ImageLayout.Stretch;
            btn45.Location = new Point(507, 131);
            btn45.Margin = new Padding(3, 4, 3, 4);
            btn45.Name = "btn45";
            btn45.Size = new Size(91, 107);
            btn45.TabIndex = 23;
            btn45.UseVisualStyleBackColor = true;
            // 
            // btn44
            // 
            btn44.BackColor = Color.White;
            btn44.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn44.BackgroundImageLayout = ImageLayout.Stretch;
            btn44.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn44.Location = new Point(409, 131);
            btn44.Margin = new Padding(3, 4, 3, 4);
            btn44.Name = "btn44";
            btn44.Size = new Size(91, 107);
            btn44.TabIndex = 22;
            btn44.UseVisualStyleBackColor = false;
            // 
            // btn36
            // 
            btn36.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn36.BackgroundImageLayout = ImageLayout.Stretch;
            btn36.Location = new Point(605, 246);
            btn36.Margin = new Padding(3, 4, 3, 4);
            btn36.Name = "btn36";
            btn36.Size = new Size(91, 107);
            btn36.TabIndex = 27;
            btn36.UseVisualStyleBackColor = true;
            // 
            // btn35
            // 
            btn35.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn35.BackgroundImageLayout = ImageLayout.Stretch;
            btn35.Location = new Point(507, 246);
            btn35.Margin = new Padding(3, 4, 3, 4);
            btn35.Name = "btn35";
            btn35.Size = new Size(91, 107);
            btn35.TabIndex = 26;
            btn35.UseVisualStyleBackColor = true;
            // 
            // btn34
            // 
            btn34.BackColor = Color.White;
            btn34.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn34.BackgroundImageLayout = ImageLayout.Stretch;
            btn34.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn34.Location = new Point(409, 246);
            btn34.Margin = new Padding(3, 4, 3, 4);
            btn34.Name = "btn34";
            btn34.Size = new Size(91, 107);
            btn34.TabIndex = 25;
            btn34.UseVisualStyleBackColor = false;
            // 
            // btn26
            // 
            btn26.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn26.BackgroundImageLayout = ImageLayout.Stretch;
            btn26.Location = new Point(605, 361);
            btn26.Margin = new Padding(3, 4, 3, 4);
            btn26.Name = "btn26";
            btn26.Size = new Size(91, 107);
            btn26.TabIndex = 30;
            btn26.UseVisualStyleBackColor = true;
            // 
            // btn25
            // 
            btn25.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn25.BackgroundImageLayout = ImageLayout.Stretch;
            btn25.Location = new Point(507, 361);
            btn25.Margin = new Padding(3, 4, 3, 4);
            btn25.Name = "btn25";
            btn25.Size = new Size(91, 107);
            btn25.TabIndex = 29;
            btn25.UseVisualStyleBackColor = true;
            // 
            // btn24
            // 
            btn24.BackColor = Color.White;
            btn24.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn24.BackgroundImageLayout = ImageLayout.Stretch;
            btn24.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn24.Location = new Point(409, 361);
            btn24.Margin = new Padding(3, 4, 3, 4);
            btn24.Name = "btn24";
            btn24.Size = new Size(91, 107);
            btn24.TabIndex = 28;
            btn24.UseVisualStyleBackColor = false;
            // 
            // btn16
            // 
            btn16.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn16.BackgroundImageLayout = ImageLayout.Stretch;
            btn16.Location = new Point(605, 476);
            btn16.Margin = new Padding(3, 4, 3, 4);
            btn16.Name = "btn16";
            btn16.Size = new Size(91, 107);
            btn16.TabIndex = 37;
            btn16.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            btn14.BackColor = Color.White;
            btn14.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn14.BackgroundImageLayout = ImageLayout.Stretch;
            btn14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn14.Location = new Point(409, 476);
            btn14.Margin = new Padding(3, 4, 3, 4);
            btn14.Name = "btn14";
            btn14.Size = new Size(91, 107);
            btn14.TabIndex = 35;
            btn14.UseVisualStyleBackColor = false;
            // 
            // btn13
            // 
            btn13.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn13.BackgroundImageLayout = ImageLayout.Stretch;
            btn13.Location = new Point(309, 475);
            btn13.Margin = new Padding(3, 4, 3, 4);
            btn13.Name = "btn13";
            btn13.Size = new Size(91, 107);
            btn13.TabIndex = 34;
            btn13.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            btn12.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn12.BackgroundImageLayout = ImageLayout.Stretch;
            btn12.Location = new Point(210, 475);
            btn12.Margin = new Padding(3, 4, 3, 4);
            btn12.Name = "btn12";
            btn12.Size = new Size(91, 107);
            btn12.TabIndex = 33;
            btn12.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            btn11.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn11.BackgroundImageLayout = ImageLayout.Stretch;
            btn11.Location = new Point(112, 475);
            btn11.Margin = new Padding(3, 4, 3, 4);
            btn11.Name = "btn11";
            btn11.Size = new Size(91, 107);
            btn11.TabIndex = 32;
            btn11.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            btn10.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn10.BackgroundImageLayout = ImageLayout.Stretch;
            btn10.Location = new Point(14, 475);
            btn10.Margin = new Padding(3, 4, 3, 4);
            btn10.Name = "btn10";
            btn10.Size = new Size(91, 107);
            btn10.TabIndex = 31;
            btn10.UseVisualStyleBackColor = true;
            // 
            // btn06
            // 
            btn06.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn06.BackgroundImageLayout = ImageLayout.Stretch;
            btn06.Location = new Point(605, 591);
            btn06.Margin = new Padding(3, 4, 3, 4);
            btn06.Name = "btn06";
            btn06.Size = new Size(91, 107);
            btn06.TabIndex = 44;
            btn06.UseVisualStyleBackColor = true;
            // 
            // btn05
            // 
            btn05.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn05.BackgroundImageLayout = ImageLayout.Stretch;
            btn05.Location = new Point(507, 591);
            btn05.Margin = new Padding(3, 4, 3, 4);
            btn05.Name = "btn05";
            btn05.Size = new Size(91, 107);
            btn05.TabIndex = 43;
            btn05.UseVisualStyleBackColor = true;
            // 
            // btn04
            // 
            btn04.BackColor = Color.White;
            btn04.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn04.BackgroundImageLayout = ImageLayout.Stretch;
            btn04.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn04.Location = new Point(409, 591);
            btn04.Margin = new Padding(3, 4, 3, 4);
            btn04.Name = "btn04";
            btn04.Size = new Size(91, 107);
            btn04.TabIndex = 42;
            btn04.UseVisualStyleBackColor = false;
            // 
            // btn03
            // 
            btn03.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn03.BackgroundImageLayout = ImageLayout.Stretch;
            btn03.Location = new Point(309, 590);
            btn03.Margin = new Padding(3, 4, 3, 4);
            btn03.Name = "btn03";
            btn03.Size = new Size(91, 107);
            btn03.TabIndex = 41;
            btn03.UseVisualStyleBackColor = true;
            // 
            // btn02
            // 
            btn02.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn02.BackgroundImageLayout = ImageLayout.Stretch;
            btn02.Location = new Point(210, 590);
            btn02.Margin = new Padding(3, 4, 3, 4);
            btn02.Name = "btn02";
            btn02.Size = new Size(91, 107);
            btn02.TabIndex = 40;
            btn02.UseVisualStyleBackColor = true;
            // 
            // btn01
            // 
            btn01.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn01.BackgroundImageLayout = ImageLayout.Stretch;
            btn01.Location = new Point(112, 590);
            btn01.Margin = new Padding(3, 4, 3, 4);
            btn01.Name = "btn01";
            btn01.Size = new Size(91, 107);
            btn01.TabIndex = 39;
            btn01.UseVisualStyleBackColor = true;
            // 
            // btn00
            // 
            btn00.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn00.BackgroundImageLayout = ImageLayout.Stretch;
            btn00.Location = new Point(14, 590);
            btn00.Margin = new Padding(3, 4, 3, 4);
            btn00.Name = "btn00";
            btn00.Size = new Size(91, 107);
            btn00.TabIndex = 38;
            btn00.UseVisualStyleBackColor = true;
            // 
            // btn40
            // 
            btn40.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn40.BackgroundImageLayout = ImageLayout.Stretch;
            btn40.Location = new Point(14, 131);
            btn40.Margin = new Padding(3, 4, 3, 4);
            btn40.Name = "btn40";
            btn40.Size = new Size(91, 107);
            btn40.TabIndex = 4;
            btn40.UseVisualStyleBackColor = true;
            btn40.Click += col1Click;
            // 
            // btn41
            // 
            btn41.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn41.BackgroundImageLayout = ImageLayout.Stretch;
            btn41.Location = new Point(112, 131);
            btn41.Margin = new Padding(3, 4, 3, 4);
            btn41.Name = "btn41";
            btn41.Size = new Size(91, 107);
            btn41.TabIndex = 5;
            btn41.UseVisualStyleBackColor = true;
            btn41.Click += col2Click;
            // 
            // btn42
            // 
            btn42.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn42.BackgroundImageLayout = ImageLayout.Stretch;
            btn42.Location = new Point(210, 131);
            btn42.Margin = new Padding(3, 4, 3, 4);
            btn42.Name = "btn42";
            btn42.Size = new Size(91, 107);
            btn42.TabIndex = 6;
            btn42.UseVisualStyleBackColor = true;
            btn42.Click += col3Click;
            // 
            // btn43
            // 
            btn43.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn43.BackgroundImageLayout = ImageLayout.Stretch;
            btn43.Location = new Point(309, 131);
            btn43.Margin = new Padding(3, 4, 3, 4);
            btn43.Name = "btn43";
            btn43.Size = new Size(91, 107);
            btn43.TabIndex = 7;
            btn43.UseVisualStyleBackColor = true;
            btn43.Click += col4Click;
            // 
            // btn30
            // 
            btn30.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn30.BackgroundImageLayout = ImageLayout.Stretch;
            btn30.Location = new Point(14, 245);
            btn30.Margin = new Padding(3, 4, 3, 4);
            btn30.Name = "btn30";
            btn30.Size = new Size(91, 107);
            btn30.TabIndex = 8;
            btn30.UseVisualStyleBackColor = true;
            btn30.Click += col1Click;
            // 
            // btn31
            // 
            btn31.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn31.BackgroundImageLayout = ImageLayout.Stretch;
            btn31.Location = new Point(112, 245);
            btn31.Margin = new Padding(3, 4, 3, 4);
            btn31.Name = "btn31";
            btn31.Size = new Size(91, 107);
            btn31.TabIndex = 9;
            btn31.UseVisualStyleBackColor = true;
            btn31.Click += col2Click;
            // 
            // btn32
            // 
            btn32.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn32.BackgroundImageLayout = ImageLayout.Stretch;
            btn32.Location = new Point(210, 245);
            btn32.Margin = new Padding(3, 4, 3, 4);
            btn32.Name = "btn32";
            btn32.Size = new Size(91, 107);
            btn32.TabIndex = 10;
            btn32.UseVisualStyleBackColor = true;
            btn32.Click += col3Click;
            // 
            // btn33
            // 
            btn33.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn33.BackgroundImageLayout = ImageLayout.Stretch;
            btn33.Location = new Point(309, 245);
            btn33.Margin = new Padding(3, 4, 3, 4);
            btn33.Name = "btn33";
            btn33.Size = new Size(91, 107);
            btn33.TabIndex = 11;
            btn33.UseVisualStyleBackColor = true;
            btn33.Click += col4Click;
            // 
            // btn20
            // 
            btn20.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn20.BackgroundImageLayout = ImageLayout.Stretch;
            btn20.Location = new Point(14, 360);
            btn20.Margin = new Padding(3, 4, 3, 4);
            btn20.Name = "btn20";
            btn20.Size = new Size(91, 107);
            btn20.TabIndex = 12;
            btn20.UseVisualStyleBackColor = true;
            btn20.Click += col1Click;
            // 
            // btn21
            // 
            btn21.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn21.BackgroundImageLayout = ImageLayout.Stretch;
            btn21.Location = new Point(112, 360);
            btn21.Margin = new Padding(3, 4, 3, 4);
            btn21.Name = "btn21";
            btn21.Size = new Size(91, 107);
            btn21.TabIndex = 13;
            btn21.UseVisualStyleBackColor = true;
            btn21.Click += col2Click;
            // 
            // btn22
            // 
            btn22.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn22.BackgroundImageLayout = ImageLayout.Stretch;
            btn22.Location = new Point(210, 360);
            btn22.Margin = new Padding(3, 4, 3, 4);
            btn22.Name = "btn22";
            btn22.Size = new Size(91, 107);
            btn22.TabIndex = 14;
            btn22.UseVisualStyleBackColor = true;
            btn22.Click += col3Click;
            // 
            // btn23
            // 
            btn23.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn23.BackgroundImageLayout = ImageLayout.Stretch;
            btn23.Location = new Point(309, 360);
            btn23.Margin = new Padding(3, 4, 3, 4);
            btn23.Name = "btn23";
            btn23.Size = new Size(91, 107);
            btn23.TabIndex = 15;
            btn23.UseVisualStyleBackColor = true;
            btn23.Click += col4Click;
            // 
            // btn15
            // 
            btn15.BackColor = Color.White;
            btn15.BackgroundImage = Properties.Resources.hole_Empty__01;
            btn15.BackgroundImageLayout = ImageLayout.Stretch;
            btn15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn15.Location = new Point(506, 475);
            btn15.Margin = new Padding(3, 4, 3, 4);
            btn15.Name = "btn15";
            btn15.Size = new Size(91, 107);
            btn15.TabIndex = 45;
            btn15.UseVisualStyleBackColor = false;
            // 
            // btnerror
            // 
            btnerror.BackColor = SystemColors.MenuHighlight;
            btnerror.BackgroundImage = Properties.Resources.hole_Empty__01;
            btnerror.BackgroundImageLayout = ImageLayout.Stretch;
            btnerror.Location = new Point(410, 719);
            btnerror.Margin = new Padding(3, 4, 3, 4);
            btnerror.Name = "btnerror";
            btnerror.Size = new Size(286, 28);
            btnerror.TabIndex = 46;
            btnerror.UseVisualStyleBackColor = false;
            btnerror.Click += btnerror_Click;
            // 
            // Connect4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 765);
            Controls.Add(btnerror);
            Controls.Add(btn15);
            Controls.Add(btn06);
            Controls.Add(btn05);
            Controls.Add(btn04);
            Controls.Add(btn03);
            Controls.Add(btn02);
            Controls.Add(btn01);
            Controls.Add(btn00);
            Controls.Add(btn16);
            Controls.Add(btn14);
            Controls.Add(btn13);
            Controls.Add(btn12);
            Controls.Add(btn11);
            Controls.Add(btn10);
            Controls.Add(btn26);
            Controls.Add(btn25);
            Controls.Add(btn24);
            Controls.Add(btn36);
            Controls.Add(btn35);
            Controls.Add(btn34);
            Controls.Add(btn46);
            Controls.Add(btn45);
            Controls.Add(btn44);
            Controls.Add(btn56);
            Controls.Add(btn55);
            Controls.Add(btn54);
            Controls.Add(chkAI);
            Controls.Add(txtDisp);
            Controls.Add(btnNG);
            Controls.Add(btn23);
            Controls.Add(btn22);
            Controls.Add(btn21);
            Controls.Add(btn20);
            Controls.Add(btn33);
            Controls.Add(btn32);
            Controls.Add(btn31);
            Controls.Add(btn30);
            Controls.Add(btn43);
            Controls.Add(btn42);
            Controls.Add(btn41);
            Controls.Add(btn40);
            Controls.Add(btn53);
            Controls.Add(btn52);
            Controls.Add(btn51);
            Controls.Add(btn50);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Connect4";
            Text = "Connect 4";
            TransparencyKey = Color.IndianRed;
            Load += Connect4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btn50;
        private Button btn51;
        private Button btn52;
        private Button btn53;
        private Button btnNG;
        private TextBox txtDisp;
        private CheckBox chkAI;
        private Button btn56;
        private Button btn55;
        private Button btn54;
        private Button btn46;
        private Button btn45;
        private Button btn44;
        private Button btn36;
        private Button btn35;
        private Button btn34;
        private Button btn26;
        private Button btn25;
        private Button btn24;
        private Button btn16;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button btn14;
        private Button btn13;
        private Button btn12;
        private Button btn11;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button btn10;
        private Button btn06;
        private Button btn05;
        private Button btn04;
        private Button btn03;
        private Button btn02;
        private Button btn01;
        private Button btn00;
        private Button btn40;
        private Button btn41;
        private Button btn42;
        private Button btn43;
        private Button btn30;
        private Button btn9;
        private Button btn31;
        private Button btn32;
        private Button btn33;
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Button btn13f;
        private Button btn14f;
        private Button btn15f;
        private Button btn23;
        private Button btn15;

        /*
        public Button GetButton(string button)
        {
                foreach (Button b in Controls)
                {
                    if (b.Name == button) 
                    { 
                        return b;
                    }
                }

            btnerror.Visible = true;
            return btnerror;

        }*/

        private Button btnerror;
    }
}