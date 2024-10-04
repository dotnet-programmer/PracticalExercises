// Book: C++: zadania z programowania z przykładowymi rozwiązaniami

using System.Text;

namespace PracticalExercises;

internal class FirstBook
{
	private static readonly Action[] _functions =
	[
		Exercise_1_1, Exercise_1_2, Exercise_1_3, Exercise_1_4, Exercise_1_5, Exercise_1_6, Exercise_1_7,
		Exercise_2_1, Exercise_2_2, Exercise_2_3, Exercise_2_4, Exercise_2_5,
		Exercise_3_1, Exercise_3_2, Exercise_3_3, Exercise_3_4, Exercise_3_5, Exercise_3_6, Exercise_3_7, Exercise_3_8, Exercise_3_9, Exercise_3_10, Exercise_3_11, Exercise_3_12, Exercise_3_13, Exercise_3_14, Exercise_3_15, Exercise_3_16, Exercise_3_17, Exercise_3_18, Exercise_3_19, Exercise_3_20, Exercise_3_21, Exercise_3_22, Exercise_3_23, Exercise_3_24,
		Exercise_4_1, Exercise_4_2, Exercise_4_3, Exercise_4_4, Exercise_4_5, Exercise_4_6, Exercise_4_7, Exercise_4_8,
		Exercise_5_1, Exercise_5_2, Exercise_5_3, Exercise_5_4, Exercise_5_5, Exercise_5_6, Exercise_5_7, Exercise_5_8, Exercise_5_9,
		Exercise_6_1, Exercise_6_2,
		Exercise_7_1, Exercise_7_2, Exercise_7_3,
	];

	public static void FirstBookExercises()
		=> MainMenu.DoWork(_functions, "First Book Exercises: ");

	#region Chapter_1

	// Napisz program, który oblicza pole prostokąta. Wartości boków a i b wprowadzamy z klawiatury.
	// W programie należy przyjąć, że zmienne a i b oraz pole są typu float (rzeczywistego).
	// Przyjmujemy format wyświetlania ich na ekranie z dokładnością dwóch miejsc po kropce.
	public static void Exercise_1_1()
	{
		Console.WriteLine("The program calculates the area of a rectangle.");
		Console.WriteLine("Give side a: ");
		float sideA = float.Parse(Console.ReadLine());
		Console.WriteLine("Give side b: ");
		float sideB = float.Parse(Console.ReadLine());
		Console.WriteLine($"The area of a rectangle = {sideA * sideB:F2}");
	}

	// Napisz program, który wyświetla na ekranie komputera wartość predefiniowanej stałej p = 3,14…
	// Należy przyjąć format prezentowania tej stałej, oznaczanej w języku C++ jako M_PI, z dokładnością pięciu miejsc po kropce.
	public static void Exercise_1_2()
		=> Console.WriteLine($"The program displays the predefined constant pi with five place accuracy: {Math.PI:F5}");

	// Napisz program, który wyświetla na ekranie komputera pierwiastek kwadratowy z wartości predefiniowanej stałej p = 3,14...
	// Należy przyjąć format wyświetlania tego pierwiastka z dokładnością dwóch miejsc po kropce.
	public static void Exercise_1_3()
		=> Console.WriteLine($"The program displays the square root of the pi value with two place accuracy: {Math.Sqrt(Math.PI):F2}");

	// Napisz program, który oblicza objętość kuli o promieniu r. Wartość promienia wprowadzamy z klawiatury.
	// W programie należy przyjąć, że r jest typu float (rzeczywistego).
	// Dla zmiennych r oraz objetosc należy przyjąć format wyświetlania ich na ekranie z dokładnością dwóch miejsc po kropce.
	public static void Exercise_1_4()
	{
		Console.WriteLine("The program calculates the volume of a sphere.");
		Console.WriteLine("Give radius r: ");
		float radius = float.Parse(Console.ReadLine());
		Console.WriteLine($"The volume of a sphere = {4 * Math.PI * Math.Pow(radius, 3) / 3:F2}");
	}

	// Napisz program, który oblicza wynik dzielenia całkowitego bez reszty dla dwóch liczb całkowitych a = 37 i b = 11.
	public static void Exercise_1_5()
		=> Console.WriteLine(37 / 11);

	// Napisz program, który oblicza resztę z dzielenia całkowitego dla dwóch liczb całkowitych a = 37 i b = 11.
	public static void Exercise_1_6()
		=> Console.WriteLine(37 % 11);

	// Napisz program, który oblicza sumę, różnicę, iloczyn i iloraz dla dwóch liczb x i y wprowadzanych z klawiatury.
	// W programie przyjmujemy, że liczby x i y są typu float (rzeczywistego).
	// Dla zmiennych x, y, suma, roznica, iloczyn i iloraz należy przyjąć format wyświetlania ich na ekranie z dokładnością dwóch miejsc po kropce.
	public static void Exercise_1_7()
	{
		Console.Write("Give first number: ");
		float num1 = float.Parse(Console.ReadLine());
		Console.Write("Give second number: ");
		float num2 = float.Parse(Console.ReadLine());
		Console.WriteLine($"Addition = {num1 + num2:F2}");
		Console.WriteLine($"Subtraction = {num1 - num2:F2}");
		Console.WriteLine($"Multiplication = {num1 * num2:F2}");
		Console.WriteLine($"Division = {num1 / num2:F2}");
	}

	#endregion Chapter_1

	#region Chapter_2

