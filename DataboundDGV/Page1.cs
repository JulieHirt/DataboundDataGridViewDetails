using System.Collections.Generic;
using Wisej.Web;

namespace DataboundDGV
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		List<Person> peopleList = new List<Person>();

		List<Company> companyList = new List<Company>();
		private void Page1_Load(object sender, System.EventArgs e)
		{
			dataGridView1.DataSource = peopleList;
			peopleList.Add(new Person() { Name = "John", Company = "ITG", ID = 1 });
			peopleList.Add(new Person() { Name = "Julie", Company = "ITG", ID = 2 });
			peopleList.Add(new Person() { Name = "Tom", Company = "Google", ID = 3 });
			peopleList.Add(new Person() { Name = "Susan", Company = "Google", ID = 4 });
		}
	}
}
