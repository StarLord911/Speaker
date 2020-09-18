using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Speach;

namespace Windows.FormMethod
{
    public class Comfortable
    {

        public void OpenDialog(ref OpenFileDialog FileDialog,ref string Path,ref Speached speached,ref PdfViewer pdfViewer,ref string[] book)
        {
            try
            {

                if (FileDialog.ShowDialog() == DialogResult.OK)
                {
                    Path = FileDialog.FileName;
                    book = speached.TextFromPdf(Path);
                    pdfViewer.Document = PdfDocument.Load(Path);
                }
            }
            catch 
            {
                MessageBox.Show("Выберите сначало книгу");
            }
        }
        public void Speak(ref Speached speached, ref string[] book)
        {
            try
            {
                for (int i = 1; i <= book.Length - 1; i++)
                {
                speached.Speak(book[i].ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Выберите сначало книгу");
            }
        }
    }
}
