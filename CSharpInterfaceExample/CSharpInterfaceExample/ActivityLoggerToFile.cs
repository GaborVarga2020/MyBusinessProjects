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

	class ActivityLoggerToFile :
		IActivityLogger,
		IDisposable
	{
		#region Fields

		private bool _bDisposed;
		private System.IO.StreamWriter _logFileStreamWriter;
		private const string _strLogFileName = "CSharpInterfaceExample log file.txt";

		#endregion

		#region Methods

		// Use C# destructor syntax for finalization code.
		// This destructor will run only if the Dispose method
		// does not get called.
		// It gives your base class the opportunity to finalize.
		// Do not provide destructors in types derived from this class.
		~ActivityLoggerToFile()
		{
			// Do not re-create Dispose clean-up code here.
			// Calling Dispose(false) is optimal in terms of
			// readability and maintainability.
			Dispose(false);
		}

		// Implement IDisposable.
		// Do not make this method virtual.
		// A derived class should not be able to override this method.
		public void Dispose()
		{
			Dispose(true);

			// This object will be cleaned up by the Dispose method.
			// Therefore, you should call GC.SupressFinalize to
			// take this object off the finalization queue
			// and prevent finalization code for this object
			// from executing a second time.
			GC.SuppressFinalize(this);
		}

		// Dispose(bool) executes in two distinct scenarios.
		// If disposing equals true, the method has been called directly
		// or indirectly by a user's code. Managed and unmanaged resources
		// can be disposed.
		// If disposing equals false, the method has been called by the
		// runtime from inside the finalizer and you should not reference
		// other objects. Only unmanaged resources can be disposed.
		protected virtual void Dispose(bool a_bDisposing)
		{
			// Check to see if Dispose has already been called.
			if (_bDisposed == false)
			{
				// If disposing equals true, dispose all managed
				// and unmanaged resources.
				if (a_bDisposing)
				{
					// Dispose managed resources.

					if (_logFileStreamWriter != null)
					{
						_logFileStreamWriter.Dispose();
						_logFileStreamWriter = null;
					}

					string strMyDocumentsPathName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
					string strLogFilePathName = strMyDocumentsPathName + "\\" + _strLogFileName;

					System.IO.File.Delete(strLogFilePathName);
				}

				// Call the appropriate methods to clean up unmanaged resources here.
				// If disposing is false, only the following code is executed.

				// Note disposing has been done.
				_bDisposed = true;
			}
		}

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
