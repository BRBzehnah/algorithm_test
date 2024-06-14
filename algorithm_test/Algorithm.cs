using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace algorithm_test
{
    internal class Algorithm
    {
        static void ShowMessage(int firstOperand, double secondOperand, int answer, char exprOperator)
        {
            Console.WriteLine($"first operand is {firstOperand}\nsecond operand is {secondOperand}\nanswer is {answer}\nfinal expression is {firstOperand} {exprOperator} {secondOperand} = {answer}");
        }

        static void ShowErrorMesage(int firstOperand, int answer)
        {
            Console.WriteLine($"expression cannot be resolved with first operand is {firstOperand} and answer is {answer}");
        }


        static int JumpSearch(int firstOperand, int secondOperand, int searchingIndex)
        {
            while (secondOperand != searchingIndex)
            {
                if (searchingIndex - secondOperand <= 5 && searchingIndex - secondOperand >= 0)
                {
                    while (secondOperand != searchingIndex)
                    {
                        secondOperand++;
                    }
                }
                else if (searchingIndex - secondOperand >= -5 && searchingIndex -secondOperand <= 0)
                {
                    while (secondOperand != searchingIndex)
                    {
                        secondOperand--;
                    }
                }
                else
                    secondOperand += 10;
            }
            return secondOperand;
        }
        
        static int BinarySearch(int answer, int searchingIndex)
        {
            int firstThread = answer / 2;
            int secondThread = firstThread;
            while (firstThread != searchingIndex && secondThread != searchingIndex)
            {
                firstThread--;
                secondThread++;
            }

            if (firstThread == searchingIndex)
                return firstThread;
            else
                return secondThread;
        }

        static int DevideAndConquerSeacrh(int answer, int searchingIndex)
        {
            int firstThread = 0;
            int secondThread = answer / 4;
            int thirdThread = secondThread * 2;
            int fourthThread = secondThread * 3;
            while (firstThread != searchingIndex && secondThread != searchingIndex && thirdThread != searchingIndex && fourthThread != searchingIndex)
            {
                firstThread++;
                secondThread++;
                thirdThread++;
                fourthThread++;
            }

            if (firstThread == searchingIndex)
                return firstThread;
            else if (secondThread == searchingIndex)
                return secondThread;
            else if (thirdThread == searchingIndex)
                return thirdThread;
            else 
                return fourthThread;
        }


        static public void Linear(int answer, char exprOperator)
        {
            int firstOperand = new();
            int secondOperand = new();
            int searchingIndex = new();
            switch (exprOperator)
            {
                case '+':
                    firstOperand = new Random().Next(answer);
                    searchingIndex = answer - firstOperand;
                        while (secondOperand != searchingIndex)
                    {
                        secondOperand++;
                    }
                        ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    break;
                case '-':
                    firstOperand = new Random().Next(answer, answer + answer);
                    searchingIndex = (firstOperand - answer);
                        while (secondOperand != searchingIndex)
                    {
                        secondOperand++;
                    }
                        ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    break;
                case '*':
                    firstOperand = new Random().Next(1, answer);
                    searchingIndex = answer / firstOperand;
                        while (secondOperand != searchingIndex)
                    {
                        secondOperand++;
                    }
                        if (firstOperand * secondOperand != answer)
                    {
                        ShowErrorMesage(firstOperand, answer);
                    }
                        else
                        ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    break;
                case '/':
                    firstOperand = new Random().Next(answer, answer + answer);
                        if (answer == 0)
                            ShowErrorMesage(firstOperand, answer);
                        while (secondOperand != (firstOperand / answer))
                    {
                        secondOperand++;
                    }
                        if (firstOperand / secondOperand != answer)
                    {
                        ShowErrorMesage(firstOperand, answer);
                    }
                        else
                    {
                        ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    }
                    break;
                default:
                    Console.WriteLine("wrong value");
                    break;

            }
        }

        static public void Jump(int answer, char exprOperator)
        {
            int firstOperand = new();
            int secondOperand = new();
            int searchingIndex = new();
            switch (exprOperator)
            {
                case '+':
                    firstOperand = new Random().Next(answer);
                    searchingIndex = answer - firstOperand;
                        ShowMessage(firstOperand, JumpSearch(firstOperand, secondOperand, searchingIndex), answer, exprOperator);
                    break;
                case '-':
                    firstOperand = new Random().Next(answer, answer + answer);
                    searchingIndex = firstOperand - answer;
                        ShowMessage(firstOperand, JumpSearch(firstOperand, secondOperand, searchingIndex), answer, exprOperator);
                    break;
                case '*':
                    firstOperand = new Random().Next(1, answer);
                    searchingIndex = answer / firstOperand;
                        ShowMessage(firstOperand, JumpSearch(firstOperand, secondOperand, searchingIndex), answer, exprOperator);
                    break;
                case '/':
                    firstOperand = new Random().Next(answer, answer + answer);
                    if (firstOperand == 0)
                        firstOperand = 1;
                        ShowMessage(firstOperand, JumpSearch(firstOperand, secondOperand, searchingIndex), answer, exprOperator);
                    break;
                default:
                    Console.WriteLine("wrong value");
                    break;

            }
        }

        static public void BinarySearch(int answer, char exprOperator)
        {          
            int firstOperand = new();
            int searchingIndex = new();
                switch (exprOperator)
                {
                    case '+':
                        firstOperand = new Random().Next(answer);
                        searchingIndex = answer - firstOperand;                   
                            ShowMessage(firstOperand, BinarySearch(answer, searchingIndex), answer, exprOperator);
                        break;
                    case '-':
                        firstOperand = new Random().Next(answer, answer + answer);
                        searchingIndex = (firstOperand - answer);
                            ShowMessage(firstOperand, BinarySearch(answer, searchingIndex), answer, exprOperator);
                        break;
                    case '*':
                        firstOperand = new Random().Next(1, answer);
                        searchingIndex = answer / firstOperand;
                            ShowMessage(firstOperand, BinarySearch(answer, searchingIndex), answer, exprOperator);
                        break;
                    case '/':
                        firstOperand = new Random().Next(answer, answer + answer);
                        if (answer == 0)
                            ShowErrorMesage(firstOperand, answer);

                            ShowMessage(firstOperand, BinarySearch(answer, searchingIndex), answer, exprOperator);
                        break;
                    default:
                        Console.WriteLine("wrong value");
                        break;

                }
        }

        static public void DevideAndConquer(int answer, char exprOperator)
        {
            int firstOperand = new();
            int searchingIndex = new();
            switch (exprOperator)
            {
                case '+':
                    firstOperand = new Random().Next(answer);
                    searchingIndex = answer - firstOperand;
                    ShowMessage(firstOperand, DevideAndConquerSeacrh(answer, searchingIndex), answer, exprOperator);
                    break;
                case '-':
                    firstOperand = new Random().Next(answer, answer + answer);
                    searchingIndex = (firstOperand - answer);
                    ShowMessage(firstOperand, DevideAndConquerSeacrh(answer, searchingIndex), answer, exprOperator);
                    break;
                case '*':
                    firstOperand = new Random().Next(1, answer);
                    searchingIndex = answer / firstOperand;
                    ShowMessage(firstOperand, DevideAndConquerSeacrh(answer, searchingIndex), answer, exprOperator);
                    break;
                case '/':
                    firstOperand = new Random().Next(answer, answer + answer);
                    if (answer == 0)
                        ShowErrorMesage(firstOperand, answer);

                    ShowMessage(firstOperand, DevideAndConquerSeacrh(answer, searchingIndex), answer, exprOperator);
                    break;
                default:
                    Console.WriteLine("wrong value");
                    break;

            }
        }

    }
}
