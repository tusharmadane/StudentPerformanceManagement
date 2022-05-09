// See https://aka.ms/new-console-template for more information
using studentperformancemanagement.Modules;
using studentperformancemanagement.Services;

Console.WriteLine("Hello, World!");

 StudentServices ss = new StudentServices();
//ss.AddStudentInfo();
//ss.UpdateStudentInfo();
//Student s1=new Student();

//ss.DeleteStudentInfo();


ss.ShowStudentInfo();

