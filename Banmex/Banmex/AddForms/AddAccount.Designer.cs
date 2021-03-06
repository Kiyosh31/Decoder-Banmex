﻿namespace Banmex.Menu
{
    partial class AddAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccount));
            this.addButton = new System.Windows.Forms.Button();
            this.nipLabel = new System.Windows.Forms.Label();
            this.niptextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.maximumCreditTextBox = new System.Windows.Forms.TextBox();
            this.maximumCreditLabel = new System.Windows.Forms.Label();
            this.accountTypeComboBox = new System.Windows.Forms.ComboBox();
            this.accountTypeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.Location = new System.Drawing.Point(185, 369);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(136, 67);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // nipLabel
            // 
            this.nipLabel.AutoSize = true;
            this.nipLabel.BackColor = System.Drawing.Color.Transparent;
            this.nipLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nipLabel.Location = new System.Drawing.Point(70, 68);
            this.nipLabel.Name = "nipLabel";
            this.nipLabel.Size = new System.Drawing.Size(29, 17);
            this.nipLabel.TabIndex = 1;
            this.nipLabel.Text = "Nip";
            // 
            // niptextBox
            // 
            this.niptextBox.Location = new System.Drawing.Point(73, 88);
            this.niptextBox.Name = "niptextBox";
            this.niptextBox.PasswordChar = '*';
            this.niptextBox.Size = new System.Drawing.Size(201, 22);
            this.niptextBox.TabIndex = 2;
            this.niptextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.niptextBox_KeyPress);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(73, 144);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.Size = new System.Drawing.Size(201, 22);
            this.balanceTextBox.TabIndex = 4;
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTextBox_KeyPress);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.BackColor = System.Drawing.Color.Transparent;
            this.balanceLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.balanceLabel.Location = new System.Drawing.Point(70, 124);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(44, 17);
            this.balanceLabel.TabIndex = 3;
            this.balanceLabel.Text = "Saldo";
            // 
            // maximumCreditTextBox
            // 
            this.maximumCreditTextBox.Location = new System.Drawing.Point(73, 201);
            this.maximumCreditTextBox.Name = "maximumCreditTextBox";
            this.maximumCreditTextBox.Size = new System.Drawing.Size(201, 22);
            this.maximumCreditTextBox.TabIndex = 6;
            this.maximumCreditTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maximumCreditTextBox_KeyPress);
            // 
            // maximumCreditLabel
            // 
            this.maximumCreditLabel.AutoSize = true;
            this.maximumCreditLabel.BackColor = System.Drawing.Color.Transparent;
            this.maximumCreditLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.maximumCreditLabel.Location = new System.Drawing.Point(70, 181);
            this.maximumCreditLabel.Name = "maximumCreditLabel";
            this.maximumCreditLabel.Size = new System.Drawing.Size(104, 17);
            this.maximumCreditLabel.TabIndex = 5;
            this.maximumCreditLabel.Text = "Credito maximo";
            // 
            // accountTypeComboBox
            // 
            this.accountTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.accountTypeComboBox.FormattingEnabled = true;
            this.accountTypeComboBox.Items.AddRange(new object[] {
            "Credito",
            "Debito"});
            this.accountTypeComboBox.Location = new System.Drawing.Point(73, 266);
            this.accountTypeComboBox.Name = "accountTypeComboBox";
            this.accountTypeComboBox.Size = new System.Drawing.Size(201, 24);
            this.accountTypeComboBox.TabIndex = 9;
            // 
            // accountTypeLabel
            // 
            this.accountTypeLabel.AutoSize = true;
            this.accountTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.accountTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.accountTypeLabel.Location = new System.Drawing.Point(70, 246);
            this.accountTypeLabel.Name = "accountTypeLabel";
            this.accountTypeLabel.Size = new System.Drawing.Size(103, 17);
            this.accountTypeLabel.TabIndex = 10;
            this.accountTypeLabel.Text = "Tipo de cuenta";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(333, 448);
            this.Controls.Add(this.accountTypeLabel);
            this.Controls.Add(this.accountTypeComboBox);
            this.Controls.Add(this.maximumCreditTextBox);
            this.Controls.Add(this.maximumCreditLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.niptextBox);
            this.Controls.Add(this.nipLabel);
            this.Controls.Add(this.addButton);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Cuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label nipLabel;
        private System.Windows.Forms.TextBox niptextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox maximumCreditTextBox;
        private System.Windows.Forms.Label maximumCreditLabel;
        private System.Windows.Forms.ComboBox accountTypeComboBox;
        private System.Windows.Forms.Label accountTypeLabel;
    }
}