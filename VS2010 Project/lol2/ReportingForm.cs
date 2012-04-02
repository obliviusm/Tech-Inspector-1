using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using MongoDB.Bson;
using MongoDB.Driver;
using MyExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections;

namespace lol2
{
    public partial class ReportingForm : Form
    {

        public ReportingForm()
        {
            InitializeComponent();
            
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {
            docTypesComboBox.SelectedIndex = 0;
        }

        private void docTypesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Path.GetFullPath("DATA\\samples\\"+docTypesComboBox.Text+".mht"));
        }

        private void saveDocButton_Click(object sender, EventArgs e)
        {
            GeneralReport();
        }
        public void GeneralReport()
        {
            MyExcel.Application oXL;
            MyExcel._Workbook oWB;
            MyExcel._Worksheet oSheet;
            MyExcel.Range oRng;

            try
            {
                oXL = new MyExcel.Application();
                //Get a new workbook.
                oWB = (MyExcel._Workbook)(oXL.Workbooks.Open(Path.GetFullPath("DATA\\samples\\Savs.xlsx"), 0, true, 5,
                    "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, 
                    false, 0, true, 1, 0));
                oSheet = (MyExcel._Worksheet)oWB.Worksheets.get_Item(1);
                //take computers from DB
                int sheet_num = 15;
                foreach (BsonDocument it in DatabaseManager.GetDataCollection("locations").Find(new QueryDocument()))
                {
                    String location = (string)it["name"];
                    QueryDocument query = new QueryDocument();
                    query.Add("type", "Комп'ютер");
                    query.Add("location",location);                    
                    String[] cells = new String[100];
                    int i = 0;
                    foreach (BsonDocument item in DatabaseManager.GetDataCollection("equipments").Find(query))
                    {
                        String processor = "", 
                                RAM = "", 
                                HDD = "";
                        BsonArray attr = item["attr"].AsBsonArray;
                        foreach (BsonDocument j in attr)
                            if ((string)j["attr_name"] == "Процесор*") processor = (string)j["value"];
                            else if ((string)j["attr_name"] == "RAM*") RAM = (string)j["value"];
                            else if ((string)j["attr_name"] == "HDD*") HDD = (string)j["value"];
                        //write computers to Excel
                        //oSheet.Cells[15 + i, 5] = processor + " / " + RAM + " / " + HDD;
                        //oSheet.Cells[15 + i, 7] = location;
                        cells[i] = processor + " / " + RAM + " / " + HDD;
                        ++i;
                    }
                    if (i != 0)
                    {
                        String[] cells2 = cells.Distinct().ToArray();
                        //int[] size = new int[cells2.Length];
                        //if()
                        for (int k = 0; k < cells2.Length - 1; ++k )
                        {
                            int size = 0;
                            for (int j = 0; j < cells.Length; ++j)
                                if (cells[j] == cells2[k])
                                    size++;
                            oSheet.Cells[sheet_num + k, 5] = cells2[k];
                            oSheet.Cells[sheet_num + k, 6] = size.ToString();
                            oSheet.Cells[sheet_num + k, 7] = location;
                            oRng = oSheet.get_Range("A" + (sheet_num + k).ToString(),
                                "M" + (sheet_num + k).ToString());
                            oRng.Borders.Weight = MyExcel.XlBorderWeight.xlThin;
                        }
                        sheet_num += cells2.Length - 1;
                    }
                }
                ////Apply borders to the Sales data and headers.
                //oResizeRange = oWS.get_Range("E1", "E6").get_Resize(Missing.Value, iNumQtrs);
                //oResizeRange.Borders.Weight = Excel.XlBorderWeight.xlThin;

                //save xls and quit
                String path = Path.GetFullPath("DATA\\docs") + "\\Savs" + DateTime.Now.ToLongTimeString().Replace(":","") + ".xls";
                oWB.SaveAs(path, MyExcel.XlFileFormat.xlWorkbookNormal, 
                    Missing.Value, Missing.Value, Missing.Value, Missing.Value, 
                    MyExcel.XlSaveAsAccessMode.xlExclusive, Missing.Value, Missing.Value, 
                    Missing.Value, Missing.Value, Missing.Value);
                oWB.Close(true, Missing.Value, Missing.Value);
                oXL.Quit();
                MessageBox.Show("Document Savs" + DateTime.Now + " has been saved to " + path);
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }
    }
}
