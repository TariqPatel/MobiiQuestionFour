using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using MVVM.Core.Model;

namespace MVVM.Core.ViewModels
{
    public class SecondViewModel : MvxViewModel
    {
        public static ObservableCollection<Employee> employeeList;

        public SecondViewModel()
        {
            PopulateEmployeeList();
        }

        public void PopulateEmployeeList()
        {
            employeeList = new ObservableCollection<Employee>
            {
                new Employee {DisplayName = "Sherlock Holmes"},
                new Employee {DisplayName = "Elon Musk"},
                new Employee {DisplayName = "Goku"},
                new Employee {DisplayName = "Kratos"},
                new Employee {DisplayName = "Velvet"},
                new Employee {DisplayName = "Cloud"}
            };
            _employees = employeeList;
        }

        public string MainPageButtonText { get; set; }

        public IMvxCommand AddToListCommand =>
            new MvxCommand(() => { Employees.Add(new Employee {DisplayName = "I dont have a name yet"}); });

        public ObservableCollection<Employee> _employees;

        public ObservableCollection<Employee> Employees
        {
            get => _employees;
            set => _employees = value;
        }
    }
}