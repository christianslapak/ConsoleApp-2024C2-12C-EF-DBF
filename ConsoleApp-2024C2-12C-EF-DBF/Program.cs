using ConsoleApp_2024C2_12C_EF_DBF.Modelo;

namespace ConsoleApp_2024C2_12C_EF_DBF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var micontexto = new AaEscuelaDbContext();

            var misCursos = micontexto.Courses.ToList();

            foreach (var itemCurso in misCursos)
            {
                Console.WriteLine("Nombre Curso:" + itemCurso.CourseName);
            }



            Console.WriteLine("LinQ - Query Expression");
            var queryLinQ = from c in micontexto.Courses where c.TeacherId >=2 && c.TeacherId<=4 orderby c.CourseName select c;

            foreach (var itemqueryLinQ in queryLinQ)
            {
                Console.WriteLine("Nombre curso: " + itemqueryLinQ.CourseName);
            }

            micontexto.Courses.Add(new Course()
            { 
                CourseName = "PNT1",
                TeacherId = 4
            });
            micontexto.SaveChanges();
        }
    }
}
