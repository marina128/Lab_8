namespace Lab_8
{
    partial class FormSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParams = new System.Windows.Forms.GroupBox();
            this.textBox_number_of_baggage = new System.Windows.Forms.TextBox();
            this.textBox_datetime = new System.Windows.Forms.TextBox();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_sum_weight = new System.Windows.Forms.TextBox();
            this.textBox_flight_number = new System.Windows.Forms.TextBox();
            this.label_sum_weight = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.label_number_of_baggage = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_flight_number = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxParams.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(680, 204);
            this.listBox1.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonSearch.Location = new System.Drawing.Point(495, 229);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(191, 39);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Поиск";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.buttonCancel.Location = new System.Drawing.Point(495, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(191, 39);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBoxParams
            // 
            this.groupBoxParams.Controls.Add(this.textBox_number_of_baggage);
            this.groupBoxParams.Controls.Add(this.textBox_datetime);
            this.groupBoxParams.Controls.Add(this.textBox_destination);
            this.groupBoxParams.Controls.Add(this.textBox_last_name);
            this.groupBoxParams.Controls.Add(this.textBox_sum_weight);
            this.groupBoxParams.Controls.Add(this.textBox_flight_number);
            this.groupBoxParams.Controls.Add(this.label_sum_weight);
            this.groupBoxParams.Controls.Add(this.label_destination);
            this.groupBoxParams.Controls.Add(this.label_number_of_baggage);
            this.groupBoxParams.Controls.Add(this.label_last_name);
            this.groupBoxParams.Controls.Add(this.label_datetime);
            this.groupBoxParams.Controls.Add(this.label_flight_number);
            this.groupBoxParams.Font = new System.Drawing.Font("Courier New", 10F);
            this.groupBoxParams.Location = new System.Drawing.Point(6, 217);
            this.groupBoxParams.Name = "groupBoxParams";
            this.groupBoxParams.Size = new System.Drawing.Size(471, 221);
            this.groupBoxParams.TabIndex = 2;
            this.groupBoxParams.TabStop = false;
            this.groupBoxParams.Text = "Параметры поиска";
            // 
            // textBox_number_of_baggage
            // 
            this.textBox_number_of_baggage.Location = new System.Drawing.Point(255, 145);
            this.textBox_number_of_baggage.Name = "textBox_number_of_baggage";
            this.textBox_number_of_baggage.Size = new System.Drawing.Size(191, 26);
            this.textBox_number_of_baggage.TabIndex = 3;
            // 
            // textBox_datetime
            // 
            this.textBox_datetime.Location = new System.Drawing.Point(255, 55);
            this.textBox_datetime.Name = "textBox_datetime";
            this.textBox_datetime.Size = new System.Drawing.Size(191, 26);
            this.textBox_datetime.TabIndex = 3;
            // 
            // textBox_destination
            // 
            this.textBox_destination.Location = new System.Drawing.Point(255, 117);
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(191, 26);
            this.textBox_destination.TabIndex = 2;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Location = new System.Drawing.Point(255, 85);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(191, 26);
            this.textBox_last_name.TabIndex = 2;
            // 
            // textBox_sum_weight
            // 
            this.textBox_sum_weight.Location = new System.Drawing.Point(255, 177);
            this.textBox_sum_weight.Name = "textBox_sum_weight";
            this.textBox_sum_weight.Size = new System.Drawing.Size(191, 26);
            this.textBox_sum_weight.TabIndex = 1;
            // 
            // textBox_flight_number
            // 
            this.textBox_flight_number.Location = new System.Drawing.Point(255, 27);
            this.textBox_flight_number.Name = "textBox_flight_number";
            this.textBox_flight_number.Size = new System.Drawing.Size(191, 26);
            this.textBox_flight_number.TabIndex = 1;
            // 
            // label_sum_weight
            // 
            this.label_sum_weight.AutoSize = true;
            this.label_sum_weight.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum_weight.Location = new System.Drawing.Point(6, 179);
            this.label_sum_weight.Name = "label_sum_weight";
            this.label_sum_weight.Size = new System.Drawing.Size(209, 20);
            this.label_sum_weight.TabIndex = 0;
            this.label_sum_weight.Text = "Суммарный вес багажа";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Location = new System.Drawing.Point(6, 119);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(169, 20);
            this.label_destination.TabIndex = 0;
            this.label_destination.Text = "Пункт назначения";
            // 
            // label_number_of_baggage
            // 
            this.label_number_of_baggage.AutoSize = true;
            this.label_number_of_baggage.Location = new System.Drawing.Point(6, 149);
            this.label_number_of_baggage.Name = "label_number_of_baggage";
            this.label_number_of_baggage.Size = new System.Drawing.Size(229, 20);
            this.label_number_of_baggage.TabIndex = 0;
            this.label_number_of_baggage.Text = "Количество мест багажа";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Location = new System.Drawing.Point(6, 89);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(79, 20);
            this.label_last_name.TabIndex = 0;
            this.label_last_name.Text = "Фамилия";
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Location = new System.Drawing.Point(6, 59);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(199, 20);
            this.label_datetime.TabIndex = 0;
            this.label_datetime.Text = "Дата и время вылета";
            // 
            // label_flight_number
            // 
            this.label_flight_number.AutoSize = true;
            this.label_flight_number.Location = new System.Drawing.Point(6, 27);
            this.label_flight_number.Name = "label_flight_number";
            this.label_flight_number.Size = new System.Drawing.Size(119, 20);
            this.label_flight_number.TabIndex = 0;
            this.label_flight_number.Text = "Номер рейса";
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.groupBoxParams);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(714, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(714, 497);
            this.Name = "FormSearch";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            this.groupBoxParams.ResumeLayout(false);
            this.groupBoxParams.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxParams;
        private System.Windows.Forms.Label label_flight_number;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_sum_weight;
        private System.Windows.Forms.Label label_number_of_baggage;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.TextBox textBox_number_of_baggage;
        private System.Windows.Forms.TextBox textBox_datetime;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_sum_weight;
        private System.Windows.Forms.TextBox textBox_flight_number;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}