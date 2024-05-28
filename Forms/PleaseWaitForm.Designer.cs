namespace TGAConverter.CustomForms
{
    partial class PleaseWaitForm
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
            this.labelLoadingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLoadingText
            // 
            this.labelLoadingText.AutoSize = true;
            this.labelLoadingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoadingText.Location = new System.Drawing.Point(12, 9);
            this.labelLoadingText.Name = "labelLoadingText";
            this.labelLoadingText.Size = new System.Drawing.Size(279, 26);
            this.labelLoadingText.TabIndex = 0;
            this.labelLoadingText.Text = "Please wait TGAs loading...";
            this.labelLoadingText.UseWaitCursor = true;
            // 
            // PleaseWaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 46);
            this.ControlBox = false;
            this.Controls.Add(this.labelLoadingText);
            this.Name = "PleaseWaitForm";
            this.Text = "Loading please wait...";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.PleaseWaitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoadingText;
    }
}