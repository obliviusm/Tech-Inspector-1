using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace lol2
{
    public partial class DetailedInfo : Form
    {
        public DetailedInfo()
        {
            InitializeComponent();
        }
        public DetailedInfo(string inventory_number)
        {
            InitializeComponent();
            BsonDocument item = DatabaseManager.GetDataCollection("equipments").FindOne(new QueryDocument("inventory_number", inventory_number));
            deviceNumberTextBox.Text = (string)item["inventory_number"];
            locationTextBox.Text = (string)item["location"];
            typeTextBox.Text = (string)item["type"];
            //if (item.Contains("price"))
            //{
            //    priceTextBox.Text = (string)item["price"].A;
            //}
            if (item.Contains("purchase_date"))
            {
                purchaseDateTextBox.Text = (string)item["purchase_date"];
            }
            if (item.Contains("placement_date"))
            {
                placementDateTextBox.Text = (string)item["placement_date"];
            }
            if (item.Contains("servise_end_date"))
            {
                serviceEndTextBox.Text = (string)item["servise_end_date"];
            }
            if (item.Contains("attr"))
            {
                foreach (BsonDocument attr in item["attr"].AsBsonArray)
                {
                    configurationDataGridView.Rows.Add(attr["attr_name"], attr["value"]);
                }
            }
        }
    }
}
