using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintReportForm
{
    public partial class PrintReportDemoForm : Form
    {
        PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
        PrintDocument printDocument1 = new PrintDocument(); 

        public PrintReportDemoForm()
        {
            InitializeComponent();
            printDocument1.PrintPage += PrintDocument1_PrintPage;
        }

        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

            Font headerFont = new Font("Arial", 50, FontStyle.Bold);
            
            string text = "Report Outcome Page";

            e.Graphics.DrawString(text, headerFont, Brushes.Black, 50, 0);
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
