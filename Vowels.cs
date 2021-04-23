using System.IO;
using System;
    public class count
    {  
        public static void Main(string[] args)  
        {  
            Console.Write("Enter the String: ");   
            string sample =Console.ReadLine(); 
            int count=0;
            for( int i=0;i<sample.Length;i++)
            {
                if(sample[i]=='a' || sample[i]=='e' || sample[i]=='i'||sample[i]=='o'||sample[i]=='u')      
                    count=count+1;
            }       
            Console.WriteLine("No of vowels are:"+count);      
    	}  
 	}