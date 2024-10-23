using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
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
        double r = 2;
        //Console.WriteLine("Ââåäèòå x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå y");
        //y = Convert.ToDouble(Console.ReadLine());
        if (Math.Abs((x * x) + (y * y) - (r * r)) <= 0.001)
        {
         
            answer = true;
            Console.WriteLine("òî÷êà ëåæèò íà îêðóæíîñòè");
        }
        else
        {
            answer = false;
             Console.WriteLine("òî÷êà íå ëåæèò íà îêðóæíîñòè");
        }
        // end

        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;

        // code here
        //Console.WriteLine("Ââåäèòå x");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå y");
        //y = Convert.ToDouble(Console.ReadLine());
        if ((y >= 0) && (y + Math.Abs(x) <= 1))
        {
            answer = true;
            Console.WriteLine("òî÷êà ïðèíàäëåæèò ôèãóðå");
        }
        else
        {
            answer = false;
            Console.WriteLine("òî÷êà íå ïðèíàäëåæèò ôèãóðå");   
        }

        // end

        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;

        // code here
        //Console.WriteLine("Ââåäèòå a");
        //x = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå b");
        //y = Convert.ToDouble(Console.ReadLine());
        double c;
        if (a > 0)
        {
            if (a > b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        else
        {
            if (a < b)
            {
                c = a;
            }
            else
            {
                c = b;
            }
        }
        answer = c;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;

        // code here
        //Console.WriteLine("Ââåäèòå a");
        //a = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå b");
        //b = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå c");
        //c = Convert.ToDouble(Console.ReadLine());
        double z, min_ab;
        if (a < b)
        {
            min_ab = a;
        }
        else
        {
            min_ab = b;
        }
        if (min_ab > c)
        {
            z = min_ab;
        }
        else
        {
            z = c;
        }
        answer = z;
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;

        // code here
        //Console.WriteLine("Ââåäèòå r");
        //r = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå s");
        //s = Convert.ToDouble(Console.ReadLine());
        double diagonal = Math.Sqrt(2 * s);
        double diametr = 2 * (Math.Sqrt(r / Math.PI));
        if (diagonal <= diametr)
        {
            answer = true;
            Console.WriteLine("êâàäðàò ïîìåñòèòñÿ â êðóã");
        }
        else
        {
            answer = false;
            Console.WriteLine("êâàäðàò íå ïîìåñòèòñÿ â êðóã");
        }
        // end

        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;

        // code here
        //Console.WriteLine("Ââåäèòå r");
        //r = Convert.ToDouble(Console.ReadLine());
        //Console.WriteLine("Ââåäèòå s");
        //s = Convert.ToDouble(Console.ReadLine());
        double diagonal = Math.Sqrt(s);
        double diametr = 2 * (Math.Sqrt(r / Math.PI));
        if (diametr <= diagonal)
        {
            answer = true;
            Console.WriteLine("êðóã ïîìåñòèòñÿ â êâàäðàòå");
        }
        else
        {
            answer = false;
            Console.WriteLine("êðóã íå ïîìåñòèòñÿ â êâàäðàòå");
        }
        // end

        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0, y = 0;

        // code here
        if (Math.Abs(x) > 1)
        {
            y = 1;
        }
        else
        {
            y = Math.Abs(x);
        }
        answer = y;
        Console.WriteLine($"{x,10:F2}  {y,10:F2}");
        // end

        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0, y = 0;

        // code here
        if (Math.Abs(x) >= 1)
        {
            y = 0;
        }
        else
        {
            y = x * x - 1;
        }
        answer = y;
        Console.WriteLine($"{x,10:F2}  {y,10:F2}");
        // end

        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0, y = 0;

        // code here
        if (x <= -1)
        {
            y = 0;
        }
        else if (-1 < x && x <= 0)
        {
            y = 1 + x;
        }
        else
        {
            y = 1;
        }
        answer = y;
        Console.WriteLine($"{x,10:F2}  {y,10:F2}");
        // end

        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0, y = 0;

        // code here
        if (x <= -1)
        {
            y = 1;
        }
        else if (-1 < x && x <= 1)
        {
            y = -x;
        }
        else
        {
            y = -1;
        }
        answer = y;
        Console.WriteLine($"{x,10:F2}  {y,10:F2}");
        // end

        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0;

        // code here
        double sr, r, s = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå ðîñò ó÷åíèêà");
            r = double.Parse(Console.ReadLine());
            s += r;
        }
        sr = s / n;
        answer = sr;
        Console.WriteLine(sr);
        // end

        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0;

        // code here
        double k = 0, x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ââåäèòå y");
            y = double.Parse(Console.ReadLine());
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                k++;
            }
        }
        Console.WriteLine($"Â êðóã ïîïàëî {k} òî÷åê èç {n}");
        // end

        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0;

        // code here
        double k = 0, weight;
        for (double i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå âåñ");
            weight = double.Parse(Console.ReadLine());
            if (weight < 30)
            {
                k += 200;
            }
        }
        Console.WriteLine($"ïîòðåáóåòñÿ {k} ëèòðîâ ìîëîêà äëÿ êëàññà èç {n} ó÷åíèêîâ");

        // end

        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0;

        // code here
        double k = 0, x, y;
        for (double i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ââåäèòå y");
            y = double.Parse(Console.ReadLine());
            if (Math.Abs(x * x + y * y) >= r1 * r1 && (Math.Abs(x * x + y * y) <= r2 * r2))
            {
                k++;
            }
        }
        Console.WriteLine($"â êîëüöî ïîïàäàåò {k} òî÷åê èç {n}");
        // end

        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0;
        double k = 0, res;

        // code here
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ââåäèòå ðåçóëüòàò ó÷àñòíèêà");
            res = double.Parse(Console.ReadLine());
            if (res <= norm)
            {
                k++;
            }
        }
        Console.WriteLine(k);
        // end

        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;

        // code here

        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ââåäèòå y");
            y = double.Parse(Console.ReadLine());
            if ((x >= 0) && (x <= Math.PI) && (y <= Math.Sin(x)))
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
        double x, y;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ââåäèòå y");
            y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("òî÷êà ëåæèò â 1-ì êâàäðàíòå");
                answer1++;
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("òî÷êà ëåæèò âo 2-ì êâàäðàíòå");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("òî÷êà ëåæèò â 3-ì êâàäðàíòå");
                answer3++;
            }
            if (x > 0 && y < 0)
            {
                Console.WriteLine("òî÷êà ëåæèò â 4-ì êâàäðàíòå");
            }
        }
        Console.WriteLine($"êîëè÷åñòâî òî÷åê â 1-ì êâàäðàíòå = {answer1}, êîëè÷åñòâî òî÷åê â 3-ì êâàäðàíòå = {answer3}");
        // end

        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0;
        double answerLength = double.MaxValue;
        double x, y;

        // code here
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ââåäèòå y");
            y = Convert.ToDouble(Console.ReadLine());

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"íîìåð òî÷êè = {answer}, âåëè÷èíà ðàññòîÿíèÿ = {answerLength:F2}");
        // end

        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue;

        // code here
        double res;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå ðåçóëüòàò");
            res = Convert.ToDouble(Console.ReadLine());
            if (res < answer)
            {
                answer = res;
            }
        }
        Console.WriteLine($"ëó÷øûé ðåçóëüòàò = {answer}");
        // end

        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0;

        // code here;
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå îöåíêè");
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if(mark1 > 3 && mark2 > 3 && mark3 > 3 && mark4 > 3)
            {
                answer++;
            }

        }
        Console.WriteLine($"÷èñëî ñòóäåíòîâ, íå èìåþùèõ «2» è «3» = {answer}");
        // end

        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0;
        double avg = 0.0;

        // code here;
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        double summa = 0, k = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Ââåäèòå îöåíêè");
            mark1 = double.Parse(Console.ReadLine());
            mark2 = double.Parse(Console.ReadLine());
            mark3 = double.Parse(Console.ReadLine());
            mark4 = double.Parse(Console.ReadLine());
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
            summa += mark1 + mark2 + mark3 + mark4;
            k += 4;
        }
        avg = summa / k;
        Console.WriteLine($"êîëè÷åñòâî íåóñïåâàþùèõ ñòóäåíòîâ = {answer},  ñðåäíèé áàëë ãðóïïû = {avg}");
        // end

        return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;

        // code here;
        
        if (r > 0)
        {
            switch (type)
            {
                case 0:
                    answer = Math.Round(r * r, 2);
                    Console.WriteLine("ïëîùàäü êâàäðàòà");
                    break;
                case 1:
                    answer = Math.Round(Math.PI * r * r, 2);
                    Console.WriteLine("ïëîùàäü êðóãà");
                    break;
                case 2:
                    answer = Math.Round((Math.Sqrt(3) * r * r) / 4, 2);
                    Console.WriteLine("ïëîùàäü ðàâíîñòîðîííåãî òðåóãîëüíèêà");
                    break;
            }
        }
        else
        {
            answer = 0;
        }
        Console.WriteLine(answer);
        // end

        return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;

        // code here;
        if ((A <= 0) || (B <= 0)) return 0;
        {
            switch (type)
            {
                case 0:
                    answer = A * B;
                    Console.WriteLine("ïëîùàäü ïðÿìîóãîëüíèêà");
                    break;
                case 1:
                    answer = Math.Abs(Math.PI * A * A - Math.PI * B * B);
                    Console.WriteLine("ïëîùàäü êîëüöà");
                    break;
                case 2:
                    answer = Math.Sqrt(B * B - A * A / 4) * A / 2;
                    Console.WriteLine("ïëîùàäü ðàâíîáåäðåííîãî òðåóãîëüíèêà");
                    break;
            }
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
        bool stop = false;
        double k = 0, x, y;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("Ââåäèòå y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop)
            {
                break;
            }
            if (((x - a) * (x - a) + (y - b) * (y - b)) <= r * r)
            {
                k++;
            }
        }
        Console.WriteLine($"Â êðóã ïîïàëî {k} òî÷åê");
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
        bool stop = false;
        int answer = 0;
        double res = 0, k = 0;
        
        // code here
        for (int i = 1; ; i++)
        {
            Console.WriteLine("Ââåäèòå ðåçóëüòàò ó÷àñòíèêà");
            stop = !double.TryParse(Console.ReadLine(), out res);
            if (stop)
            {
                break;
            }
            if (res <= norm)
            {
                k++;
            }
        }
        Console.WriteLine(k);
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
        bool stop = false;
        int answer = 0, n = 0;
        double x, y;
        double answerLength = double.MaxValue;

        // code here
        for (int i = 1; ; i++)
        {
            Console.WriteLine("Ââåäèòå x");
            stop = !double.TryParse(Console.ReadLine(), out x);
            if (stop)
            {
                break;
            }
            Console.WriteLine("Ââåäèòå y");
            stop = !double.TryParse(Console.ReadLine(), out y);
            if (stop)
            {
                break;
            }

            double l = Math.Sqrt(x * x + y * y);
            if (l < answerLength)
            {
                answer = i;
                answerLength = l;
            }
        }
        Console.WriteLine($"íîìåð òî÷êè = {answer}, âåëè÷èíà ðàññòîÿíèÿ = {answerLength:F2}");
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
        bool stop = false;
        double mark1 = 0, mark2 = 0, mark3 = 0, mark4 = 0;
        double summa = 0, k = 0;
        for (int i = 1; ; i++)
        {
            Console.WriteLine("Ââåäèòå îöåíêè");
            stop = !double.TryParse(Console.ReadLine(), out mark1);
            stop = !double.TryParse(Console.ReadLine(), out mark2);
            stop = !double.TryParse(Console.ReadLine(), out mark3);
            stop = !double.TryParse(Console.ReadLine(), out mark4);
            if (stop)
            {
                break;
            }
            if (mark1 == 2 || mark2 == 2 || mark3 == 2 || mark4 == 2)
            {
                answer++;
            }
            summa += mark1 + mark2 + mark3 + mark4;
            k += 4;
        }
        avg = summa / k;
        Console.WriteLine($"êîëè÷åñòâî íåóñïåâàþùèõ ñòóäåíòîâ = {answer},  ñðåäíèé áàëë ãðóïïû = {avg}");
        // end

        return (answer, avg);
    }
    #endregion
}
