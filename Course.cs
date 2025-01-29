using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_Nova
{
    internal class Course : DBConnection
    {
        //public void CreateCourse()
        //{
        //    using (SqlConnection connection = new SqlConnection("your_connection_string"))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("INSERT INTO Course (title, description) OUTPUT INSERTED.courseID VALUES (@title, @description)", connection);
        //        cmd.Parameters.AddWithValue("@title", "New Course Title");
        //        cmd.Parameters.AddWithValue("@description", "Course Description");

        //        int courseId = (int)cmd.ExecuteScalar();
        //    }
        //}

        //public DataTable GetRooms(int courseId)
        //{
        //    DataTable dataTable = new DataTable();

        //    using (SqlConnection connection = new SqlConnection("your_connection_string"))
        //    {
        //        connection.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT * FROM Room WHERE courseID = @courseID");
        //        cmd.Parameters.AddWithValue("@courseID", courseId);

        //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //        adapter.Fill(dataTable);
        //    }

        //    return dataTable;
        //}

        public DataTable getCourses()
        {
            this.connect();
            SqlCommand cmd = this.command();

            cmd.CommandText = "select * from [Course]";

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            this.closeConnection();
            return dataTable;
        }
    }
}
