using System;
 
class function
{
     
    static year checkYear(int year)
    {
        if (year % 400 == 0)
            return true;
    
        if (year % 100 == 0)
            return false;
    
        if (year % 4 == 0)
            return true;
        return false;
    }
         
    public static void Main()
    {
        int year = 2010;
        Console.Write( checkYear(year)? "Leap Year" :
                                 "Not a Leap Year" );
    }
 
}
 
