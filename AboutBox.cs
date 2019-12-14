using MijoSoftware.AssemblyInformation;

using System;
using System.Windows.Forms;

namespace BitLogicCalculator
{
	/// <summary>
	/// AboutBox
	/// </summary>
	internal partial class AboutBox : Form
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AboutBox() => InitializeComponent();

		/// <summary>
		/// Load the form
		/// </summary>
		/// <param name="sender">object sender</param>
		/// <param name="e">event arguments</param>
		/// <remarks>The parameters <paramref name="e"/> and <paramref name="sender"/> are not needed, but must be indicated.</remarks>
		private void AboutBox_Load(object sender, EventArgs e)
		{
			Text = $"Info about {AssemblyInfo.AssemblyTitle}";
			labelProductName.Text = AssemblyInfo.AssemblyProduct;
			labelVersion.Text = $"Version {AssemblyInfo.AssemblyVersion}";
			labelCopyright.Text = AssemblyInfo.AssemblyCopyright;
			labelCompanyName.Text = AssemblyInfo.AssemblyCompany;
			textBoxDescription.Text = AssemblyInfo.AssemblyDescription;
		}
	}
}
