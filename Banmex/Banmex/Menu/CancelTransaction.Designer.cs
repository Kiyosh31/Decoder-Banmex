﻿namespace Banmex.Menu
{
    partial class CancelTransaction
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
            this.canceltGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.canceltGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // canceltGridView
            // 
            this.canceltGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canceltGridView.Location = new System.Drawing.Point(13, 13);
            this.canceltGridView.Name = "canceltGridView";
            this.canceltGridView.RowTemplate.Height = 24;
            this.canceltGridView.Size = new System.Drawing.Size(602, 419);
            this.canceltGridView.TabIndex = 0;
            // 
            // CancelTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 444);
            this.Controls.Add(this.canceltGridView);
            this.Name = "CancelTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Transaccion";
            this.Load += new System.EventHandler(this.CancelTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canceltGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView canceltGridView;
    }
}