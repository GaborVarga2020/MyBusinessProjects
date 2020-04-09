namespace CSharpInterfaceExample
{
	partial class Form
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
			this._tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this._buttonIncreaseCounter = new System.Windows.Forms.Button();
			this._buttonLogToScreen = new System.Windows.Forms.Button();
			this._buttonLogToFile = new System.Windows.Forms.Button();
			this._label = new System.Windows.Forms.Label();
			this._textBox = new System.Windows.Forms.TextBox();
			this._tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// _tableLayoutPanel
			// 
			this._tableLayoutPanel.ColumnCount = 2;
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._tableLayoutPanel.Controls.Add(this._buttonIncreaseCounter, 1, 0);
			this._tableLayoutPanel.Controls.Add(this._buttonLogToScreen, 1, 1);
			this._tableLayoutPanel.Controls.Add(this._buttonLogToFile, 1, 2);
			this._tableLayoutPanel.Controls.Add(this._label, 0, 0);
			this._tableLayoutPanel.Controls.Add(this._textBox, 0, 1);
			this._tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this._tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this._tableLayoutPanel.Name = "_tableLayoutPanel";
			this._tableLayoutPanel.RowCount = 3;
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._tableLayoutPanel.Size = new System.Drawing.Size(800, 450);
			this._tableLayoutPanel.TabIndex = 0;
			// 
			// _buttonIncreaseCounter
			// 
			this._buttonIncreaseCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonIncreaseCounter.AutoSize = true;
			this._buttonIncreaseCounter.Location = new System.Drawing.Point(644, 3);
			this._buttonIncreaseCounter.Name = "_buttonIncreaseCounter";
			this._buttonIncreaseCounter.Size = new System.Drawing.Size(153, 27);
			this._buttonIncreaseCounter.TabIndex = 0;
			this._buttonIncreaseCounter.Text = "Számláló növelése";
			this._buttonIncreaseCounter.UseVisualStyleBackColor = true;
			this._buttonIncreaseCounter.Click += new System.EventHandler(this.EventHandler_ButtonIncreaseCounter_Click);
			// 
			// _buttonLogToScreen
			// 
			this._buttonLogToScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonLogToScreen.AutoSize = true;
			this._buttonLogToScreen.Location = new System.Drawing.Point(644, 36);
			this._buttonLogToScreen.Name = "_buttonLogToScreen";
			this._buttonLogToScreen.Size = new System.Drawing.Size(153, 27);
			this._buttonLogToScreen.TabIndex = 1;
			this._buttonLogToScreen.Text = "Naplózás képernyőre";
			this._buttonLogToScreen.UseVisualStyleBackColor = true;
			// 
			// _buttonLogToFile
			// 
			this._buttonLogToFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonLogToFile.AutoSize = true;
			this._buttonLogToFile.Location = new System.Drawing.Point(644, 69);
			this._buttonLogToFile.Name = "_buttonLogToFile";
			this._buttonLogToFile.Size = new System.Drawing.Size(153, 27);
			this._buttonLogToFile.TabIndex = 2;
			this._buttonLogToFile.Text = "Naplózás fájlba";
			this._buttonLogToFile.UseVisualStyleBackColor = true;
			this._buttonLogToFile.Click += new System.EventHandler(this.EventHandler_ButtonLogToFile_Click);
			// 
			// _label
			// 
			this._label.AutoSize = true;
			this._label.Dock = System.Windows.Forms.DockStyle.Fill;
			this._label.Location = new System.Drawing.Point(3, 0);
			this._label.Name = "_label";
			this._label.Size = new System.Drawing.Size(635, 33);
			this._label.TabIndex = 3;
			this._label.Text = "Tevékenységnapló:";
			this._label.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _textBox
			// 
			this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this._textBox.Location = new System.Drawing.Point(3, 36);
			this._textBox.Multiline = true;
			this._textBox.Name = "_textBox";
			this._tableLayoutPanel.SetRowSpan(this._textBox, 2);
			this._textBox.Size = new System.Drawing.Size(635, 411);
			this._textBox.TabIndex = 4;
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this._tableLayoutPanel);
			this.Name = "Form";
			this.Text = "C# interfész példa";
			this._tableLayoutPanel.ResumeLayout(false);
			this._tableLayoutPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel _tableLayoutPanel;
		private System.Windows.Forms.Button _buttonIncreaseCounter;
		private System.Windows.Forms.Button _buttonLogToScreen;
		private System.Windows.Forms.Button _buttonLogToFile;
		private System.Windows.Forms.Label _label;
		private System.Windows.Forms.TextBox _textBox;
	}
}

