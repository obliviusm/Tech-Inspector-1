using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web.UI;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace lol2
{
    public partial class ProphylaxisReporting : Form
    {
        private string filePath;
        private bool saved = false;
        private List<IElement> elements;

        public ProphylaxisReporting(string filePath,List<IElement> elements)
        {
            InitializeComponent();
            this.filePath = filePath;
            webBrowser.Navigate(filePath);
            this.elements = elements;
            pathTextBox.Text = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        private void browseFoldersButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            if (folderBrowserDialog.SelectedPath != "")
                pathTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void SaveReport()
        {
            if (Directory.Exists(pathTextBox.Text))
            {
                if (!saveHTMLCheckBox.Checked && !savePDFCheckBox.Checked)
                {
                    MessageBox.Show("Не вибрано жодного формату збереження", 
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                saved = true;
                if (pathTextBox.Text[pathTextBox.Text.Length - 1] != '\\')
                    pathTextBox.Text += '\\';
                string path = pathTextBox.Text + Path.GetFileName(filePath);
                string pathPDF = pathTextBox.Text + Path.GetFileNameWithoutExtension(filePath) + ".pdf";
                if (savePDFCheckBox.Checked)
                {
                    Document document = new Document(PageSize.A4, 20, 20, 30, 65);
                    PdfWriter.GetInstance(document, new FileStream(pathPDF, FileMode.Create));
                    BaseFont baseFont = BaseFont.CreateFont("../../Fonts/ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD);
                    iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);
                    document.Open();

                    for (int i = 0; i < elements.Count; i++)
                        document.Add(elements[i]);

                    if (notesRichText.Text != "")
                    {
                        Paragraph par = new Paragraph();
                        par.Add(new Chunk("\n"));
                        par.Add(new Chunk("Примітки :\n", fontBold));
                        par.Add(new Chunk(notesRichText.Text, fontNormal));
                        document.Add(par);
                    }

                    document.Close();
                }
                if (notesRichText.Text != "" && saveHTMLCheckBox.Checked)
                {
                    TextWriter tWriter = new StreamWriter(filePath, true);
                    HtmlTextWriter writer = new HtmlTextWriter(tWriter);
                    writer.WriteBreak();
                    writer.WriteBreak();
                    writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
                    writer.RenderBeginTag(HtmlTextWriterTag.Font);
                    writer.WriteLine("Примітки :");
                    writer.RenderEndTag();
                    writer.WriteBreak();
                    writer.Write(notesRichText.Text);
                    writer.Close();
                }
                if (saveHTMLCheckBox.Checked)
                {
                    try
                    {
                        File.Copy(filePath, path);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Виникла системна помилка\n" + e.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!saveHTMLCheckBox.Checked)
                    path = pathPDF;
                if (MessageBox.Show("Звіт по профілактиці збережено.\nВідкрити теку розташування ?",
                    "Збережено", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    System.Diagnostics.Process.Start("explorer.exe", @"/select, " + @path);
            }
            else
            {
                MessageBox.Show("Вказаний шлях збереження не існує", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveReport();
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveReport();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && ActiveControl.Text != "")
                Clipboard.SetText(ActiveControl.Text);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && ActiveControl.Text != "")
            {
                Clipboard.SetText(ActiveControl.Text);
                ActiveControl.Text = "";
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl != null && Clipboard.GetText() != null)
                ActiveControl.Text += Clipboard.GetText();
        }

        private void ProphylaxisReporting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!saved && MessageBox.Show("Ви не зберігли звіт.\nЯкщо ви вийдете то вже не зможете повернутися в це вікно.\nВийти ?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
    }
}
