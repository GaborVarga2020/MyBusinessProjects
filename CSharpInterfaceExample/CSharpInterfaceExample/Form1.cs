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

		private ActivityLoggerToFile _activityLoggerToFile;
		private BackendSoftwareComponent _backendSoftwareComponent;

		#endregion

		#region Constructors

		public Form()
		{
			InitializeComponent();

			_backendSoftwareComponent = new BackendSoftwareComponent();
			_backendSoftwareComponent.SetActivityLogger(this);
		}

		#endregion

		#region Methods

		private void EventHandler_ButtonIncreaseCounter_Click(object sender, EventArgs e)
		{
			_backendSoftwareComponent.IncreaseInternalCounter();
		}

		private void EventHandler_ButtonLogToFile_Click(object sender, EventArgs e)
		{
			_backendSoftwareComponent.SetActivityLogger(_activityLoggerToFile);
		}

		public void LogActivity(string a_strLogMessage)
		{
			if (_textBox.Text.Equals(string.Empty) == false)
			{
				_textBox.Text += "\r\n";
			}

			_textBox.Text += a_strLogMessage;
		}

		#endregion
	}
}
