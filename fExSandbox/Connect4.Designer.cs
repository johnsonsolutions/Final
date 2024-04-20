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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect4));
            btnNG = new Button();
            chkAI = new CheckBox();
            btnClose = new Button();
            txtDisp = new Label();
            SuspendLayout();
            // 
            // btnNG
            // 
            btnNG.BackColor = Color.Transparent;
            btnNG.BackgroundImage = Properties.Resources.bubble2;
            btnNG.BackgroundImageLayout = ImageLayout.Stretch;
            btnNG.FlatAppearance.BorderSize = 0;
            btnNG.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNG.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNG.FlatStyle = FlatStyle.Flat;
            btnNG.ForeColor = Color.Beige;
            btnNG.Location = new Point(448, 573);
            btnNG.Name = "btnNG";
            btnNG.Size = new Size(75, 23);
            btnNG.TabIndex = 16;
            btnNG.Text = "New Game";
            btnNG.UseVisualStyleBackColor = false;
            btnNG.Click += btnNG_Click;
            // 
            // chkAI
            // 
            chkAI.AutoSize = true;
            chkAI.BackColor = Color.Transparent;
            chkAI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkAI.ForeColor = Color.Beige;
            chkAI.Location = new Point(12, 576);
            chkAI.Name = "chkAI";
            chkAI.Size = new Size(38, 19);
            chkAI.TabIndex = 18;
            chkAI.Text = "AI";
            chkAI.UseVisualStyleBackColor = false;
            chkAI.CheckedChanged += chkAI_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.bubble2;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Beige;
            btnClose.Location = new Point(529, 573);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 46;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtDisp
            // 
            txtDisp.AutoSize = true;
            txtDisp.BackColor = Color.Transparent;
            txtDisp.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtDisp.ForeColor = Color.Beige;
            txtDisp.Location = new Point(238, 9);
            txtDisp.Name = "txtDisp";
            txtDisp.Size = new Size(145, 37);
            txtDisp.TabIndex = 47;
            txtDisp.Text = "Connect 4";
            txtDisp.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Connect4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.DAVINCI_1712499043055;
            ClientSize = new Size(623, 608);
            ControlBox = false;
            Controls.Add(txtDisp);
            Controls.Add(chkAI);
            Controls.Add(btnClose);
            Controls.Add(btnNG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Connect4";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            TransparencyKey = Color.IndianRed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        //row 1
        public Button btn50;
        private Button btn51;
        private Button btn52;
        private Button btn53;
        private Button btn54;
        private Button btn55;
        private Button btn56;

        //row 2
        private Button btn40;
        private Button btn41;
        private Button btn42;
        private Button btn43;
        private Button btn44;
        private Button btn45;
        private Button btn46;

        //row 3
        private Button btn30;
        private Button btn31;
        private Button btn32;
        private Button btn33;
        private Button btn34;
        private Button btn35;
        private Button btn36;

        //row 4
        private Button btn20;
        private Button btn21;
        private Button btn22;
        private Button btn23;
        private Button btn24;
        private Button btn25;
        private Button btn26;

        //row 5
        private Button btn10;
        private Button btn11;
        private Button btn12;
        private Button btn13;
        private Button btn14;
        private Button btn15;
        private Button btn16;

        //row 6
        private Button btn00;
        private Button btn01;
        private Button btn02;
        private Button btn03;
        private Button btn04;
        private Button btn05;
        private Button btn06;

        //game buttons
        private Button btnNG;
        private Label txtDisp;
        private CheckBox chkAI;

        //other buttons
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button btn9;
        private Button btn13f;
        private Button btn14f;
        private Button btn15f;
        private Button btnClose;
    }
}