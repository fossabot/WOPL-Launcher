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
			this.RegisterButtonLabel = new System.Windows.Forms.Label();
			this.InfoBox = new System.Windows.Forms.Label();
			this.LoginButtonLabel = new System.Windows.Forms.Label();
			this.border = new System.Windows.Forms.Panel();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			this.serverStatusText = new System.Windows.Forms.Label();
			this.serverStatusDescription = new System.Windows.Forms.Label();
			this.RememberMeLabel = new System.Windows.Forms.CheckBox();
			this.settingsButton = new System.Windows.Forms.PictureBox();
			this.closeButton = new System.Windows.Forms.PictureBox();
			this.serverStatusImage = new System.Windows.Forms.PictureBox();
			this.LoginButtonBorder = new System.Windows.Forms.PictureBox();
			this.RegisterButtonBorder = new System.Windows.Forms.PictureBox();
			this.logo = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.DownloaderProgressBar = new ProgressBarEx.ProgressBarEx();
			this.PasswordBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.PasswordBoxTextBox = new System.Windows.Forms.MaskedTextBox();
			this.LoginBoxBorder = new WOPL_Launcher.Controls.MyPanel();
			this.LoginBoxTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.settingsButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.serverStatusImage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.LoginButtonBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterButtonBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
			this.PasswordBoxBorder.SuspendLayout();
			this.LoginBoxBorder.SuspendLayout();
			this.SuspendLayout();
			// 
			// RegisterButtonLabel
			// 
			this.RegisterButtonLabel.BackColor = System.Drawing.Color.Transparent;
			this.RegisterButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.RegisterButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(41)))));
			this.RegisterButtonLabel.Location = new System.Drawing.Point(704, 303);
			this.RegisterButtonLabel.Name = "RegisterButtonLabel";
			this.RegisterButtonLabel.Size = new System.Drawing.Size(253, 34);
			this.RegisterButtonLabel.TabIndex = 5;
			this.RegisterButtonLabel.Text = "REJESTRACJA";
			this.RegisterButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.RegisterButtonLabel.UseCompatibleTextRendering = true;
			// 
			// InfoBox
			// 
			this.InfoBox.AutoEllipsis = true;
			this.InfoBox.BackColor = System.Drawing.Color.Transparent;
			this.InfoBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.InfoBox.Location = new System.Drawing.Point(704, 413);
			this.InfoBox.Name = "InfoBox";
			this.InfoBox.Size = new System.Drawing.Size(253, 43);
			this.InfoBox.TabIndex = 6;
			this.InfoBox.Text = "WCZYTYWANIE...";
			this.InfoBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.InfoBox.UseCompatibleTextRendering = true;
			// 
			// LoginButtonLabel
			// 
			this.LoginButtonLabel.BackColor = System.Drawing.Color.Transparent;
			this.LoginButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.LoginButtonLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(222)))), ((int)(((byte)(41)))));
			this.LoginButtonLabel.Location = new System.Drawing.Point(704, 264);
			this.LoginButtonLabel.Name = "LoginButtonLabel";
			this.LoginButtonLabel.Size = new System.Drawing.Size(253, 34);
			this.LoginButtonLabel.TabIndex = 9;
			this.LoginButtonLabel.Text = "ZALOGUJ";
			this.LoginButtonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.LoginButtonLabel.UseCompatibleTextRendering = true;
			// 
			// border
			// 
			this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.border.Location = new System.Drawing.Point(687, 12);
			this.border.Name = "border";
			this.border.Size = new System.Drawing.Size(1, 453);
			this.border.TabIndex = 11;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Location = new System.Drawing.Point(12, 12);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(669, 453);
			this.webBrowser1.TabIndex = 13;
			this.webBrowser1.Url = new System.Uri("https://nfswonline.pl/aktualnosci2.php", System.UriKind.Absolute);
			// 
			// serverStatusText
			// 
			this.serverStatusText.AutoSize = true;
			this.serverStatusText.ForeColor = System.Drawing.Color.White;
			this.serverStatusText.Location = new System.Drawing.Point(726, 354);
			this.serverStatusText.Name = "serverStatusText";
			this.serverStatusText.Size = new System.Drawing.Size(152, 13);
			this.serverStatusText.TabIndex = 16;
			this.serverStatusText.Text = "Stan Serwera - Wczytywanie...";
			// 
			// serverStatusDescription
			// 
			this.serverStatusDescription.AutoSize = true;
			this.serverStatusDescription.ForeColor = System.Drawing.Color.White;
			this.serverStatusDescription.Location = new System.Drawing.Point(726, 372);
			this.serverStatusDescription.Name = "serverStatusDescription";
			this.serverStatusDescription.Size = new System.Drawing.Size(115, 13);
			this.serverStatusDescription.TabIndex = 17;
			this.serverStatusDescription.Text = "Graczy na serwerze: ---";
			// 
			// RememberMeLabel
			// 
			this.RememberMeLabel.AutoSize = true;
			this.RememberMeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.RememberMeLabel.ForeColor = System.Drawing.Color.White;
			this.RememberMeLabel.Location = new System.Drawing.Point(704, 234);
			this.RememberMeLabel.Name = "RememberMeLabel";
			this.RememberMeLabel.Size = new System.Drawing.Size(274, 19);
			this.RememberMeLabel.TabIndex = 19;
			this.RememberMeLabel.Text = "ZAPAMIETAJ MOJE DANE LOGOWANIA";
			this.RememberMeLabel.UseVisualStyleBackColor = true;
			// 
			// settingsButton
			// 
			this.settingsButton.Image = global::WOPL_Launcher.Properties.Resources.settings;
			this.settingsButton.Location = new System.Drawing.Point(904, 12);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(24, 24);
			this.settingsButton.TabIndex = 23;
			this.settingsButton.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.Image = global::WOPL_Launcher.Properties.Resources.close;
			this.closeButton.Location = new System.Drawing.Point(934, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(24, 24);
			this.closeButton.TabIndex = 21;
			this.closeButton.TabStop = false;
			// 
			// serverStatusImage
			// 
			this.serverStatusImage.Image = global::WOPL_Launcher.Properties.Resources.status_unknown;
			this.serverStatusImage.Location = new System.Drawing.Point(704, 356);
			this.serverStatusImage.Name = "serverStatusImage";
			this.serverStatusImage.Size = new System.Drawing.Size(16, 16);
			this.serverStatusImage.TabIndex = 15;
			this.serverStatusImage.TabStop = false;
			// 
			// LoginButtonBorder
			// 
			this.LoginButtonBorder.BackColor = System.Drawing.Color.Transparent;
			this.LoginButtonBorder.BackgroundImage = global::WOPL_Launcher.Properties.Resources.button_register_border;
			this.LoginButtonBorder.Location = new System.Drawing.Point(704, 264);
			this.LoginButtonBorder.Name = "LoginButtonBorder";
			this.LoginButtonBorder.Size = new System.Drawing.Size(253, 34);
			this.LoginButtonBorder.TabIndex = 8;
			this.LoginButtonBorder.TabStop = false;
			// 
			// RegisterButtonBorder
			// 
			this.RegisterButtonBorder.BackColor = System.Drawing.Color.Transparent;
			this.RegisterButtonBorder.BackgroundImage = global::WOPL_Launcher.Properties.Resources.button_register_border;
			this.RegisterButtonBorder.Location = new System.Drawing.Point(704, 303);
			this.RegisterButtonBorder.Name = "RegisterButtonBorder";
			this.RegisterButtonBorder.Size = new System.Drawing.Size(253, 34);
			this.RegisterButtonBorder.TabIndex = 4;
			this.RegisterButtonBorder.TabStop = false;
			// 
			// logo
			// 
			this.logo.BackColor = System.Drawing.Color.Transparent;
			this.logo.BackgroundImage = global::WOPL_Launcher.Properties.Resources.logo;
			this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.logo.Location = new System.Drawing.Point(704, 22);
			this.logo.Name = "logo";
			this.logo.Size = new System.Drawing.Size(253, 112);
			this.logo.TabIndex = 2;
			this.logo.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(916, 390);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(10, 10);
			this.button1.TabIndex = 25;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.DownloaderProgressBar.Location = new System.Drawing.Point(704, 459);
			this.DownloaderProgressBar.Name = "DownloaderProgressBar";
			this.DownloaderProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(179)))), ((int)(((byte)(189)))));
			this.DownloaderProgressBar.Size = new System.Drawing.Size(253, 6);
			this.DownloaderProgressBar.Text = "progressBarEx1";
			// 
			// PasswordBoxBorder
			// 
			this.PasswordBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.PasswordBoxBorder.Controls.Add(this.PasswordBoxTextBox);
			this.PasswordBoxBorder.Location = new System.Drawing.Point(704, 189);
			this.PasswordBoxBorder.Name = "PasswordBoxBorder";
			this.PasswordBoxBorder.Size = new System.Drawing.Size(253, 37);
			this.PasswordBoxBorder.TabIndex = 1;
			// 
			// PasswordBoxTextBox
			// 
			this.PasswordBoxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
			this.LoginBoxBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.LoginBoxBorder.Controls.Add(this.LoginBoxTextBox);
			this.LoginBoxBorder.Location = new System.Drawing.Point(704, 150);
			this.LoginBoxBorder.Name = "LoginBoxBorder";
			this.LoginBoxBorder.Size = new System.Drawing.Size(253, 37);
			this.LoginBoxBorder.TabIndex = 0;
			// 
			// LoginBoxTextBox
			// 
			this.LoginBoxTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
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
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(20)))));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(976, 481);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.settingsButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.RememberMeLabel);
			this.Controls.Add(this.serverStatusDescription);
			this.Controls.Add(this.serverStatusText);
			this.Controls.Add(this.serverStatusImage);
			this.Controls.Add(this.webBrowser1);
			this.Controls.Add(this.border);
			this.Controls.Add(this.LoginButtonLabel);
			this.Controls.Add(this.LoginButtonBorder);
			this.Controls.Add(this.InfoBox);
			this.Controls.Add(this.DownloaderProgressBar);
			this.Controls.Add(this.RegisterButtonLabel);
			this.Controls.Add(this.RegisterButtonBorder);
			this.Controls.Add(this.logo);
			this.Controls.Add(this.PasswordBoxBorder);
			this.Controls.Add(this.LoginBoxBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "WorldOnlinePL";
			((System.ComponentModel.ISupportInitialize)(this.settingsButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.serverStatusImage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.LoginButtonBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RegisterButtonBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
			this.PasswordBoxBorder.ResumeLayout(false);
			this.PasswordBoxBorder.PerformLayout();
			this.LoginBoxBorder.ResumeLayout(false);
			this.LoginBoxBorder.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Controls.MyPanel LoginBoxBorder;
		public Controls.MyPanel PasswordBoxBorder;
		public System.Windows.Forms.TextBox LoginBoxTextBox;
		public System.Windows.Forms.MaskedTextBox PasswordBoxTextBox;
		public System.Windows.Forms.PictureBox logo;
		public System.Windows.Forms.PictureBox RegisterButtonBorder;
		public System.Windows.Forms.Label RegisterButtonLabel;
		public ProgressBarEx.ProgressBarEx DownloaderProgressBar;
		public System.Windows.Forms.Label InfoBox;
		public System.Windows.Forms.Label LoginButtonLabel;
		public System.Windows.Forms.PictureBox LoginButtonBorder;
		public System.Windows.Forms.Panel border;
		public System.Windows.Forms.WebBrowser webBrowser1;
		public System.Windows.Forms.PictureBox serverStatusImage;
		public System.Windows.Forms.Label serverStatusText;
		public System.Windows.Forms.Label serverStatusDescription;
		public System.Windows.Forms.CheckBox RememberMeLabel;
		public System.Windows.Forms.PictureBox closeButton;
		public System.Windows.Forms.PictureBox settingsButton;
		public System.Windows.Forms.Button button1;
	}
}