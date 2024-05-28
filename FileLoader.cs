using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TGAConverter.TGA;

namespace TGAConverter
{
    internal class FileLoader
    {
        public String m_selectedInputPath { get; set; }
        public String m_selectedOutputPath { get; set; }
        public Dictionary<String, Image> LoadedImages { get; set; }

        // Expression-Bodied Constructor -> eine verkürzte Version für die Lesbarkeit
        public FileLoader() => LoadedImages = new Dictionary<String, Image>();


        // Lädt Dateien ins Programm
        public void LoadTGAFiles(out int fileCount)
        {
            fileCount = 0;
            IEnumerable<string> folderContent = Directory.EnumerateFiles(m_selectedInputPath, "*.TGA");
            if (folderContent.Count() <= 0) return;

            foreach (string file in folderContent) // file = ganzer Pfad der Datei (C:\\xyz\\zzz\\test.tga)
            {
                Bitmap bitmap = TGAReader.ReadTGAFile(file).PixelData;
                Image image = (Image)bitmap;
                LoadedImages.Add(file.Remove(0, m_selectedInputPath.Length + 1), image);
                fileCount++;
            }
        }

        // Speichert die geladenen BitMaps als PNG Datei an den Benutzerdefinierten Ort
        public void ExportImageAsPNG()
        {
            // Einfacher Weg um über nen Dictionary zu iterieren
            foreach (KeyValuePair<string, Image> entry in LoadedImages)
            {
                entry.Value.Save($"{m_selectedOutputPath}\\{entry.Key.Replace(".tga", "")}.PNG");
            }

            DialogResult res = MessageBox.Show($"All files exported as PNG to {m_selectedOutputPath}", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}