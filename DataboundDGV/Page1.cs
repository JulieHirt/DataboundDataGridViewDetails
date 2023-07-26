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

		}
	}
}
