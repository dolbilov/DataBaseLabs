
namespace WinFormsApp1.Forms
{
	partial class DoctorsForm
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.mainLabel = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox1.Location = new System.Drawing.Point(218, 46);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(227, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mainLabel.Location = new System.Drawing.Point(102, 9);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(235, 25);
			this.mainLabel.TabIndex = 2;
			this.mainLabel.Text = "Добавить нового врача";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Табельный номер врача";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(177, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Номер лечебного учреждения";
			// 
			// textBox2
			// 
			this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox2.Location = new System.Drawing.Point(218, 97);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(227, 23);
			this.textBox2.TabIndex = 4;
			this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Фамилия";
			// 
			// textBox3
			// 
			this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox3.Location = new System.Drawing.Point(218, 145);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(227, 23);
			this.textBox3.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 198);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Имя";
			// 
			// textBox4
			// 
			this.textBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox4.Location = new System.Drawing.Point(218, 198);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(227, 23);
			this.textBox4.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 252);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(58, 15);
			this.label5.TabIndex = 11;
			this.label5.Text = "Отчество";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// textBox5
			// 
			this.textBox5.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox5.Location = new System.Drawing.Point(218, 252);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(227, 23);
			this.textBox5.TabIndex = 10;
			this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 304);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(92, 15);
			this.label6.TabIndex = 12;
			this.label6.Text = "Специальность";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(176, 357);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 14;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox6
			// 
			this.textBox6.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.textBox6.Location = new System.Drawing.Point(218, 304);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(227, 23);
			this.textBox6.TabIndex = 15;
			// 
			// DoctorsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(466, 392);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mainLabel);
			this.Controls.Add(this.textBox1);
			this.Name = "DoctorsForm";
			this.Text = "DoctorsForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Label mainLabel;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.Label label5;
		public System.Windows.Forms.TextBox textBox5;
		public System.Windows.Forms.Label label6;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.TextBox textBox6;
	}
}