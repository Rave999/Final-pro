using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Numerics;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

public class weirdKeyboard
{
    public static void Main(string[] args)
    {
        int m1 = 0;
        int n1 = 0;
        int b1 = 0;
        int v1 = 0;
        int c1 = 0;
        int x1 = 0;
        int z1 = 0;
        int l1 = 0;
        int k1 = 0;
        int j1 = 0;
        int h1 = 0;
        int g1 = 0;
        int f1 = 0;
        int d1 = 0;
        int s1 = 0;
        int a1 = 0;
        int p1 = 0;
        int o1 = 0;
        int i1 = 0;
        int u1 = 0;
        int y1 = 0;
        int t1 = 0;
        int r1 = 0;
        int e1 = 0;
        int w1 = 0;
        int q1 = 0;

        int word1 = 0;
        int word2 = 0;
        int word3 = 0;
        int word4 = 0;

        ConsoleKeyInfo keyinfo;
        Console.WriteLine("Hello! Welcome to the spelling test. If you would like to participate in it press | s |. If you are here for the math test please press | m |");
        string yo = Console.ReadLine();
        if (yo == "s")
        {

            Console.WriteLine("Your objective is to spell the word | hi | You must do this with no other letters on the screen. If you mess up press backspace to reset. Good luck!");
            do

            {
                keyinfo = Console.ReadKey();
                if (keyinfo.Key == ConsoleKey.Q)
                {
                    m1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("m");

                }
                if (keyinfo.Key == ConsoleKey.W)
                {
                    n1 = 1;
                    g1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("n");
                }
                if (keyinfo.Key == ConsoleKey.E)
                {
                    b1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("b");
                }
                if (keyinfo.Key == ConsoleKey.R)
                {
                    v1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("v");
                }
                if (keyinfo.Key == ConsoleKey.T)
                {
                    c1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("c");
                }
                if (keyinfo.Key == ConsoleKey.Y)
                {
                    x1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("x");
                }
                if (keyinfo.Key == ConsoleKey.U)
                {
                    z1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("z");
                }
                if (keyinfo.Key == ConsoleKey.I)
                {
                    l1 = 1;
                    o1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("l");
                }
                if (keyinfo.Key == ConsoleKey.O)
                {
                    k1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("k");
                }
                if (keyinfo.Key == ConsoleKey.P)
                {
                    j1 = 1;
                    o1 += 1;

                    Console.Write("\b");
                    Console.WriteLine("j");
                }
                if (keyinfo.Key == ConsoleKey.A)
                {
                    h1 = 1;
                    i1 += 1;

                    Console.Write("\b");
                    Console.WriteLine("h");
                }
                if (keyinfo.Key == ConsoleKey.S)
                {
                    g1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("g");
                }
                if (keyinfo.Key == ConsoleKey.D)
                {
                    f1 = 1;
                    t1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("f");
                }
                if (keyinfo.Key == ConsoleKey.F)
                {
                    d1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("d");
                }
                if (keyinfo.Key == ConsoleKey.G)
                {
                    s1 = 1;
                    t1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("s");
                }
                if (keyinfo.Key == ConsoleKey.H)
                {
                    a1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("a");
                }
                if (keyinfo.Key == ConsoleKey.J)
                {
                    p1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("p");
                }
                if (keyinfo.Key == ConsoleKey.K)
                {
                    o1 = 1;
                    b1 += 1;
                    f1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("o");
                }
                if (keyinfo.Key == ConsoleKey.L)
                {
                    i1 = 1;
                    n1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("i");
                }
                if (keyinfo.Key == ConsoleKey.Z)
                {
                    u1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("u");
                }
                if (keyinfo.Key == ConsoleKey.X)
                {
                    y1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("y");
                }
                if (keyinfo.Key == ConsoleKey.C)
                {
                    t1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("t");
                }
                if (keyinfo.Key == ConsoleKey.V)
                {
                    r1 = 1;
                    i1 += 1;
                    Console.Write("\b");
                    Console.WriteLine("r");
                }
                if (keyinfo.Key == ConsoleKey.B)
                {
                    e1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("e");
                }
                if (keyinfo.Key == ConsoleKey.N)
                {
                    w1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("w");
                }
                if (keyinfo.Key == ConsoleKey.M)
                {
                    q1 = 1;
                    Console.Write("\b");
                    Console.WriteLine("q");
                }
                if (keyinfo.Key == ConsoleKey.Backspace)
                {
                    Console.WriteLine("Successful reset!");
                    m1 = 0;
                    n1 = 0;
                    b1 = 0;
                    v1 = 0;
                    c1 = 0;
                    x1 = 0;
                    z1 = 0;
                    l1 = 0;
                    k1 = 0;
                    j1 = 0;
                    h1 = 0;
                    g1 = 0;
                    f1 = 0;
                    d1 = 0;
                    s1 = 0;
                    a1 = 0;
                    p1 = 0;
                    o1 = 0;
                    i1 = 0;
                    u1 = 0;
                    y1 = 0;
                    t1 = 0;
                    r1 = 0;
                    e1 = 0;
                    w1 = 0;
                    q1 = 0;

                }
                
                if (keyinfo.Key == ConsoleKey.Enter && h1 == 1 && i1 == 1 && n1 == 1 && q1 + w1 + e1 + r1 + t1 + y1 + u1 + o1 + p1 + a1 + s1 + d1 + f1 + g1 + j1 + k1 + l1 + z1 + x1 + c1 + v1 + b1 + m1 == 0)
                {

                    Console.WriteLine("Good job on completing the first word! Now try spelling | job |");
                    word1 = 1;

                    m1 = 0;
                    n1 = 0;
                    b1 = 0;
                    v1 = 0;
                    c1 = 0;
                    x1 = 0;
                    z1 = 0;
                    l1 = 0;
                    k1 = 0;
                    j1 = 0;
                    h1 = 0;
                    g1 = 0;
                    f1 = 0;
                    d1 = 0;
                    s1 = 0;
                    a1 = 0;
                    p1 = 0;
                    o1 = 0;
                    i1 = 0;
                    u1 = 0;
                    y1 = 0;
                    t1 = 0;
                    r1 = 0;
                    e1 = 0;
                    w1 = 0;
                    q1 = 0;

                }
                
                if (keyinfo.Key == ConsoleKey.Enter && word1 == 1 && j1 == 1 && o1 == 1 && b1 == 1 && f1 == 1 && l1 + t1 + h1 + q1 + w1 + e1 + r1 + y1 + u1 + p1 + a1 + s1 + d1 + g1 + k1 + z1 + x1 + c1 + v1 + n1 + m1 == 0)
                {
                    Console.WriteLine("Good Job on completing the second word! Now try spelling | loft |");
                    word2 = 1;

                    m1 = 0;
                    n1 = 0;
                    b1 = 0;
                    v1 = 0;
                    c1 = 0;
                    x1 = 0;
                    z1 = 0;
                    l1 = 0;
                    k1 = 0;
                    j1 = 0;
                    h1 = 0;
                    g1 = 0;
                    f1 = 0;
                    d1 = 0;
                    s1 = 0;
                    a1 = 0;
                    p1 = 0;
                    o1 = 0;
                    i1 = 0;
                    u1 = 0;
                    y1 = 0;
                    t1 = 0;
                    r1 = 0;
                    e1 = 0;
                    w1 = 0;
                    q1 = 0;
                }
                
                if (keyinfo.Key == ConsoleKey.Enter && word1 == 1 && word2 == 1 && l1 == 1 && o1 == 1 && f1 == 1 && t1 == 1 && b1 == 1 && h1 + q1 + w1 + e1 + r1 + y1 + u1 + p1 + a1 + s1 + d1 + g1 + j1 + k1 + z1 + x1 + c1 + v1 + n1 + m1 == 0)
                {
                    Console.WriteLine("Good Job on completing the third word! You have completed the spelling test. If you want to truly test your spelling skills try spelling the bonus word | string |");
                    word3 = 1;

                    m1 = 0;
                    n1 = 0;
                    b1 = 0;
                    v1 = 0;
                    c1 = 0;
                    x1 = 0;
                    z1 = 0;
                    l1 = 0;
                    k1 = 0;
                    j1 = 0;
                    h1 = 0;
                    g1 = 0;
                    f1 = 0;
                    d1 = 0;
                    s1 = 0;
                    a1 = 0;
                    p1 = 0;
                    o1 = 0;
                    i1 = 0;
                    u1 = 0;
                    y1 = 0;
                    t1 = 0;
                    r1 = 0;
                    e1 = 0;
                    w1 = 0;
                    q1 = 0;
                }
                
                if (keyinfo.Key == ConsoleKey.Enter && word1 == 1 && word2 == 1 && word3 == 1 && s1 == 1 && t1 == 1 && r1 == 1 && i1 == 1 && n1 == 1 && g1 == 1 && z1 + x1 + c1 + v1 + b1 + m1 + a1 + d1 + f1 + h1 + j1 + k1 + l1 + q1 + w1 + e1 + y1 + u1 + o1 + p1 == 0)
                {
                    Console.WriteLine("Good job on completing the bonus word! That was all I have for you to spell.");
                    word4 = 1;

                    m1 = 0;
                    n1 = 0;
                    b1 = 0;
                    v1 = 0;
                    c1 = 0;
                    x1 = 0;
                    z1 = 0;
                    l1 = 0;
                    k1 = 0;
                    j1 = 0;
                    h1 = 0;
                    g1 = 0;
                    f1 = 0;
                    d1 = 0;
                    s1 = 0;
                    a1 = 0;
                    p1 = 0;
                    o1 = 0;
                    i1 = 0;
                    u1 = 0;
                    y1 = 0;
                    t1 = 0;
                    r1 = 0;
                    e1 = 0;
                    w1 = 0;
                    q1 = 0;
                }
                if (word1 == 1 && word2 == 1 && word3 == 1 && word4 == 1)
                {
                    Environment.Exit(0);
                }
                
            }
            while (keyinfo.Key != ConsoleKey.Escape);
        }
        else if (yo == "m")
        {
            int math1 = 0;
            int math2 = 0;
            int math3 = 0;

            float f = 3.5f;
            Console.WriteLine("What is 5-1.5");
            string d = Console.ReadLine();
            if (d == "3.5")
            {
                Console.WriteLine("You got the anwser " + f + " correct!");
                math1 = 1;
            }
            if (math1 == 1)
            {
                Console.WriteLine("What is 4+2(32)");
                math2 = 1;
                string w = Console.ReadLine();
                if (w == "68" && math2 == 1)
                {
                    Console.WriteLine("What is 9+9(4+54*787)");
                    math3 = 1;
                    string ll = Console.ReadLine();
                    if (ll == "382527" && math3 == 1)
                    {
                        Console.WriteLine("Good job on completing the math test! That is all I have for you.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Incorrect. You are dumb don't even think about trying again.");
            }
            
            /*Console.WriteLine("");
            {


               for (int i = 0; i < 1; i++) 
               {
                   Random random = new Random();
                   int LL1 = (random.Next(1, 26 + 1));
                   int LL2 = (random.Next(1, 26 + 1));
                   int LL3 = (random.Next(1, 26 + 1));
                   int LL4 = (random.Next(1, 26 + 1));
                   int LL5 = (random.Next(1, 26 + 1));
                   int LL6 = (random.Next(1, 26 + 1));

                   Console.WriteLine(LL1);
                   Console.WriteLine(LL2);
                   Console.WriteLine(LL3);
                   Console.WriteLine(LL4);
                   Console.WriteLine(LL5);
                   Console.WriteLine(LL6);

                   int a = 0;
                   int b = 0;
                   int c = 0;
                   int d = 0;
                   int e = 0;
                   int f = 0;
                   int g = 0;
                   int h = 0;
                   int ii = 0;
                   int j = 0;
                   int k = 0;
                   int l = 0;
                   int m = 0;
                   int n = 0;
                   int o = 0;
                   int p = 0;
                   int q = 0;
                   int r = 0;
                   int s = 0;
                   int t = 0;
                   int u = 0;
                   int v = 0;
                   int w = 0;
                   int x = 0;
                   int y = 0;
                   int z = 0;

                   if (LL1 == 1)
                   {
                       a = 1;
                   }
                   if (LL1 == 2)
                   {
                       b = 1;
                   }
                   if (LL1 == 3)
                   {
                       c = 1;
                   }
                   if (LL1 == 4)
                   {
                       d = 1;
                   }
                   if (LL1 == 5)
                   {
                       e = 1;
                   }
                   if (LL1 == 6)
                   {
                       f = 1;
                   }
                   if (LL1 == 7)
                   {
                       g = 1;
                   }
                   if (LL1 == 8)
                   {
                       h = 1;
                   }
                   if (LL1 == 9)
                   {
                       ii = 1;
                   }
                   if (LL1 == 10)
                   {
                       j = 1;
                   }
                   if (LL1 == 11)
                   {
                       k = 1;
                   }
                   if (LL1 == 12)
                   {
                       l = 1;
                   }
                   if (LL1 == 13)
                   {
                       m = 1;
                   }
                   if (LL1 == 14)
                   {
                       n = 1;
                   }
                   if (LL1 == 15)
                   {
                       o = 1;
                   }
                   if (LL1 == 16)
                   {
                       p = 1;
                   }
                   if (LL1 == 17)
                   {
                       q = 1;
                   }
                   if (LL1 == 18)
                   {
                       r = 1;
                   }
                   if (LL1 == 19)
                   {
                       s = 1;
                   }
                   if (LL1 == 20)
                   {
                       t = 1;
                   }
                   if (LL1 == 21)
                   {
                       u = 1;
                   }
                   if (LL1 == 22)
                   {
                       v = 1;
                   }
                   if (LL1 == 23)
                   {
                       w = 1;
                   }
                   if (LL1 == 24)
                   {
                       x = 1;
                   }
                   if (LL1 == 25)
                   {
                       y = 1;
                   }
                   if (LL1 == 26)
                   {
                       z = 1;
                   }

                   int aa = 0;
                   int bb = 0;
                   int cc = 0;
                   int dd = 0;
                   int ee = 0;
                   int ff = 0;
                   int gg = 0;
                   int hh = 0;
                   int iii = 0;
                   int jj = 0;
                   int kk = 0;
                   int ll = 0;
                   int mm = 0;
                   int nn = 0;
                   int oo = 0;
                   int pp = 0;
                   int qq = 0;
                   int rr = 0;
                   int ss = 0;
                   int tt = 0;
                   int uu = 0;
                   int vv = 0;
                   int ww = 0;
                   int xx = 0;
                   int yy = 0;
                   int zz = 0;

                   if (LL2 == 1)
                   {
                       aa = 1;
                   }
                   if (LL2 == 2)
                   {
                       bb = 1;
                   }
                   if (LL2 == 3)
                   {
                       cc = 1;
                   }
                   if (LL2 == 4)
                   {
                       dd = 1;
                   }
                   if (LL2 == 5)
                   {
                       ee = 1;
                   }
                   if (LL2 == 6)
                   {
                       ff = 1;
                   }
                   if (LL2 == 7)
                   {
                       gg = 1;
                   }
                   if (LL2 == 8)
                   {
                       hh = 1;
                   }
                   if (LL2 == 9)
                   {
                       iii = 1;
                   }
                   if (LL2 == 10)
                   {
                       jj = 1;
                   }
                   if (LL2 == 11)
                   {
                       kk = 1;
                   }
                   if (LL2 == 12)
                   {
                       ll = 1;
                   }
                   if (LL2 == 13)
                   {
                       mm = 1;
                   }
                   if (LL2 == 14)
                   {
                       nn = 1;
                   }
                   if (LL2 == 15)
                   {
                       oo = 1;
                   }
                   if (LL2 == 16)
                   {
                       pp = 1;
                   }
                   if (LL2 == 17)
                   {
                       qq = 1;
                   }
                   if (LL2 == 18)
                   {
                       rr = 1;
                   }
                   if (LL2 == 19)
                   {
                       ss = 1;
                   }
                   if (LL2 == 20)
                   {
                       tt = 1;
                   }
                   if (LL2 == 21)
                   {
                       uu = 1;
                   }
                   if (LL2 == 22)
                   {
                       vv = 1;
                   }
                   if (LL2 == 23)
                   {
                       ww = 1;
                   }
                   if (LL2 == 24)
                   {
                       xx = 1;
                   }
                   if (LL2 == 25)
                   {
                       yy = 1;
                   }
                   if (LL2 == 26)
                   {
                       zz = 1;
                   }

                   int aaa = 0;
                   int bbb = 0;
                   int ccc = 0;
                   int ddd = 0;
                   int eee = 0;
                   int fff = 0;
                   int ggg = 0;
                   int hhh = 0;
                   int iiii = 0;
                   int jjj = 0;
                   int kkk = 0;
                   int lll = 0;
                   int mmm = 0;
                   int nnn = 0;
                   int ooo = 0;
                   int ppp = 0;
                   int qqq = 0;
                   int rrr = 0;
                   int sss = 0;
                   int ttt = 0;
                   int uuu = 0;
                   int vvv = 0;
                   int www = 0;
                   int xxx = 0;
                   int yyy = 0;
                   int zzz = 0;

                   if (LL3 == 1)
                   {
                       aaa = 1;
                   }
                   if (LL3 == 2)
                   {
                       bbb = 1;
                   }
                   if (LL3 == 3)
                   {
                       ccc = 1;
                   }
                   if (LL3 == 4)
                   {
                       ddd = 1;
                   }
                   if (LL3 == 5)
                   {
                       eee = 1;
                   }
                   if (LL3 == 6)
                   {
                       fff = 1;
                   }
                   if (LL3 == 7)
                   {
                       ggg = 1;
                   }
                   if (LL3 == 8)
                   {
                       hhh = 1;
                   }
                   if (LL3 == 9)
                   {
                       iiii = 1;
                   }
                   if (LL3 == 10)
                   {
                       jjj = 1;
                   }
                   if (LL3 == 11)
                   {
                       kkk = 1;
                   }
                   if (LL3 == 12)
                   {
                       lll = 1;
                   }
                   if (LL3 == 13)
                   {
                       mmm = 1;
                   }
                   if (LL3 == 14)
                   {
                       nnn = 1;
                   }
                   if (LL3 == 15)
                   {
                       ooo = 1;
                   }
                   if (LL3 == 16)
                   {
                       ppp = 1;
                   }
                   if (LL3 == 17)
                   {
                       qqq = 1;
                   }
                   if (LL3 == 18)
                   {
                       rrr = 1;
                   }
                   if (LL3 == 19)
                   {
                       sss = 1;
                   }
                   if (LL3 == 20)
                   {
                       ttt = 1;
                   }
                   if (LL3 == 21)
                   {
                       uuu = 1;
                   }
                   if (LL3 == 22)
                   {
                       vvv = 1;
                   }
                   if (LL3 == 23)
                   {
                       www = 1;
                   }
                   if (LL3 == 24)
                   {
                       xxx = 1;
                   }
                   if (LL3 == 25)
                   {
                       yyy = 1;
                   }
                   if (LL3 == 26)
                   {
                       zzz = 1;
                   }

                   int aaaa = 0;
                   int bbbb = 0;
                   int cccc = 0;
                   int dddd = 0;
                   int eeee = 0;
                   int ffff = 0;
                   int gggg = 0;
                   int hhhh = 0;
                   int iiiii = 0;
                   int jjjj = 0;
                   int kkkk = 0;
                   int llll = 0;
                   int mmmm = 0;
                   int nnnn = 0;
                   int oooo = 0;
                   int pppp = 0;
                   int qqqq = 0;
                   int rrrr = 0;
                   int ssss = 0;
                   int tttt = 0;
                   int uuuu = 0;
                   int vvvv = 0;
                   int wwww = 0;
                   int xxxx = 0;
                   int yyyy = 0;
                   int zzzz = 0;

                   if (LL4 == 1)
                   {
                       aaaa = 1;
                   }
                   if (LL4 == 2)
                   {
                       bbbb = 1;
                   }
                   if (LL4 == 3)
                   {
                       cccc = 1;
                   }
                   if (LL4 == 4)
                   {
                       dddd = 1;
                   }
                   if (LL4 == 5)
                   {
                       eeee = 1;
                   }
                   if (LL4 == 6)
                   {
                       ffff = 1;
                   }
                   if (LL4 == 7)
                   {
                       gggg = 1;
                   }
                   if (LL4 == 8)
                   {
                       hhhh = 1;
                   }
                   if (LL4 == 9)
                   {
                       iiiii = 1;
                   }
                   if (LL4 == 10)
                   {
                       jjjj = 1;
                   }
                   if (LL4 == 11)
                   {
                       kkkk = 1;
                   }
                   if (LL4 == 12)
                   {
                       llll = 1;
                   }
                   if (LL4 == 13)
                   {
                       mmmm = 1;
                   }
                   if (LL4 == 14)
                   {
                       nnnn = 1;
                   }
                   if (LL4 == 15)
                   {
                       oooo = 1;
                   }
                   if (LL4 == 16)
                   {
                       pppp = 1;
                   }
                   if (LL4 == 17)
                   {
                       qqqq = 1;
                   }
                   if (LL4 == 18)
                   {
                       rrrr = 1;
                   }
                   if (LL4 == 19)
                   {
                       ssss = 1;
                   }
                   if (LL4 == 20)
                   {
                       tttt = 1;
                   }
                   if (LL4 == 21)
                   {
                       uuuu = 1;
                   }
                   if (LL4 == 22)
                   {
                       vvvv = 1;
                   }
                   if (LL4 == 23)
                   {
                       wwww = 1;
                   }
                   if (LL4 == 24)
                   {
                       xxxx = 1;
                   }
                   if (LL4 == 25)
                   {
                       yyyy = 1;
                   }
                   if (LL4 == 26)
                   {
                       zzzz = 1;
                   }

                   int aaaaa = 0;
                   int bbbbb = 0;
                   int ccccc = 0;
                   int ddddd = 0;
                   int eeeee = 0;
                   int fffff = 0;
                   int ggggg = 0;
                   int hhhhh = 0;
                   int iiiiii = 0;
                   int jjjjj = 0;
                   int kkkkk = 0;
                   int lllll = 0;
                   int mmmmm = 0;
                   int nnnnn = 0;
                   int ooooo = 0;
                   int ppppp = 0;
                   int qqqqq = 0;
                   int rrrrr = 0;
                   int sssss = 0;
                   int ttttt = 0;
                   int uuuuu = 0;
                   int vvvvv = 0;
                   int wwwww = 0;
                   int xxxxx = 0;
                   int yyyyy = 0;
                   int zzzzz = 0;

                   if (LL5 == 1)
                   {
                       aaaaa = 1;
                   }
                   if (LL5 == 2)
                   {
                       bbbbb = 1;
                   }
                   if (LL5 == 3)
                   {
                       ccccc = 1;
                   }
                   if (LL5 == 4)
                   {
                       ddddd = 1;
                   }
                   if (LL5 == 5)
                   {
                       eeeee = 1;
                   }
                   if (LL5 == 6)
                   {
                       fffff = 1;
                   }
                   if (LL5 == 7)
                   {
                       ggggg = 1;
                   }
                   if (LL5 == 8)
                   {
                       hhhhh = 1;
                   }
                   if (LL5 == 9)
                   {
                       iiiiii = 1;
                   }
                   if (LL5 == 10)
                   {
                       jjjjj = 1;
                   }
                   if (LL5 == 11)
                   {
                       kkkkk = 1;
                   }
                   if (LL5 == 12)
                   {
                       lllll = 1;
                   }
                   if (LL5 == 13)
                   {
                       mmmmm = 1;
                   }
                   if (LL5 == 14)
                   {
                       nnnnn = 1;
                   }
                   if (LL5 == 15)
                   {
                       ooooo = 1;
                   }
                   if (LL5 == 16)
                   {
                       ppppp = 1;
                   }
                   if (LL5 == 17)
                   {
                       qqqqq = 1;
                   }
                   if (LL5 == 18)
                   {
                       rrrrr = 1;
                   }
                   if (LL5 == 19)
                   {
                       sssss = 1;
                   }
                   if (LL5 == 20)
                   {
                       ttttt = 1;
                   }
                   if (LL5 == 21)
                   {
                       uuuuu = 1;
                   }
                   if (LL5 == 22)
                   {
                       vvvvv = 1;
                   }
                   if (LL5 == 23)
                   {
                       wwwww = 1;
                   }
                   if (LL5 == 24)
                   {
                       xxxxx = 1;
                   }
                   if (LL5 == 25)
                   {
                       yyyyy = 1;
                   }
                   if (LL5 == 26)
                   {
                       zzzzz = 1;
                   }

                   int aaaaaa = 0;
                   int bbbbbb = 0;
                   int cccccc = 0;
                   int dddddd = 0;
                   int eeeeee = 0;
                   int ffffff = 0;
                   int gggggg = 0;
                   int hhhhhh = 0;
                   int iiiiiii = 0;
                   int jjjjjj = 0;
                   int kkkkkk = 0;
                   int llllll = 0;
                   int mmmmmm = 0;
                   int nnnnnn = 0;
                   int oooooo = 0;
                   int pppppp = 0;
                   int qqqqqq = 0;
                   int rrrrrr = 0;
                   int ssssss = 0;
                   int tttttt = 0;
                   int uuuuuu = 0;
                   int vvvvvv = 0;
                   int wwwwww = 0;
                   int xxxxxx = 0;
                   int yyyyyy = 0;
                   int zzzzzz = 0;

                   if (LL6 == 1)
                   {
                       aaaaaa = 1;
                   }
                   if (LL6 == 2)
                   {
                       bbbbbb = 1;
                   }
                   if (LL6 == 3)
                   {
                       cccccc = 1;
                   }
                   if (LL6 == 4)
                   {
                       dddddd = 1;
                   }
                   if (LL6 == 5)
                   {
                       eeeeee = 1;
                   }
                   if (LL6 == 6)
                   {
                       ffffff = 1;
                   }
                   if (LL6 == 7)
                   {
                       gggggg = 1;
                   }
                   if (LL6 == 8)
                   {
                       hhhhhh = 1;
                   }
                   if (LL6 == 9)
                   {
                       iiiiiii = 1;
                   }
                   if (LL6 == 10)
                   {
                       jjjjjj = 1;
                   }
                   if (LL6 == 11)
                   {
                       kkkkkk = 1;
                   }
                   if (LL6 == 12)
                   {
                       llllll = 1;
                   }
                   if (LL6 == 13)
                   {
                       mmmmmm = 1;
                   }
                   if (LL6 == 14)
                   {
                       nnnnnn = 1;
                   }
                   if (LL6 == 15)
                   {
                       oooooo = 1;
                   }
                   if (LL6 == 16)
                   {
                       pppppp = 1;
                   }
                   if (LL6 == 17)
                   {
                       qqqqqq = 1;
                   }
                   if (LL6 == 18)
                   {
                       rrrrrr = 1;
                   }
                   if (LL6 == 19)
                   {
                       ssssss = 1;
                   }
                   if (LL6 == 20)
                   {
                       tttttt = 1;
                   }
                   if (LL6 == 21)
                   {
                       uuuuuu = 1;
                   }
                   if (LL6 == 22)
                   {
                       vvvvvv = 1;
                   }
                   if (LL6 == 23)
                   {
                       wwwwww = 1;
                   }
                   if (LL6 == 24)
                   {
                       xxxxxx = 1;
                   }
                   if (LL6 == 25)
                   {
                       yyyyyy = 1;
                   }
                   if (LL6 == 26)
                   {
                       zzzzzz = 1;
                   }






                   keyinfo = Console.ReadKey();
                   if (keyinfo.Key == ConsoleKey.Q)
                   {
                       q += 1; qq += 1; qqq += 1; qqqq += 1; qqqqq += 1; qqqqqq += 1;
                       Console.Write("\b");
                       Console.WriteLine("q");

                   }
                   if (keyinfo.Key == ConsoleKey.W)
                   {
                       w += 1; ww += 1; www += 1; wwww += 1; wwwww += 1; wwwwww += 1;
                       Console.Write("\b");
                       Console.WriteLine("w");
                   }
                   if (keyinfo.Key == ConsoleKey.E)
                   {
                       e += 1; ee += 1; eee += 1; eeee += 1; eeeee += 1; eeeeee += 1;
                       Console.Write("\b");
                       Console.WriteLine("e");
                   }
                   if (keyinfo.Key == ConsoleKey.R)
                   {
                       r += 1; rr += 1; rrr += 1; rrrr += 1; rrrrr += 1; rrrrrr += 1;
                       Console.Write("\b");
                       Console.WriteLine("r");
                   }
                   if (keyinfo.Key == ConsoleKey.T)
                   {
                       t += 1; tt += 1; ttt += 1; tttt += 1; ttttt += 1; tttttt += 1;
                       Console.Write("\b");
                       Console.WriteLine("t");
                   }
                   if (keyinfo.Key == ConsoleKey.Y)
                   {
                       y += 1; yy += 1; yyy += 1; yyyy += 1; yyyyy += 1; yyyyyy += 1;
                       Console.Write("\b");
                       Console.WriteLine("y");
                   }
                   if (keyinfo.Key == ConsoleKey.U)
                   {
                       u += 1; uu += 1; uuu += 1; uuuu += 1; uuuuu += 1; uuuuuu += 1;
                       Console.Write("\b");
                       Console.WriteLine("u");
                   }
                   if (keyinfo.Key == ConsoleKey.I)
                   {
                       ii += 1; iii += 1; iiii += 1; iiiii += 1; iiiiii += 1; iiiiiii += 1;
                       Console.Write("\b");
                       Console.WriteLine("i");
                   }
                   if (keyinfo.Key == ConsoleKey.O)
                   {
                       o += 1; oo += 1; ooo += 1; oooo += 1; ooooo += 1; oooooo += 1;
                       Console.Write("\b");
                       Console.WriteLine("o");
                   }
                   if (keyinfo.Key == ConsoleKey.P)
                   {
                       p += 1; pp += 1; ppp += 1; pppp += 1; ppppp += 1; pppppp += 1;
                       Console.Write("\b");
                       Console.WriteLine("p");
                   }
                   if (keyinfo.Key == ConsoleKey.A)
                   {
                       a += 1; aa += 1; aaa += 1; aaaa += 1; aaaaa += 1; aaaaaa += 1;
                       Console.Write("\b");
                       Console.WriteLine("a");
                   }
                   if (keyinfo.Key == ConsoleKey.S)
                   {
                       s += 1; ss += 1; sss += 1; ssss += 1; sssss += 1; ssssss += 1;
                       Console.Write("\b");
                       Console.WriteLine("s");
                   }
                   if (keyinfo.Key == ConsoleKey.D)
                   {
                       d += 1; dd += 1; ddd += 1; dddd += 1; ddddd += 1; dddddd += 1;
                       Console.Write("\b");
                       Console.WriteLine("d");
                   }
                   if (keyinfo.Key == ConsoleKey.F)
                   {
                       f += 1; ff += 1; fff += 1; ffff += 1; fffff += 1; ffffff += 1;
                       Console.Write("\b");
                       Console.WriteLine("f");
                   }
                   if (keyinfo.Key == ConsoleKey.G)
                   {
                       g += 1; gg += 1; ggg += 1; gggg += 1; ggggg += 1; gggggg += 1;
                       Console.Write("\b");
                       Console.WriteLine("g");
                   }
                   if (keyinfo.Key == ConsoleKey.H)
                   {
                       h += 1; hh += 1; hhh += 1; hhhh += 1; hhhhh += 1; hhhhhh += 1;
                       Console.Write("\b");
                       Console.WriteLine("h");
                   }
                   if (keyinfo.Key == ConsoleKey.J)
                   {
                       j += 1; jj += 1; jjj += 1; jjjj += 1; jjjjj += 1; jjjjjj += 1;
                       Console.Write("\b");
                       Console.WriteLine("j");
                   }
                   if (keyinfo.Key == ConsoleKey.K)
                   {
                       k += 1; kk += 1; kkk += 1; kkkk += 1; kkkkk += 1; kkkkkk += 1;
                       Console.Write("\b");
                       Console.WriteLine("k");
                   }
                   if (keyinfo.Key == ConsoleKey.L)
                   {
                       l += 1; ll += 1; lll += 1; llll += 1; lllll += 1; llllll += 1;
                       Console.Write("\b");
                       Console.WriteLine("l");
                   }
                   if (keyinfo.Key == ConsoleKey.Z)
                   {
                       z += 1; zz += 1; zzz += 1; zzzz += 1; zzzzz += 1; zzzzzz += 1;
                       Console.Write("\b");
                       Console.WriteLine("z");
                   }
                   if (keyinfo.Key == ConsoleKey.X)
                   {
                       x += 1; xx += 1; xxx += 1; xxx += 1; xxxx += 1; xxxxx += 1; xxxxxx += 1;
                       Console.Write("\b");
                       Console.WriteLine("x");
                   }
                   if (keyinfo.Key == ConsoleKey.C)
                   {
                       c += 1; cc += 1; ccc += 1; cccc += 1; ccccc += 1; cccccc += 1;
                       Console.Write("\b");
                       Console.WriteLine("c");
                   }
                   if (keyinfo.Key == ConsoleKey.V)
                   {
                       v += 1; vv += 1; vvv += 1; vvvv += 1; vvvvv += 1; vvvvvv += 1;
                       Console.Write("\b");
                       Console.WriteLine("v");
                   }
                   if (keyinfo.Key == ConsoleKey.B)
                   {
                       b += 1; bb += 1; bbb += 1; bbbb += 1; bbbbb += 1; bbbbbb += 1;
                       Console.Write("\b");
                       Console.WriteLine("b");
                   }
                   if (keyinfo.Key == ConsoleKey.N)
                   {
                       n += 1; nn += 1; nnn += 1; nnnn += 1; nnnnn += 1; nnnnnn += 1;
                       Console.Write("\b");
                       Console.WriteLine("n");
                   }
                   if (keyinfo.Key == ConsoleKey.M)
                   {
                       m += 1; mm += 1; mmm += 1; mmmm += 1; mmmmm += 1; mmmmmm += 1;
                       Console.Write("\b");
                       Console.WriteLine("m");
                   }
                   if (keyinfo.Key == ConsoleKey.Enter && q + w + e + r + t + y + u + u + ii + o + p + a + s + d + f + g + h + j + k + l + z + x + c + v + b + n + m == 2)
                   {
                       Console.WriteLine("");
                   }
               }






            }
            */
        }
        else
        {
            Console.WriteLine("Bro, I said s or m how do you mess that up? Nevermind that if you can not spell a single letter your not cut out for the spelling test. You get a K-");
        }
        
        
    }
}
