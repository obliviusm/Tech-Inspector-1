using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.UI;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace lol2
{
    public partial class CheckReport : Form
    {
        private string startTime;
        private List<int> changedIds = new List<int>();
        private bool wasStarted = false;

        public CheckReport()
        {
            InitializeComponent();
        }

        private void CheckReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tech_inspectorDataSet.equipments' table. You can move, or remove it, as needed.
            //this.equipmentsTableAdapter.Fill(this.tech_inspectorDataSet.equipments);
            this.locationsTableAdapter.Fill(this.tech_inspectorDataSet.locations);
        }

        private void closeWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartProphylaxis()
        {
            wasStarted = true;
            if (responsibleTextBox.Text != "" && locationComboBox.SelectedValue != "")
            {
                this.equipmentsTableAdapter.FillByLoc(this.tech_inspectorDataSet.equipments, locationComboBox.SelectedIndex + 1);
                if (locationEquipmentsDataGridView.RowCount < 1)
                {
                    MessageBox.Show("В аудиторії немає обладнання", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                startTime = DateTime.Now.ToString("HH:mm:ss  dd MMMM yyyy");
                startToolStripMenuItem.Enabled = false;
                saveChangesToolStripMenuItem.Enabled = true;
                editAllButton.Enabled = true;
                finishButton.Enabled = true;
                responsibleTextBox.Enabled = false;
                locationComboBox.Enabled = false;
                startCheckButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Не всі обов'язкові поля були заповнені", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startCheckButton_Click(object sender, EventArgs e)
        {
            StartProphylaxis();
        }

        private void locationEquipmentsDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string state = locationEquipmentsDataGridView["state_name", e.RowIndex].Value.ToString();
                int id = (int)locationEquipmentsDataGridView["equipment_id", e.RowIndex].Value;
                EditEquipment childEdit = new EditEquipment((int)locationEquipmentsDataGridView[0, e.RowIndex].Value);
                childEdit.ShowDialog();
                this.equipmentsTableAdapter.FillByLoc(this.tech_inspectorDataSet.equipments, locationComboBox.SelectedIndex + 1);

                int index = -1;
                DataGridViewRow row = locationEquipmentsDataGridView.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["equipment_id"].Value.ToString().Equals(id.ToString()))
                    .First();
                index = row.Index;

                if (index>-1 && state != locationEquipmentsDataGridView["state_name", index].Value.ToString())
                    changedIds.Add((int)locationEquipmentsDataGridView["equipment_id", index].Value);
            }
        }

        private void editAllButton_Click(object sender, EventArgs e)
        {
            List<int> showrows = new List<int>();
            Dictionary<int, string> states = new Dictionary<int, string>();
            for (int i = 0; i < locationEquipmentsDataGridView.SelectedCells.Count; ++i)
            {
                int index = locationEquipmentsDataGridView.SelectedCells[i].RowIndex;
                if (!showrows.Contains(index))
                {
                    showrows.Add(index);
                    states.Add((int)locationEquipmentsDataGridView["equipment_id", index].Value,
                        locationEquipmentsDataGridView["state_name", index].Value.ToString());
                }
            }
            for (int i = 0; i < showrows.Count; ++i)
            {
                int id = (int)locationEquipmentsDataGridView.Rows[showrows[i]].Cells[0].Value;
                EditEquipment edit_form = new EditEquipment(id);
                edit_form.ShowDialog();
            }
            this.equipmentsTableAdapter.FillByLoc(this.tech_inspectorDataSet.equipments, locationComboBox.SelectedIndex + 1);
            for (int i = 0; i < locationEquipmentsDataGridView.RowCount; i++)
                if (states.ContainsKey((int)locationEquipmentsDataGridView["equipment_id", i].Value))
                    if (states[(int)locationEquipmentsDataGridView["equipment_id", i].Value] !=
                        locationEquipmentsDataGridView["state_name", i].Value.ToString())
                            changedIds.Add((int)locationEquipmentsDataGridView["equipment_id", i].Value);
        }

        private List<IElement> SaveTempPDF()
        {
            List<IElement> elements = new List<IElement>();
            BaseFont baseFont = BaseFont.CreateFont(GeneralContentManager.RootFolder + "Fonts/ARIAL.TTF", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fontNormal = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL);
            iTextSharp.text.Font fontNormalRed = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.NORMAL, BaseColor.RED);
            iTextSharp.text.Font fontBold = new iTextSharp.text.Font(baseFont, 8, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font fontBigBold = new iTextSharp.text.Font(baseFont, 14 , iTextSharp.text.Font.BOLD);

            Paragraph par = new Paragraph();

            par.Add(new Chunk("Звіт по профілактиці в аудитоії " + locationComboBox.SelectedValue+"\n\n",fontBigBold));
            par.Add(new Chunk("Аудиторія : ", fontBold));
            par.Add(new Chunk(locationComboBox.SelectedValue.ToString()+"\n", fontNormal));
            par.Add(new Chunk("Відповідальний : ", fontBold));
            par.Add(new Chunk(responsibleTextBox.Text+"\n", fontNormal));
            par.Add(new Chunk("Час початку : ", fontBold));
            par.Add(new Chunk(startTime + "\n", fontNormal));
            par.Add(new Chunk("Час завершення : ", fontBold));
            par.Add(new Chunk(DateTime.Now.ToString("HH:mm:ss  dd MMMM yyyy") + "\n", fontNormal));
            par.Add(new Chunk("Кількість змін в станах : ", fontBold));
            par.Add(new Chunk(changedIds.Count.ToString()+"\n\n", fontNormal));
            par.Add(new Chunk("Зміни в стані обладнання\n\n", fontBigBold));

            Image logo = Image.GetInstance(GeneralContentManager.RootFolder + "DATA/images/seal.gif");
            par.Alignment = Element.ALIGN_JUSTIFIED;
            logo.ScaleToFit(120f, 150f);
            logo.Alignment = Image.TEXTWRAP | Image.ALIGN_RIGHT;
            logo.IndentationLeft = 9f;
            logo.SpacingAfter = 9f;
            logo.BorderWidthTop = 2f;
            logo.BorderColorTop = BaseColor.WHITE;
            elements.Add(logo);

            int visible=0;
            for (int i = 0; i < locationEquipmentsDataGridView.ColumnCount; i++)
                if (locationEquipmentsDataGridView[i, 0].Visible)
                    visible++;

            PdfPTable table = new PdfPTable(visible);
            table.WidthPercentage = 100;
            for (int j = 0; j < locationEquipmentsDataGridView.ColumnCount; j++)
                if (locationEquipmentsDataGridView[j, 0].Visible)
                {
                    table.AddCell(new Phrase(locationEquipmentsDataGridView.Columns[j].HeaderText,fontBold));
                }

            iTextSharp.text.Font currentFont;
            for (int i = 0; i < locationEquipmentsDataGridView.RowCount; i++)
            {
                if (changedIds.Contains((int)locationEquipmentsDataGridView["equipment_id", i].Value))
                    currentFont = fontNormalRed;
                else currentFont = fontNormal;
                for (int j = 0; j < locationEquipmentsDataGridView.ColumnCount; j++)
                    if (locationEquipmentsDataGridView[j, 0].Visible)
                    {
                        if (locationEquipmentsDataGridView[j, i].Value.ToString() != "")
                            table.AddCell(new Phrase(locationEquipmentsDataGridView[j, i].Value.ToString(), currentFont));
                        else table.AddCell(new Phrase("-", currentFont));
                    }
            }

            elements.Add(par);
            elements.Add(table);

            return elements;
        }

        private void SaveTempReport(List<IElement> elements)
        {
            string filePath = GeneralContentManager.RootFolder + "Temp/report_" + locationComboBox.SelectedValue + "_" + startTime.Replace(':', '_').Replace(' ', '_')
                + ".html";
            Text = filePath;
            TextWriter tWriter = new StreamWriter(filePath, false, Encoding.UTF8);
            HtmlTextWriter writer = new HtmlTextWriter(tWriter);
            writer.RenderBeginTag(HtmlTextWriterTag.Head);
            writer.Write("<meta http-equiv='Content-Type' content='text/html;charset=UTF-8'>");
            writer.RenderEndTag();
            writer.AddStyleAttribute(HtmlTextWriterStyle.BackgroundColor, "FFFFCC");
            writer.RenderBeginTag(HtmlTextWriterTag.Body);
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "24");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Звіт по профілактиці в аудитоії " + locationComboBox.SelectedValue);
            writer.WriteBreak();
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Аудиторія :");
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine(locationComboBox.SelectedValue);
            writer.RenderEndTag();
            writer.WriteBreak();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Відповідальний :");
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine(responsibleTextBox.Text);
            writer.RenderEndTag();
            writer.WriteBreak();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Час початку :");
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine(startTime);
            writer.RenderEndTag();
            writer.WriteBreak();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Час завершення :");
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine(DateTime.Now.ToString("HH:mm:ss  dd MMMM yyyy"));
            writer.RenderEndTag();
            writer.WriteBreak();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Кількість змін в станах :");
            writer.RenderEndTag();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "14");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine(changedIds.Count);
            writer.RenderEndTag();
            writer.WriteBreak();
            writer.WriteBreak();

            writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "18");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Font);
            writer.WriteLine("Зміни в стані обладнання");
            writer.RenderEndTag();
            writer.WriteBreak();
            writer.WriteBreak();

            //All equipment table
            writer.AddAttribute(HtmlTextWriterAttribute.Width, "100%");
            writer.AddAttribute(HtmlTextWriterAttribute.Border, "1");
            writer.RenderBeginTag(HtmlTextWriterTag.Table);

            writer.AddAttribute(HtmlTextWriterAttribute.Width, "100%");
            writer.AddStyleAttribute(HtmlTextWriterStyle.FontWeight, "bold");
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            for (int j = 0; j < locationEquipmentsDataGridView.ColumnCount; j++)
                if (locationEquipmentsDataGridView[j, 0].Visible)
                {
                    writer.RenderBeginTag(HtmlTextWriterTag.Td);
                    writer.Write(locationEquipmentsDataGridView.Columns[j].HeaderText);
                    writer.RenderEndTag();
                }
            writer.RenderEndTag();

            for (int i = 0; i < locationEquipmentsDataGridView.RowCount; i++)
            {
                writer.AddAttribute(HtmlTextWriterAttribute.Width, "100%");
                if (changedIds.Contains((int)locationEquipmentsDataGridView["equipment_id", i].Value))
                    writer.AddStyleAttribute(HtmlTextWriterStyle.Color, "red");
                else writer.AddStyleAttribute(HtmlTextWriterStyle.Color, "black");
                writer.RenderBeginTag(HtmlTextWriterTag.Tr);
                for (int j = 0; j < locationEquipmentsDataGridView.ColumnCount; j++)
                    if (locationEquipmentsDataGridView[j, 0].Visible)
                    {
                        writer.RenderBeginTag(HtmlTextWriterTag.Td);
                        if (locationEquipmentsDataGridView[j, i].Value.ToString() != "")
                            writer.Write(locationEquipmentsDataGridView[j, i].Value);
                        else writer.Write("-");
                        writer.RenderEndTag();
                    }
                writer.RenderEndTag();
            }

            writer.RenderEndTag();
            //end table

            writer.RenderEndTag();
            writer.Close();
            ProphylaxisReporting childReportingForm = new ProphylaxisReporting(Path.GetFullPath(filePath),elements);
            childReportingForm.ShowDialog();
            wasStarted = false;
            Close();
        }

        private void finishButton_Click(object sender, EventArgs e)
        {
            SaveTempReport(SaveTempPDF());
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

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTempReport(SaveTempPDF());
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartProphylaxis();
        }

        private void CheckReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (wasStarted && MessageBox.Show("Якщо ви вийдете, зміни про стан обладнання будуть збережені,\n але дані про профілактику будуть втрачені.\nВийти ?",
                "Попередження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }

        private void допомогаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void версіяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void розробникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
