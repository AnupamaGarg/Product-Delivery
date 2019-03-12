using System;
using System.Collections.Generic;

namespace Classes_List_Employes_Working_At_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company1 = new Company("NSS",new DateTime(2012,01,21));


            Employee employee1 = new Employee( "Anupama","Garg","Software Developer", new DateTime(2019,01,21));
            Employee employee2 = new Employee( "Dolly","Singla","Software Engineer", new DateTime(2018,05,20));
            Employee employee3 = new Employee( "Anu","Singla","Software Developer", new DateTime(2016,05,22));


            
            company1.EmployeeList.Add(employee1);
            company1.EmployeeList.Add(employee2);
            company1.EmployeeList.Add(employee3);

            company1.ListEmployees();
        
            
              
              
              
                
            
        }
    }
}
