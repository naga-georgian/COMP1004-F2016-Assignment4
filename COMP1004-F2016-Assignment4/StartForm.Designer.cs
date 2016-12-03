namespace COMP1004_F2016_Assignment4
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.WelcomeGroupBox = new System.Windows.Forms.GroupBox();
            this.WelcomeTextBox = new System.Windows.Forms.TextBox();
            this.AboutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeGroupBox
            // 
            this.WelcomeGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeGroupBox.Controls.Add(this.WelcomeTextBox);
            this.WelcomeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeGroupBox.Location = new System.Drawing.Point(17, 48);
            this.WelcomeGroupBox.Name = "WelcomeGroupBox";
            this.WelcomeGroupBox.Size = new System.Drawing.Size(379, 102);
            this.WelcomeGroupBox.TabIndex = 11;
            this.WelcomeGroupBox.TabStop = false;
            this.WelcomeGroupBox.Text = "Welcome!";
            // 
            // WelcomeTextBox
            // 
            this.WelcomeTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.WelcomeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WelcomeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeTextBox.Location = new System.Drawing.Point(6, 22);
            this.WelcomeTextBox.Multiline = true;
            this.WelcomeTextBox.Name = "WelcomeTextBox";
            this.WelcomeTextBox.ReadOnly = true;
            this.WelcomeTextBox.Size = new System.Drawing.Size(367, 74);
            this.WelcomeTextBox.TabIndex = 5;
            this.WelcomeTextBox.TabStop = false;
            this.WelcomeTextBox.Text = resources.GetString("WelcomeTextBox.Text");
            // 
            // AboutLinkLabel
            // 
            this.AboutLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.AboutLinkLabel.AutoSize = true;
            this.AboutLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.AboutLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutLinkLabel.Location = new System.Drawing.Point(14, 210);
            this.AboutLinkLabel.Name = "AboutLinkLabel";
            this.AboutLinkLabel.Size = new System.Drawing.Size(119, 16);
            this.AboutLinkLabel.TabIndex = 2;
            this.AboutLinkLabel.TabStop = true;
            this.AboutLinkLabel.Text = "About the Software";
            this.AboutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AboutLinkLabel_LinkClicked);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.AutoSize = true;
            this.LoadOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LoadOrderButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.LoadOrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoadOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LoadOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadOrderButton.Location = new System.Drawing.Point(293, 167);
            this.LoadOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(103, 29);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "Load Order";
            this.LoadOrderButton.UseVisualStyleBackColor = false;
            this.LoadOrderButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.AutoSize = true;
            this.NewOrderButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NewOrderButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewOrderButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewOrderButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NewOrderButton.FlatAppearance.BorderSize = 2;
            this.NewOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.NewOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.NewOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrderButton.Location = new System.Drawing.Point(187, 167);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(98, 29);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "New Order";
            this.NewOrderButton.UseVisualStyleBackColor = false;
            this.NewOrderButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TitleLabel.Location = new System.Drawing.Point(13, 9);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(171, 24);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Dollar Computers";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ExitButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExitButton.FlatAppearance.BorderSize = 2;
            this.ExitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(17, 167);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(49, 29);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.FormButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::COMP1004_F2016_Assignment4.Properties.Resources.outline_computer2;
            this.pictureBox1.Location = new System.Drawing.Point(238, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 235);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.WelcomeGroupBox);
            this.Controls.Add(this.AboutLinkLabel);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Your Computer Today!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_FormClosing);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.WelcomeGroupBox.ResumeLayout(false);
            this.WelcomeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox WelcomeGroupBox;
        private System.Windows.Forms.TextBox WelcomeTextBox;
        private System.Windows.Forms.LinkLabel AboutLinkLabel;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}