	// Napisz program, który dla trzech boków trójkąta a, b i c wprowadzonych z klawiatury sprawdza, czy tworzą one trójkąt prostokątny.
	// Zakładamy, że a > 0, b > 0, c > 0.
	public static void Exercise_2_1()
	{
		Console.Write("Give side a: ");
		double sideA = double.Parse(Console.ReadLine());
		Console.Write("Give side b: ");
		double sideB = double.Parse(Console.ReadLine());
		Console.Write("Give side c: ");
		double sideC = double.Parse(Console.ReadLine());
		Console.WriteLine($"Triangle {(sideA * sideA + sideB * sideB == sideC * sideC ? "is" : "is not")} rectangular");
	}

	// Napisz program, który z wykorzystaniem instrukcji warunkowej if oblicza pierwiastki równania kwadratowego ax2+bx+c = 0,
	// gdzie zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury.
	// Dla zmiennych a, b, c, x1 oraz x2 należy przyjąć format wyświetlania ich z dokładnością dwóch miejsc po kropce.
	public static void Exercise_2_2()
	{
		Console.Write("Give number 1: ");
		double number1 = double.Parse(Console.ReadLine());
		Console.Write("Give number 2: ");
		double number2 = double.Parse(Console.ReadLine());
		Console.Write("Give number 3: ");
		double number3 = double.Parse(Console.ReadLine());
		if (number1 == 0)
		{
			Console.WriteLine("Error!");
			return;
		}
		double delta = number2 * number2 - 4 * number1 * number3;

		if (delta > 0)
		{
			Console.WriteLine($"Result 1 = {(-number2 - Math.Sqrt(delta)) / (2 * number1)}");
			Console.WriteLine($"Result 2 = {(-number2 + Math.Sqrt(delta)) / (2 * number1)}");
		}
		else if (delta == 0)
		{
			Console.WriteLine($"Result 1 = {(-number2) / (2 * number1)}");
		}
		else
		{
			Console.WriteLine("No results");
		}
	}

	// Napisz program, który z wykorzystaniem instrukcji wyboru switch oblicza pierwiastki równania kwadratowego ax2+bx+c = 0,
	// gdzie zmienne a, b, c to liczby rzeczywiste wprowadzane z klawiatury.
	// Dla zmiennych a, b, c, x1 oraz x2 należy przyjąć format wyświetlania ich na ekranie z dokładnością dwóch miejsc po kropce.
	public static void Exercise_2_3()
	{
		Console.Write("Give number 1: ");
		double number1 = double.Parse(Console.ReadLine());
		Console.Write("Give number 2: ");
		double number2 = double.Parse(Console.ReadLine());
		Console.Write("Give number 3: ");
		double number3 = double.Parse(Console.ReadLine());

		if (number1 == 0)
		{
			Console.WriteLine("Error!");
			return;
		}

		double delta = number2 * number2 - 4 * number1 * number3;
		switch (delta)
		{
			case > 0:
				Console.WriteLine($"Result 1 = {(-number2 - Math.Sqrt(delta)) / (2 * number1)}");
				Console.WriteLine($"Result 2 = {(-number2 + Math.Sqrt(delta)) / (2 * number1)}");
				break;
			case 0:
				Console.WriteLine($"Result 1 = {(-number2) / (2 * number1)}");
				break;
			case < 0:
				Console.WriteLine("No results");
				break;
		}
	}

	// Napisz program, który oblicza wartość x z równania ax+b = c. Wartości a, b i c należą do zbioru liczb rzeczywistych i są wprowadzane z klawiatury.
	// Dodatkowo należy zabezpieczyć program na wypadek sytuacji, kiedy wprowadzona wartość a jest równa zero.
	// Dla zmiennych a, b, c oraz x należy przyjąć format wyświetlania ich z dokładnością dwóch miejsc po kropce.
	public static void Exercise_2_4()
	{
		Console.Write("Give number 1: ");
		double number1 = double.Parse(Console.ReadLine());
		Console.Write("Give number 2: ");
		double number2 = double.Parse(Console.ReadLine());
		Console.Write("Give number 3: ");
		double number3 = double.Parse(Console.ReadLine());
		if (number1 == 0)
		{
			Console.WriteLine("Error!");
			return;
		}
		Console.WriteLine($"X = {(number3 - number2) / number1:F2}");
	}

	// Napisz program, w którym użytkownik zgaduje liczbę losową z przedziału od 0 do 9 generowaną przez komputer.
	public static void Exercise_2_5()
	{
		int random = new Random().Next(10);
		Console.Write("Give number: ");
		int number1 = int.Parse(Console.ReadLine());
		Console.WriteLine(random == number1 ? "You guessed the number" : $"Fail :( The number was {random}");
	}

	#endregion Chapter_2

	#region Chapter_3

	// Napisz program, który za pomocą instrukcji for dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x.
	public static void Exercise_3_1()
	{
		for (int i = 0; i <= 10; i++)
		{
			Console.WriteLine($"x = {i}  y = {3 * i}");
		}
	}

	// Napisz program, który za pomocą instrukcji do ... while dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x.
	public static void Exercise_3_2()
	{
		int i = 0;
		do
		{
			Console.WriteLine($"x = {i}  y = {3 * i}");
			i++;
		} while (i <= 10);
	}

	// Napisz program, który za pomocą instrukcji while dla danych wartości x zmieniających się od 0 do 10 oblicza wartość funkcji y = 3x.
	public static void Exercise_3_3()
	{
		int i = 0;
		while (i <= 10)
		{
			Console.WriteLine($"x = {i}  y = {3 * i}");
			i++;
		}
	}

	// Napisz program, który za pomocą instrukcji for wyświetla liczby całkowite od 1 do 20.
	public static void Exercise_3_4()
	{
		for (int i = 1; i <= 20; i++)
		{
			Console.Write($"{i}{(i < 20 ? ", " : ".")}");
		}
	}

