
namespace WinFormsApp1.Forms
{
	partial class PatientsForm
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
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mainLabel.Location = new System.Drawing.Point(12, 9);
			this.mainLabel.MaximumSize = new System.Drawing.Size(215, 30);
			this.mainLabel.MinimumSize = new System.Drawing.Size(215, 30);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(215, 30);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Добавить пациента";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(113, 325);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(227, 58);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(187, 23);
			this.textBox1.TabIndex = 3;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(227, 232);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(187, 23);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "Номер страхового полиса";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 15);
			this.label2.TabIndex = 9;
			this.label2.Text = "Фамилия";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(227, 100);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(187, 23);
			this.textBox2.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 144);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 11;
			this.label3.Text = "Имя";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(227, 144);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(187, 23);
			this.textBox3.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "Отчество";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(227, 189);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(187, 23);
			this.textBox4.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 232);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(90, 15);
			this.label5.TabIndex = 17;
			this.label5.Text = "Дата рождения";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Адрес";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(227, 278);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(187, 23);
			this.textBox5.TabIndex = 18;
			// 
			// PatientsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 374);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.mainLabel);
			this.Name = "PatientsForm";
			this.Text = "PatientsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label mainLabel;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.DateTimePicker dateTimePicker1;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.TextBox textBox5;
	}
}