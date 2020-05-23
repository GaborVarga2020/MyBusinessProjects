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

        private void EventHandler_ButtonCreateChildForm_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
