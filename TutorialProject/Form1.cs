using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialProject
{
	public partial class Names : Form
	{
		public Names()
		{
			InitializeComponent();
		}





		private void one_Click(object sender, EventArgs e){screen.Text = screen.Text + one.Text;}
		private void two_Click(object sender, EventArgs e){screen.Text = screen.Text + two.Text;}
		private void three_Click(object sender, EventArgs e){screen.Text = screen.Text + three.Text;}
		private void four_Click(object sender, EventArgs e){screen.Text = screen.Text + four.Text;}
		private void five_Click(object sender, EventArgs e){screen.Text = screen.Text + five.Text;}
		private void six_Click(object sender, EventArgs e){screen.Text = screen.Text + six.Text;}
		private void seven_Click(object sender, EventArgs e){screen.Text = screen.Text + seven.Text;}
		private void eight_Click(object sender, EventArgs e){screen.Text = screen.Text + eight.Text;}
		private void nine_Click(object sender, EventArgs e){screen.Text = screen.Text + nine.Text;}
		private void zero_Click(object sender, EventArgs e){screen.Text = screen.Text + zero.Text;}
		private void clear_Click(object sender, EventArgs e){ screen.Text = ""; }

		private void addition_Click(object sender, EventArgs e){screen.Text = screen.Text + addition.Text;}
		private void subtract_Click(object sender, EventArgs e){screen.Text = screen.Text + subtract.Text;}
		private void multiply_Click(object sender, EventArgs e){screen.Text = screen.Text + multiply.Text;}
		private void divide_Click(object sender, EventArgs e){screen.Text = screen.Text + divide.Text;}


		private void equal_Click(object sender, EventArgs e)
		{
			// create a array of numbers seperated by the operators
			List<String> numbers = new List<String>(screen.Text.Split('+', '-', '*', '/'));


			// check if the syntax is right
			foreach (String number in numbers) { if (number == "") { screen.Text = "Syntax Error"; return; } }

			string expression = "234/1+23*99";

			// Calculate the result following the PEMDAS rule
			double result = EvaluateExpression(screen.Text);

			screen.Text = result.ToString();

			double EvaluateExpression(string expression1)
			{
				try
				{
					System.Data.DataTable table = new System.Data.DataTable();
					table.Columns.Add("expression", typeof(string), expression1);
					System.Data.DataRow row = table.NewRow();
					table.Rows.Add(row);
					return double.Parse((string)row["expression"]);
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error: " + ex.Message);
					return double.NaN; // Return NaN (Not-a-Number) on error
				}
			}


		}
	}
}
