namespace MagicDates {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.DayText = new System.Windows.Forms.TextBox();
			this.MonthText = new System.Windows.Forms.TextBox();
			this.YearText = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.result = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(444, 39);
			this.label1.TabIndex = 0;
			this.label1.Text = "There are some magic dates where the month times the date = the last two digits o" +
    "f the year. \r\nAn example would be:\r\n6/10/60 where 6*10=60\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Day: Ex: 26";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 126);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Month: Ex: 6";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(13, 156);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Year: Ex:1995";
			// 
			// DayText
			// 
			this.DayText.Location = new System.Drawing.Point(95, 99);
			this.DayText.Name = "DayText";
			this.DayText.Size = new System.Drawing.Size(100, 20);
			this.DayText.TabIndex = 4;
			this.DayText.TextChanged += new System.EventHandler(this.MagicDates);
			// 
			// MonthText
			// 
			this.MonthText.Location = new System.Drawing.Point(95, 126);
			this.MonthText.Name = "MonthText";
			this.MonthText.Size = new System.Drawing.Size(100, 20);
			this.MonthText.TabIndex = 5;
			this.MonthText.TextChanged += new System.EventHandler(this.MagicDates);
			// 
			// YearText
			// 
			this.YearText.Location = new System.Drawing.Point(95, 153);
			this.YearText.Name = "YearText";
			this.YearText.Size = new System.Drawing.Size(100, 20);
			this.YearText.TabIndex = 6;
			this.YearText.TextChanged += new System.EventHandler(this.MagicDates);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 65);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(179, 20);
			this.dateTimePicker1.TabIndex = 7;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// result
			// 
			this.result.AutoSize = true;
			this.result.Location = new System.Drawing.Point(25, 215);
			this.result.Name = "result";
			this.result.Size = new System.Drawing.Size(120, 13);
			this.result.TabIndex = 8;
			this.result.Text = "This should not be seen";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 269);
			this.Controls.Add(this.result);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.YearText);
			this.Controls.Add(this.MonthText);
			this.Controls.Add(this.DayText);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Magic Dates";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox DayText;
		private System.Windows.Forms.TextBox MonthText;
		private System.Windows.Forms.TextBox YearText;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label result;
	}
}

