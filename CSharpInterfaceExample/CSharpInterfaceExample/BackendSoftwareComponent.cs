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

		private int _nInternalCounter;

		#endregion

		#region Methods

		public void IncreaseInternalCounter()
		{
			_nInternalCounter++;
		}

		#endregion
	}
}
