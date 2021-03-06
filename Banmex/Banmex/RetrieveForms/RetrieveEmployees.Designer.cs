﻿namespace Banmex.Menu
{
    partial class RetrieveEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrieveEmployees));
            this.employesGridview = new System.Windows.Forms.DataGridView();
            this.retrieveButton = new System.Windows.Forms.Button();
            this.deleteDefinitely = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // employesGridview
            // 
            this.employesGridview.AllowUserToAddRows = false;
            this.employesGridview.AllowUserToDeleteRows = false;
            this.employesGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employesGridview.Location = new System.Drawing.Point(12, 95);
            this.employesGridview.Name = "employesGridview";
            this.employesGridview.ReadOnly = true;
            this.employesGridview.RowTemplate.Height = 24;
            this.employesGridview.Size = new System.Drawing.Size(746, 439);
            this.employesGridview.TabIndex = 1;
            // 
            // retrieveButton
            // 
            this.retrieveButton.Location = new System.Drawing.Point(783, 131);
            this.retrieveButton.Name = "retrieveButton";
            this.retrieveButton.Size = new System.Drawing.Size(128, 96);
            this.retrieveButton.TabIndex = 2;
            this.retrieveButton.Text = "Reactivar";
            this.retrieveButton.UseVisualStyleBackColor = true;
            this.retrieveButton.Click += new System.EventHandler(this.retrieveButton_Click);
            // 
            // deleteDefinitely
            // 
            this.deleteDefinitely.Location = new System.Drawing.Point(783, 407);
            this.deleteDefinitely.Name = "deleteDefinitely";
            this.deleteDefinitely.Size = new System.Drawing.Size(128, 96);
            this.deleteDefinitely.TabIndex = 3;
            this.deleteDefinitely.Text = "Eliminar Definitivamente";
            this.deleteDefinitely.UseVisualStyleBackColor = true;
            this.deleteDefinitely.Click += new System.EventHandler(this.deleteDefinitely_Click);
            // 
            // RetrieveEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(935, 546);
            this.Controls.Add(this.deleteDefinitely);
            this.Controls.Add(this.retrieveButton);
            this.Controls.Add(this.employesGridview);
            this.Name = "RetrieveEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Empleado BANMEX";
            this.Load += new System.EventHandler(this.RetrieveEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employesGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView employesGridview;
        private System.Windows.Forms.Button retrieveButton;
        private System.Windows.Forms.Button deleteDefinitely;
    }
}