	// Napisz program, który za pomocą instrukcji do ... while wyświetla liczby całkowite od 1 do 20.
	public static void Exercise_3_5()
	{
		int i = 1;
		do
		{
			Console.Write($"{i}{(i < 20 ? ", " : ".")}");
			i++;
		} while (i <= 20);
	}

	// Napisz program, który za pomocą instrukcji while wyświetla liczby całkowite od 1 do 20.
	public static void Exercise_3_6()
	{
		int i = 1;
		while (i <= 20)
		{
			Console.Write($"{i}{(i < 20 ? ", " : ".")}");
			i++;
		}
	}

	// Napisz program, który za pomocą instrukcji for sumuje liczby całkowite od 1 do 100.
	public static void Exercise_3_7()
	{
		int sum = 0;
		for (int i = 0; i <= 100; i++)
		{
			sum += i;
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji do ... while sumuje liczby całkowite od 1 do 100.
	public static void Exercise_3_8()
	{
		int sum = 0, i = 0;
		do
		{
			sum += i;
			i++;
		} while (i <= 100);
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji while sumuje liczby całkowite od 1 do 100.
	public static void Exercise_3_9()
	{
		int sum = 0, i = 0;
		while (i <= 100)
		{
			sum += i;
			i++;
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji for sumuje liczby parzyste w przedziale od 1 do 100.
	public static void Exercise_3_10()
	{
		int sum = 0;
		for (int i = 0; i <= 100; i++)
		{
			if (i % 2 == 0)
			{
				sum += i;
			}
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji do ... while sumuje liczby parzyste w przedziale od 1 do 100.
	public static void Exercise_3_11()
	{
		int sum = 0, i = 0;
		do
		{
			if (i % 2 == 0)
			{
				sum += i;
			}
			i++;
		} while (i <= 100);
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji while sumuje liczby parzyste w przedziale od 1 do 100.
	public static void Exercise_3_12()
	{
		int sum = 0, i = 0;
		while (i <= 100)
		{
			if (i % 2 == 0)
			{
				sum += i;
			}
			i++;
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji for sumuje liczby nieparzyste z przedzialu od 1 do 100.
	public static void Exercise_3_13()
	{
		int sum = 0;
		for (int i = 0; i <= 100; i++)
		{
			if (i % 2 != 0)
			{
				sum += i;
			}
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji do ... while sumuje liczby nieparzyste w przedziale od 1 do 100.
	public static void Exercise_3_14()
	{
		int sum = 0, i = 0;
		do
		{
			if (i % 2 != 0)
			{
				sum += i;
			}
			i++;
		} while (i <= 100);
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji while sumuje liczby nieparzyste w przedziale od 1 do 100.
	public static void Exercise_3_15()
	{
		int sum = 0, i = 0;
		while (i <= 100)
		{
			if (i % 2 != 0)
			{
				sum += i;
			}
			i++;
		}
		Console.WriteLine(sum);
	}

	// Napisz program, który za pomocą instrukcji for znajduje największą i najmniejszą liczbę ze zbioru n liczb losowych z przedziału od 0 do 99
	// oraz oblicza ich średnią (w zadaniu n = 5).
	public static void Exercise_3_16()
	{
		Random random = new();
		int min, max, sum, count = 5;
		int tmpNumber = random.Next(100);
		min = max = sum = tmpNumber;
		Console.Write(tmpNumber + " ");
		for (int i = 1; i < count; i++)
		{
			tmpNumber = random.Next(100);
			Console.Write(tmpNumber + " ");
			sum += tmpNumber;
			min = tmpNumber < min ? tmpNumber : min;
			max = tmpNumber > max ? tmpNumber : max;
		}
		Console.WriteLine($"\nMax = {max}");
		Console.WriteLine($"Min = {min}");
		Console.WriteLine($"Avg = {sum / count:F2}");
	}

	// Napisz program, który za pomocą instrukcji do ... while znajduje największą i najmniejszą liczbę ze zbioru n liczb losowych z przedziału od 0 do 99
	// oraz oblicza ich średnią (w zadaniu n = 5).
	public static void Exercise_3_17()
	{
		Random random = new();
		int min, max, sum, count = 5;
		int tmpNumber = random.Next(100);
		min = max = sum = tmpNumber;
		Console.Write(tmpNumber + " ");
		int i = 1;
		do
		{
			tmpNumber = random.Next(100);
			Console.Write(tmpNumber + " ");
			sum += tmpNumber;
			min = tmpNumber < min ? tmpNumber : min;
			max = tmpNumber > max ? tmpNumber : max;
			i++;
		} while (i < count);
		Console.WriteLine($"\nMax = {max}");
		Console.WriteLine($"Min = {min}");
		Console.WriteLine($"Avg = {sum / count:F2}");
	}

	// Napisz program, który za pomocą instrukcji while znajduje największą i najmniejszą liczbę ze zbioru n liczb losowych z przedziału od 0 do 99
	// oraz oblicza ich średnią (w zadaniu n = 5).
	public static void Exercise_3_18()
	{
		Random random = new();
		int min, max, sum, count = 5;
		int tmpNumber = random.Next(100);
		min = max = sum = tmpNumber;
		Console.Write(tmpNumber + " ");
		int i = 1;
		while (i < count)
		{
			tmpNumber = random.Next(100);
			Console.Write(tmpNumber + " ");
			sum += tmpNumber;
			min = tmpNumber < min ? tmpNumber : min;
			max = tmpNumber > max ? tmpNumber : max;
			i++;
		}
		Console.WriteLine($"\nMax = {max}");
		Console.WriteLine($"Min = {min}");
		Console.WriteLine($"Avg = {sum / count:F2}");
	}

	// Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100 z wykorzystaniem podwójnej pętli for.
	public static void Exercise_3_19()
	{
		for (int i = 1; i <= 10; i++)
		{
			for (int j = 1; j <= 10; j++)
			{
				Console.Write($"{i * j,4}");
			}
			Console.WriteLine();
		}
	}

	// Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100 z wykorzystaniem podwójnej pętli do ... while.
	public static void Exercise_3_20()
	{
		int i = 1, j;
		do
		{
			j = 1;
			do
			{
				Console.Write($"{i * j,4}");
				j++;
			} while (j <= 10);
			i++;
			Console.WriteLine();
		} while (i <= 10);
	}

	// Napisz program wyświetlający tabliczkę mnożenia dla liczb od 1 do 100 z wykorzystaniem podwójnej pętli while.
	public static void Exercise_3_21()
	{
		int i = 1, j;
		while (i <= 10)
		{
			j = 1;
			while (j <= 10)
			{
				Console.Write($"{i * j,4}");
				j++;
			}
			i++;
			Console.WriteLine();
		}
	}

	// Napisz program, który wyświetla duże litery alfabetu od A do Z i od Z do A, z wykorzystaniem pętli for.
	public static void Exercise_3_22()
	{
		for (char i = 'A'; i <= 'Z'; i++)
		{
			Console.Write(i + " ");
		}
		Console.WriteLine();
		for (char i = 'Z'; i >= 'A'; i--)
		{
			Console.Write(i + " ");
		}
	}

	// Napisz program, który wyświetla duże litery alfabetu od a do z i od z do A, z wykorzystaniem pętli do ... while.
	public static void Exercise_3_23()
	{
		char i = 'A';
		do
		{
			Console.Write(i + " ");
			i++;
		} while (i <= 'Z');

		Console.WriteLine();

		i = 'Z';
		do
		{
			Console.Write(i + " ");
			i--;
		} while (i >= 'A');
	}

	// Napisz program, który wyświetla duże litery alfabetu od a do z i od z do A, z wykorzystaniem pętli while.
	public static void Exercise_3_24()
	{
		char i = 'A';
		while (i <= 'Z')
		{
			Console.Write(i + " ");
			i++;
		}

		Console.WriteLine();

		i = 'Z';
		while (i >= 'A')
		{
			Console.Write(i + " ");
			i--;
		}
	}

	#endregion Chapter_3

	#region Chapter_4

	// Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie dane umieszcza liczby od 0 do 9 (zobacz poniżej jej reprezentację graficzną).
	public static void Exercise_4_1()
	{
		const int size = 10;
		int[] numbers = new int[size];
		for (int i = 0; i < size; i++)
		{
			numbers[i] = i;
		}
		foreach (var item in numbers)
		{
			Console.Write(item + " ");
		}
	}

	// Napisz program, który w 10-elementowej tablicy jednowymiarowej o nazwie dane umieszcza liczby od 9 do 0 (zobacz poniżej jej reprezentację graficzną).
	public static void Exercise_4_2()
	{
		const int size = 10;
		int[] numbers = new int[size];
		for (int i = 0; i < size; i++)
		{
			numbers[i] = size - i - 1;
		}
		foreach (var item in numbers)
		{
			Console.Write(item + " ");
		}
	}

	// Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10×10 o nazwie macierz umieszcza na przekątnej liczbę 1, a poza przekątną 0.
	// Dodatkowo program powinien obliczać sumę elementów wyróżnionych w tablicy, tj. tych znajdujących się na jej przekątnej.
	public static void Exercise_4_3()
	{
		const int size = 10;
		int sum = 0;
		int[,] numbers = new int[size, size];
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				if (i == j)
				{
					numbers[i, j] = 1;
					sum += i;
				}
			}
		}
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				Console.Write(numbers[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine($"Sum = {sum}");
	}

	// Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10×10 o nazwie macierz umieszcza na przekątnej liczby od 0 do 9, a poza przekątną 0.
	// Dodatkowo program powinien obliczać sumę elementów wyróżnionych w tablicy, tj. znajdujących się na jej przekątnej.
	public static void Exercise_4_4()
	{
		const int size = 10;
		int sum = 0;
		int[,] numbers = new int[size, size];
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				if (i == j)
				{
					numbers[i, j] = i;
					sum += i;
				}
			}
		}
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				Console.Write(numbers[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine($"Sum = {sum}");
	}

	// Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10×10 o nazwie macierz (jej interpretacja graficzna poniżej) umieszcza liczby 1 i 0.
	// Program powinien dodatkowo obliczać sumę wyróżnionych elementów.
	public static void Exercise_4_5()
	{
		const int size = 10;
		int sum = 0;
		int[,] numbers = new int[size, size];
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				if (j == size - i - 1)
				{
					numbers[i, j] = 1;
					sum += 1;
				}
			}
		}
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				Console.Write(numbers[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine($"Sum = {sum}");
	}

	// Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10×10 o nazwie macierz (jej interpretacja graficzna poniżej) umieszcza liczby od 0 do 9.
	// Program powinien dodatkowo obliczać sumę wyróżnionych elementów.
	public static void Exercise_4_6()
	{
		const int size = 10;
		int sum = 0;
		int[,] numbers = new int[size, size];
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				if (j == size - i - 1)
				{
					numbers[i, j] = i;
					sum += i;
				}
			}
		}
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				Console.Write(numbers[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine($"Sum = {sum}");
	}

	// Napisz program, który w zadeklarowanej tablicy dwuwymiarowej 10×10 umieszcza w pierwszej kolumnie liczby od 0 do 9, w drugiej kwadraty tych liczb,
	// natomiast w pozostałych kolumnach 0 (interpretacja graficzna tablicy poniżej).
	// Dodatkowo program powinien obliczać sumę elementów znajdujących się w pierwszej kolumnie oraz sumę liczb z kolumny drugiej.
	public static void Exercise_4_7()
	{
		const int size = 10;
		int sum1 = 0;
		int sum2 = 0;
		int[,] numbers = new int[size, size];
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				if (j == 0)
				{
					numbers[i, j] = i;
					sum1 += numbers[i, j];
				}
				else if (j == 1)
				{
					numbers[i, j] = i * i;
					sum2 += numbers[i, j];
				}
			}
		}
		for (int i = 0; i < numbers.GetLength(0); i++)
		{
			for (int j = 0; j < numbers.GetLength(1); j++)
			{
				Console.Write(numbers[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine($"Sum1 = {sum1}  Sum2 = {sum2}");
	}

	// Napisz program, który przepisuje zawartość tablicy a do tablicy b, zamieniając kolumny na wiersze
	public static void Exercise_4_8()
	{
		const int size = 10;
		int[,] numbers1 = new int[size, size];
		for (int i = 0; i < numbers1.GetLength(0); i++)
		{
			for (int j = 0; j < numbers1.GetLength(1); j++)
			{
				numbers1[i, j] = j;
			}
		}
		for (int i = 0; i < numbers1.GetLength(0); i++)
		{
			for (int j = 0; j < numbers1.GetLength(1); j++)
			{
				Console.Write(numbers1[i, j] + " ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
		int[,] numbers2 = new int[size, size];
		for (int i = 0; i < numbers2.GetLength(0); i++)
		{
			for (int j = 0; j < numbers2.GetLength(1); j++)
			{
				numbers2[i, j] = numbers1[j, i];
			}
		}
		for (int i = 0; i < numbers2.GetLength(0); i++)
		{
			for (int j = 0; j < numbers2.GetLength(1); j++)
			{
				Console.Write(numbers2[i, j] + " ");
			}
			Console.WriteLine();
		}
	}

	#endregion Chapter_4

	#region Chapter_5

	// Napisz program obliczający pole prostokąta. Powinien on zawierać jeden podprogram: bezparametrową funkcję pole_prostokata(), w której zawarty będzie algorytm obliczania pola.
	// Wartości boków a i b wprowadzamy z klawiatury. Należy dla nich przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	public static void Exercise_5_1()
	{
		Console.WriteLine("The program calculates the area of a rectangle.");
		Console.WriteLine("Give side a: ");
		double sideA = double.Parse(Console.ReadLine());
		Console.WriteLine("Give side b: ");
		double sideB = double.Parse(Console.ReadLine());
		Console.WriteLine($"The area of a rectangle = {RectangleArea(sideA, sideB):F2}");

		static double RectangleArea(double a, double b)
			=> a * b;
	}

	// Napisz program obliczający pole prostokąta. Powinien on zawierać jeden podprogram: bezparametrową funkcję pole_prostokata, w której zawarty będzie algorytm obliczania pola.
	// Wartości boków a i b wprowadzamy z klawiatury. Należy dla nich przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	public static void Exercise_5_2()
	{
		Console.WriteLine("The program calculates the area of a rectangle.");
		Console.WriteLine("Give side a: ");
		double sideA = double.Parse(Console.ReadLine());
		Console.WriteLine("Give side b: ");
		double sideB = double.Parse(Console.ReadLine());
		Console.WriteLine($"The area of a rectangle = {RectangleArea(sideA, sideB):F2}");

		static double RectangleArea(double a, double b)
			=> a * b;
	}

	// Napisz program obliczający pole prostokąta. Powinien on zawierać jeden podprogram: funkcję pole_prostokata(), do której parametry przekazywane są przez wartość.
	// Wartości boków a i b wprowadzamy z klawiatury. Należy dla nich przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	public static void Exercise_5_3()
	{
		Console.WriteLine("The program calculates the area of a rectangle.");
		Console.WriteLine("Give side a: ");
		double sideA = double.Parse(Console.ReadLine());
		Console.WriteLine("Give side b: ");
		double sideB = double.Parse(Console.ReadLine());
		Console.WriteLine($"The area of a rectangle = {RectangleArea(sideA, sideB):F2}");

		static double RectangleArea(double a, double b)
			=> a * b;
	}

	// Napisz program, który oblicza pole prostokąta. Powinien on zawierać trzy bezparametrowe funkcje: czytaj_dane(), przetworz_dane() oraz wyswietl_wynik().
	// Wartości boków a i b wprowadzamy z klawiatury. Należy dla nich przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	// Funkcja czytaj_dane() czyta wartości boków a i b, przetworz_dane() oblicza pole prostokąta, a wyswietl_wynik() prezentuje wyniki na ekranie komputera.
	public static void Exercise_5_4()
	{
		ReadData(out double sideA, out double sideB);
		ShowResult(RectangleArea(sideA, sideB));

		static void ReadData(out double x, out double y)
		{
			Console.WriteLine("The program calculates the area of a rectangle.");
			Console.WriteLine("Give side a: ");
			x = double.Parse(Console.ReadLine());
			Console.WriteLine("Give side b: ");
			y = double.Parse(Console.ReadLine());
		}

		static double RectangleArea(double a, double b)
			=> a * b;

		static void ShowResult(double result)
			=> Console.WriteLine($"The area of a rectangle = {result:F2}");
	}

	// Napisz program, który z wykorzystaniem instrukcji wyboru switch ... case oblicza pierwiastki równania kwadratowego ax2+bx+c = 0,
	// gdzie zmienne a, b oraz c to liczby rzeczywiste wprowadzane z klawiatury.
	// Dla zmiennych a, b, c, x1 oraz x2 należy przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	// Program powinien zawierać trzy bezparametrowe funkcje: czytaj_dane(), przetworz_dane()i wyswietl_wynik().
	public static void Exercise_5_5()
	{
		ReadData(out double a, out double b, out double c);
		(double x1, double x2) = DoCalculations(a, b, c, out int resultsCount);
		ShowResults(x1, x2, resultsCount);

		static void ReadData(out double a, out double b, out double c)
		{
			Console.Write("Give number 1: ");
			a = double.Parse(Console.ReadLine());
			if (a == 0)
			{
				Console.WriteLine("Error!");
				Console.ReadLine();
				Environment.Exit(1);
			}
			Console.Write("Give number 2: ");
			b = double.Parse(Console.ReadLine());
			Console.Write("Give number 3: ");
			c = double.Parse(Console.ReadLine());
		}

		static (double, double) DoCalculations(double a, double b, double c, out int resultsCount)
		{
			double delta = b * b - 4 * a * c;

			if (delta > 0)
			{
				resultsCount = 2;
				return ((-b - Math.Sqrt(delta)) / (2 * a), (-b + Math.Sqrt(delta)) / (2 * a));
			}
			else if (delta == 0)
			{
				resultsCount = 1;
				return ((-b) / (2 * a), 0);
			}
			else
			{
				resultsCount = 0;
				return (0, 0);
			}
		}

		static void ShowResults(double x1, double x2, int resultsCount)
		{
			switch (resultsCount)
			{
				case 2:
					Console.WriteLine($"X1 = {x1}  X2 = {x2}");
					break;
				case 1:
					Console.WriteLine($"X1 = {x1}");
					break;
				case 0:
					Console.WriteLine("No results");
					break;
				default:
					break;
			}
		}
	}

	// Napisz program, który w tablicy 10×10 umieszcza losowo na przekątnej cyfry od 0 do 9, a poza nią zera.
	// Dodatkowo oblicza on sumę liczb znajdujących się na przekątnej.
	// Program powinien zawierać trzy bezparametrowe funkcje: czytaj_dane(), przetworz_dane() i wyswietl_wynik().
	// Funkcja czytaj_dane() umieszcza dane w tablicy, przetworz_dane() oblicza sumę liczb znajdujących się na przekątnej,
	// natomiast funkcja wyswietl_wynik() prezentuje zawartość tablicy na ekranie monitora.
	public static void Exercise_5_6()
	{
		const int size = 10;
		int[,] numbers = new int[size, size];
		PopulateArray(numbers);
		ShowArray(numbers);
		CountSum(numbers);

		static void PopulateArray(int[,] numbers)
		{
			Random random = new();
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					if (i == j)
					{
						numbers[i, j] = random.Next(10);
					}
				}
			}
		}

		static void ShowArray(int[,] numbers)
		{
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					Console.Write(numbers[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		static void CountSum(int[,] numbers)
		{
			int sum = 0;
			for (int i = 0; i < numbers.GetLength(0); i++)
			{
				for (int j = 0; j < numbers.GetLength(1); j++)
				{
					if (i == j)
					{
						sum += numbers[i, j];
					}
				}
			}
			Console.WriteLine($"Sum = {sum}");
		}
	}

	// Napisz program, który sortuje n liczb wczytanych z klawiatury (w zadaniu jest ich sześć).
	// Powinien on zawierać trzy bezparametrowe funkcje: czytaj_dane(), przetworz_dane() i wyswietl_wynik().
	// Funkcja czytaj_dane() czyta dane wprowadzone z klawiatury i umieszcza je w tablicy o nazwie liczby.
	// Funkcja przetworz_dane() sortuje je według wybranego algorytmu (w programie należy zastosować algorytm sortowania bąbelkowego).
	// Funkcja wyswietl_wynik() prezentuje natomiast zawartość posortowanej tablicy liczby na ekranie monitora.
	public static void Exercise_5_7()
	{
		const int size = 6;
		int[] numbers = new int[size];
		PopulateArray(numbers);
		ShowArray(numbers);
		SortArray(numbers);
		Console.WriteLine();
		ShowArray(numbers);

		static void PopulateArray(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write($"Number {i + 1}: ");
				numbers[i] = int.Parse(Console.ReadLine());
			}
		}

		static void ShowArray(int[] numbers)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
		}

		static void SortArray(int[] numbers)
		{
			for (int i = 1; i < numbers.Length; i++)
			{
				for (int j = numbers.Length - 1; j >= i; j--)
				{
					if (numbers[j - 1] > numbers[j])
					{
						(numbers[j - 1], numbers[j]) = (numbers[j], numbers[j - 1]);
					}
				}
			}
		}
	}

	// Napisz program, który losuje n liczb całkowitych (w zadaniu n = 10) z przedziału od 0 do 99, a następnie znajduje najmniejszą i największą z nich.
	// Powinien on zawierać trzy bezparametrowe funkcje: czytaj_dane(), przetworz_dane() i wyswietl_ wynik().
	// Funkcja czytaj_dane() losuje n całkowitych liczb od 0 do 99. przetworz_dane() porównuje je ze sobą i ustala, która z nich jest najmniejsza oraz największa.
	// Funkcja wyswietl_wynik() prezentuje natomiast największą i najmniejszą liczbę z wylosowanego zbioru.
	public static void Exercise_5_8()
	{
		const int size = 10;
		int[] numbers = new int[size];
		PopulateArray(numbers);
		DoCalculations(numbers, out int min, out int max);
		ShowResult(numbers, min, max);

		static void PopulateArray(int[] numbers)
		{
			Random random = new();
			for (int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = random.Next(100);
			}
		}

		static void DoCalculations(int[] numbers, out int min, out int max)
		{
			min = max = numbers[0];
			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] < min)
				{
					min = numbers[i];
				}
				if (numbers[i] > max)
				{
					max = numbers[i];
				}
			}
		}

		static void ShowResult(int[] numbers, int min, int max)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.Write(numbers[i] + " ");
			}
			Console.WriteLine($"\nMin = {min}\nMax = {max}");
		}
	}

	// Napisz program, który dla x zmieniającego się od 0 do 5 z krokiem 0,5 oblicza wartość funkcji y = x2+1.
	public static void Exercise_5_9()
	{
		for (double i = 0; i <= 5; i += 0.5)
		{
			Console.WriteLine($"x = {i,5:F2} y = {Math.Pow(i, 2) + 1,5:F2}");
		}
	}

	#endregion Chapter_5

	#region Chapter_6

	// Napisz zgodnie z zasadami programowania obiektowego program, który oblicza pole prostokąta. Klasa powinna zawierać trzy metody:
	// czytaj_dane() — umożliwia wprowadzenie do programu wartości boków a i b z klawiatury.w programie należy przyjąć, że boki oraz zmienna pole są typu float (rzeczywistego).
	// przetworz_dane() — oblicza pole prostokąta według wzoru pole = a * b.
	// wyswietl_wynik() — wyświetla wartości boków a i b oraz zmiennej pole w określonym formacie.
	// Dla tych trzech zmiennych należy przyjąć format wyświetlania ich na ekranie z dwoma miejscami po kropce.
	public static void Exercise_6_1()
	{
		RectangleArea rectangleArea = new();
		rectangleArea.ReadData();
		rectangleArea.DoCalculations();
		rectangleArea.ShowResult();
	}

	private class RectangleArea
	{
		private double _a, _b, _area;

		public void ReadData()
		{
			Console.WriteLine("The program calculates the area of a rectangle.");
			Console.WriteLine("Give side a: ");
			_a = double.Parse(Console.ReadLine());
			Console.WriteLine("Give side b: ");
			_b = double.Parse(Console.ReadLine());
		}

		public void DoCalculations()
			=> _area = _a * _b;

		public void ShowResult()
			=> Console.WriteLine($"Rectangle area = {_area:F2}");
	}

	// Napisz zgodnie z zasadami programowania obiektowego program, który oblicza pierwiastki równania kwadratowego ax2+bx+c = 0 z wykorzystaniem instrukcji wyboru switch ... case.
	// Klasa powinna zawierać trzy metody:
	// czytaj_dane() — jest odpowiedzialna za wczytanie danych do programu oraz obsłużenie sytuacji, kiedy a = 0. Zmienne a, b oraz c to liczby rzeczywiste wprowadzane z klawiatury.
	// przetworz_dane() — odpowiada za wykonanie niezbędnych obliczeń.
	// wyswietl_wynik() — jest odpowiedzialna za pokazanie wyników na ekranie monitora.
	// Dla zmiennych a, b, c, x1 oraz x2 należy przyjąć format wyświetlania ich z dwoma miejscami po kropce.
	public static void Exercise_6_2()
	{
		Trinomial trinomial = new();
		trinomial.ReadData();
		trinomial.DoCalculations();
		trinomial.ShowResults();
	}

	private class Trinomial
	{
		private double _a, _b, _c, _x1, _x2;
		private int _resultsCount;

		public void ReadData()
		{
			Console.Write("Give number 1: ");
			_a = double.Parse(Console.ReadLine());
			if (_a == 0)
			{
				Console.WriteLine("Error!");
				Console.ReadLine();
				Environment.Exit(1);
			}
			Console.Write("Give number 2: ");
			_b = double.Parse(Console.ReadLine());
			Console.Write("Give number 3: ");
			_c = double.Parse(Console.ReadLine());
		}

		public void DoCalculations()
		{
			double delta = _b * _b - 4 * _a * _c;

			if (delta > 0)
			{
				_resultsCount = 2;
				_x1 = (-_b - Math.Sqrt(delta)) / (2 * _a);
				_x2 = (-_b + Math.Sqrt(delta)) / (2 * _a);
			}
			else if (delta == 0)
			{
				_resultsCount = 1;
				_x1 = (-_b) / (2 * _a);
				_x2 = 0;
			}
			else
			{
				_resultsCount = 0;
				_x1 = _x2 = 0;
			}
		}

		public void ShowResults()
		{
			switch (_resultsCount)
			{
				case 2:
					Console.WriteLine($"X1 = {_x1}  X2 = {_x2}");
					break;
				case 1:
					Console.WriteLine($"X1 = {_x1}");
					break;
				case 0:
					Console.WriteLine("No results");
					break;
				default:
					break;
			}
		}
	}

	#endregion Chapter_6

	#region Chapter_7

	// Napisz zgodnie z zasadami programowania obiektowego program, który wczytuje z klawiatury imię i nazwisko, zapisuje te dane do pliku tekstowego dane.txt,
	// a następnie odczytuje je z niego i wyświetla na ekranie komputera.
	// Klasa powinna zawierać trzy metody:
	// czytaj_dane() — wczytuje z klawiatury imię i nazwisko;
	// zapisz_dane_do_pliku() — zapisuje imię i nazwisko do pliku tekstowego dane.txt;
	// czytaj_dane_z_pliku() — odczytuje dane z pliku dane.txt i wyświetla je na ekranie komputera.
	public static void Exercise_7_1()
	{
		FileHelper fileHelper = new();
		fileHelper.ReadData();
		fileHelper.SaveData();
		fileHelper.ShowData();
	}

	private class FileHelper
	{
		private readonly string _path = Path.Combine(Environment.CurrentDirectory, "data.txt");

		private string _name;

		public void ReadData()
		{
			Console.WriteLine("Write your name and surname: ");
			_name = Console.ReadLine();
		}

		public void SaveData()
			=> File.WriteAllText(_path, _name);

		public void ShowData()
			=> Console.WriteLine(File.ReadAllText(_path));
	}

	// Napisz zgodnie z zasadami programowania obiektowego program, który tablicę 10×10 zapisuje do pliku tekstowego dane.txt,
	// a następnie zapisane dane odczytuje i wyświetla na ekranie komputera. Klasa powinna zawierać trzy metody:
	// czytaj_dane() — tworzy tablicę 10×10;
	// zapisz_dane_do_pliku() — zapisuje tablicę 10×10 do pliku tekstowego dane.txt;
	// czytaj_dane_z_pliku() — odczytuje tablicę 10×10 z pliku dane.txt i wyświetla ją na ekranie komputera.
	public static void Exercise_7_2()
	{
		FileHelperForArray fileHelper = new();
		fileHelper.ReadData();
		fileHelper.SaveData();
		fileHelper.ShowData();
	}

	private class FileHelperForArray
	{
		private const int Size = 10;
		private readonly string _path = Path.Combine(Environment.CurrentDirectory, "array1.txt");
		private int[,] _numbers;

		public void ReadData()
		{
			_numbers = new int[Size, Size];

			for (int i = 0; i < _numbers.GetLength(0); i++)
			{
				for (int j = 0; j < _numbers.GetLength(1); j++)
				{
					if (i == j)
					{
						_numbers[i, j] = i;
					}
				}
			}
		}

		public void SaveData()
		{
			StringBuilder textToSave = new();

			for (int i = 0; i < _numbers.GetLength(0); i++)
			{
				for (int j = 0; j < _numbers.GetLength(1); j++)
				{
					textToSave.Append(_numbers[i, j] + " ");
				}
				textToSave.Append(Environment.NewLine);
			}

			File.WriteAllText(_path, textToSave.ToString());
		}

		public void ShowData()
			=> Console.WriteLine(File.ReadAllText(_path));
	}

	// Napisz zgodnie z zasadami programowania obiektowego program, który tablicę a o wymiarach 10×10 przekształca w tablicę b i zapisuje wynik do pliku tekstowego dane.txt,
	// a następnie odczytuje z niego tablicę i wyświetla ją na ekranie. Klasa powinna zawierać cztery metody:
	// czytaj_dane() — tworzy tablicę a o wymiarach 10×10;
	// przetworz_dane() — przepisuje elementy tablicy a o wymiarach 10×10 do tablicy b o tej samej wielkości;
	// zapisz_dane_do_pliku() — zapisuje tablicę b o wymiarach 10×10 do pliku;
	// czytaj_dane_z_pliku() — odczytuje tablicę c o wymiarach 10×10 z pliku i wyświetla ją na ekranie.
	public static void Exercise_7_3()
	{
		FileHelperForArray2 fileHelper = new();
		fileHelper.ReadData();
		fileHelper.PrepareArrayToSave();
		fileHelper.SaveData();
		fileHelper.ShowData();
	}

	private class FileHelperForArray2
	{
		private const int Size = 10;
		private readonly string _path = Path.Combine(Environment.CurrentDirectory, "array2.txt");
		private int[,] _numbers, _numbersToSave, _numbersFromFile;

		public void ReadData()
		{
			_numbers = new int[Size, Size];

			for (int i = 0; i < _numbers.GetLength(0); i++)
			{
				for (int j = 0; j < _numbers.GetLength(1); j++)
				{
					if (i == j)
					{
						_numbers[i, j] = i;
					}
				}
			}
		}

		public void PrepareArrayToSave()
		{
			_numbersToSave = new int[Size, Size];
			for (int i = 0; i < _numbers.GetLength(0); i++)
			{
				for (int j = 0; j < _numbers.GetLength(1); j++)
				{
					if (i == j)
					{
						_numbersToSave[i, j] = _numbers[i, j];
					}
				}
			}
		}

		public void SaveData()
		{
			StringBuilder textToSave = new();

			for (int i = 0; i < _numbersToSave.GetLength(0); i++)
			{
				for (int j = 0; j < _numbersToSave.GetLength(1); j++)
				{
					textToSave.Append(_numbersToSave[i, j] + " ");
				}
				if (i < _numbersToSave.GetLength(0) - 1)
				{
					textToSave.Append(Environment.NewLine);
				}
			}

			File.WriteAllText(_path, textToSave.ToString());
		}

		public void ShowData()
		{
			_numbersFromFile = new int[Size, Size];

			var lines = File.ReadAllLines(_path);
			for (int i = 0; i < lines.Length; i++)
			{
				var numbers = lines[i].TrimEnd().Split(' ').Select(int.Parse).ToArray();
				for (int j = 0; j < numbers.Length; j++)
				{
					_numbersFromFile[i, j] = numbers[j];
				}
			}

			for (int i = 0; i < _numbersFromFile.GetLength(0); i++)
			{
				for (int j = 0; j < _numbersFromFile.GetLength(1); j++)
				{
					Console.Write(_numbersFromFile[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}

	#endregion Chapter_7
}