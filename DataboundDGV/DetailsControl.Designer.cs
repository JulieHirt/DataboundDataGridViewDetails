namespace DataboundDGV
{
	partial class DetailsControl
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelCompanyName = new Wisej.Web.Label();
			this.labelWebsite = new Wisej.Web.Label();
			this.pictureBoxLogo = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.labelCompanyName.AutoSize = true;
			this.labelCompanyName.Location = new System.Drawing.Point(80, 13);
			this.labelCompanyName.Name = "label1";
			this.labelCompanyName.Size = new System.Drawing.Size(39, 18);
			this.labelCompanyName.TabIndex = 0;
			this.labelCompanyName.Text = "label1";
			// 
			// label2
			// 
			this.labelWebsite.AutoSize = true;
			this.labelWebsite.Location = new System.Drawing.Point(80, 36);
			this.labelWebsite.Name = "label2";
			this.labelWebsite.Size = new System.Drawing.Size(39, 18);
			this.labelWebsite.TabIndex = 1;
			this.labelWebsite.Text = "label2";
			// 
			// pictureBox1
			// 
			this.pictureBoxLogo.Location = new System.Drawing.Point(15, 3);
			this.pictureBoxLogo.Name = "pictureBox1";
			this.pictureBoxLogo.Size = new System.Drawing.Size(59, 51);
			// 
			// DetailsControl
			// 
			this.Controls.Add(this.pictureBoxLogo);
			this.Controls.Add(this.labelWebsite);
			this.Controls.Add(this.labelCompanyName);
			this.Name = "DetailsControl";
			this.Size = new System.Drawing.Size(246, 64);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public Wisej.Web.Label labelCompanyName;
		public Wisej.Web.Label labelWebsite;
		public Wisej.Web.PictureBox pictureBoxLogo;
	}
}
