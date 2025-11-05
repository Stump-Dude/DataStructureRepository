// Please to test un-comment each exercise individually (sorry for the inconvenience)

#region Exercise 1

//int i = 0;

//void NaturalNumberRec(int n)
//{
//    if (i <= n)
//    {
//        Console.WriteLine(i);
//        i++;
//        NaturalNumberRec(n);
//    }
//    else
//        i = 0;
//}

//NaturalNumberRec(10);

#endregion

#region Exercise 2

//int[] x = [1, 4, 9, 16, 25];
//int y = 0, i = 0;

//void SumNumberRec(int[] x)
//{
//    if (i <= (x.Length - 1))
//    {
//        y += x[i];
//        i++;
//        SumNumberRec(x);
//    }
//    else
//        Console.WriteLine(y);
//}

//SumNumberRec(x);

#endregion

#region Exercise 3


//int x = 1, y = 0;

//void SumofNumbersFromOne(int n)
//{
//    if (x <= n)
//    {
//        y += x;
//        x++;
//        SumofNumbersFromOne(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//SumofNumbersFromOne(10);

#endregion

#region Exercise 4


//int i = -2;
//string drow = "";

//void Revers(string word)
//{
//    if (i == -2)
//    {
//        i = word.Length - 1;
//        Revers(word);
//    }
//    else if (i >= 0)
//    {
//        drow = drow + word[i];
//        i--;
//        Revers(word);
//    }
//    else
//        Console.WriteLine(drow);
//}

//Revers("hello");

#endregion

#region Exercise 5


//int i = 1, x = 1;
//void FacRecursion(int n)
//{
//    if (i <= n)
//    {
//        x *= i;
//        i++;
//        FacRecursion(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//FacRecursion(5);

#endregion

#region Exercise 6


//int i = 1, j = 1, x = 1;
//void FactorialRecursion(int n)
//{
//    if (j <= n)
//    {
//        if (i <= j)
//        {
//            x *= i;
//            i++;
//            FactorialRecursion(n);
//        }
//        else
//        {
//            i = 1;
//            j++;
//            FactorialRecursion(n);
//        }
//    }
//    else
//        Console.WriteLine(x);
//}

//FactorialRecursion(4);

#endregion

#region Exercise 7

//int[] x = [0, 0, 0, 1];
//int i = 0, y = 0;


//void TetanacciSequence(int n)
//{
//    if ((i + 1) <= (n - 4))
//    {
//        y = x[i] + x[i + 1] + x[i + 2] + x[i + 3];
//        x = x.Append(y).ToArray();
//        i++;
//        TetanacciSequence(n);
//    }
//    else
//        Console.WriteLine(y);
//}

//TetanacciSequence(10);


#endregion

#region Exercise 8

//int i = 1, x = 0;

//void RecursiveCubes(int n)
//{
//    if (i <= n)
//    {
//        x += (int)Math.Pow(i, 3);
//        i++;
//        RecursiveCubes(n);
//    }
//    else
//        Console.WriteLine(x);
//}

//RecursiveCubes(3);

#endregion