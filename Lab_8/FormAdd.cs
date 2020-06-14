using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Lab_8
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Form1.AddingCanceled = true;
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBox_last_name.Text.Trim(' ');
            textBox_destination.Text.Trim(' ');
            uint f_num;
            ushort bagg, weight;
            DateTime date;
            bool fl_f_num, fl_date, fl_bagg, fl_weight;
            fl_f_num = UInt32.TryParse(textBox_flight_number.Text, out f_num);
            fl_date = DateTime.TryParseExact(textBox_datetime.Text, "dd.MM.yyyy HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out date);
            fl_bagg = UInt16.TryParse(textBox_number_of_baggage.Text, out bagg);
            fl_weight = UInt16.TryParse(textBox_sum_weight.Text, out weight);

            if (textBox_flight_number.Text != "" && fl_f_num && textBox_datetime.Text != "" && fl_date && textBox_last_name.Text != "" && 
                textBox_destination.Text != "" && textBox_number_of_baggage.Text != "" && fl_bagg && textBox_sum_weight.Text != "" && fl_weight)
            {
                Record record = new Record(f_num, date, textBox_last_name.Text, textBox_destination.Text, bagg, weight);
                Form1.list.Add(record);
                Form1.AddingCanceled = false;
                this.Close();
            }
            else { MessageBox.Show("Некорректное заполнение полей."); }
        }
        
    }
}
