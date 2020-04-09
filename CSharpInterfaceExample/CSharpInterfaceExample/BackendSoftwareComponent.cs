using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaceExample
{
	class BackendSoftwareComponent
	{
		#region Fields

		// A szoftver komponens tevékenységét naplózó szoftver komponensre hivatkozó referencia.
		private Form _activityLogger;

		private int _nInternalCounter;

		#endregion

		#region Methods

		public void IncreaseInternalCounter()
		{
			_nInternalCounter++;

			System.Diagnostics.Debug.Assert(_activityLogger != null);
			_activityLogger.LogActivity(
				string.Format(
					"Backend software component belső számláló növelve, aktuális érték: {0}",
					_nInternalCounter
				)
			);
		}

		// Metódus a tevékenységnaplót menedzselő szoftver komponens beállítására.
		public void SetActivityLogger(Form a_activityLogger)
		{
			_activityLogger = a_activityLogger;
		}

		#endregion
	}
}
