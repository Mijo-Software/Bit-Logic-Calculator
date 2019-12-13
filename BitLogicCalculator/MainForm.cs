using BitLogicCalculator.Properties;

using System;
using System.Collections;
using System.Windows.Forms;

namespace BitLogicCalculator
{
	public partial class MainForm : Form
	{
		#region Constants and variables

		private bool isLsbSignSet;

		private const int length = 32;

		private BitArray accumulator1 = new BitArray(length: length);

		private BitArray accumulator2 = new BitArray(length: length);

		private readonly BitArray result = new BitArray(length: length);

		private readonly Random random = new Random();

		#endregion

		#region Local methods

		private void ShowAccumulator1States(BitArray bitArray)
		{
			checkBoxA1Bit00.Checked = bitArray.Get(index: 0);
			checkBoxA1Bit01.Checked = bitArray.Get(index: 1);
			checkBoxA1Bit02.Checked = bitArray.Get(index: 2);
			checkBoxA1Bit03.Checked = bitArray.Get(index: 3);
			checkBoxA1Bit04.Checked = bitArray.Get(index: 4);
			checkBoxA1Bit05.Checked = bitArray.Get(index: 5);
			checkBoxA1Bit06.Checked = bitArray.Get(index: 6);
			checkBoxA1Bit07.Checked = bitArray.Get(index: 7);
			if (groupBoxA1Byte2.Enabled)
			{
				checkBoxA1Bit08.Checked = bitArray.Get(index: 8);
				checkBoxA1Bit09.Checked = bitArray.Get(index: 9);
				checkBoxA1Bit10.Checked = bitArray.Get(index: 10);
				checkBoxA1Bit11.Checked = bitArray.Get(index: 11);
				checkBoxA1Bit12.Checked = bitArray.Get(index: 12);
				checkBoxA1Bit13.Checked = bitArray.Get(index: 13);
				checkBoxA1Bit14.Checked = bitArray.Get(index: 14);
				checkBoxA1Bit15.Checked = bitArray.Get(index: 15);
			}
			if (groupBoxA1Byte3.Enabled)
			{
				checkBoxA1Bit16.Checked = bitArray.Get(index: 16);
				checkBoxA1Bit17.Checked = bitArray.Get(index: 17);
				checkBoxA1Bit18.Checked = bitArray.Get(index: 18);
				checkBoxA1Bit19.Checked = bitArray.Get(index: 19);
				checkBoxA1Bit20.Checked = bitArray.Get(index: 20);
				checkBoxA1Bit21.Checked = bitArray.Get(index: 21);
				checkBoxA1Bit22.Checked = bitArray.Get(index: 22);
				checkBoxA1Bit23.Checked = bitArray.Get(index: 23);
			}
			if (groupBoxA1Byte4.Enabled)
			{
				checkBoxA1Bit24.Checked = bitArray.Get(index: 24);
				checkBoxA1Bit25.Checked = bitArray.Get(index: 25);
				checkBoxA1Bit26.Checked = bitArray.Get(index: 26);
				checkBoxA1Bit27.Checked = bitArray.Get(index: 27);
				checkBoxA1Bit28.Checked = bitArray.Get(index: 28);
				checkBoxA1Bit29.Checked = bitArray.Get(index: 29);
				checkBoxA1Bit30.Checked = bitArray.Get(index: 30);
				checkBoxA1Bit31.Checked = bitArray.Get(index: 31);
			}
		}

		private void ShowAccumulator2States(BitArray bitArray)
		{
			checkBoxA2Bit00.Checked = bitArray.Get(index: 0);
			checkBoxA2Bit01.Checked = bitArray.Get(index: 1);
			checkBoxA2Bit02.Checked = bitArray.Get(index: 2);
			checkBoxA2Bit03.Checked = bitArray.Get(index: 3);
			checkBoxA2Bit04.Checked = bitArray.Get(index: 4);
			checkBoxA2Bit05.Checked = bitArray.Get(index: 5);
			checkBoxA2Bit06.Checked = bitArray.Get(index: 6);
			checkBoxA2Bit07.Checked = bitArray.Get(index: 7);
			if (groupBoxA2Byte2.Enabled)
			{
				checkBoxA2Bit08.Checked = bitArray.Get(index: 8);
				checkBoxA2Bit09.Checked = bitArray.Get(index: 9);
				checkBoxA2Bit10.Checked = bitArray.Get(index: 10);
				checkBoxA2Bit11.Checked = bitArray.Get(index: 11);
				checkBoxA2Bit12.Checked = bitArray.Get(index: 12);
				checkBoxA2Bit13.Checked = bitArray.Get(index: 13);
				checkBoxA2Bit14.Checked = bitArray.Get(index: 14);
				checkBoxA2Bit15.Checked = bitArray.Get(index: 15);
			}
			if (groupBoxA2Byte3.Enabled)
			{
				checkBoxA2Bit16.Checked = bitArray.Get(index: 16);
				checkBoxA2Bit17.Checked = bitArray.Get(index: 17);
				checkBoxA2Bit18.Checked = bitArray.Get(index: 18);
				checkBoxA2Bit19.Checked = bitArray.Get(index: 19);
				checkBoxA2Bit20.Checked = bitArray.Get(index: 20);
				checkBoxA2Bit21.Checked = bitArray.Get(index: 21);
				checkBoxA2Bit22.Checked = bitArray.Get(index: 22);
				checkBoxA2Bit23.Checked = bitArray.Get(index: 23);
			}
			if (groupBoxA2Byte4.Enabled)
			{
				checkBoxA2Bit24.Checked = bitArray.Get(index: 24);
				checkBoxA2Bit25.Checked = bitArray.Get(index: 25);
				checkBoxA2Bit26.Checked = bitArray.Get(index: 26);
				checkBoxA2Bit27.Checked = bitArray.Get(index: 27);
				checkBoxA2Bit28.Checked = bitArray.Get(index: 28);
				checkBoxA2Bit29.Checked = bitArray.Get(index: 29);
				checkBoxA2Bit30.Checked = bitArray.Get(index: 30);
				checkBoxA2Bit31.Checked = bitArray.Get(index: 31);
			}
		}

