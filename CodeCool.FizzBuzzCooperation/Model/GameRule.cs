namespace CodeCool.FizzBuzzCooperation.Model;
public record GameRule
{
    public int[] Divisors { get; }
    public Operator? ThisOperator { get; }
    public string Keyword;
    public GameRule(int[] divisors, Operator specificOperator)
    {
        Divisors = divisors;
        ThisOperator = specificOperator;
        Keyword = GetKeyword();
    }

    public GameRule(int divisor)
    {
        Divisors = new int[1];
        Divisors[0] = divisor;
        ThisOperator = null;
        Keyword = GetKeyword();
    }
    // private Operator GetOperator()
    // {
    //     Array values = Enum.GetValues(typeof(Operator));
    //     Random random = new Random();
    //     return (Operator)values.GetValue(random.Next(values.Length));
    // }
    private string GetKeyword()
    {
        bool HasOneNumber = Divisors.Length == 1;
        bool HasTwoNumbers = Divisors.Length == 2;
        bool ContainsNrThree = Divisors.Contains(3);
        bool ContainsNrFive = Divisors.Contains(5);

        if ( HasTwoNumbers && ContainsNrThree && ContainsNrFive && ThisOperator == Operator.And) return "FizzBuzz";
        else if (HasOneNumber && ContainsNrThree) return "Fizz";
        else if (HasOneNumber && ContainsNrFive) return "Buzz";
        else return "original number";

    }
};