namespace BilateralReferences
{
    partial class ClassMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_buttonCreateChildForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_buttonCreateChildForm
            // 
            this.m_buttonCreateChildForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_buttonCreateChildForm.Location = new System.Drawing.Point(12, 12);
            this.m_buttonCreateChildForm.Name = "m_buttonCreateChildForm";
            this.m_buttonCreateChildForm.Size = new System.Drawing.Size(622, 30);
            this.m_buttonCreateChildForm.TabIndex = 0;
            this.m_buttonCreateChildForm.Text = "Create child form";
            this.m_buttonCreateChildForm.UseVisualStyleBackColor = true;
            this.m_buttonCreateChildForm.Click += new System.EventHandler(this.EventHandler_ButtonCreateChildForm_Click);
            // 
            // ClassMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 56);
            this.Controls.Add(this.m_buttonCreateChildForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ClassMainForm";
            this.Text = "Bilateral references example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button m_buttonCreateChildForm;
    }
}

