// See https://aka.ms/new-console-template for more information
using studentperformancemanagement.Modules;
using studentperformancemanagement.Services;
using StudentPerformanceManagement.Services;

Console.WriteLine("Hello, World!");

//StudentServices ss = new StudentServices();
//ss.AddStudentInfo();
//ss.UpdateStudentInfo();
//ss.DeleteStudentInfo();
//ss.ShowStudentInfo();





SubjectServices sub = new SubjectServices();
//sub.AddSubjectInfo();
//sub.UpdateSubjectInfo();
//sub.DeleteSubjectInfo();

sub.ShowSubjectInfo();

//CourseServices cour = new CourseServices();
//cour.AddCourseInfo();



