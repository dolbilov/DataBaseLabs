
namespace WinFormsApp1.Forms
{
	partial class ProceduresForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainLabel
			// 
			this.mainLabel.AutoSize = true;
			this.mainLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.mainLabel.Location = new System.Drawing.Point(12, 9);
			this.mainLabel.Name = "mainLabel";
			this.mainLabel.Size = new System.Drawing.Size(231, 30);
			this.mainLabel.TabIndex = 0;
			this.mainLabel.Text = "Добавить процедуру";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(191, 59);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(209, 23);
			this.textBox1.TabIndex = 2;
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Номер процедуры";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Название";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(191, 95);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(209, 23);
			this.textBox2.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 134);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(84, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "Длительность";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(191, 134);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(209, 23);
			this.textBox3.TabIndex = 6;
			this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 15);
			this.label4.TabIndex = 9;
			this.label4.Text = "Цена";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(191, 172);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(209, 23);
			this.textBox4.TabIndex = 8;
			this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(140, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(119, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ProceduresForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(416, 285);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.mainLabel);
			this.MaximumSize = new System.Drawing.Size(432, 324);
			this.MinimumSize = new System.Drawing.Size(432, 324);
			this.Name = "ProceduresForm";
			this.Text = "ProceduresForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label mainLabel;
		public System.Windows.Forms.TextBox textBox1;
		public System.Windows.Forms.Label label1;
		public System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox textBox2;
		public System.Windows.Forms.Label label3;
		public System.Windows.Forms.TextBox textBox3;
		public System.Windows.Forms.Label label4;
		public System.Windows.Forms.TextBox textBox4;
		public System.Windows.Forms.Button button1;
	}
}