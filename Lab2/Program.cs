using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(4, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        //program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false;

        // code here
        double r = 2;
        double b = Math.Abs(x * x + y * y - r * r);
        if (b <= 0.001) 
        {
            answer = true;
        }
        else 
        {
            Console.WriteLine(answer);
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if (y >= 0 && y + Math.Abs(x) <= 1)
        {
            answer = true;
        }
        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)
        {
            if (a > b) answer = a;
            else answer = b;
        }
        else
        {
            if (a < b) answer = a;
            else answer = b;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        if (a < b) answer = a;
        else answer = b;
        if (answer < c) answer = c;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) * Math.Sqrt(2) <= 2 * Math.Sqrt(r / Math.PI))
        {
            answer = true;
        }
        else
        {
            Console.WriteLine("false");
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        if (Math.Sqrt(s) >= 2 * Math.Sqrt(r / Math.PI))
        {
            answer = true;
        }
        else
        {
            Console.WriteLine("false");
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            answer = 1;
        }
        else
        {
            answer = Math.Abs(x);
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            answer = 0;
        }
        else
        {
            answer = x * x - 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1) 
            answer = 0;
        else if (x > -1 && x <= 0)
            answer = 1 + x;
        else
            answer = 1;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 1;
        }
        else if (x > -1 && x <= 1)
        {
            answer = x * -1;
        }
        else
        {
            answer = -1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            sum += x1;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(sum / n);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (Math.Pow(a - x1, 2) + Math.Pow(b - x2, 2) <= Math.Pow(r, 2)) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (x1 < 30) answer += 0.2;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (((x1 * x1 + x2 * x2) <= (r2 * r2)) && !((x1 * x1 + x2 * x2) < (r1 * r1))) answer += 1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (x1 <= norm) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            if ((x1 >= 0) && (x2 >= 0) && (x1 <= Math.PI) && (x2 <= Math.Sin(x1))) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0;
        int answer3 = 0;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (x1 == 0 || x2 == 0) System.Console.WriteLine("no");
            if (x1 > 0 && x2 > 0)
            {
                System.Console.WriteLine(1);
                answer1++;
            }
            if (x1 < 0 && x2 > 0) System.Console.WriteLine(2);
            if (x1 < 0 && x2 < 0)
            {
                System.Console.WriteLine(3);
                answer3++;
            }
            else System.Console.WriteLine(4);
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            if (Math.Sqrt(x1*x1 + x2*x2) < answerLength)
            {
                answerLength = Math.Sqrt(x1*x1 + x2*x2);
                answer = i;
            }
            answerLength = Math.Round(answerLength, 2);
        }
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        for (int i = 1; i <= n; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (x1 < answer) answer = x1;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int count1 = 0;
        int count2 = 0;
        for (int i = 1; i <= n * 4; i++)
        {
            double x1 = Convert.ToDouble((Console.ReadLine()));
            if (count1 == 4)
            {
                count1 = 0; 
                count2 = 0;
            }
            count1++;
            if (x1 == 2 || x1 == 3) count2++;
            if (count1 == 4 && count2 == 0) answer++;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double k = 0;
        int count1 = 0, count2 = 0;
        for (int i = 1; i <= n*4; i++)
        {
            double x1 = Convert.ToDouble(Console.ReadLine());
            if (count1 == 4)
            {
                count1 = 0;
                count2 = 0;
            }
            k += x1;
            count1++;
            if (x1 <= 2) count2++;
            if (count1 == 4 && count2 != 0) answer++;
        }
        avg = k / n / 4.0;
        Console.WriteLine(answer);
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0)
        {
            answer = 0;
            return answer;
        }
        switch (type)
        {
            case 0: answer = r*r; break;
            case 1: answer = Math.PI * (r * r); break;
            case 2: answer = Math.Sqrt(3)/4*(r * r); break;
            default: answer = 0; break;
        }
        answer = Math.Round(answer,2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0)
        {
            answer = 0;
        }
        else switch (type)
        {
            case 0: answer = A*B; break;
            case 1:
                if (A >= B) answer = Math.PI * (A * A) - Math.PI * (B * B);
                else answer = Math.PI * (B * B) - Math.PI * (A * A); break;
            case 2: answer = A/4*Math.Sqrt(4*(B*B)-A*A); break;
            default: answer = 0; break; 
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end

        return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here
        for (int i = 1; ; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), out double x1);
            if (check)
            {
                if (x1 < 30) 
                    answer += 0.2;
            }
            else 
                break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        for (int i = 1; ; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), out double x1);
            if (!check) 
                break;
            bool check2 = double.TryParse(Console.ReadLine(), out double x2);
            if (check2)
            {
                if ((x1 >= 0) && (x2 >= 0) && (x1 <= Math.PI) && (x2 <= Math.Sin(x1))) 
                    answer++;
            }
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;

        // code here

        // end

        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here
        for (int i = 1; ; i++)
        {
            bool check = double.TryParse(Console.ReadLine(), out double x1);
            if (check)
            {
                if (x1 < answer) 
                    answer = x1;
            }
            else break;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0;

        // code here;

        // end

        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}