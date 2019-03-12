using System;
using System.Collections.Generic;


namespace Classes_List_Employes_Working_At_Company

{
public class Company
{

    public string Name { get;set; }
    public DateTime CreatedOn { get; set;}

    public List<Employee> EmployeeList {get; set;}



    // Create a public property for holding a list of current employees

    // public string EmployeeList{get;set}
     

     public Company ( String name, DateTime createdOn){
         Name=name;
         CreatedOn = createdOn;
         EmployeeList= new List<Employee>();
}

public void ListEmployees(){
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine( $"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}.");
            }
         }

        public void CompanyInfo(){
            Console.WriteLine($"{Name} was founded on {CreatedOn}");
        }
    
}
}

// Create an instance of a company. Name it whatever you like.

        // Create three employees

        // Assign the employees to the company

        /*
            Iterate the company's employee list and generate the
            simple report shown above
        */