using System;
using System.Collections;
using System.Collections.Generic;

namespace RpnCalculator
{
    class Program
    {
        //args is an array of strings

        static void Main(string[] args)
        {
            {
                var stack = new Stack<int>();
                foreach (var arg in args)
                {

                    switch (arg.Substring(0, 1))
                    {

                        //our domain is any string or numbers, two ways to process, if you are throwing most away, look for what you 
                        //want to process using + - * / ....can't use an operator...big domain of what you might get coming into program,
                        //then focus on what you can use and throw the rest away
                        //but on a smaller domain, focus on what you can work with and throw the rest away....
                        //we can use it if it is one of our characters or an operator
                        //o, 1 means just get the first character of our arguement


                        case "+":

                            var op1 = stack.Pop();
                            var op2 = stack.Pop();
                            var ans = op1 + op2;
                            stack.Push(ans);
                            break;

                        case "-":
                            op1 = stack.Pop();
                            op2 = stack.Pop();
                            ans = op1 - op2;
                            stack.Push(ans);
                            break;

                        case "*":
                            op1 = stack.Pop();
                            op2 = stack.Pop();
                            ans = op1 * op2;
                            stack.Push(ans);
                            break;

                        case "/":
                            op1 = stack.Pop();
                            op2 = stack.Pop();
                            ans = op1 / op2;
                            stack.Push(ans);
                            break;

                        //process the operator

                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                            //convert to integer
                            //method call
                            int i;
                            var converted = int.TryParse(arg, out i);
                            if (!converted) continue;
                            stack.Push(i);
                            break;
                        default:
                            //throw it away
                            break;
                    }
                }


                var ans1 = stack.Pop();
                Console.WriteLine($"{ans1}");
            }
        }

    }
}