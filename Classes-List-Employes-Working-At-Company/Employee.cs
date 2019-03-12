

using System;
using System.Collections.Generic;

namespace Classes_List_Employes_Working_At_Company

{

public class Employee
{

    
    public string FirstName { get; set;}
    public string LastName { get; set;}
    public string Title { get;set; }
    public DateTime StartDate { get;set; }

    public Employee(String firstName, string lastName,String title, DateTime startDate
    )
{

    FirstName = firstName;
    LastName= lastName;
    Title= title;
    StartDate= startDate;
    
}



        
}

}