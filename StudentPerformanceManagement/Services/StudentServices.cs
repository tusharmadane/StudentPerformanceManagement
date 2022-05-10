using studentperformancemanagement.Modules;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentperformancemanagement.Services
{
    public class StudentServices
    {
        Student s;

        public void AddStudentInfo()
        {
            s = new Student();
            Console.WriteLine("Enter Student Details :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Student Name : ");
            s.Name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll No : ");
            s.Roll = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Student Address : ");
            s.Address = Console.ReadLine();

            Console.WriteLine("Enter Course ID: ");
            s.cid = int.Parse(Console.ReadLine());




            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[addStudentInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@roll", s.Roll));
                command.Parameters.Add(new SqlParameter("@name", s.Name));
                command.Parameters.Add(new SqlParameter("@address", s.Address));
                command.Parameters.Add(new SqlParameter("@cid", s.cid));

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();





            }
        }

        public void UpdateStudentInfo()
        {
            s = new Student();
            Console.WriteLine("Enter Update Details :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Student ID: ");
            s.Studentid = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name : ");
            s.Name = Console.ReadLine();

            Console.WriteLine("Enter Student Roll No : ");
            s.Roll = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter Student Address : ");
            s.Address = Console.ReadLine();

            Console.WriteLine("Enter Course ID: ");
            s.cid = int.Parse(Console.ReadLine());




            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[editStudentInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@sid", s.Studentid));
                command.Parameters.Add(new SqlParameter("@roll", s.Roll));
                command.Parameters.Add(new SqlParameter("@name", s.Name));
                command.Parameters.Add(new SqlParameter("@address", s.Address));
                command.Parameters.Add(new SqlParameter("@cid", s.cid));

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();




            }


        }

        public void DeleteStudentInfo()
        {
            s = new Student();
            Console.WriteLine("Enter Details To Delete Record :");
            Console.WriteLine("*******************************************************");

            Console.WriteLine("Enter Student ID: ");
            s.Studentid = int.Parse(Console.ReadLine());



            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[Student].[deleteStudentInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@sid", s.Studentid);

                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected);

                connection.Close();






            }


        }
        public void ShowSubjectInfo()
        {
            s = new Student();
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("*********************************All Students Records************************************");


            string connectionstring = @"Data Source = WAIANGDESK04; Initial Catalog = StudentDatabase; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionstring)) //object create
            {
                connection.Open();

                SqlCommand command = new SqlCommand("[student].[allstudentInfo]", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                //DisplayDataHeader();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString()+" " + reader[2].ToString() 
                           + " "+reader[3].ToString() +" "+reader[4].ToString());
                    }
                }
            }


        }

    }

}
