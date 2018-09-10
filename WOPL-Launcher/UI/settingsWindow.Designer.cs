namespace WOPL_Launcher.UI {
	partial class settingsWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.RozdzielczoscGryLabel = new System.Windows.Forms.Label();
			this.RozdzielczoscGry = new System.Windows.Forms.ComboBox();
			this.JezykGry = new System.Windows.Forms.ComboBox();
			this.JezykGryLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// RozdzielczoscGryLabel
			// 
			this.RozdzielczoscGryLabel.AutoSize = true;
			this.RozdzielczoscGryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RozdzielczoscGryLabel.ForeColor = System.Drawing.Color.White;
			this.RozdzielczoscGryLabel.Location = new System.Drawing.Point(12, 160);
			this.RozdzielczoscGryLabel.Name = "RozdzielczoscGryLabel";
			this.RozdzielczoscGryLabel.Size = new System.Drawing.Size(134, 17);
			this.RozdzielczoscGryLabel.TabIndex = 0;
			this.RozdzielczoscGryLabel.Text = "ROZDZIELCZOSC GRY:";
			this.RozdzielczoscGryLabel.UseCompatibleTextRendering = true;
			// 
			// RozdzielczoscGry
			// 
			this.RozdzielczoscGry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RozdzielczoscGry.FormattingEnabled = true;
			this.RozdzielczoscGry.Location = new System.Drawing.Point(12, 180);
			this.RozdzielczoscGry.Name = "RozdzielczoscGry";
			this.RozdzielczoscGry.Size = new System.Drawing.Size(174, 21);
			this.RozdzielczoscGry.TabIndex = 1;
			// 
			// JezykGry
			// 
			this.JezykGry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.JezykGry.FormattingEnabled = true;
			this.JezykGry.Location = new System.Drawing.Point(12, 120);
			this.JezykGry.Name = "JezykGry";
			this.JezykGry.Size = new System.Drawing.Size(174, 21);
			this.JezykGry.TabIndex = 3;
			// 
			// JezykGryLabel
			// 
			this.JezykGryLabel.AutoSize = true;
			this.JezykGryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.JezykGryLabel.ForeColor = System.Drawing.Color.White;
			this.JezykGryLabel.Location = new System.Drawing.Point(12, 100);
			this.JezykGryLabel.Name = "JezykGryLabel";
			this.JezykGryLabel.Size = new System.Drawing.Size(72, 17);
			this.JezykGryLabel.TabIndex = 2;
			this.JezykGryLabel.Text = "JEZYK GRY:";
			this.JezykGryLabel.UseCompatibleTextRendering = true;
			// 
			// settingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(20)))));
			this.ClientSize = new System.Drawing.Size(976, 481);
			this.Controls.Add(this.JezykGry);
			this.Controls.Add(this.JezykGryLabel);
			this.Controls.Add(this.RozdzielczoscGry);
			this.Controls.Add(this.RozdzielczoscGryLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "settingsWindow";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "settingsWindow";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.settingsWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label RozdzielczoscGryLabel;
		private System.Windows.Forms.ComboBox RozdzielczoscGry;
		private System.Windows.Forms.ComboBox JezykGry;
		private System.Windows.Forms.Label JezykGryLabel;
	}
}