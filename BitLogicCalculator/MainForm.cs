using BitLogicCalculator.Properties;

using System;
using System.Windows.Forms;

namespace BitLogicCalculator
{
	public partial class MainForm : Form
	{
		#region Constants and variables

		private bool isLsbSignSet;

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
		}

		private void ButtonSubtractionA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonMultiplicationA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonDivisionA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalAndA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalOrA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalXorA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalXandA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalNorA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonLogicalXnorA1AndA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonInvertA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonInvertA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCopyResultToA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonCopyResultToA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftLeftWithZeroA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftLeftWithZeroA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftLeftWithOneA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftLeftWithOneA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftRightWithZeroA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftRightWithZeroA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftRightWithOneA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonShiftRightWithOneA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateLeftA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateLeftA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateRightA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRotateRightA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRevertA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRevertA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonClearA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonClearA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonFillA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonFillA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSwapA1A2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRandomizeA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonRandomizeA2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonInhibitionA1A2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonInhibitionA2A1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSubjunktionA1A2_Click(object sender, EventArgs e)
		{
		}

		private void ButtonSubjunktionA2A1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonHalfswapA1_Click(object sender, EventArgs e)
		{
		}

		private void ButtonHalfswapA2_Click(object sender, EventArgs e)
		{
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
