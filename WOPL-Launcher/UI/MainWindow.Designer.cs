namespace WOPL_Launcher.UI {
	partial class MainWindow {
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
			this.LoginBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.LoginBoxTextBox = new System.Windows.Forms.TextBox();
			this.PasswordBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.RememberMeLabel = new System.Windows.Forms.Label();
			this.LoginBoxBorder.SuspendLayout();
			this.PasswordBoxBorder.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginBoxBorder
			// 
			this.LoginBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.LoginBoxBorder.Controls.Add(this.LoginBoxTextBox);
			this.LoginBoxBorder.Location = new System.Drawing.Point(23, 166);
			this.LoginBoxBorder.Name = "LoginBoxBorder";
			this.LoginBoxBorder.Size = new System.Drawing.Size(253, 37);
			this.LoginBoxBorder.TabIndex = 0;
			// 
			// LoginBoxTextBox
			// 
			this.LoginBoxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.LoginBoxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.LoginBoxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LoginBoxTextBox.ForeColor = System.Drawing.Color.White;
			this.LoginBoxTextBox.Location = new System.Drawing.Point(11, 12);
			this.LoginBoxTextBox.Name = "LoginBoxTextBox";
			this.LoginBoxTextBox.Size = new System.Drawing.Size(232, 13);
			this.LoginBoxTextBox.TabIndex = 0;
			// 
			// PasswordBoxBorder
			// 
			this.PasswordBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.PasswordBoxBorder.Controls.Add(this.maskedTextBox1);
			this.PasswordBoxBorder.Location = new System.Drawing.Point(23, 216);
			this.PasswordBoxBorder.Name = "PasswordBoxBorder";
			this.PasswordBoxBorder.Size = new System.Drawing.Size(253, 37);
			this.PasswordBoxBorder.TabIndex = 1;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
			this.maskedTextBox1.Location = new System.Drawing.Point(11, 12);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(232, 13);
			this.maskedTextBox1.TabIndex = 0;
			this.maskedTextBox1.UseSystemPasswordChar = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImage = global::WOPL_Launcher.Properties.Resources.logo;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(23, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(253, 112);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// RememberMeLabel
			// 
			this.RememberMeLabel.AutoSize = true;
			this.RememberMeLabel.BackColor = System.Drawing.Color.Transparent;
			this.RememberMeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
			this.RememberMeLabel.ForeColor = System.Drawing.Color.Transparent;
			this.RememberMeLabel.Location = new System.Drawing.Point(50, 267);
			this.RememberMeLabel.Name = "RememberMeLabel";
			this.RememberMeLabel.Size = new System.Drawing.Size(310, 15);
			this.RememberMeLabel.TabIndex = 3;
			this.RememberMeLabel.Text = "REMEMBER MY EMAIL ADDRESS & PASSWORD";
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WOPL_Launcher.Properties.Resources.background;
			this.ClientSize = new System.Drawing.Size(300, 539);
			this.Controls.Add(this.RememberMeLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PasswordBoxBorder);
			this.Controls.Add(this.LoginBoxBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WorldOnlinePL Launcher";
			this.LoginBoxBorder.ResumeLayout(false);
			this.LoginBoxBorder.PerformLayout();
			this.PasswordBoxBorder.ResumeLayout(false);
			this.PasswordBoxBorder.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.MyPanel LoginBoxBorder;
		private Controls.MyPanel PasswordBoxBorder;
		private System.Windows.Forms.TextBox LoginBoxTextBox;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label RememberMeLabel;
	}
}