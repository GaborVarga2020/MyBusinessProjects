using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpInterfaceExample
{
	public partial class Form : System.Windows.Forms.Form
	{
		#region Fields

		private BackendSoftwareComponent _backendSoftwareComponent;

		#endregion

		#region Constructors

		public Form()
		{
			InitializeComponent();

			_backendSoftwareComponent = new BackendSoftwareComponent();
		}

		#endregion

		#region Methods

		private void EventHandler_ButtonIncreaseCounter_Click(object sender, EventArgs e)
		{
			_backendSoftwareComponent.IncreaseInternalCounter();
		}

		#endregion
	}
}
