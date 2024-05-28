using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TGAConverter.CustomForms
{
    public partial class PleaseWaitForm : Form
    {
        private static PleaseWaitForm m_waitForm;

        public PleaseWaitForm()
        {
            InitializeComponent();
        }

        private void PleaseWaitForm_Load(object sender, EventArgs e)
        {

        }

        public static void ShowWaitForm(string message)
        {
            // don't display more than one wait form at a time
            if (m_waitForm != null && !m_waitForm.IsDisposed)
            {
                return;
            }

            m_waitForm = new PleaseWaitForm();
            m_waitForm.labelLoadingText.Text = message; // "Loading data. Please wait..."
            m_waitForm.TopMost = true;
            m_waitForm.StartPosition = FormStartPosition.CenterScreen;
            m_waitForm.Show();
            m_waitForm.Refresh();
        }

        public static void CloseWaitForm()
        {
            m_waitForm.Close();
        }
    }
}
