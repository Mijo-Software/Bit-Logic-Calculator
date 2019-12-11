using System;
using System.Windows.Forms;
using BitLogicCalculator.Properties;

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
			comboBoxBitRepresentation.SelectedIndex = 0;
			comboBoxMsbRepresentation.SelectedIndex = 0;
			comboBoxDataSize.SelectedIndex = comboBoxDataSize.Items.Count - 1;
		}

		#endregion

		#region SelectedIndexChanged event handlers

		private void ComboBoxMsbRepresentation_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void ComboBoxDataSize_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void ComboBoxBitRepresentation_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		#endregion

		#region SelectedIndexChanged event handlers

		private void TrackBarTransparency_Scroll(object sender, EventArgs e)
		{
		}

		#endregion

		#region Click event handlers

		#region buttons	

		private void ButtonLsbSign_Click(object sender, EventArgs e)
		{
			isLsbSignSet = !isLsbSignSet;
			if (!isLsbSignSet)
			{
				buttonLsbSign.Text = Resources.lsb0;
				labelA1Bit0.Text = Resources.number00;
				labelA1Bit1.Text = Resources.number01;
				labelA1Bit2.Text = Resources.number02;
				labelA1Bit3.Text = Resources.number03;
				labelA1Bit4.Text = Resources.number04;
				labelA1Bit5.Text = Resources.number05;
				labelA1Bit6.Text = Resources.number06;
				labelA1Bit7.Text = Resources.number07;
				labelA1Bit8.Text = Resources.number08;
				labelA1Bit9.Text = Resources.number09;
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
				labelA2Bit0.Text = Resources.number00;
				labelA2Bit1.Text = Resources.number01;
				labelA2Bit2.Text = Resources.number02;
				labelA2Bit3.Text = Resources.number03;
				labelA2Bit4.Text = Resources.number04;
				labelA2Bit5.Text = Resources.number05;
				labelA2Bit6.Text = Resources.number06;
				labelA2Bit7.Text = Resources.number07;
				labelA2Bit8.Text = Resources.number08;
				labelA2Bit9.Text = Resources.number09;
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
				labelResultBit0.Text = Resources.number00;
				labelResultBit1.Text = Resources.number01;
				labelResultBit2.Text = Resources.number02;
				labelResultBit3.Text = Resources.number03;
				labelResultBit4.Text = Resources.number04;
				labelResultBit5.Text = Resources.number05;
				labelResultBit6.Text = Resources.number06;
				labelResultBit7.Text = Resources.number07;
				labelResultBit8.Text = Resources.number08;
				labelResultBit9.Text = Resources.number09;
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
				labelA1Bit0.Text = Resources.number01;
				labelA1Bit1.Text = Resources.number02;
				labelA1Bit2.Text = Resources.number03;
				labelA1Bit3.Text = Resources.number04;
				labelA1Bit4.Text = Resources.number05;
				labelA1Bit5.Text = Resources.number06;
				labelA1Bit6.Text = Resources.number07;
				labelA1Bit7.Text = Resources.number08;
				labelA1Bit8.Text = Resources.number09;
				labelA1Bit9.Text = Resources.number10;
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
				labelA2Bit0.Text = Resources.number01;
				labelA2Bit1.Text = Resources.number02;
				labelA2Bit2.Text = Resources.number03;
				labelA2Bit3.Text = Resources.number04;
				labelA2Bit4.Text = Resources.number05;
				labelA2Bit5.Text = Resources.number06;
				labelA2Bit6.Text = Resources.number07;
				labelA2Bit7.Text = Resources.number08;
				labelA2Bit8.Text = Resources.number09;
				labelA2Bit9.Text = Resources.number10;
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
				labelResultBit0.Text = Resources.number01;
				labelResultBit1.Text = Resources.number02;
				labelResultBit2.Text = Resources.number03;
				labelResultBit3.Text = Resources.number04;
				labelResultBit4.Text = Resources.number05;
				labelResultBit5.Text = Resources.number06;
				labelResultBit6.Text = Resources.number07;
				labelResultBit7.Text = Resources.number08;
				labelResultBit8.Text = Resources.number09;
				labelResultBit9.Text = Resources.number10;
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

		private void LabelA1Bit0_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit1_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit2_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit3_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit4_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit5_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit6_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit7_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit8_Click(object sender, EventArgs e)
		{
		}

		private void LabelA1Bit9_Click(object sender, EventArgs e)
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

		private void LabelA2Bit0_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit1_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit2_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit3_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit4_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit5_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit6_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit8_Click(object sender, EventArgs e)
		{
		}

		private void LabelA2Bit9_Click(object sender, EventArgs e)
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

		private void CheckBoxA1Bit0_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit3_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit4_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit5_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit6_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit7_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit8_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA1Bit9_CheckedChanged(object sender, EventArgs e)
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

		private void CheckBoxA2Bit0_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit3_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit4_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit5_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit6_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit7_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit8_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxA2Bit9_CheckedChanged(object sender, EventArgs e)
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

		private void CheckBoxResultBit0_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit2_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit3_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit4_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit5_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit6_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit7_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit8_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void CheckBoxResultBit9_CheckedChanged(object sender, EventArgs e)
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

		#endregion
	}
}
