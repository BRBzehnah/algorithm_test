using System.Collections.Concurrent;

namespace algorithm_test
{
    internal class Program
    {
        static void ShowMessage(int firstOperand, double secondOperand, int answer, char exprOperator)
        {
            Console.WriteLine($"first operand is {firstOperand}\nsecond operand is {secondOperand}\nanswer is {answer}\nfinal expression is {firstOperand} {exprOperator} {secondOperand} = {answer}");
        }

        static void ShowErrorMesage(int firstOperand, int answer)
        {
            Console.WriteLine($"expression cannot be resolved with first operand is {firstOperand} and answer is {answer}");
        }

        static void LinearSearchOfMember(int answer, char exprOperator)
        {
            Random random = new Random();
            int firstOperand = new();
            int secondOperand = new();
            switch (exprOperator)
            {
                case '+':
                    firstOperand = random.Next(answer);
                    while (secondOperand != (answer - firstOperand))
                    {
                        secondOperand++;
                    }
                    ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    break;
                case '-':
                    firstOperand = random.Next(answer,answer+100);
                    while (secondOperand != (firstOperand - answer))
                    {
                        secondOperand++;
                    }
                    ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    break;
                case '*':
                    firstOperand = random.Next(answer);
                    if (firstOperand ==0)
                        firstOperand = 1;
                    while (secondOperand != (answer / firstOperand))
                    {
                        secondOperand++;
                    }
                        if (firstOperand * secondOperand != answer)
                    {
                        ShowErrorMesage(firstOperand, answer);
                    }
                        else
                    {
                        ShowMessage(firstOperand, secondOperand, answer, exprOperator);
                    }
                    break;
                case '/':
                    firstOperand = random.Next(answer,answer + 100);
                    if (firstOperand == 0)
                        firstOperand = 1;
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

        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                LinearSearchOfMember(42, '/');
                Console.WriteLine();
            }
        }
    }
}
