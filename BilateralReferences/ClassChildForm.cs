using System;
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

		// This field can be referenced only in its property!
		private ClassMainForm m_owner;

		#endregion

		#region Properties

		private ClassMainForm Owner
		{
			get
			{
				return m_owner;
			}

			set
			{
				if (m_owner != null)
				{
					// Unregister event handlers.
					m_owner.EventBackColorChanged -= EventHandler_Owner_BackColorChanged;
				}

				m_owner = value;

				if (m_owner != null)
				{
					// Register event handlers.
					m_owner.EventBackColorChanged += EventHandler_Owner_BackColorChanged;
				}
			}
		}

		#endregion

		#region Constructors

		public ClassChildForm(ClassMainForm a_owner)
		{
			InitializeComponent();

			Owner = a_owner;
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

			if (EventDisposing != null)
			{
				EventDisposing(this);
			}

			if (a_bDisposing)
			{
				if (components != null)
				{
					components.Dispose();
				}

				Owner = null;

				// Check each own-implemented event handlers if all objects have unregistered their event handlers.
				System.Diagnostics.Debug.Assert(EventDisposing == null);
			}

			m_bDisposed = true;

			base.Dispose(a_bDisposing);
		}

		private void EventHandler_Owner_BackColorChanged(System.Drawing.Color a_backColor)
		{
			System.Diagnostics.Debug.Assert(m_bDisposed == false);
			this.BackColor = a_backColor;
		}

		public void SetBackColor(System.Drawing.Color a_backColor)
		{
			System.Diagnostics.Debug.Assert(m_bDisposed == false);

			this.BackColor = a_backColor;
		}

		#endregion

		#region Events

		public delegate void DelegateDisposing(ClassChildForm a_sender);
		public event DelegateDisposing EventDisposing;

		#endregion
	}
}
