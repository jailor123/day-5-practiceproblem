using System;
 
class function{
      
public static Tuple<int, int> count_ht(char s,
                                       int N)
{ 
     
    
    Tuple<int, int> p = Tuple.Create(0, 0);
     
    if (s == 'H')
    {
        p = Tuple.Create((int)Math.Floor(N / 2.0),
                         (int)Math.Ceiling(N / 2.0));
    }
     
  
    else if (s == 'T')
    {
        p = Tuple.Create((int)Math.Ceiling(N / 2.0),
                         (int)Math.Floor(N / 2.0));
    }
    return p;
}
 
{
    char C = 'H';
    int N = 5;
    Tuple<int, int> p = count_ht(C, N);
     
    Console.WriteLine("Head = " + p.Item1);
    Console.WriteLine("Tail = " + p.Item2);
}
}
 
