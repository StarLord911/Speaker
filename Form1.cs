using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Speach;
using PdfiumViewer;
using System.Threading;
using Windows.FormMethod;

namespace Windows
{
    
    public partial class Form1 : Form
    {
        #region  prop
        private Speached speached = null;
        private string Path = null;
        private string[] book = null;
        private int currentPage = 1;
        private Comfortable comfortable;
        #endregion

        public Form1()
        {
            InitializeComponent();
            speached = new Speached();
            comfortable = new Comfortable();
        
        }

        private void открытьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            comfortable.OpenDialog(ref FileDialog,ref Path,ref speached,ref pdfViewer,ref book);
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                speached.ss = speached.NextPage();
                currentPage++;
                speached.Speak(book[currentPage].ToString());
            }
            catch
            {
                MessageBox.Show("Выберите сначало книгу");
 
            }
      
        }
        private void startBtn_Click(object sender, EventArgs e)
        {
            //Проиграть содержимое книги  
            comfortable.Speak(ref speached, ref book);
        }
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            speached.Pause();
        }

        private void BeforePgeBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                try
                {
                    speached.ss = speached.NextPage();
                    currentPage--;
                    speached.Speak(book[currentPage].ToString());
                }
                catch
                {
                    MessageBox.Show("Выберите сначало книгу");

                }
            }
        }

        private void volumeBar_Scroll(object sender, EventArgs e)
        {
            speached.Volume = volumeBar.Value;
            Volume.Text = "Volume" + speached.Volume.ToString();
        }

        private void настроикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.Show();
        }

        private void ToPageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                speached.ss = speached.NextPage();
                currentPage = Convert.ToInt32(pageNum.Text);
                speached.Speak(book[currentPage].ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Вы ввели слово вместо числа, пожалуста введите число");
            }
           
        }
    }
}
