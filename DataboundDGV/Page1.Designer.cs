namespace DataboundDGV
{
	partial class Page1
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
			this.components = new System.ComponentModel.Container();
			this.dataGridView1 = new Wisej.Web.DataGridView();
			this.personBindingSource = new Wisej.Web.BindingSource(this.components);
			this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colID = new Wisej.Web.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colName,
            this.colCompany,
            this.colID});
			this.dataGridView1.DataSource = this.personBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(318, 95);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(569, 370);
			this.dataGridView1.TabIndex = 0;
			// 
			// personBindingSource
			// 
			this.personBindingSource.DataSource = typeof(DataboundDGV.Person);
			// 
			// colName
			// 
			this.colName.DataPropertyName = "Name";
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			// 
			// colCompany
			// 
			this.colCompany.DataPropertyName = "Company";
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			// 
			// colID
			// 
			this.colID.DataPropertyName = "ID";
			this.colID.HeaderText = "ID";
			this.colID.Name = "colID";
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.dataGridView1);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1524, 478);
			this.Load += new System.EventHandler(this.Page1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.DataGridView dataGridView1;
		private Wisej.Web.DataGridViewTextBoxColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colID;
		private Wisej.Web.BindingSource personBindingSource;
	}
}