		private void ShowResultStates(BitArray bitArray)
		{
			checkBoxResultBit00.Checked = bitArray.Get(index: 0);
			checkBoxResultBit01.Checked = bitArray.Get(index: 1);
			checkBoxResultBit02.Checked = bitArray.Get(index: 2);
			checkBoxResultBit03.Checked = bitArray.Get(index: 3);
			checkBoxResultBit04.Checked = bitArray.Get(index: 4);
			checkBoxResultBit05.Checked = bitArray.Get(index: 5);
			checkBoxResultBit06.Checked = bitArray.Get(index: 6);
			checkBoxResultBit07.Checked = bitArray.Get(index: 7);
			if (groupBoxResultByte2.Enabled)
			{
				checkBoxResultBit08.Checked = bitArray.Get(index: 8);
				checkBoxResultBit09.Checked = bitArray.Get(index: 9);
				checkBoxResultBit10.Checked = bitArray.Get(index: 10);
				checkBoxResultBit11.Checked = bitArray.Get(index: 11);
				checkBoxResultBit12.Checked = bitArray.Get(index: 12);
				checkBoxResultBit13.Checked = bitArray.Get(index: 13);
				checkBoxResultBit14.Checked = bitArray.Get(index: 14);
				checkBoxResultBit15.Checked = bitArray.Get(index: 15);
			}
			if (groupBoxResultByte3.Enabled)
			{
				checkBoxResultBit16.Checked = bitArray.Get(index: 16);
				checkBoxResultBit17.Checked = bitArray.Get(index: 17);
				checkBoxResultBit18.Checked = bitArray.Get(index: 18);
				checkBoxResultBit19.Checked = bitArray.Get(index: 19);
				checkBoxResultBit20.Checked = bitArray.Get(index: 20);
				checkBoxResultBit21.Checked = bitArray.Get(index: 21);
				checkBoxResultBit22.Checked = bitArray.Get(index: 22);
				checkBoxResultBit23.Checked = bitArray.Get(index: 23);
			}
			if (groupBoxResultByte4.Enabled)
			{
				checkBoxResultBit24.Checked = bitArray.Get(index: 24);
				checkBoxResultBit25.Checked = bitArray.Get(index: 25);
				checkBoxResultBit26.Checked = bitArray.Get(index: 26);
				checkBoxResultBit27.Checked = bitArray.Get(index: 27);
				checkBoxResultBit28.Checked = bitArray.Get(index: 28);
				checkBoxResultBit29.Checked = bitArray.Get(index: 29);
				checkBoxResultBit30.Checked = bitArray.Get(index: 30);
				checkBoxResultBit31.Checked = bitArray.Get(index: 31);
			}
		}

		private bool RandomBit() => (byte)random.Next(maxValue: 2) == 1;

		private void SetAccumulator1RandomBits()
		{
			for (int i = 0; i < length; i++)
			{
				accumulator1.Set(index: i, value: RandomBit());
			}
		}

		private void SetAccumulator2RandomBits()
		{
			for (int i = 0; i < length; i++)
			{
				accumulator2.Set(index: i, value: RandomBit());
			}
		}

		#endregion

		#region Constructor

		public MainForm() => InitializeComponent();

		#endregion

		#region Form* event handlers

		private void MainForm_Load(object sender, EventArgs e)
		{
			comboBoxMsbRepresentation.SelectedIndex = 0;
			comboBoxDataSize.SelectedIndex = comboBoxDataSize.Items.Count - 1;
			textBoxConversionInput.Text = Resources.number00;
			textBoxConversionOutput.Text = Resources.number00;
			comboBoxConversionInputUnit.SelectedIndex = 0;
			comboBoxConversionOutputUnit.SelectedIndex = 1;

			SetAccumulator1RandomBits();
			SetAccumulator2RandomBits();
			ShowAccumulator1States(bitArray: accumulator1);
			ShowAccumulator2States(bitArray: accumulator2);
		}

		#endregion

		#region SelectedIndexChanged event handlers

