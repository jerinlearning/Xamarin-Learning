using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SqliteDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEmployee : ContentPage
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public void OnSaveClicked(object sender, EventArgs args)
        {
            var vEmployee = new Employee()
            {
                EmpName = txtEmpName.Text,
                Department = txtDepartment.Text,
                Designation = txtDesign.Text,
                Qualification = txtQualification.Text
            };
            App.DAUtil.SaveEmployee(vEmployee);
            Navigation.PushAsync(new ManageEmployee());
        }
    }
}