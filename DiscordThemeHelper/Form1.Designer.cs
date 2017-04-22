namespace DiscordThemeHelper
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkBox = new System.Windows.Forms.TextBox();
            this.helperButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pathBox = new System.Windows.Forms.TextBox();
            this.helperButton2 = new System.Windows.Forms.Button();
            this.mainButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.clrCodeBox = new System.Windows.Forms.TextBox();
            this.helperButton3 = new System.Windows.Forms.Button();
            this.helperLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Better Discord Theme Helper";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter image link:";
            // 
            // linkBox
            // 
            this.linkBox.Location = new System.Drawing.Point(124, 61);
            this.linkBox.Name = "linkBox";
            this.linkBox.Size = new System.Drawing.Size(147, 20);
            this.linkBox.TabIndex = 2;
            // 
            // helperButton
            // 
            this.helperButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperButton.Location = new System.Drawing.Point(278, 59);
            this.helperButton.Name = "helperButton";
            this.helperButton.Size = new System.Drawing.Size(28, 23);
            this.helperButton.TabIndex = 3;
            this.helperButton.Text = "?";
            this.helperButton.UseVisualStyleBackColor = true;
            this.helperButton.Click += new System.EventHandler(this.helperButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter PC-Username:";
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(141, 87);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(130, 20);
            this.pathBox.TabIndex = 5;
            // 
            // helperButton2
            // 
            this.helperButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperButton2.Location = new System.Drawing.Point(278, 85);
            this.helperButton2.Name = "helperButton2";
            this.helperButton2.Size = new System.Drawing.Size(28, 23);
            this.helperButton2.TabIndex = 6;
            this.helperButton2.Text = "?";
            this.helperButton2.UseVisualStyleBackColor = true;
            this.helperButton2.Click += new System.EventHandler(this.helperButton2_Click);
            // 
            // mainButton
            // 
            this.mainButton.Location = new System.Drawing.Point(66, 149);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(219, 23);
            this.mainButton.TabIndex = 7;
            this.mainButton.Text = "Create my theme!";
            this.mainButton.UseVisualStyleBackColor = true;
            this.mainButton.Click += new System.EventHandler(this.mainButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(85, 178);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(182, 23);
            this.cleanButton.TabIndex = 8;
            this.cleanButton.Text = "Clean up!";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.Click += new System.EventHandler(this.cleanButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter color code:";
            // 
            // clrCodeBox
            // 
            this.clrCodeBox.Location = new System.Drawing.Point(128, 113);
            this.clrCodeBox.Name = "clrCodeBox";
            this.clrCodeBox.Size = new System.Drawing.Size(143, 20);
            this.clrCodeBox.TabIndex = 10;
            // 
            // helperButton3
            // 
            this.helperButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helperButton3.Location = new System.Drawing.Point(277, 111);
            this.helperButton3.Name = "helperButton3";
            this.helperButton3.Size = new System.Drawing.Size(29, 23);
            this.helperButton3.TabIndex = 11;
            this.helperButton3.Text = "?";
            this.helperButton3.UseVisualStyleBackColor = true;
            this.helperButton3.Click += new System.EventHandler(this.helperButton3_Click);
            // 
            // helperLink
            // 
            this.helperLink.AutoSize = true;
            this.helperLink.Location = new System.Drawing.Point(121, 207);
            this.helperLink.Name = "helperLink";
            this.helperLink.Size = new System.Drawing.Size(113, 13);
            this.helperLink.TabIndex = 12;
            this.helperLink.TabStop = true;
            this.helperLink.Text = "How to install themes?";
            this.helperLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.helperLink_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 228);
            this.Controls.Add(this.helperLink);
            this.Controls.Add(this.helperButton3);
            this.Controls.Add(this.clrCodeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.mainButton);
            this.Controls.Add(this.helperButton2);
            this.Controls.Add(this.pathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.helperButton);
            this.Controls.Add(this.linkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Discord Theme Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox linkBox;
        private System.Windows.Forms.Button helperButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button helperButton2;
        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clrCodeBox;
        private System.Windows.Forms.Button helperButton3;
        private System.Windows.Forms.LinkLabel helperLink;
    }
}

