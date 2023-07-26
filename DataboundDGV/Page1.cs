using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;

namespace DataboundDGV
{
	public partial class Page1 : Page
	{

		//button column in each DGV row -created in the designer

		//all buttons have the same OnClick event (dataGridView1_CellClick)

		//OnClick event says that it adds a DetailsControl (Custom Usercontrol with 2 textboxes 1 picturebox)

		//DetailsControl loads data from the companyList, based on the company that person belongs to

		public Page1()
		{
			InitializeComponent();
		}

		BindingList<Person> peopleList = new BindingList<Person>();

		List<Company> companyList = new List<Company>();
		private void Page1_Load(object sender, System.EventArgs e)
		{
			//set up peopleList
			peopleList.Add(new Person() { Name = "John", Company = "ITG", ID = 1 });
			peopleList.Add(new Person() { Name = "Julie", Company = "ITG", ID = 2 });
			peopleList.Add(new Person() { Name = "Tom", Company = "Google", ID = 3 });

			this.personBindingSource.DataSource = peopleList;
			peopleList.Add(new Person() { Name = "Susan", Company = "Google", ID = 4 });

			//set up companyList
			companyList.Add(new Company() { CompanyName = "Google", Website = "google.com", Logo = "./Images/googleLogo.png" });
			companyList.Add(new Company() { CompanyName = "Ice Tea Group", Website = "iceteagroup.com", Logo = "./Images/ITGlogo.png" });

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			//assumes that the buttons are in column 3, and there is an empty column in column 4
			if(e.ColumnIndex == 3 && e.RowIndex >= 0) 
			{
				//a button in the ButtonColumn was clicked.
				AlertBox.Show("clicked");
				DetailsControl d = new DetailsControl();
				d.labelCompanyName.Text = "CompanyName";
				d.labelWebsite.Text = "website";
				d.pictureBoxLogo.Image = Image.FromFile("./Images/ITGlogo.png");
				dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex +1].Control = d;
			}
		}
	}
}
