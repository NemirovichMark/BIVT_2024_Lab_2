using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        //program.Task_2_4(5, 1, 2);
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
        int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= Math.Pow(10, -3))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
        }
        else
        {
            answer = false;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        if (a > 0)         
        {
            if (a > b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }

        }
        else
        {

            if (a < b)
            {
                answer = a;
            }
            else
            {
                answer = b;
            }
        }
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        double min;
        if (a < b)
            min = a;
        else
        {
            min = b;
        }
        if (min > c)
            return min;
        return c;

        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        double storona = Math.Sqrt(s);
        if (storona <= r)
            return true;

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
            answer = false;
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

        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;

        // code here
        if (x <= -1)
        {
            answer = 0;
        }
        else if (-1 < x && x <= 0)
        {
            answer = 1 + x;
        }
        else
        {
            answer = 1;
        }

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
        else if (-1 < x && x <= 1)
        {
            answer = -1 * x;
        }
        else if (x > 1)
        {
            answer = -1;
        }

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
            bool y = double.TryParse(Console.ReadLine(), out double rost);
            if (y == true)
            {
                sum = sum + rost;
            }
        }
        answer = sum / n;
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        for (int i = n; i > 0; i--)
        {
            double x, y;

            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());

            if (Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2)) <= r) answer++;
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        double weight;
        // code here
        for (int i = 1; i <= n; i++)
        {
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                answer += 0.2;
            }
        }

        // end
        Console.WriteLine(answer);

        return answer;

    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            if (x * x + y * y <= r2 * r2 && x * x + y * y >= r1 * r1) answer++;
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
            bool j = double.TryParse(Console.ReadLine(), out double p);
            if (j == true && p <= norm)
            {
                answer += 1;
            }

        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here
        double x;
        double y;
        for (int i = 1; i <= n; i++)
        {
            x = double.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine());
            if (x < 0 || x > Math.PI)
            {
                continue;
            }
            else if (x >= 0 && y >= 0 && y <= Math.Sin(x))
            {
                answer++;
            }
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
            bool g1 = double.TryParse(Console.ReadLine(), out double x);
            bool g2 = double.TryParse(Console.ReadLine(), out double y);
            if (g1 && g2 && x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine(1);
                    answer1 += 1;
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine(2);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine(3);
                    answer3 += 1;
                }
                else
                {
                    Console.WriteLine(4);
                }
            }
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
        double minres = 100000;
        int num = 0;
        for (int i = 0; i < n; i++)
        {
            double x = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double y = double.Parse(Console.ReadLine(), new CultureInfo("en-US"));
            double distance = Math.Sqrt(x * x + y * y);
            if (distance < minres)
            {
                minres = distance;
                num = i + 1;
            }
        }
        minres = Math.Round(minres, 2);
        Console.WriteLine(num);
        Console.WriteLine(minres);

        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;
        
        // code here
        double rez;
        for (int i = 1; i <= n; i++)
        {
            rez = double.Parse(Console.ReadLine());
            if (rez < answer)
            {
                answer = rez;
            }
        }

        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        int Count = 0;
        for (int i = 1; i <= n; i++)
        {
            bool g1 = double.TryParse(Console.ReadLine(), out double ozenka1);
            bool g2 = double.TryParse(Console.ReadLine(), out double ozenka2);
            bool g3 = double.TryParse(Console.ReadLine(), out double ozenka3);
            bool g4 = double.TryParse(Console.ReadLine(), out double ozenka4);

            if (g1 && g2 && g3 && g4)
            {
                if ((ozenka1 != 2 && ozenka2 != 2 && ozenka3 != 2 && ozenka4 != 2) && (ozenka1 != 3 && ozenka2 != 3 && ozenka3 != 3 && ozenka4 != 3))
                {
                    Count += 1;
                }

            }
        }
        answer = Count;

        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        int mark1;
        int mark2;
        int mark3;
        int mark4;
        for (int i = 1; i <= n; i++)
        {
            mark1 = int.Parse(Console.ReadLine());
            mark2 = int.Parse(Console.ReadLine());
            mark3 = int.Parse(Console.ReadLine());
            mark4 = int.Parse(Console.ReadLine());
            if (mark1 < 3 || mark2 < 3 || mark3 < 3 || mark4 < 3)
            {
                answer++;
            }
            avg += (mark1 + mark2 + mark3 + mark4);
        }
        avg /= n * 4;

        Console.WriteLine(answer);
        Console.WriteLine(avg);

        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        if (r <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = r * r;
                break;
            case 1:
                answer = Math.PI * r * r;
                break;
            case 2:
                answer = r * r * Math.Sqrt(3) / 4;
                break;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if (A <= 0 || B <= 0) return 0;
        switch (type)
        {
            case 0:
                answer = A * B;
                break;
            case 1:
                answer = Math.Abs(Math.PI * ((A * A) - (B * B)));
                break;
            case 2:
                answer = Math.Sqrt(B * B - (A * A / 4)) * 0.5 * A;
                break;
        }
        answer = Math.Round(answer, 2);
        System.Console.WriteLine(answer);

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
        while (true)
        {
            Console.WriteLine("Ââåäèòå start ÷òîáû íàéòè òî÷êó èëè stop ÷òîáû ïîëó÷èòü ðåçóëüòàò ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double distance = Math.Sqrt(Math.Pow(x - a, 2) + Math.Pow(y - b, 2));
                if (distance <= r)
                {
                    answer += 1;
                }
            }

        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

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
        while (true)
        {
            Console.WriteLine("Ââåäèòå start ÷òîáû çàïèñàòü ðåçóëüòàò èëè stop ÷òîáû ïîëó÷èòü ðåçóëüòàò ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                double result = double.Parse(Console.ReadLine());
                if (result <= norm)
                {
                    answer += 1;
                }
            }
        }
        Console.WriteLine(answer);

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here
        

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
        int uw = 0;
        // code here
        while (true)
        {
            Console.WriteLine("Ââåäèòå start ÷òîáû ââåñòè òî÷êè èëè stop ÷òîáû ïîëó÷èòü ðåçóëüòàò ");
            string start = Console.ReadLine();
            if (start == "stop") break;
            else if (start == "start")
            {
                uw++;
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                double dlina = Math.Sqrt(x * x + y * y);
                if (dlina < answerLength)
                {
                    answer = uw;
                    answerLength = dlina;
                }
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine($"{answer} \n{answerLength}");

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

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

        string end = "___";
        while (end != "end")
        {
            Console.WriteLine("Ввод оценок:");
            double fst_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double sec_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double thr_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));
            double for_m = double.Parse(System.Console.ReadLine(), new CultureInfo("en-US"));

            avg += fst_m + sec_m + thr_m + for_m;



            if (fst_m == 2 || sec_m == 2 || thr_m == 2 || for_m == 2) answer++;


            n++;
            Console.WriteLine("Конец? (Введите end)");
            end = System.Console.ReadLine();
        }

        Console.WriteLine(answer + " / " + n);
        avg /= n * 4;
        Console.WriteLine(avg);
        // end

        return (answer, avg);
    }
    #endregion
}