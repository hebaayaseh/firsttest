namespace Firsttest
{

    public class notmain() { }

    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = x;
            y = 7;
            //Console.Write(x);
            /* 1 : 
            //int[] b = new int[5];
            b = new int[] { 1, 2, 3, 4, 5 };*/
            // 2 : 
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = a;
            b[0] = 6;
            if (a[0]==6)
            {
               // Console.WriteLine("a is a reference type");
            }
           // Console.Write(a[0]);
            int day = 1;
            string DayByName = day switch
            {
                1 => "sun",
                2 => "mon",
                3 => "tus",
                _ => "nothing" // There is no real case
            };
            //Console.WriteLine(DayByName);
            for(int i=0; i<5; i++)
            {
               // Console.Write(a[i] + " ");
            }
          
            foreach(int l in a)
            {
                //Console.Write(l + " ");
            }
            int q = 0;
            while (q<5)
            {
               // Console.Write(a[q] + " ");
                q++;
            }
            // string interpolation : 
           // Console.WriteLine($"Back End {1} Course ! ");

            // string 
            string aa = "Heba Hesham       Ayaseh";
            string[] ans = aa.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach(string s in ans)
            {
                Console.WriteLine(s);
                Console.WriteLine(s);
            }


            // reflection 
            Type t = typeof(string);
            aa.GetType();




            var u = new DoIt();
            //u = 5; // you can’t change the data type , only at first

            dynamic u1 = new DoIt();
            u1 = 5;
            u1 = "back end";
        }
        public class DoIt
        {
            public int b;
        }
        
        public static string dayp(int d)
        {
            string DayByName="";
            switch (d)
            {
                case 1: DayByName = "sun";  break;
                case 2: DayByName = "mon"; break;
                case 3: DayByName = "tus  "; break;

            }
            return DayByName;
        }
    }
}
