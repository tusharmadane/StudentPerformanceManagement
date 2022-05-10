using StudentPerformanceManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentPerformanceManagement.Services
{
    public class SubjectServices
    {
        Subject s;

        public void AddSubjectInfo()
        {
            s = new Subject();

            Console.WriteLine("Enter Subject Details :");
            Console.WriteLine("*******************************************************");



            Console.WriteLine("Enter Subject Code :");
            s.subject_Code = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Subject Title : ");
            s.subjectTitle = Console.ReadLine();

            Console.WriteLine("Enter Subject Description");
            s.subjectDescription = Console.ReadLine();

            Console.WriteLine("Enter Subject Course ID : ");
            s.courseID = int.Parse(Console.ReadLine());




            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[course].[insertSubject]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@code", s.subject_Code));
                command.Parameters.Add(new SqlParameter("@title", s.subjectTitle));
                command.Parameters.Add(new SqlParameter("@description", s.subjectDescription));
                command.Parameters.Add(new SqlParameter("@course_id", s.courseID));

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();


            }
        }

        internal void ShowSubjectInfo()
        {
            throw new NotImplementedException();
        }

        public void UpdateSubjectInfo()
        {
            s = new Subject();
            Console.WriteLine("Enter Subject Details :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Subject ID: ");
            s.subjectID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject ID: ");
            s.subject_Code = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Title : ");
            s.subjectTitle = Console.ReadLine();



            Console.WriteLine("Enter Subject Description : ");
            s.subjectDescription = Console.ReadLine();

            Console.WriteLine("Enter Course ID: ");
            s.courseID = int.Parse(Console.ReadLine());




            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[course].[editSubjectInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@subject_id", s.subjectID));
                command.Parameters.Add(new SqlParameter("@subject_code", s.subject_Code));
                command.Parameters.Add(new SqlParameter("@subject_title", s.subjectTitle));
                command.Parameters.Add(new SqlParameter("@subject_description", s.subjectDescription));
                command.Parameters.Add(new SqlParameter("@course_id", s.courseID));


                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();




            }


        }
        public void DeleteSubjectInfo()
        {
            s = new Subject();
            Console.WriteLine("Enter Details To Delete Record :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Subject ID: ");
            s.subjectID = int.Parse(Console.ReadLine());



            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[deleteSubjectInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@subject_id", s.subjectID);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();


            }
        }

        public void ShowStudentInfo()
        {
            s = new Subject();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************All Subject Records************************************");


            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[allSubjectInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //DisplayDataHeader();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString() + " " + reader[2].ToString()
                           + " " + reader[3].ToString() + " " + reader[4].ToString());
                    }
                }
            }


        }
    }
}
