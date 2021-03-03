using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RSA_Generator
{
    public static class Functions
    {
        public static void Cut(TextEdit textEdit)
        {
            if (!string.IsNullOrEmpty(textEdit.Text))
            {
                var textSelected = textEdit.SelectedText;
                textEdit.Text = textEdit.Text.Replace(textSelected, string.Empty);
                Clipboard.SetText(textSelected);
            }
        }

        public static void Copy(TextEdit textEdit)
        {
            if (!string.IsNullOrEmpty(textEdit.SelectedText))
            {
                Clipboard.SetText(textEdit.SelectedText);
            }
        }

        public static void Paste(TextEdit textEdit)
        {
            if (!string.IsNullOrEmpty(Clipboard.GetText()))
            {
                textEdit.Text = Clipboard.GetText();
            }
        }

        public static void Clear(TextEdit textEdit)
        {
            textEdit.ResetText();
        }

        public static void SelectAll(TextEdit textEdit)
        {
            textEdit.SelectAll();
        }
    }
}
