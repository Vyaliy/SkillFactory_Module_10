namespace SkillFactory_Module_10;

public class Program
{
    static Logger lg = new Logger();
    static void Main(string[] args)
    {
        lg.Event("Программа начала работу");
        SumOfTwoNumbers sum = new SumOfTwoNumbers(lg);
        Console.WriteLine("Введите два числа");
        try
        {
            sum.SetValues();
            sum.Calculate();
            sum.DisplayResult();
        } 
        catch (Exception ex)
        {
            lg.Error(ex.Message);
        }
        Console.ReadKey();
    }
}