using CodeCool.FizzBuzzCooperation.Model;
using CodeCool.FizzBuzzCooperation.Service.Game;

namespace CodeCool.FizzBuzzCooperation.UI;

public class FizzBuzzGameUi
{
    private readonly IGameService _gameService;

    public FizzBuzzGameUi(IGameService gameService)
    {
        _gameService = gameService;
    }

    public void Run()
    {
        int number = GetNumber();
        GameSpecification spec = CreateGameSpecification();

        string result = _gameService.Play(number, spec);
        Console.WriteLine(result);
    }

    private GameSpecification CreateGameSpecification()
    {
        SortedList<int, GameRule> gameRules = new();
        GameRule gameRule1 = new(new int[2]{ 3, 5 }, Operator.And);
        GameRule gameRule2 = new(3);
        GameRule gameRule3 = new(5);
        gameRules.Add(1, gameRule1);
        gameRules.Add(2, gameRule2);
        gameRules.Add(3, gameRule3);
        return new GameSpecification(gameRules);
    }

    private int GetNumber()
    {
        string? input = null;
        int number;
        Console.WriteLine("Provide a number to FizzBuzz: ");

        while (!Int32.TryParse(input, out number))
        {
            if (input != null)
            {
                Console.WriteLine("Invalid number!");
            }

            input = Console.ReadLine();
        }

        return number;
    }
}
