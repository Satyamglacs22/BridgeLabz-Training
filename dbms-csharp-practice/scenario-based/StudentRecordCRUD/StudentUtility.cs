using System;
using System.Data.SqlClient;

class StudentUtility : IStudent
{
    public void InsertStudent()
    {
        Console.WriteLine("Enter Name of the Student:");
        string name = Console.ReadLine()!;

        Console.WriteLine("Enter Age of the Student:");
        int age;
        while (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.Write("Enter valid age: ");
        }

        Console.WriteLine("Enter Course of the Student:");
        string course = Console.ReadLine()!;

        string query =
            "INSERT INTO Students (Name, Age, Course) " +
            "VALUES (@name, @age, @course)";

        using (SqlConnection con =
               new SqlConnection(Connection.ConnectionString))
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@course", course);

                con.Open();
                cmd.ExecuteNonQuery();

                Console.WriteLine("Student Record Inserted Successfully ✅");
            }
        }
    }

    public void ReadStudent()
{
    string query = "SELECT StudentId, Name, Age, Course FROM Students";

    using (SqlConnection con =
           new SqlConnection(Connection.ConnectionString))
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            if (!reader.HasRows)
            {
                Console.WriteLine("No student records found ❌");
                return;
            }

            Console.WriteLine("\n--- Student Records ---\n");

           while (reader.Read())
{
    int id = Convert.ToInt32(reader["StudentID"]);
    string name = reader["Name"].ToString();
    int age = Convert.ToInt32(reader["Age"]);
    string course = reader["Course"].ToString();

    Console.WriteLine($"ID: {id}");
    Console.WriteLine($"Name: {name}");
    Console.WriteLine($"Age: {age}");
    Console.WriteLine($"Course: {course}");
    Console.WriteLine("--------------------");
}

            reader.Close();
        }
    }
}


    public void DeleteStudent()
{
    Console.WriteLine("Enter Student ID to Delete:");
    
    int id;
    while (!int.TryParse(Console.ReadLine(), out id))
    {
        Console.Write("Enter valid Student ID: ");
    }

    string query = "DELETE FROM Students WHERE StudentID = @id";

    using (SqlConnection con =
           new SqlConnection(Connection.ConnectionString))
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Student Record Deleted Successfully ✅");
            }
            else
            {
                Console.WriteLine("No Student Found with this ID ❌");
            }
        }
    }
}
public void UpdateStudent()
{
    Console.WriteLine("Enter Student ID to Update:");

    int id;
    while (!int.TryParse(Console.ReadLine(), out id))
    {
        Console.Write("Enter valid Student ID: ");
    }

    Console.WriteLine("Enter New Name:");
    string name = Console.ReadLine()!;

    Console.WriteLine("Enter New Age:");
    int age;
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.Write("Enter valid Age: ");
    }

    Console.WriteLine("Enter New Course:");
    string course = Console.ReadLine()!;

    string query =
        "UPDATE Students " +
        "SET Name = @name, Age = @age, Course = @course " +
        "WHERE StudentID = @id";

    using (SqlConnection con =
           new SqlConnection(Connection.ConnectionString))
    {
        using (SqlCommand cmd = new SqlCommand(query, con))
        {
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@course", course);

            con.Open();

            int rows = cmd.ExecuteNonQuery();

            if (rows > 0)
            {
                Console.WriteLine("Student Record Updated Successfully ✅");
            }
            else
            {
                Console.WriteLine("No Student Found with this ID ❌");
            }
        }
    }
}


}
