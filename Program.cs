using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper.Contrib.Extensions;

namespace DapperDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["dapperConnStr"].ConnectionString))
            {
                //Student student = new Student()
                //{
                //    Name = "张三",
                //    Age = 20,
                //    Remark = "测试Dapper"
                //};

                //db.Execute("insert into Student(name, age, remark) values(@name,@age,@remark)", new {name="XC", age=8,remark="fsdgfsdg" });

                db.Insert(new Student() { Id=9, Name = "1708A", Age = 3, Remark = "very good" });



                //db.Delete<Student>(new Student() { Id = 1 });

                //db.Update<Student>(new Student() { Id = 9, Name = "1708A", Age = 2, Remark = "very very very good" });
               
                Student student = db.Get<Student>(3);

                //var students = db.Query<Student>("select * from student");

                // //Student student = db.QueryFirstOrDefault<Student>("select * from student");


                // string query = "select * from student WHERE Id = @IdH AND NAME = @NAME";
                // var student3 = db.QuerySingleOrDefault<Student>(query, new { IdH = 2, NAME = "张三" });


                //Student student2 = db.QuerySingleOrDefault<Student>("select * from student where Id = 2");




            }
        }
    }
}



