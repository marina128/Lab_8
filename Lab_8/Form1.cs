using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Lab_8
{
    public partial class Form1 : Form
    {
        public static bool AddingCanceled = false;
        static public List<Record> list = new List<Record>();

        public Form1()
        {
            InitializeComponent();
        }

        public static void SelectFile(string filename)
        {
            int errorInXml = 0;
            int cnt_rec = 1;
            list.Clear();
            try
            {
                XmlDocument xDoc = new XmlDocument();
                errorInXml = 7;
                xDoc.Load(filename);
                // Корневой элемент
                XmlElement xRoot = xDoc.DocumentElement;

                // обход всех узлов в корневом элементе
                foreach (XmlNode xnode in xRoot)
                {
                    Record record = new Record();

                    // обход всех дочерних узлов элемента
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        // flight_number
                        if (childnode.Name == "flight_number")
                        {
                            errorInXml = 1;
                            record.flight_number = UInt32.Parse(childnode.InnerText);
                        }
                        // datetime
                        if (childnode.Name == "datetime")
                        {
                            errorInXml = 2;
                            record.datetime = DateTime.ParseExact(childnode.InnerText, "dd.MM.yyyy HH:mm", null); 
                        }
                        // last_name
                        if (childnode.Name == "last_name")
                        {
                            errorInXml = 3;
                            record.last_name = childnode.InnerText.Trim(' ');
                        }
                        // destination
                        if (childnode.Name == "destination")
                        {
                            errorInXml = 4;
                            record.destination = childnode.InnerText.Trim(' ');
                        }
                        // number_of_baggage
                        if (childnode.Name == "number_of_baggage")
                        {
                            errorInXml = 5;
                            record.number_of_baggage = UInt16.Parse(childnode.InnerText);
                        }
                        // sum_weight
                        if (childnode.Name == "sum_weight")
                        {
                            errorInXml = 6;
                            record.sum_weight = UInt16.Parse(childnode.InnerText);
                        }
                    }
                    cnt_rec++;
                    list.Add(record);
                }

            }
            catch (Exception ex)
            {
                switch (errorInXml)
                {
                    case 0: MessageBox.Show(filename + " не найден"); break;
                    case 1: MessageBox.Show("В " + cnt_rec + "-й записи поле flight_number заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 2: MessageBox.Show("В " + cnt_rec + "-й записи поле datetime заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 3: MessageBox.Show("В " + cnt_rec + "-й записи поле last_name заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 4: MessageBox.Show("В " + cnt_rec + "-й записи поле destination заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 5: MessageBox.Show("В " + cnt_rec + "-й записи поле number_of_baggage заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 6: MessageBox.Show("В " + cnt_rec + "-й записи поле sum_weight заполнено некорректно.\nЗагрузка записей остановлена."); break;
                    case 7: MessageBox.Show(ex.Message); break;
                    default: MessageBox.Show(ex.Message); errorInXml = 8; break;
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            string filename = "List.xml";
            SelectFile(filename);
            foreach (Record rec in list)
                listBox1.Items.Add(rec.flight_number + " " + rec.datetime + " " + rec.last_name + " " + rec.destination + " " + rec.number_of_baggage + " " + rec.sum_weight);
            if (listBox1.Items.Count == 0)
            {
                buttonSearch.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd();
            formAdd.ShowDialog();
            if (!AddingCanceled)
            {
                Record rec = list.Last();
                listBox1.Items.Add(rec.flight_number + " " + rec.datetime + " " + rec.last_name + " " + rec.destination + " " + rec.number_of_baggage + " " + rec.sum_weight);
            }
            AddingCanceled = false;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            list.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FormSearch Search = new FormSearch(list);
            Search.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = saveFileDialog1.FileName;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Record>));
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                formatter.Serialize(fs, list);
                MessageBox.Show("Файл сохранен.");
            }
        }

        private void buttonLoading_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string filename = openFileDialog1.FileName;
            SelectFile(filename);
            listBox1.Items.Clear();
            foreach (Record rec in list)
                listBox1.Items.Add(rec.flight_number + " " + rec.datetime + " " + rec.last_name + " " + rec.destination + " " + rec.number_of_baggage + " " + rec.sum_weight);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDel.Enabled = true;
            buttonSearch.Enabled = true;
            if (listBox1.SelectedIndex == -1)
            {
                buttonDel.Enabled = false;
            }
        }
    }
}
