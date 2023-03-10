namespace SkillFactory_Module_10;

internal partial class Program
{
    static Logger lg = new Logger();
    static void Main(string[] args)
    {
        lg.Event("Программа начала работу");
        SumOfTwoNumbers sum = new SumOfTwoNumbers();
        Console.WriteLine("Введите два числа");
        try
        {
            sum.SetValues();
            sum.Calculate(lg);
            sum.DisplayResult(lg);
        } 
        catch (Exception ex)
        {
            lg.Error(ex.Message);
        }
        Console.ReadKey();
    }
}