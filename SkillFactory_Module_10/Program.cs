namespace SkillFactory_Module_10;

internal partial class Program
{
    static Logger lg = new Logger();
    static void Main(string[] args)
    {
        lg.Event("Программа начала работу");
        Console.WriteLine("Введите два числа");
        try
        {
            SumOfTwoNumbers<int> sum = new SumOfTwoNumbers<int>();
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