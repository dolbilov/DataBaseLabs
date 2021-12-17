
namespace WinFormsApp1.Forms
{
	partial class AppointmentsForm
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
			this.mainLabel = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mainLabel.Location = new System.Drawing.Point(12, 9);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(185, 30);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Добавить прием";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(186, 146);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(200, 23);
			this.textBox1.TabIndex = 1;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(114, 368);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(186, 60);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Дата приема";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "Время приема";
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "h:mm tt";
			this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker2.Location = new System.Drawing.Point(186, 103);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
			this.dateTimePicker2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Номер кабинета";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Табельный номер врача";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(186, 189);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(200, 23);
			this.textBox2.TabIndex = 8;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 233);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Номер страхового полиса";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(186, 233);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(200, 23);
			this.textBox3.TabIndex = 10;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 280);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(146, 15);
			this.label6.TabIndex = 13;
			this.label6.Text = "Идентификатор диагноза";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(186, 280);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(200, 23);
			this.textBox4.TabIndex = 12;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 320);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 15);
			this.label7.TabIndex = 15;
			this.label7.Text = "Номер процедуры";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(186, 320);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(200, 23);
			this.textBox5.TabIndex = 14;
			this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
			// 
			// AppointmentsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 416);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.mainLabel);
			this.MaximumSize = new System.Drawing.Size(432, 455);
			this.MinimumSize = new System.Drawing.Size(432, 455);
			this.Name = "AppointmentsForm";
			this.Text = "AppointmentsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label mainLabel;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.DateTimePicker dateTimePicker2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.Label label7;
		public System.Windows.Forms.TextBox textBox5;
	}
}