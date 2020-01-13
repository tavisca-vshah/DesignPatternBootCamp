using System;
using System.Collections.Generic;
using System.Text;

namespace DesignBootcamp
{
    class ConcreteCollection
    {
        private List<Employee> listEmployees = new List<Employee>();
        //Create Iterator
       
        // Gets item count
        public int Count
        {
            get { return listEmployees.Count; }
        }
        //Add items to the collection
        public void AddEmployee(Employee employee)
        {
            listEmployees.Add(employee);
        }
        //Get item from collection
        public Employee GetEmployee(int IndexPosition)
        {
            return listEmployees[IndexPosition];
        }
    }

}
