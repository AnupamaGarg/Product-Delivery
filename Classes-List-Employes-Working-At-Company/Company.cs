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
         



               
     }

    
}
}