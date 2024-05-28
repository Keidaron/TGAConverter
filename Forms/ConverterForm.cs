using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TGAConverter.CustomForms;

namespace TGAConverter
{
    public partial class TGAConverter : Form
    {
        private FileLoader m_fileLoader = new FileLoader();

        private ImageList m_list;

        public TGAConverter()
        {
            InitializeComponent();
        }

        // When the programm, more the form loads
        private void TGAConverter_Load(object sender, EventArgs e)
        {
            textBoxInputPath.Enabled = false;
            textBoxOutputPath.Enabled = false;
            buttonExportLoadedTGAs.Enabled = false;
            
            m_list = new ImageList();
            m_list.ImageSize = new Size(128, 128);

            imagesList.LargeImageList = m_list;
        }

        // InputFolderButton Event
        private void buttonSelectInput_Click(object sender, EventArgs e)
        {
            m_fileLoader.m_selectedInputPath = SelectFolderPath();
            this.textBoxInputPath.Text = m_fileLoader.m_selectedInputPath;
        }

        // OutputFolderButton Event
        private void buttonSelectOutput_Click(object sender, EventArgs e)
        {
            m_fileLoader.m_selectedOutputPath = SelectFolderPath();
            this.textBoxOutputPath.Text = m_fileLoader.m_selectedOutputPath;
        }

        // LoadTGAFilesButton Event
        private void loadTGAButton_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(m_fileLoader.m_selectedInputPath))
            {
                RenderMessageForm("Directory not found", "Selected input path was not found.");
                return;
            }

            PleaseWaitForm.ShowWaitForm("Loading TGA Textures...");

            m_fileLoader.LoadTGAFiles(out int _tgaCount);
            RenderImagesToForm();

            PleaseWaitForm.CloseWaitForm();
            MessageBox.Show(this, $"Loaded {_tgaCount} TGA Files successfully!", "TGAs Loaded!", MessageBoxButtons.OK);
            buttonExportLoadedTGAs.Enabled = true;
        }

        // ExportTGAFilesButton Event
        private void buttonExportLoadedTGAs_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(m_fileLoader.m_selectedOutputPath))
            {
                RenderMessageForm("Directory not found", "Selected output path was not found.");
                return;
            }

            m_fileLoader.ExportImageAsPNG();
        }

        private void RenderMessageForm(string MessageFormText, string MessageFormTitle)
        {
            MessageBox.Show(this, MessageFormTitle, MessageFormText, MessageBoxButtons.OK);
        }


        private string SelectFolderPath()
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                // Setze die Beschreibung des Dialogs
                folderDialog.Description = "Select a folder containing TGA Textures.";
                DialogResult result = folderDialog.ShowDialog();

                // Überprüfe, ob der Benutzer "OK" ausgewählt hat und gebe den ausgewählten Pfad zurück
                if (result == DialogResult.OK)
                    return folderDialog.SelectedPath;

                return string.Empty;
            }
        }

        private void RenderImagesToForm()
        {
            foreach (KeyValuePair<string, Image> entry in m_fileLoader.LoadedImages)
            {
                m_list.Images.Add(entry.Value);
            }

            for (int i = 0; i < m_list.Images.Count; i++)
            {
                imagesList.Items.Add(new ListViewItem("",i));
            }
        }
    }
}
