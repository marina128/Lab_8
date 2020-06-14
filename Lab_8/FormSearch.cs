using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Lab_8
{
    public partial class FormSearch : Form
    {
        static public List<Record> list = new List<Record>();
        static public List<Record> SaveRecords = new List<Record>();

        public FormSearch(List<Record> reclist)
        {
            InitializeComponent();
            list = reclist;
        }

        public FormSearch()
        {
            InitializeComponent();
        }

        private void FormSearch_Load(object sender, EventArgs e)
        {
            foreach (Record rec in list)
                listBox1.Items.Add(rec.flight_number + " " + rec.datetime + " " + rec.last_name + " " + rec.destination + " " + rec.number_of_baggage + " " + rec.sum_weight);            
        }

        private List<Record> Search()
        {
            listBox1.Items.Clear();
            SaveRecords.Clear();
            List<Record> listSearch = new List<Record>();
            listSearch.AddRange(list);
            if (textBox_last_name.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.last_name.Equals(textBox_last_name.Text)
                                            select i;
                listSearch = new List<Record>(evens);

            }
            if (textBox_destination.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.destination.Equals(textBox_destination.Text)
                                            select i;
                listSearch = new List<Record>(evens);
            }
            if (textBox_flight_number.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.flight_number.Equals(UInt32.Parse(textBox_flight_number.Text))
                                            select i;
                listSearch = new List<Record>(evens);
            }
            if (textBox_datetime.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.datetime.Equals(DateTime.ParseExact(textBox_datetime.Text, "dd.MM.yyyy HH:mm", null))
                                            select i;
                listSearch = new List<Record>(evens);
            }
            if (textBox_number_of_baggage.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.number_of_baggage.Equals(UInt16.Parse(textBox_number_of_baggage.Text))
                                            select i;
                listSearch = new List<Record>(evens);
            }
            if (textBox_sum_weight.Text != "")
            {
                IEnumerable<Record> evens = from i in listSearch
                                            where i.sum_weight <= UInt16.Parse(textBox_sum_weight.Text)
                                            select i;
                Record rec = listSearch.First();
                listSearch = new List<Record>(evens);
            }
            return listSearch;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            List<Record> SearchRecords = Search();
            foreach (Record rec in SearchRecords)
                listBox1.Items.Add(rec.flight_number + " " + rec.datetime + " " + rec.last_name + " " + rec.destination + " " + rec.number_of_baggage + " " + rec.sum_weight);
            SaveRecords.AddRange(SearchRecords);
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
