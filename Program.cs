using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("이름을 입력하세요: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("이름이 입력되지 않았습니다.");
                return;
            }

            Console.WriteLine($"안녕하세요, {name}님!");

            Console.WriteLine("1부터 5까지 출력합니다:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"오류가 발생했습니다: {ex.Message}");
        }
    }
}
