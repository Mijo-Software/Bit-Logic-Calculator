using System;
using System.Globalization;
using System.Windows.Forms;

namespace BitLogicCalculator
{
	public partial class StatisticsForm : Form
	{
		private int numberA1Bit0;

		private int numberA1Bit1;

		private int numberA2Bit0;

		private int numberA2Bit1;

		private int numberResultBit0;

		private int numberResultBit1;

		/// <summary>
		/// culture info for the date
		/// </summary>
		private static readonly CultureInfo culture = CultureInfo.CurrentUICulture;

		public StatisticsForm() => InitializeComponent();

		public void SetData(int numberA1Bit0, int numberA1Bit1, int numberA2Bit0, int numberA2Bit1, int numberResultBit0, int numberResultBit1)
		{
			this.numberA1Bit0 = numberA1Bit0;
			this.numberA1Bit1 = numberA1Bit1;
			this.numberA2Bit0 = numberA2Bit0;
			this.numberA2Bit1 = numberA2Bit1;
			this.numberResultBit0 = numberResultBit0;
			this.numberResultBit1 = numberResultBit1;
		}

		private void StatisticsForm_Load(object sender, EventArgs e)
		{
			labelA1Bit0Number.Text = numberA1Bit0.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA1Bit0 / (numberA1Bit0 + numberA1Bit1));
			labelA1Bit1Number.Text = numberA1Bit1.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA1Bit1 / (numberA1Bit0 + numberA1Bit1));
			labelA1TotalNumber.Text = (numberA1Bit0 + numberA1Bit1).ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberA1Bit0 + numberA1Bit1) / (numberA1Bit0 + numberA1Bit1));
			labelA2Bit0Number.Text = numberA2Bit0.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA2Bit0 / (numberA2Bit0 + numberA2Bit1));
			labelA2Bit1Number.Text = numberA2Bit1.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberA2Bit1 / (numberA2Bit0 + numberA2Bit1));
			labelA2TotalNumber.Text = (numberA2Bit0 + numberA2Bit1).ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberA2Bit0 + numberA2Bit1) / (numberA2Bit0 + numberA2Bit1));
			labelResultBit0Number.Text = numberResultBit0.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberResultBit0 / (numberResultBit0 + numberResultBit1));
			labelResultBit1Number.Text = numberResultBit1.ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * numberResultBit1 / (numberResultBit0 + numberResultBit1));
			labelResultTotalNumber.Text = (numberResultBit0 + numberResultBit1).ToString(provider: culture) + string.Format(provider: culture, format: " ({0:0.00}%)", args: 100.0 * (numberResultBit0 + numberResultBit1) / (numberResultBit0 + numberResultBit1));
		}
	}
}
