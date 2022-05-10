using StudentPerformanceManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.Services
{
    internal class CourseServices
    {
        Course c;
        public void AddCourseInfo()
        {

            Console.WriteLine("Enter Course Details :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Course Code : ");
            c.code = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Course  Title : ");
            c.title = (Console.ReadLine());


            Console.WriteLine("Enter Course Description : ");
            c.description = Console.ReadLine();

            Console.WriteLine("Enter Course ID: ");
            c.cid = int.Parse(Console.ReadLine());






            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[allSubjectInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@code", c.code));
                command.Parameters.Add(new SqlParameter("@title", c.title));
                command.Parameters.Add(new SqlParameter("@description", c.description));
                command.Parameters.Add(new SqlParameter("@course_id", c.cid));

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();

            }


        }

    }
}
