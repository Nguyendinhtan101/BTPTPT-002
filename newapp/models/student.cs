namespace NEWAPP.Model
{
    public class Student
    {
public string Ten { get ;set; }
public int Tuoi { get; set; }
public string diachi { get; set; }
public void EnterData()
{
    System.Console.Write("Ten = " );
    Ten = Console.ReadLine();
    System.Console.Write("Tuoi = ");
    Tuoi = Convert.ToInt16(Console.ReadLine());
    System.Console.Write("diachi = ");
    diachi = Console.ReadLine();
}
public void Display()
    {
    System.Console.WriteLine("{0} - {1}tuoi - {2}"Ten, Tuoi, diachi);
}
    }
}