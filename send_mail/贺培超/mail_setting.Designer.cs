namespace 贺培超
{
    partial class mail_setting
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richtbxMailContentReview = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.richtbxMailContentReview);
            this.groupBox3.Location = new System.Drawing.Point(3, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 368);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "预览";
            // 
            // richtbxMailContentReview
            // 
            this.richtbxMailContentReview.Location = new System.Drawing.Point(6, 17);
            this.richtbxMailContentReview.Name = "richtbxMailContentReview";
            this.richtbxMailContentReview.Size = new System.Drawing.Size(354, 344);
            this.richtbxMailContentReview.TabIndex = 0;
            this.richtbxMailContentReview.Text = "";
            // 
            // mail_setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 382);
            this.Controls.Add(this.groupBox3);
            this.Name = "mail_setting";
            this.Text = "邮件详情";
            this.Load += new System.EventHandler(this.mail_setting_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richtbxMailContentReview;
    }
}