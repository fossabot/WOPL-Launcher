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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.RememberMeLabel = new System.Windows.Forms.Label();
			this.RegisterBoxBorder = new System.Windows.Forms.PictureBox();
			this.RegisterBoxLabel = new System.Windows.Forms.Label();
			this.InfoBox = new System.Windows.Forms.Label();
			this.DownloaderProgressBar = new ProgressBarEx.ProgressBarEx();
			this.PasswordBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.PasswordBoxTextBox = new System.Windows.Forms.MaskedTextBox();
			this.LoginBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.LoginBoxTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterBoxBorder)).BeginInit();
			this.PasswordBoxBorder.SuspendLayout();
			this.LoginBoxBorder.SuspendLayout();
			this.SuspendLayout();
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
			this.RememberMeLabel.Size = new System.Drawing.Size(179, 15);
			this.RememberMeLabel.TabIndex = 3;
			this.RememberMeLabel.Text = "ZAPAMIETAJ MOJE HASŁO";
			// 
			// RegisterBoxBorder
			// 
			this.RegisterBoxBorder.BackColor = System.Drawing.Color.Transparent;
			this.RegisterBoxBorder.BackgroundImage = global::WOPL_Launcher.Properties.Resources.button_register_border;
			this.RegisterBoxBorder.Location = new System.Drawing.Point(23, 428);
			this.RegisterBoxBorder.Name = "RegisterBoxBorder";
			this.RegisterBoxBorder.Size = new System.Drawing.Size(253, 34);
			this.RegisterBoxBorder.TabIndex = 4;
			this.RegisterBoxBorder.TabStop = false;
			// 
			// RegisterBoxLabel
			// 
			this.RegisterBoxLabel.BackColor = System.Drawing.Color.Transparent;
			this.RegisterBoxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegisterBoxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(41)))));
			this.RegisterBoxLabel.Location = new System.Drawing.Point(23, 428);
			this.RegisterBoxLabel.Name = "RegisterBoxLabel";
			this.RegisterBoxLabel.Size = new System.Drawing.Size(253, 34);
			this.RegisterBoxLabel.TabIndex = 5;
			this.RegisterBoxLabel.Text = "KLIKNIJ TUTAJ ABY ZAŁOŻYĆ KONTO";
			this.RegisterBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InfoBox
			// 
			this.InfoBox.BackColor = System.Drawing.Color.Transparent;
			this.InfoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.InfoBox.Location = new System.Drawing.Point(23, 282);
			this.InfoBox.Name = "InfoBox";
			this.InfoBox.Size = new System.Drawing.Size(253, 33);
			this.InfoBox.TabIndex = 6;
			this.InfoBox.Text = "WCZYTYWANIE...";
			this.InfoBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// DownloaderProgressBar
			// 
			this.DownloaderProgressBar.BackColor = System.Drawing.Color.Transparent;
			this.DownloaderProgressBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.DownloaderProgressBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.DownloaderProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.DownloaderProgressBar.GradiantColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.DownloaderProgressBar.GradiantPosition = ProgressBarEx.ProgressBarEx.GradiantArea.None;
			this.DownloaderProgressBar.Image = null;
			this.DownloaderProgressBar.Location = new System.Drawing.Point(24, 318);
			this.DownloaderProgressBar.Name = "DownloaderProgressBar";
			this.DownloaderProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.DownloaderProgressBar.Size = new System.Drawing.Size(253, 12);
			this.DownloaderProgressBar.Text = "progressBarEx1";
			// 
			// PasswordBoxBorder
			// 
			this.PasswordBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.PasswordBoxBorder.Controls.Add(this.PasswordBoxTextBox);
			this.PasswordBoxBorder.Location = new System.Drawing.Point(23, 216);
			this.PasswordBoxBorder.Name = "PasswordBoxBorder";
			this.PasswordBoxBorder.Size = new System.Drawing.Size(253, 37);
			this.PasswordBoxBorder.TabIndex = 1;
			// 
			// PasswordBoxTextBox
			// 
			this.PasswordBoxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(28)))), ((int)(((byte)(36)))));
			this.PasswordBoxTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.PasswordBoxTextBox.ForeColor = System.Drawing.Color.White;
			this.PasswordBoxTextBox.Location = new System.Drawing.Point(11, 12);
			this.PasswordBoxTextBox.Name = "PasswordBoxTextBox";
			this.PasswordBoxTextBox.Size = new System.Drawing.Size(232, 13);
			this.PasswordBoxTextBox.TabIndex = 0;
			this.PasswordBoxTextBox.UseSystemPasswordChar = true;
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
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WOPL_Launcher.Properties.Resources.background;
			this.ClientSize = new System.Drawing.Size(300, 539);
			this.Controls.Add(this.InfoBox);
			this.Controls.Add(this.DownloaderProgressBar);
			this.Controls.Add(this.RegisterBoxLabel);
			this.Controls.Add(this.RegisterBoxBorder);
			this.Controls.Add(this.RememberMeLabel);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.PasswordBoxBorder);
			this.Controls.Add(this.LoginBoxBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WorldOnlinePL";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterBoxBorder)).EndInit();
			this.PasswordBoxBorder.ResumeLayout(false);
			this.PasswordBoxBorder.PerformLayout();
			this.LoginBoxBorder.ResumeLayout(false);
			this.LoginBoxBorder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.MyPanel LoginBoxBorder;
		private Controls.MyPanel PasswordBoxBorder;
		private System.Windows.Forms.TextBox LoginBoxTextBox;
		private System.Windows.Forms.MaskedTextBox PasswordBoxTextBox;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label RememberMeLabel;
		private System.Windows.Forms.PictureBox RegisterBoxBorder;
		private System.Windows.Forms.Label RegisterBoxLabel;
		private ProgressBarEx.ProgressBarEx DownloaderProgressBar;
		private System.Windows.Forms.Label InfoBox;
	}
}