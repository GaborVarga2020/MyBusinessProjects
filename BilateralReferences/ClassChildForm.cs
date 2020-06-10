﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilateralReferences
{
    public partial class ClassChildForm : Form
    {
		#region Fields

		private bool m_bDisposed;

		#endregion

		#region Constructors

		public ClassChildForm()
        {
            InitializeComponent();
        }

		#endregion

		#region Methods

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="a_bDisposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool a_bDisposing)
		{
			if (m_bDisposed)
			{
				return;
			}

			if (a_bDisposing)
			{
				if (components != null)
				{
					components.Dispose();
				}
			}

			m_bDisposed = true;

			base.Dispose(a_bDisposing);
		}

		public void SetBackColor(System.Drawing.Color a_backColor)
		{
			System.Diagnostics.Debug.Assert(m_bDisposed == false);

			this.BackColor = a_backColor;
		}

		#endregion
	}
}