using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagicDates {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load( object sender, EventArgs e ) {

			//These set all the text as the current day
			DayText.Text = dateTimePicker1.Value.Day.ToString();
			MonthText.Text = dateTimePicker1.Value.Month.ToString();
			YearText.Text = dateTimePicker1.Value.Year.ToString();

			
		}//When the program starts
		private void MagicDates( object sender, EventArgs e ) {
			int day=1;//This stores the date
			int month=1;//This stores the month
			int year=1990;//This stores the year
			DateTime currentDate = dateTimePicker1.Value;//This grabs the current date
			DateTime testDate=currentDate;

			if(int.TryParse(MonthText.Text, out month)) {
				try {
					dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, month, dateTimePicker1.Value.Day);
					//Sets the date time picker month
					if((int.TryParse(DayText.Text, out day))) {
						try {
							dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, day);
							//Sets the date time picker day
							if(int.TryParse(YearText.Text, out year)) {
									try {
										dateTimePicker1.Value = new DateTime(year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day);
										if(day * month == year % 100) {
											result.Text = "YAY, This is a MAGIC date!!!";
										}
										//Checks to see if the day * month = last 2 digits of year
										//If yes, say it is a magic date
										else {
											result.Text = "This is not a magic date.";
										}
										//If not, then say it is not a magic date
									}//Tries to set the year
									catch {
										result.Text = "The date does not exist";
									}//If the year doesn't exist
								}
							//Checks if year is an int
							else if(YearText.Text == "") {

							}//Prevents an error if the text is empty
							else {
								result.Text = "ERROR, the year is not an integer.";
							}//Catches the rest of the errors
							
						}
						//This tries to see if the day exist
						catch {
							result.Text = "The date does not exist";
						}//This catches the error

					}
					//this finds out if the day is an integer
					else if(DayText.Text == "") {

					}
					//This lets there not be an error when everything is empty
					else {
						result.Text = "ERROR, the day is not an integer.";
					}//This catches the rest of the errors


				}//This tries to set the day as the set day, and throws an error 
				catch {
					result.Text = "The date does not exist";
				}

			}
			//This tries to get the month, and if it is succesful, cotinues to the next step

			else if(MonthText.Text == "") {

			}//If the user deletes everything, does not throw an error
			else {
				result.Text = "ERROR, the month is not an integer.";
			}//This will catch all the other possibilities
			

		}
		//Everytime the date is changed, this runs

		private void dateTimePicker1_ValueChanged( object sender, EventArgs e ) {
			DayText.Text = dateTimePicker1.Value.Day.ToString();
			MonthText.Text = dateTimePicker1.Value.Month.ToString();
			YearText.Text = dateTimePicker1.Value.Year.ToString();
			MessageBox.Show("Sorry, This is not a magic date.");
		}

		
		//This changes all of the text boxes when the datetime picker is changed
	}
}
