namespace Ternary_Converter
{
  public class Program
  {
    public static void Main()
    {
      int UserInput = 0;

      while (UserInput != 1)
      {
        Console.Write("Enter 1 to stop converting: ");
        int.TryParse(Console.ReadLine(), out UserInput);

        if (UserInput == 1)
        break;

        Console.Write("Input your ternary number: ");
        string Ternary = Console.ReadLine();

        int ProgrammeOutput = 0;
        int Length = Ternary.Length;

        for (int i = 0; i < Length; i++)
        {
          char Current = Ternary[i];

          // validate 0-1-2
          if (Current < '0' || Current > '2')
          {
            Console.WriteLine("Error: only digits 0, 1, and 2 are allowed.");
            ProgrammeOutput = 0;
            break;
          }
          int Value = Current - '0';        // char to int
          int Power = Length - 1 - i;       // correct exponent
          ProgrammeOutput += Value * (int)Math.Pow(3, Power);
        }
      Console.WriteLine("Decimal: " + ProgrammeOutput);
      }
    }
  }
}
