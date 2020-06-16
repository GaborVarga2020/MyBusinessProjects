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
	public partial class ClassMainForm : Form
	{
		#region Fields

		private bool m_bDisposed;
		private System.Collections.Generic.List<ClassChildForm> m_listChildForm;

		#endregion

		#region Constructors

		public ClassMainForm()
		{
			InitializeComponent();

			m_listChildForm = new List<ClassChildForm>();
		}

		#endregion

		#region Methods

		private void ChildFormAdd(ClassChildForm a_childForm)
		{
#if DEBUG
			System.Diagnostics.Debug.Assert(a_childForm != null);
			System.Diagnostics.Debug.Assert(m_listChildForm.Contains(a_childForm) == false);
#endif

			m_listChildForm.Add(a_childForm);

			a_childForm.Text = string.Format(
				"Child form {0}",
				m_listChildForm.Count
			);

			// Register event handlers.
			a_childForm.EventDisposing += EventHandler_ChildForm_Disposing;
		}

		private void ChildFormRemove(ClassChildForm a_childForm)
		{
			System.Diagnostics.Debug.Assert(a_childForm != null);
			System.Diagnostics.Debug.Assert(m_listChildForm.Contains(a_childForm));

			m_listChildForm.Remove(a_childForm);

			// Unregister event handlers.
			a_childForm.EventDisposing -= EventHandler_ChildForm_Disposing;
		}

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

				while (m_listChildForm.Count > 0)
				{
					ClassChildForm childForm = m_listChildForm[m_listChildForm.Count - 1];
					ChildFormRemove(childForm);
					childForm.Dispose();
				}

				m_listChildForm = null;

				// Check each own-implemented event handlers if all objects have unregistered their event handlers.
				System.Diagnostics.Debug.Assert(EventBackColorChanged == null);
			}

			m_bDisposed = true;

			base.Dispose(a_bDisposing);
		}

		private void EventHandler_ButtonBackColorChangeWithChildMethodCall_Click(object sender, EventArgs e)
		{
			using (ColorDialog colorDialog = new ColorDialog())
			{
				if (colorDialog.ShowDialog() == DialogResult.OK)
				{
					for (int nChildFormIndex = 0; nChildFormIndex < m_listChildForm.Count; nChildFormIndex++)
					{
						ClassChildForm childFormIndexed = m_listChildForm[nChildFormIndex];
						childFormIndexed.SetBackColor(colorDialog.Color);
					}
				}
			}
		}

		private void EventHandler_ButtonBackColorChangeWithMainFormEvent_Click(object sender, EventArgs e)
		{
			if (EventBackColorChanged != null)
			{
				using (ColorDialog colorDialog = new ColorDialog())
				{
					if (colorDialog.ShowDialog() == DialogResult.OK)
					{
						EventBackColorChanged(colorDialog.Color);
					}
				}
			}
		}

		private void EventHandler_ButtonCreateChildForm_Click(object sender, EventArgs e)
		{
			ClassChildForm childForm = new ClassChildForm(this);
			ChildFormAdd(childForm);
			childForm.Show();
		}

		private void EventHandler_ChildForm_Disposing(ClassChildForm a_sender)
		{
			System.Diagnostics.Debug.Assert(a_sender != null);
			System.Diagnostics.Debug.Assert(m_listChildForm.Contains(a_sender));

			ChildFormRemove(a_sender);
		}

		#endregion

		#region Events

		public delegate void DelegateBackColorChanged(System.Drawing.Color a_backColor);
		public event DelegateBackColorChanged EventBackColorChanged;

		#endregion
		}
}