		private void ComboBoxMsbRepresentation_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void ComboBoxDataSize_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBoxDataSize.SelectedIndex)
			{
				case 0:
					checkBoxA1Bit08.Checked = false;
					checkBoxA1Bit09.Checked = false;
					checkBoxA1Bit10.Checked = false;
					checkBoxA1Bit11.Checked = false;
					checkBoxA1Bit12.Checked = false;
					checkBoxA1Bit13.Checked = false;
					checkBoxA1Bit14.Checked = false;
					checkBoxA1Bit15.Checked = false;
					checkBoxA1Bit16.Checked = false;
					checkBoxA1Bit17.Checked = false;
					checkBoxA1Bit18.Checked = false;
					checkBoxA1Bit19.Checked = false;
					checkBoxA1Bit20.Checked = false;
					checkBoxA1Bit21.Checked = false;
					checkBoxA1Bit22.Checked = false;
					checkBoxA1Bit23.Checked = false;
					checkBoxA1Bit24.Checked = false;
					checkBoxA1Bit25.Checked = false;
					checkBoxA1Bit26.Checked = false;
					checkBoxA1Bit27.Checked = false;
					checkBoxA1Bit28.Checked = false;
					checkBoxA1Bit29.Checked = false;
					checkBoxA1Bit30.Checked = false;
					checkBoxA1Bit31.Checked = false;
					checkBoxA2Bit08.Checked = false;
					checkBoxA2Bit09.Checked = false;
					checkBoxA2Bit10.Checked = false;
					checkBoxA2Bit11.Checked = false;
					checkBoxA2Bit12.Checked = false;
					checkBoxA2Bit13.Checked = false;
					checkBoxA2Bit14.Checked = false;
					checkBoxA2Bit15.Checked = false;
					checkBoxA2Bit16.Checked = false;
					checkBoxA2Bit17.Checked = false;
					checkBoxA2Bit18.Checked = false;
					checkBoxA2Bit19.Checked = false;
					checkBoxA2Bit20.Checked = false;
					checkBoxA2Bit21.Checked = false;
					checkBoxA2Bit22.Checked = false;
					checkBoxA2Bit23.Checked = false;
					checkBoxA2Bit24.Checked = false;
					checkBoxA2Bit25.Checked = false;
					checkBoxA2Bit26.Checked = false;
					checkBoxA2Bit27.Checked = false;
					checkBoxA2Bit28.Checked = false;
					checkBoxA2Bit29.Checked = false;
					checkBoxA2Bit30.Checked = false;
					checkBoxA2Bit31.Checked = false;
					checkBoxResultBit08.Checked = false;
					checkBoxResultBit09.Checked = false;
					checkBoxResultBit10.Checked = false;
					checkBoxResultBit11.Checked = false;
					checkBoxResultBit12.Checked = false;
					checkBoxResultBit13.Checked = false;
					checkBoxResultBit14.Checked = false;
					checkBoxResultBit15.Checked = false;
					checkBoxResultBit16.Checked = false;
					checkBoxResultBit17.Checked = false;
					checkBoxResultBit18.Checked = false;
					checkBoxResultBit19.Checked = false;
					checkBoxResultBit20.Checked = false;
					checkBoxResultBit21.Checked = false;
					checkBoxResultBit22.Checked = false;
					checkBoxResultBit23.Checked = false;
					checkBoxResultBit24.Checked = false;
					checkBoxResultBit25.Checked = false;
					checkBoxResultBit26.Checked = false;
					checkBoxResultBit27.Checked = false;
					checkBoxResultBit28.Checked = false;
					checkBoxResultBit29.Checked = false;
					checkBoxResultBit30.Checked = false;
					checkBoxResultBit31.Checked = false;
					groupBoxA1Byte2.Enabled = false;
					groupBoxA1Byte3.Enabled = false;
					groupBoxA1Byte4.Enabled = false;
					groupBoxA2Byte2.Enabled = false;
					groupBoxA2Byte3.Enabled = false;
					groupBoxA2Byte4.Enabled = false;
					groupBoxResultByte2.Enabled = false;
					groupBoxResultByte3.Enabled = false;
					groupBoxResultByte4.Enabled = false;
					break;
				case 1:
					checkBoxA1Bit16.Checked = false;
					checkBoxA1Bit17.Checked = false;
					checkBoxA1Bit18.Checked = false;
					checkBoxA1Bit19.Checked = false;
					checkBoxA1Bit20.Checked = false;
					checkBoxA1Bit21.Checked = false;
					checkBoxA1Bit22.Checked = false;
					checkBoxA1Bit23.Checked = false;
					checkBoxA1Bit24.Checked = false;
					checkBoxA1Bit25.Checked = false;
					checkBoxA1Bit26.Checked = false;
					checkBoxA1Bit27.Checked = false;
					checkBoxA1Bit28.Checked = false;
					checkBoxA1Bit29.Checked = false;
					checkBoxA1Bit30.Checked = false;
					checkBoxA1Bit31.Checked = false;
					checkBoxA2Bit16.Checked = false;
					checkBoxA2Bit17.Checked = false;
					checkBoxA2Bit18.Checked = false;
					checkBoxA2Bit19.Checked = false;
					checkBoxA2Bit20.Checked = false;
					checkBoxA2Bit21.Checked = false;
					checkBoxA2Bit22.Checked = false;
					checkBoxA2Bit23.Checked = false;
					checkBoxA2Bit24.Checked = false;
					checkBoxA2Bit25.Checked = false;
					checkBoxA2Bit26.Checked = false;
					checkBoxA2Bit27.Checked = false;
					checkBoxA2Bit28.Checked = false;
					checkBoxA2Bit29.Checked = false;
					checkBoxA2Bit30.Checked = false;
					checkBoxA2Bit31.Checked = false;
					checkBoxResultBit16.Checked = false;
					checkBoxResultBit17.Checked = false;
					checkBoxResultBit18.Checked = false;
					checkBoxResultBit19.Checked = false;
					checkBoxResultBit20.Checked = false;
					checkBoxResultBit21.Checked = false;
					checkBoxResultBit22.Checked = false;
					checkBoxResultBit23.Checked = false;
					checkBoxResultBit24.Checked = false;
					checkBoxResultBit25.Checked = false;
					checkBoxResultBit26.Checked = false;
					checkBoxResultBit27.Checked = false;
					checkBoxResultBit28.Checked = false;
					checkBoxResultBit29.Checked = false;
					checkBoxResultBit30.Checked = false;
					checkBoxResultBit31.Checked = false;
					groupBoxA1Byte2.Enabled = true;
					groupBoxA1Byte3.Enabled = false;
					groupBoxA1Byte4.Enabled = false;
					groupBoxA2Byte2.Enabled = true;
					groupBoxA2Byte3.Enabled = false;
					groupBoxA2Byte4.Enabled = false;
					groupBoxResultByte2.Enabled = true;
					groupBoxResultByte3.Enabled = false;
					groupBoxResultByte4.Enabled = false;
					break;
				default:
					groupBoxA1Byte2.Enabled = true;
					groupBoxA1Byte3.Enabled = true;
					groupBoxA1Byte4.Enabled = true;
					groupBoxA2Byte2.Enabled = true;
					groupBoxA2Byte3.Enabled = true;
					groupBoxA2Byte4.Enabled = true;
					groupBoxResultByte2.Enabled = true;
					groupBoxResultByte3.Enabled = true;
					groupBoxResultByte4.Enabled = true;
					break;
			}
		}

		private void ComboBoxConversionInputUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void ComboBoxConversionOutputUnit_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		#endregion

		#region TextChanged event handlers

		private void TextBoxConversionInput_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextBoxConversionOutput_TextChanged(object sender, EventArgs e)
		{
		}

		#endregion

		#region Click event handlers

		#region buttons	

		private void ButtonAbout_Click(object sender, EventArgs e)
		{
			using (AboutBox aboutBox = new AboutBox())
			{
				aboutBox.ShowDialog();
			}
		}

		private void ButtonLsbSign_Click(object sender, EventArgs e)
		{
			isLsbSignSet = !isLsbSignSet;
			if (!isLsbSignSet)
			{
				buttonLsbSign.Text = Resources.lsb0;
				labelA1Bit00.Text = Resources.number00;
				labelA1Bit01.Text = Resources.number01;
				labelA1Bit02.Text = Resources.number02;
				labelA1Bit03.Text = Resources.number03;
				labelA1Bit04.Text = Resources.number04;
				labelA1Bit05.Text = Resources.number05;
				labelA1Bit06.Text = Resources.number06;
				labelA1Bit07.Text = Resources.number07;
				labelA1Bit08.Text = Resources.number08;
				labelA1Bit09.Text = Resources.number09;
				labelA1Bit10.Text = Resources.number10;
				labelA1Bit11.Text = Resources.number11;
				labelA1Bit12.Text = Resources.number12;
				labelA1Bit13.Text = Resources.number13;
				labelA1Bit14.Text = Resources.number14;
				labelA1Bit15.Text = Resources.number15;
				labelA1Bit16.Text = Resources.number16;
				labelA1Bit17.Text = Resources.number17;
				labelA1Bit18.Text = Resources.number18;
				labelA1Bit19.Text = Resources.number19;
				labelA1Bit20.Text = Resources.number20;
				labelA1Bit21.Text = Resources.number21;
				labelA1Bit22.Text = Resources.number22;
				labelA1Bit23.Text = Resources.number23;
				labelA1Bit24.Text = Resources.number24;
				labelA1Bit25.Text = Resources.number25;
				labelA1Bit26.Text = Resources.number26;
				labelA1Bit27.Text = Resources.number27;
				labelA1Bit28.Text = Resources.number28;
				labelA1Bit29.Text = Resources.number29;
				labelA1Bit30.Text = Resources.number30;
				labelA1Bit31.Text = Resources.number31;
				labelA2Bit00.Text = Resources.number00;
				labelA2Bit01.Text = Resources.number01;
				labelA2Bit02.Text = Resources.number02;
				labelA2Bit03.Text = Resources.number03;
				labelA2Bit04.Text = Resources.number04;
				labelA2Bit05.Text = Resources.number05;
				labelA2Bit06.Text = Resources.number06;
				labelA2Bit07.Text = Resources.number07;
				labelA2Bit08.Text = Resources.number08;
				labelA2Bit09.Text = Resources.number09;
				labelA2Bit10.Text = Resources.number10;
				labelA2Bit11.Text = Resources.number11;
				labelA2Bit12.Text = Resources.number12;
				labelA2Bit13.Text = Resources.number13;
				labelA2Bit14.Text = Resources.number14;
				labelA2Bit15.Text = Resources.number15;
				labelA2Bit16.Text = Resources.number16;
				labelA2Bit17.Text = Resources.number17;
				labelA2Bit18.Text = Resources.number18;
				labelA2Bit19.Text = Resources.number19;
				labelA2Bit20.Text = Resources.number20;
				labelA2Bit21.Text = Resources.number21;
				labelA2Bit22.Text = Resources.number22;
				labelA2Bit23.Text = Resources.number23;
				labelA2Bit24.Text = Resources.number24;
				labelA2Bit25.Text = Resources.number25;
				labelA2Bit26.Text = Resources.number26;
				labelA2Bit27.Text = Resources.number27;
				labelA2Bit28.Text = Resources.number28;
				labelA2Bit29.Text = Resources.number29;
				labelA2Bit30.Text = Resources.number30;
				labelA2Bit31.Text = Resources.number31;
				labelResultBit00.Text = Resources.number00;
				labelResultBit01.Text = Resources.number01;
				labelResultBit02.Text = Resources.number02;
				labelResultBit03.Text = Resources.number03;
				labelResultBit04.Text = Resources.number04;
				labelResultBit05.Text = Resources.number05;
				labelResultBit06.Text = Resources.number06;
				labelResultBit07.Text = Resources.number07;
				labelResultBit08.Text = Resources.number08;
				labelResultBit09.Text = Resources.number09;
				labelResultBit10.Text = Resources.number10;
				labelResultBit11.Text = Resources.number11;
				labelResultBit12.Text = Resources.number12;
				labelResultBit13.Text = Resources.number13;
				labelResultBit14.Text = Resources.number14;
				labelResultBit15.Text = Resources.number15;
				labelResultBit16.Text = Resources.number16;
				labelResultBit17.Text = Resources.number17;
				labelResultBit18.Text = Resources.number18;
				labelResultBit19.Text = Resources.number19;
				labelResultBit20.Text = Resources.number20;
				labelResultBit21.Text = Resources.number21;
				labelResultBit22.Text = Resources.number22;
				labelResultBit23.Text = Resources.number23;
				labelResultBit24.Text = Resources.number24;
				labelResultBit25.Text = Resources.number25;
				labelResultBit26.Text = Resources.number26;
				labelResultBit27.Text = Resources.number27;
				labelResultBit28.Text = Resources.number28;
				labelResultBit29.Text = Resources.number29;
				labelResultBit30.Text = Resources.number30;
				labelResultBit31.Text = Resources.number31;
			}
			else
			{
				buttonLsbSign.Text = Resources.lsb1;
				labelA1Bit00.Text = Resources.number01;
				labelA1Bit01.Text = Resources.number02;
				labelA1Bit02.Text = Resources.number03;
				labelA1Bit03.Text = Resources.number04;
				labelA1Bit04.Text = Resources.number05;
				labelA1Bit05.Text = Resources.number06;
				labelA1Bit06.Text = Resources.number07;
				labelA1Bit07.Text = Resources.number08;
				labelA1Bit08.Text = Resources.number09;
				labelA1Bit09.Text = Resources.number10;
				labelA1Bit10.Text = Resources.number11;
				labelA1Bit11.Text = Resources.number12;
				labelA1Bit12.Text = Resources.number13;
				labelA1Bit13.Text = Resources.number14;
				labelA1Bit14.Text = Resources.number15;
				labelA1Bit15.Text = Resources.number16;
				labelA1Bit16.Text = Resources.number17;
				labelA1Bit17.Text = Resources.number18;
				labelA1Bit18.Text = Resources.number19;
				labelA1Bit19.Text = Resources.number20;
				labelA1Bit20.Text = Resources.number21;
				labelA1Bit21.Text = Resources.number22;
				labelA1Bit22.Text = Resources.number23;
				labelA1Bit23.Text = Resources.number24;
				labelA1Bit24.Text = Resources.number25;
				labelA1Bit25.Text = Resources.number26;
				labelA1Bit26.Text = Resources.number27;
				labelA1Bit27.Text = Resources.number28;
				labelA1Bit28.Text = Resources.number29;
				labelA1Bit29.Text = Resources.number30;
				labelA1Bit30.Text = Resources.number31;
				labelA1Bit31.Text = Resources.number32;
				labelA2Bit00.Text = Resources.number01;
				labelA2Bit01.Text = Resources.number02;
				labelA2Bit02.Text = Resources.number03;
				labelA2Bit03.Text = Resources.number04;
				labelA2Bit04.Text = Resources.number05;
				labelA2Bit05.Text = Resources.number06;
				labelA2Bit06.Text = Resources.number07;
				labelA2Bit07.Text = Resources.number08;
				labelA2Bit08.Text = Resources.number09;
				labelA2Bit09.Text = Resources.number10;
				labelA2Bit10.Text = Resources.number11;
				labelA2Bit11.Text = Resources.number12;
				labelA2Bit12.Text = Resources.number13;
				labelA2Bit13.Text = Resources.number14;
				labelA2Bit14.Text = Resources.number15;
				labelA2Bit15.Text = Resources.number16;
				labelA2Bit16.Text = Resources.number17;
				labelA2Bit17.Text = Resources.number18;
				labelA2Bit18.Text = Resources.number19;
				labelA2Bit19.Text = Resources.number20;
				labelA2Bit20.Text = Resources.number21;
				labelA2Bit21.Text = Resources.number22;
				labelA2Bit22.Text = Resources.number23;
				labelA2Bit23.Text = Resources.number24;
				labelA2Bit24.Text = Resources.number25;
				labelA2Bit25.Text = Resources.number26;
				labelA2Bit26.Text = Resources.number27;
				labelA2Bit27.Text = Resources.number28;
				labelA2Bit28.Text = Resources.number29;
				labelA2Bit29.Text = Resources.number30;
				labelA2Bit30.Text = Resources.number31;
				labelA2Bit31.Text = Resources.number32;
				labelResultBit00.Text = Resources.number01;
				labelResultBit01.Text = Resources.number02;
				labelResultBit02.Text = Resources.number03;
				labelResultBit03.Text = Resources.number04;
				labelResultBit04.Text = Resources.number05;
				labelResultBit05.Text = Resources.number06;
				labelResultBit06.Text = Resources.number07;
				labelResultBit07.Text = Resources.number08;
				labelResultBit08.Text = Resources.number09;
				labelResultBit09.Text = Resources.number10;
				labelResultBit10.Text = Resources.number11;
				labelResultBit11.Text = Resources.number12;
				labelResultBit12.Text = Resources.number13;
				labelResultBit13.Text = Resources.number14;
				labelResultBit14.Text = Resources.number15;
				labelResultBit15.Text = Resources.number16;
				labelResultBit16.Text = Resources.number17;
				labelResultBit17.Text = Resources.number18;
				labelResultBit18.Text = Resources.number19;
				labelResultBit19.Text = Resources.number20;
				labelResultBit20.Text = Resources.number21;
				labelResultBit21.Text = Resources.number22;
				labelResultBit22.Text = Resources.number23;
				labelResultBit23.Text = Resources.number24;
				labelResultBit24.Text = Resources.number25;
				labelResultBit25.Text = Resources.number26;
				labelResultBit26.Text = Resources.number27;
				labelResultBit27.Text = Resources.number28;
				labelResultBit28.Text = Resources.number29;
				labelResultBit29.Text = Resources.number30;
				labelResultBit30.Text = Resources.number31;
				labelResultBit31.Text = Resources.number32;
			}
		}

		private void ButtonAdditionA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonSubtractionA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonMultiplicationA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonDivisionA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalAndA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalOrA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalXorA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalXandA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalNorA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonLogicalXnorA1AndA2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonInvertA1_Click(object sender, EventArgs e)
		{
			accumulator1.Set(index: 0, value: !accumulator1.Get(index: 0));
			accumulator1.Set(index: 1, value: !accumulator1.Get(index: 1));
			accumulator1.Set(index: 2, value: !accumulator1.Get(index: 2));
			accumulator1.Set(index: 3, value: !accumulator1.Get(index: 3));
			accumulator1.Set(index: 4, value: !accumulator1.Get(index: 4));
			accumulator1.Set(index: 5, value: !accumulator1.Get(index: 5));
			accumulator1.Set(index: 6, value: !accumulator1.Get(index: 6));
			accumulator1.Set(index: 7, value: !accumulator1.Get(index: 7));
			accumulator1.Set(index: 8, value: !accumulator1.Get(index: 8));
			accumulator1.Set(index: 9, value: !accumulator1.Get(index: 9));
			accumulator1.Set(index: 10, value: !accumulator1.Get(index: 10));
			accumulator1.Set(index: 11, value: !accumulator1.Get(index: 11));
			accumulator1.Set(index: 12, value: !accumulator1.Get(index: 12));
			accumulator1.Set(index: 13, value: !accumulator1.Get(index: 13));
			accumulator1.Set(index: 14, value: !accumulator1.Get(index: 14));
			accumulator1.Set(index: 15, value: !accumulator1.Get(index: 15));
			accumulator1.Set(index: 16, value: !accumulator1.Get(index: 16));
			accumulator1.Set(index: 17, value: !accumulator1.Get(index: 17));
			accumulator1.Set(index: 18, value: !accumulator1.Get(index: 18));
			accumulator1.Set(index: 19, value: !accumulator1.Get(index: 19));
			accumulator1.Set(index: 20, value: !accumulator1.Get(index: 20));
			accumulator1.Set(index: 21, value: !accumulator1.Get(index: 21));
			accumulator1.Set(index: 22, value: !accumulator1.Get(index: 22));
			accumulator1.Set(index: 23, value: !accumulator1.Get(index: 23));
			accumulator1.Set(index: 24, value: !accumulator1.Get(index: 24));
			accumulator1.Set(index: 25, value: !accumulator1.Get(index: 25));
			accumulator1.Set(index: 26, value: !accumulator1.Get(index: 26));
			accumulator1.Set(index: 27, value: !accumulator1.Get(index: 27));
			accumulator1.Set(index: 28, value: !accumulator1.Get(index: 28));
			accumulator1.Set(index: 29, value: !accumulator1.Get(index: 29));
			accumulator1.Set(index: 30, value: !accumulator1.Get(index: 30));
			accumulator1.Set(index: 31, value: !accumulator1.Get(index: 31));
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonInvertA2_Click(object sender, EventArgs e)
		{
			accumulator2.Set(index: 0, value: !accumulator2.Get(index: 0));
			accumulator2.Set(index: 1, value: !accumulator2.Get(index: 1));
			accumulator2.Set(index: 2, value: !accumulator2.Get(index: 2));
			accumulator2.Set(index: 3, value: !accumulator2.Get(index: 3));
			accumulator2.Set(index: 4, value: !accumulator2.Get(index: 4));
			accumulator2.Set(index: 5, value: !accumulator2.Get(index: 5));
			accumulator2.Set(index: 6, value: !accumulator2.Get(index: 6));
			accumulator2.Set(index: 7, value: !accumulator2.Get(index: 7));
			accumulator2.Set(index: 8, value: !accumulator2.Get(index: 8));
			accumulator2.Set(index: 9, value: !accumulator2.Get(index: 9));
			accumulator2.Set(index: 10, value: !accumulator2.Get(index: 10));
			accumulator2.Set(index: 11, value: !accumulator2.Get(index: 11));
			accumulator2.Set(index: 12, value: !accumulator2.Get(index: 12));
			accumulator2.Set(index: 13, value: !accumulator2.Get(index: 13));
			accumulator2.Set(index: 14, value: !accumulator2.Get(index: 14));
			accumulator2.Set(index: 15, value: !accumulator2.Get(index: 15));
			accumulator2.Set(index: 16, value: !accumulator2.Get(index: 16));
			accumulator2.Set(index: 17, value: !accumulator2.Get(index: 17));
			accumulator2.Set(index: 18, value: !accumulator2.Get(index: 18));
			accumulator2.Set(index: 19, value: !accumulator2.Get(index: 19));
			accumulator2.Set(index: 20, value: !accumulator2.Get(index: 20));
			accumulator2.Set(index: 21, value: !accumulator2.Get(index: 21));
			accumulator2.Set(index: 22, value: !accumulator2.Get(index: 22));
			accumulator2.Set(index: 23, value: !accumulator2.Get(index: 23));
			accumulator2.Set(index: 24, value: !accumulator2.Get(index: 24));
			accumulator2.Set(index: 25, value: !accumulator2.Get(index: 25));
			accumulator2.Set(index: 26, value: !accumulator2.Get(index: 26));
			accumulator2.Set(index: 27, value: !accumulator2.Get(index: 27));
			accumulator2.Set(index: 28, value: !accumulator2.Get(index: 28));
			accumulator2.Set(index: 29, value: !accumulator2.Get(index: 29));
			accumulator2.Set(index: 30, value: !accumulator2.Get(index: 30));
			accumulator2.Set(index: 31, value: !accumulator2.Get(index: 31));
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonCopyResultToA1_Click(object sender, EventArgs e)
		{
			accumulator1 = result;
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonCopyResultToA2_Click(object sender, EventArgs e)
		{
			accumulator2 = result;
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonShiftLeftWithZeroA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonShiftLeftWithZeroA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonShiftLeftWithOneA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonShiftLeftWithOneA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonShiftRightWithZeroA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonShiftRightWithZeroA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonShiftRightWithOneA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonShiftRightWithOneA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonRotateLeftA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonRotateLeftA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonRotateRightA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonRotateRightA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonRevertA1_Click(object sender, EventArgs e)
		{
			BitArray bitArray = accumulator1;
			accumulator1.Set(index: 0, value: bitArray.Get(index: 31));
			accumulator1.Set(index: 1, value: bitArray.Get(index: 30));
			accumulator1.Set(index: 2, value: bitArray.Get(index: 29));
			accumulator1.Set(index: 3, value: bitArray.Get(index: 28));
			accumulator1.Set(index: 4, value: bitArray.Get(index: 27));
			accumulator1.Set(index: 5, value: bitArray.Get(index: 26));
			accumulator1.Set(index: 6, value: bitArray.Get(index: 25));
			accumulator1.Set(index: 7, value: bitArray.Get(index: 24));
			accumulator1.Set(index: 8, value: bitArray.Get(index: 23));
			accumulator1.Set(index: 9, value: bitArray.Get(index: 22));
			accumulator1.Set(index: 10, value: bitArray.Get(index: 21));
			accumulator1.Set(index: 11, value: bitArray.Get(index: 20));
			accumulator1.Set(index: 12, value: bitArray.Get(index: 19));
			accumulator1.Set(index: 13, value: bitArray.Get(index: 18));
			accumulator1.Set(index: 14, value: bitArray.Get(index: 17));
			accumulator1.Set(index: 15, value: bitArray.Get(index: 16));
			accumulator1.Set(index: 16, value: bitArray.Get(index: 15));
			accumulator1.Set(index: 17, value: bitArray.Get(index: 14));
			accumulator1.Set(index: 18, value: bitArray.Get(index: 13));
			accumulator1.Set(index: 19, value: bitArray.Get(index: 12));
			accumulator1.Set(index: 20, value: bitArray.Get(index: 11));
			accumulator1.Set(index: 21, value: bitArray.Get(index: 10));
			accumulator1.Set(index: 22, value: bitArray.Get(index: 9));
			accumulator1.Set(index: 23, value: bitArray.Get(index: 8));
			accumulator1.Set(index: 24, value: bitArray.Get(index: 7));
			accumulator1.Set(index: 25, value: bitArray.Get(index: 6));
			accumulator1.Set(index: 26, value: bitArray.Get(index: 5));
			accumulator1.Set(index: 27, value: bitArray.Get(index: 4));
			accumulator1.Set(index: 28, value: bitArray.Get(index: 3));
			accumulator1.Set(index: 29, value: bitArray.Get(index: 2));
			accumulator1.Set(index: 30, value: bitArray.Get(index: 1));
			accumulator1.Set(index: 31, value: bitArray.Get(index: 0));
			ShowAccumulator1States(bitArray: accumulator2);
		}

		private void ButtonRevertA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonClearA1_Click(object sender, EventArgs e)
		{
			accumulator1.SetAll(value: false);
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonClearA2_Click(object sender, EventArgs e)
		{
			accumulator2.SetAll(value: false);
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonFillA1_Click(object sender, EventArgs e)
		{
			accumulator1.SetAll(value: true);
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonFillA2_Click(object sender, EventArgs e)
		{
			accumulator2.SetAll(value: true);
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonSwapA1A2_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonRandomizeA1_Click(object sender, EventArgs e)
		{
			SetAccumulator1RandomBits();
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonRandomizeA2_Click(object sender, EventArgs e)
		{
			SetAccumulator2RandomBits();
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonInhibitionA1A2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonInhibitionA2A1_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonSubjunktionA1A2_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonSubjunktionA2A1_Click(object sender, EventArgs e)
		{
			ShowResultStates(bitArray: result);
		}

		private void ButtonHalfswapA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonHalfswapA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		private void ButtonTwosComponentA1_Click(object sender, EventArgs e)
		{
			ShowAccumulator1States(bitArray: accumulator1);
		}

		private void ButtonTwosComponentA2_Click(object sender, EventArgs e)
		{
			ShowAccumulator2States(bitArray: accumulator2);
		}

		#endregion

		#region labels

		private void LabelA1Bit00_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit01_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit02_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit03_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit04_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit05_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit06_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit07_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit08_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit09_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit10_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit11_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit12_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit13_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit14_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit15_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit16_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit17_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit18_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit19_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit20_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit21_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit22_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit23_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit24_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit25_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit26_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit27_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit28_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit29_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit30_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit31_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit00_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit01_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit02_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit03_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit04_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit05_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit06_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit08_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit09_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit10_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit11_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit12_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit13_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit14_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit15_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit16_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit17_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit18_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit19_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit20_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit21_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit22_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit23_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit24_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit25_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit26_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit27_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit28_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit29_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit30_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit31_Click(object sender, EventArgs e)
		{
		}

		#endregion

		#endregion

		#region CheckedChanged event handlers

		private void CheckBoxA1Bit00_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit01_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit02_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit03_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit04_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit05_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit06_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit07_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit08_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit09_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit10_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit11_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit12_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit13_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit14_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit15_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit16_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit17_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit18_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit19_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit20_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit21_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit22_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit23_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit24_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit25_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit26_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit27_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit28_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit29_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit30_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit31_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit00_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit01_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit02_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit03_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit04_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit05_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit06_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit07_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit08_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit09_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit10_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit11_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit12_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit13_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit14_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit15_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit16_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit17_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit18_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit19_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit20_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit21_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit22_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit23_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit24_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit25_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit26_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit27_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit28_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit29_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit30_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit31_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit00_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit01_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit02_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit03_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit04_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit05_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit06_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit07_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit08_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit09_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit10_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit11_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit12_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit13_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit14_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit15_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit16_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit17_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit18_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit19_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit20_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit21_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit22_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit23_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit24_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit25_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit26_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit27_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit28_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit29_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit30_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit31_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxAlwaysOnTop_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxFadeInOut_CheckedChanged(object sender, EventArgs e)
		{
		}

		#endregion
	}
}
