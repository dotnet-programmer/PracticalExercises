namespace PracticalExercises;

internal class MainMenu
{
	public static void DoWork(Action[] functions, string header = "")
	{
		bool isWorking = true;
		while (isWorking)
		{
			ShowMenuPositions(header, functions);
			Console.Write("Choose a number: ");
			isWorking = ExecuteMethod(Console.ReadLine(), functions);
			Console.ReadKey();
		}

		static void ShowMenuPositions(string header, Action[] functions)
		{
			Console.Clear();

			if (!string.IsNullOrEmpty(header))
			{
				Console.WriteLine(header);
			}

			for (int i = 0; i < functions.Length; i++)
			{
				Console.WriteLine($"{i + 1}. {functions[i].Method.Name}");
			}
		}

		static bool ExecuteMethod(string input, Action[] functions)
		{
			if (int.TryParse(input, out int menuNumber) && menuNumber > 0 && menuNumber <= functions.Length)
			{
				functions[menuNumber - 1]();
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}