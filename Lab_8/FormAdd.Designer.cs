namespace Lab_8
{
    partial class FormAdd
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
            this.label_flight_number = new System.Windows.Forms.Label();
            this.label_datetime = new System.Windows.Forms.Label();
            this.label_last_name = new System.Windows.Forms.Label();
            this.label_destination = new System.Windows.Forms.Label();
            this.label_number_of_baggage = new System.Windows.Forms.Label();
            this.label_sum_weight = new System.Windows.Forms.Label();
            this.textBox_number_of_baggage = new System.Windows.Forms.TextBox();
            this.textBox_destination = new System.Windows.Forms.TextBox();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_flight_number = new System.Windows.Forms.TextBox();
            this.textBox_datetime = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBox_sum_weight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_flight_number
            // 
            this.label_flight_number.AutoSize = true;
            this.label_flight_number.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_flight_number.Location = new System.Drawing.Point(12, 24);
            this.label_flight_number.Name = "label_flight_number";
            this.label_flight_number.Size = new System.Drawing.Size(142, 22);
            this.label_flight_number.TabIndex = 0;
            this.label_flight_number.Text = "Номер рейса";
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_datetime.Location = new System.Drawing.Point(12, 76);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(238, 22);
            this.label_datetime.TabIndex = 0;
            this.label_datetime.Text = "Дата и время вылета";
            // 
            // label_last_name
            // 
            this.label_last_name.AutoSize = true;
            this.label_last_name.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_last_name.Location = new System.Drawing.Point(12, 136);
            this.label_last_name.Name = "label_last_name";
            this.label_last_name.Size = new System.Drawing.Size(94, 22);
            this.label_last_name.TabIndex = 0;
            this.label_last_name.Text = "Фамилия";
            // 
            // label_destination
            // 
            this.label_destination.AutoSize = true;
            this.label_destination.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_destination.Location = new System.Drawing.Point(12, 196);
            this.label_destination.Name = "label_destination";
            this.label_destination.Size = new System.Drawing.Size(202, 22);
            this.label_destination.TabIndex = 0;
            this.label_destination.Text = "Пункт назначения";
            // 
            // label_number_of_baggage
            // 
            this.label_number_of_baggage.AutoSize = true;
            this.label_number_of_baggage.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_number_of_baggage.Location = new System.Drawing.Point(12, 256);
            this.label_number_of_baggage.Name = "label_number_of_baggage";
            this.label_number_of_baggage.Size = new System.Drawing.Size(274, 22);
            this.label_number_of_baggage.TabIndex = 0;
            this.label_number_of_baggage.Text = "Количество мест багажа";
            // 
            // label_sum_weight
            // 
            this.label_sum_weight.AutoSize = true;
            this.label_sum_weight.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_sum_weight.Location = new System.Drawing.Point(12, 316);
            this.label_sum_weight.Name = "label_sum_weight";
            this.label_sum_weight.Size = new System.Drawing.Size(250, 22);
            this.label_sum_weight.TabIndex = 0;
            this.label_sum_weight.Text = "Суммарный вес багажа";
            // 
            // textBox_number_of_baggage
            // 
            this.textBox_number_of_baggage.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_number_of_baggage.Location = new System.Drawing.Point(321, 256);
            this.textBox_number_of_baggage.Name = "textBox_number_of_baggage";
            this.textBox_number_of_baggage.Size = new System.Drawing.Size(226, 30);
            this.textBox_number_of_baggage.TabIndex = 1;
            // 
            // textBox_destination
            // 
            this.textBox_destination.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_destination.Location = new System.Drawing.Point(321, 193);
            this.textBox_destination.Name = "textBox_destination";
            this.textBox_destination.Size = new System.Drawing.Size(226, 30);
            this.textBox_destination.TabIndex = 2;
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_last_name.Location = new System.Drawing.Point(321, 136);
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(226, 30);
            this.textBox_last_name.TabIndex = 2;
            // 
            // textBox_flight_number
            // 
            this.textBox_flight_number.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_flight_number.Location = new System.Drawing.Point(321, 24);
            this.textBox_flight_number.Name = "textBox_flight_number";
            this.textBox_flight_number.Size = new System.Drawing.Size(226, 30);
            this.textBox_flight_number.TabIndex = 3;
            // 
            // textBox_datetime
            // 
            this.textBox_datetime.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_datetime.Location = new System.Drawing.Point(321, 76);
            this.textBox_datetime.Name = "textBox_datetime";
            this.textBox_datetime.Size = new System.Drawing.Size(226, 30);
            this.textBox_datetime.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(16, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(226, 25);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(321, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(226, 25);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBox_sum_weight
            // 
            this.textBox_sum_weight.Font = new System.Drawing.Font("Courier New", 12F);
            this.textBox_sum_weight.Location = new System.Drawing.Point(321, 316);
            this.textBox_sum_weight.Name = "textBox_sum_weight";
            this.textBox_sum_weight.Size = new System.Drawing.Size(226, 30);
            this.textBox_sum_weight.TabIndex = 1;
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBox_datetime);
            this.Controls.Add(this.textBox_flight_number);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_destination);
            this.Controls.Add(this.textBox_sum_weight);
            this.Controls.Add(this.textBox_number_of_baggage);
            this.Controls.Add(this.label_sum_weight);
            this.Controls.Add(this.label_number_of_baggage);
            this.Controls.Add(this.label_destination);
            this.Controls.Add(this.label_last_name);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.label_flight_number);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(577, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(577, 497);
            this.Name = "FormAdd";
            this.Text = "Добавить запись";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_flight_number;
        private System.Windows.Forms.Label label_datetime;
        private System.Windows.Forms.Label label_last_name;
        private System.Windows.Forms.Label label_destination;
        private System.Windows.Forms.Label label_number_of_baggage;
        private System.Windows.Forms.Label label_sum_weight;
        private System.Windows.Forms.TextBox textBox_number_of_baggage;
        private System.Windows.Forms.TextBox textBox_destination;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_flight_number;
        private System.Windows.Forms.TextBox textBox_datetime;
        private System.Windows.Forms.TextBox textBox_sum_weight;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}