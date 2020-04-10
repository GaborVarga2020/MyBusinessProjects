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
	public partial class Form :
		System.Windows.Forms.Form,
		IActivityLogger
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

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="a_bDisposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool a_bDisposing)
		{
			if (a_bDisposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}

			base.Dispose(a_bDisposing);
		}

		private void EventHandler_ButtonIncreaseCounter_Click(object sender, EventArgs e)
		{
			_backendSoftwareComponent.IncreaseInternalCounter();
		}

		private void EventHandler_ButtonLogToFile_Click(object sender, EventArgs e)
		{
			if (_activityLoggerToFile == null)
			{
				_activityLoggerToFile = new ActivityLoggerToFile();
			}

			_backendSoftwareComponent.SetActivityLogger(_activityLoggerToFile);
		}

		private void EventHandler_ButtonLogToScreen_Click(object sender, EventArgs e)
		{
			_backendSoftwareComponent.SetActivityLogger(this);
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
