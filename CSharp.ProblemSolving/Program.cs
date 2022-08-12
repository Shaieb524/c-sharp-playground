using CSharp.ProblemSolving.Tasks.TaskNo2.Models;

var emp = new Employee("joud", "jlt", "dubai", 123);
var t = emp.DoWork(); 

var emp2 = new Employee("fadi", "jlt", "dubai", 123, 7000);
var t2 = emp.DoWork();

Manager man = new Manager("Tony", "kassa", "damas", 111);
var tt = man.DoWork("msg");
Console.WriteLine(tt);

Employee mm = new Manager("Maze", "bab tuma", "damas", 222);
var ttt = mm.DoWork();

List<Employee> emps = new List<Employee>();

emps.Add(emp);
emps.Add(emp2);
emps.Add(man);
emps.Add(mm);

foreach (var item in emps)
{
    
    Console.WriteLine(item.ToString());
    Console.WriteLine(item.DoWork("msg"));
}

