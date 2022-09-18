using EntityApp;

/*
 * dotnet ef migrations add AddCatTable --context TrainingDbContext --project EntityApp
 * dotnet ef database update --context TrainingDbContext --project EntityApp

TrainingDbContext trainingDbConttext = new TrainingDbContext();

Teacher teacher = new Teacher();

teacher.Name = "Diponkar Saha";
teacher.Cgpa = 3.79;
teacher.DateOfBirth = DateTime.Now;
teacher.IsDeleted = false;  
teacher.StudentId = Guid.NewGuid();

trainingDbConttext.Teachers.Add(teacher);
trainingDbConttext.SaveChanges();
Console.WriteLine("added");*/

TrainingDbContext trainingDbConttext = new TrainingDbContext();
/*
TTT ttt = new TTT();
ttt.Name = "Teacher";
ttt.UserName = "teacher";
ttt.Password = "pppp";
ttt.TeacherId = Guid.NewGuid();
trainingDbConttext.TTTT.Add(ttt);
trainingDbConttext.SaveChanges();*/


AllPublic allPublic = new AllPublic();
allPublic.UserName = "teacher";
allPublic.Password = "password";
allPublic.role = 2;
trainingDbConttext.SaveChanges();




//var result1 = trainingDbConttext.TTTT.Where(x => x.UserName == "teacher" && x.Password== "pppp").FirstOrDefault();
/*

if (result1 != null)
{
    Console.WriteLine(result1.UserName);
}
else
{
    Console.WriteLine("pass vul");
}

*/

/*

Console.WriteLine("Please Enter your name:");
string usrname = Console.ReadLine();
Console.WriteLine("Please Enter your Password:");
string pass = Console.ReadLine();

int type = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(type);

if (type == 1)
{
    Console.Clear();
    Console.WriteLine("Login success.. you are Admin");
    ChooseTeacherOption();
}
else if (type == 2)
{
    Console.Clear();
    Console.WriteLine("Login success.. you are Teacher");

}
else if (type == 3)
{
    Console.Clear();
    Console.WriteLine("Login success.. you are Student");

}
else
{
    Console.Clear();
    Console.WriteLine("Wrong Password, please try again!");
}

void ChooseTeacherOption()
{

    Console.WriteLine("Choose your option: \n1 = Create Student   2 = Create Teacher  3 = Create Course");
    string option = Console.ReadLine();
    if (option == "1")
    {
        Console.Clear();
        Console.WriteLine("Create Student \nPlease enter your Student Name: ");
        string stuName = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Student Username: ");
        string stuUsrname = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Student Password: ");
        string stuPass = Console.ReadLine();
      
        Console.WriteLine("data insert");

        BackAdminInit();
    }
    else if (option == "2")
    {
        Console.Clear();
        Console.WriteLine("Create Teacher \nPlease enter your Teacher Name: ");
        string teacherName = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Teacher Username: ");
        string teacherUserName = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Teacher Password: ");
        string teacherPass = Console.ReadLine();
       
        Console.WriteLine("New Teacher Created");



        BackAdminInit();
    }
    else if (option == "3")
    {
        Console.Clear();
        Console.WriteLine("Create Course \nPlease enter your Course Name: ");
        string courseName = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Course Fee: ");
        string courseFee = Console.ReadLine();
        String insertSql = $"insert into course([coursename], coursefee) values('{courseName}'," +
            $" '{courseFee}')";

      
        Console.WriteLine("New Course Created");
        BackAdminInit();

    }
}
void BackAdminInit()
{

    Console.WriteLine("\n1 press for back ");
    string option1 = Console.ReadLine();
    if (option1 == "1")
    {
        Console.Clear();
        ChooseTeacherOption();
    }
}

Console.ReadLine();

*/