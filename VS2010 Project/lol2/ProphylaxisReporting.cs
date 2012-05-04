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
        private bool savedHTML = false;
        private bool savedPDF = false;
        private List<IElement> elements;

        public ProphylaxisReporting(string filePath,List<IElement> elements)
        {
            InitializeComponent();
            this.filePath = filePath;
            webBrowser.Navigate(filePath);
            this.elements = elements;
            if (GeneralContentManager.GlobalSettings.ContainsKey("ProphylaxisReportPath"))
            {
                pathTextBox.Text = GeneralContentManager.GlobalSettings["ProphylaxisReportPath"];
                folderBrowserDialog.SelectedPath = GeneralContentManager.GlobalSettings["ProphylaxisReportPath"];
            }
            else
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
                if (GeneralContentManager.GlobalSettings.ContainsKey("ProphylaxisReportPath"))
                    GeneralContentManager.GlobalSettings["ProphylaxisReportPath"] = pathTextBox.Text;
                else GeneralContentManager.GlobalSettings.Add("ProphylaxisReportPath", pathTextBox.Text);
                if (pathTextBox.Text[pathTextBox.Text.Length - 1] != '\\')
                    pathTextBox.Text += '\\';
                string path = pathTextBox.Text + Path.GetFileName(filePath);
                string pathPDF = pathTextBox.Text + Path.GetFileNameWithoutExtension(filePath) + ".pdf";
                if (savePDFCheckBox.Checked)
                {
                    try
                    {
                        Document document = new Document(PageSize.A4, 20, 20, 30, 65);
                        PdfWriter.GetInstance(document, new FileStream(pathPDF, FileMode.Create));
                        BaseFont baseFont = BaseFont.CreateFont(Properties.Settings.Default.FontsFolder + "/ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
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
                        savedPDF = true;
                    }
                    catch (Exception e)
                    {
                        savedPDF = false;
                        MessageBox.Show("Виникла системна помилка при збереженні в PDF\n" + e.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (notesRichText.Text != "" && saveHTMLCheckBox.Checked)
                {
                    try
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
                        savedHTML = true;
                    }
                    catch (Exception e)
                    {
                        savedHTML = false;
                        MessageBox.Show("Виникла системна помилка при збереженні в HTML\n" + e.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (saveHTMLCheckBox.Checked)
                {
                    try
                    {
                        File.Copy(filePath, path);
                        savedHTML = true;
                    }
                    catch (Exception e)
                    {
                        savedHTML = false;
                        MessageBox.Show("Виникла системна помилка при збереженні в HTML\n" + e.Message,
                            "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (!saveHTMLCheckBox.Checked)
                    path = pathPDF;
                if ((savedHTML || savedPDF) && MessageBox.Show("Звіт по профілактиці збережено.\nВідкрити теку розташування ?",
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
            SendKeys.Send("^c");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^v");
        }

        private void ProphylaxisReporting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((!savedHTML && !savedPDF) && MessageBox.Show("Ви не зберігли звіт.\nЯкщо ви вийдете то вже не зможете повернутися в це вікно.\nВийти ?", "Попередження",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void instructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this,
                    System.IO.Path.GetFullPath(Properties.Settings.Default.HelpPath));
            }
            catch (Exception err)
            {
                MessageBox.Show("Виникла помилка\n" + err.Message, "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
