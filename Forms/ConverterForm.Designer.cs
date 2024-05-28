using System.Windows.Forms;

namespace TGAConverter
{
    partial class TGAConverter
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
            this.Text = "TGA Converter";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            this.buttonSelectInput = new System.Windows.Forms.Button();
            this.fileInputOutputPanel = new System.Windows.Forms.Panel();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelInput = new System.Windows.Forms.Label();
            this.buttonSelectOutput = new System.Windows.Forms.Button();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.textBoxInputPath = new System.Windows.Forms.TextBox();
            this.imagesList = new System.Windows.Forms.ListView();
            this.buttonLoadTGA = new System.Windows.Forms.Button();
            this.buttonExportLoadedTGAs = new System.Windows.Forms.Button();
            this.fileInputOutputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectInput
            // 
            this.buttonSelectInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectInput.Location = new System.Drawing.Point(848, 7);
            this.buttonSelectInput.Name = "buttonSelectInput";
            this.buttonSelectInput.Size = new System.Drawing.Size(41, 21);
            this.buttonSelectInput.TabIndex = 0;
            this.buttonSelectInput.Text = "...";
            this.buttonSelectInput.UseVisualStyleBackColor = true;
            this.buttonSelectInput.Click += new System.EventHandler(this.buttonSelectInput_Click);
            // 
            // fileInputOutputPanel
            // 
            this.fileInputOutputPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileInputOutputPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.fileInputOutputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fileInputOutputPanel.Controls.Add(this.labelOutput);
            this.fileInputOutputPanel.Controls.Add(this.labelInput);
            this.fileInputOutputPanel.Controls.Add(this.buttonSelectOutput);
            this.fileInputOutputPanel.Controls.Add(this.textBoxOutputPath);
            this.fileInputOutputPanel.Controls.Add(this.textBoxInputPath);
            this.fileInputOutputPanel.Controls.Add(this.buttonSelectInput);
            this.fileInputOutputPanel.Location = new System.Drawing.Point(13, 13);
            this.fileInputOutputPanel.Name = "fileInputOutputPanel";
            this.fileInputOutputPanel.Size = new System.Drawing.Size(912, 61);
            this.fileInputOutputPanel.TabIndex = 1;
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 36);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(64, 13);
            this.labelOutput.TabIndex = 5;
            this.labelOutput.Text = "Output Path";
            this.labelOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 11);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(56, 13);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Input Path";
            this.labelInput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSelectOutput
            // 
            this.buttonSelectOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectOutput.Location = new System.Drawing.Point(848, 32);
            this.buttonSelectOutput.Name = "buttonSelectOutput";
            this.buttonSelectOutput.Size = new System.Drawing.Size(41, 21);
            this.buttonSelectOutput.TabIndex = 3;
            this.buttonSelectOutput.Text = "...";
            this.buttonSelectOutput.UseVisualStyleBackColor = true;
            this.buttonSelectOutput.Click += new System.EventHandler(this.buttonSelectOutput_Click);
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputPath.Location = new System.Drawing.Point(89, 33);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.ReadOnly = true;
            this.textBoxOutputPath.Size = new System.Drawing.Size(753, 20);
            this.textBoxOutputPath.TabIndex = 2;
            // 
            // textBoxInputPath
            // 
            this.textBoxInputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInputPath.Location = new System.Drawing.Point(89, 7);
            this.textBoxInputPath.Name = "textBoxInputPath";
            this.textBoxInputPath.ReadOnly = true;
            this.textBoxInputPath.Size = new System.Drawing.Size(753, 20);
            this.textBoxInputPath.TabIndex = 1;
            // 
            // imagesList
            // 
            this.imagesList.HideSelection = false;
            this.imagesList.Location = new System.Drawing.Point(13, 110);
            this.imagesList.Name = "imagesList";
            this.imagesList.Size = new System.Drawing.Size(912, 460);
            this.imagesList.TabIndex = 2;
            this.imagesList.UseCompatibleStateImageBehavior = false;
            // 
            // buttonLoadTGA
            // 
            this.buttonLoadTGA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoadTGA.Location = new System.Drawing.Point(12, 81);
            this.buttonLoadTGA.Name = "buttonLoadTGA";
            this.buttonLoadTGA.Size = new System.Drawing.Size(103, 23);
            this.buttonLoadTGA.TabIndex = 3;
            this.buttonLoadTGA.Text = "Load TGAs";
            this.buttonLoadTGA.UseVisualStyleBackColor = true;
            this.buttonLoadTGA.Click += new System.EventHandler(this.loadTGAButton_Click);
            // 
            // buttonExportLoadedTGAs
            // 
            this.buttonExportLoadedTGAs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExportLoadedTGAs.Location = new System.Drawing.Point(121, 81);
            this.buttonExportLoadedTGAs.Name = "buttonExportLoadedTGAs";
            this.buttonExportLoadedTGAs.Size = new System.Drawing.Size(132, 23);
            this.buttonExportLoadedTGAs.TabIndex = 4;
            this.buttonExportLoadedTGAs.Text = "Export Loaded Images";
            this.buttonExportLoadedTGAs.UseVisualStyleBackColor = true;
            this.buttonExportLoadedTGAs.Click += new System.EventHandler(this.buttonExportLoadedTGAs_Click);
            // 
            // TGAConverter
            // 
            this.ClientSize = new System.Drawing.Size(937, 582);
            this.Controls.Add(this.buttonExportLoadedTGAs);
            this.Controls.Add(this.buttonLoadTGA);
            this.Controls.Add(this.imagesList);
            this.Controls.Add(this.fileInputOutputPanel);
            this.MaximizeBox = false;
            this.Name = "TGAConverter";
            this.Load += new System.EventHandler(this.TGAConverter_Load);
            this.fileInputOutputPanel.ResumeLayout(false);
            this.fileInputOutputPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectInput;
        private System.Windows.Forms.Panel fileInputOutputPanel;
        private System.Windows.Forms.TextBox textBoxInputPath;
        private System.Windows.Forms.Button buttonSelectOutput;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.ListView imagesList;
        private System.Windows.Forms.Button buttonLoadTGA;
        private System.Windows.Forms.Button buttonExportLoadedTGAs;
    }
}

