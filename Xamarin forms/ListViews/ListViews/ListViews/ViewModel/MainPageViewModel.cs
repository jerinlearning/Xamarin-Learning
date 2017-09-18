using ListViews.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViews.ViewModel
{
    class MainPageViewModel
    {
        public ObservableCollection<Person> People { get; set; } =
            new ObservableCollection<Person>();
        public MainPageViewModel()
        {
            for (int i = 0; i< 5; i++)
            {
                Person person = new Person();
                person.Name = "Jerin" + i.ToString();
                person.Address = i.ToString() + "Eranakulam";
                People.Add(person);
            }
        }
    }
}
