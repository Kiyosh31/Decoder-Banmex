﻿namespace Banmex.CancelForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelTransaction));
            this.canceledDataGriedView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.canceledDataGriedView)).BeginInit();
            this.SuspendLayout();
            // 
            // canceledDataGriedView
            // 
            this.canceledDataGriedView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canceledDataGriedView.Location = new System.Drawing.Point(13, 88);
            this.canceledDataGriedView.Name = "canceledDataGriedView";
            this.canceledDataGriedView.RowTemplate.Height = 24;
            this.canceledDataGriedView.Size = new System.Drawing.Size(1047, 424);
            this.canceledDataGriedView.TabIndex = 0;
            // 
            // CancelTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1072, 521);
            this.Controls.Add(this.canceledDataGriedView);
            this.Name = "CancelTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Transaccion";
            this.Load += new System.EventHandler(this.CancelTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canceledDataGriedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView canceledDataGriedView;
    }
}