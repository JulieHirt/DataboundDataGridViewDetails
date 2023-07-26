using System.Collections.Generic;
using System.ComponentModel;
using Wisej.Web;

namespace DataboundDGV
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		BindingList<Person> peopleList = new BindingList<Person>();

		List<Company> companyList = new List<Company>();
		private void Page1_Load(object sender, System.EventArgs e)
		{
			peopleList.Add(new Person() { Name = "John", Company = "ITG", ID = 1 });
			peopleList.Add(new Person() { Name = "Julie", Company = "ITG", ID = 2 });
			peopleList.Add(new Person() { Name = "Tom", Company = "Google", ID = 3 });

			this.personBindingSource.DataSource = peopleList;
			peopleList.Add(new Person() { Name = "Susan", Company = "Google", ID = 4 });


			//button column in each DGV row

			//all buttons have the same OnClick event 

			//OnClick event says that it adds a details control (Custom Usercontrol with 3 textboxes)

			//details control loads data from the companyList, based on the company that person belongs to

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//assumes that the buttons are in column 3, and there is an empty column in column 4
			if(e.ColumnIndex == 3 && e.RowIndex >= 0) 
			{
				//a button in the ButtonColumn was clicked.
				AlertBox.Show("clicked");
				DetailsControl d = new DetailsControl();
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex +1].Control = d;
			}
		}
	}
}
