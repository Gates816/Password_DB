namespace Password_DB
{
	partial class Form1
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
			listView1 = new ListView();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox3 = new TextBox();
			label4 = new Label();
			textBox4 = new TextBox();
			SuspendLayout();
			// 
			// listView1
			// 
			listView1.Location = new Point(12, 12);
			listView1.Name = "listView1";
			listView1.Size = new Size(428, 611);
			listView1.TabIndex = 0;
			listView1.UseCompatibleStateImageBehavior = false;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(613, 110);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(222, 23);
			textBox1.TabIndex = 1;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(613, 175);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(222, 23);
			textBox2.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(547, 113);
			label1.Name = "label1";
			label1.Size = new Size(60, 15);
			label1.TabIndex = 3;
			label1.Text = "Username";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(547, 178);
			label2.Name = "label2";
			label2.Size = new Size(57, 15);
			label2.TabIndex = 4;
			label2.Text = "Password";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(547, 243);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 6;
			label3.Text = "Extra label";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(613, 240);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(222, 23);
			textBox3.TabIndex = 5;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(546, 308);
			label4.Name = "label4";
			label4.Size = new Size(61, 15);
			label4.TabIndex = 8;
			label4.Text = "Extra label";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(613, 305);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(222, 23);
			textBox4.TabIndex = 7;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(1066, 635);
			Controls.Add(label4);
			Controls.Add(textBox4);
			Controls.Add(label3);
			Controls.Add(textBox3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(listView1);
			FormBorderStyle = FormBorderStyle.None;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "Form1";
			Text = "Password database";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListView listView1;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox3;
		private Label label4;
		private TextBox textBox4;
	}
}