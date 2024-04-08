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
            txtDisp = new TextBox();
            chkAI = new CheckBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // btnNG
            // 
            btnNG.BackColor = Color.Transparent;
            btnNG.BackgroundImage = Properties.Resources.btnOutline1_01;
            btnNG.BackgroundImageLayout = ImageLayout.Stretch;
            btnNG.FlatAppearance.BorderSize = 0;
            btnNG.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnNG.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnNG.FlatStyle = FlatStyle.Flat;
            btnNG.ForeColor = Color.White;
            btnNG.Location = new Point(17, 539);
            btnNG.Name = "btnNG";
            btnNG.Size = new Size(75, 23);
            btnNG.TabIndex = 16;
            btnNG.Text = "New Game";
            btnNG.UseVisualStyleBackColor = false;
            btnNG.Click += btnNG_Click;
            btnNG.MouseHover += btnHoverCancel;
            // 
            // txtDisp
            // 
            txtDisp.BackColor = Color.FromArgb(36, 24, 4);
            txtDisp.BorderStyle = BorderStyle.None;
            txtDisp.Enabled = false;
            txtDisp.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDisp.ForeColor = SystemColors.ButtonFace;
            txtDisp.Location = new Point(98, 539);
            txtDisp.Name = "txtDisp";
            txtDisp.Size = new Size(382, 22);
            txtDisp.TabIndex = 17;
            txtDisp.Text = "Ready to play!";
            txtDisp.TextAlign = HorizontalAlignment.Center;
            txtDisp.TextChanged += txtDisp_TextChanged;
            // 
            // chkAI
            // 
            chkAI.AutoSize = true;
            chkAI.BackColor = Color.Transparent;
            chkAI.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            chkAI.ForeColor = Color.White;
            chkAI.Location = new Point(486, 540);
            chkAI.Name = "chkAI";
            chkAI.Size = new Size(37, 19);
            chkAI.TabIndex = 18;
            chkAI.Text = "AI";
            chkAI.UseVisualStyleBackColor = false;
            chkAI.CheckedChanged += chkAI_CheckedChanged;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.btnOutline1_01;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(529, 537);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 46;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            btnClose.MouseHover += btnHoverCancel;
            // 
            // Connect4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DAVINCI_1712499043055;
            ClientSize = new Size(623, 574);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(chkAI);
            Controls.Add(txtDisp);
            Controls.Add(btnNG);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Connect4";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Team 2: Connect 4";
            TransparencyKey = Color.IndianRed;
            Load += Connect4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNG;
        private TextBox txtDisp;
        private CheckBox chkAI;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button btn13f;
        private Button btn14f;
        private Button btn15f;
        private Button btnClose;
    }
}