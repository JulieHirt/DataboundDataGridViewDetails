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
			this.label1 = new Wisej.Web.Label();
			this.label2 = new Wisej.Web.Label();
			this.pictureBox1 = new Wisej.Web.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 18);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 18);
			this.label2.TabIndex = 1;
			this.label2.Text = "label2";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(15, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(59, 51);
			// 
			// DetailsControl
			// 
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "DetailsControl";
			this.Size = new System.Drawing.Size(246, 64);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label label1;
		private Wisej.Web.Label label2;
		private Wisej.Web.PictureBox pictureBox1;
	}
}
