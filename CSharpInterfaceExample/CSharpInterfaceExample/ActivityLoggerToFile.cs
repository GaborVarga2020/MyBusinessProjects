using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceExample
{
	interface IActivityLogger
	{
		void LogActivity(string a_strLogMessage);
	}

	class ActivityLoggerToFile : IActivityLogger
	{
		#region Fields

		private System.IO.StreamWriter _logFileStreamWriter;
		private const string _strLogFileName = "CSharpInterfaceExample log file.txt";

		#endregion

		#region Methods

		public void LogActivity(string a_strLogMessage)
		{
			if (_logFileStreamWriter == null)
			{
				string strMyDocumentsPathName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

				string strLogFilePathName = strMyDocumentsPathName + "\\" + _strLogFileName;
				_logFileStreamWriter = System.IO.File.CreateText(strLogFilePathName);
			}

			_logFileStreamWriter.WriteLine(a_strLogMessage);
			_logFileStreamWriter.Flush();
		}

		#endregion
	}
}
