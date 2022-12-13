using System;
namespace hams;
public class hams{
    private static void Main(){
        Console.WriteLine("enter the string:");
        var str=Console.ReadLine();
        var strrev=" ";
        for(var i=str.Length-1;i>=0;i--){
        strrev+=str[i];
        }
        Console.WriteLine(strrev);
    }
}