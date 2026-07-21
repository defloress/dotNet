// // exceptional handling 

// try {
//     // int a = 10 ;
//     // int b = 0;
//     // int c = a/b;
//     Console.WriteLine(c);

//     int [] age = new int [3];
//     int myAge = age [4];
// }
// catch(Exception ex){
//     Console.WriteLine("An exception occured"+ ex.Message);
// }



try{
        /* int [] age = new int [3];
        int myAge = age [4]; */

        string myName ;
        Console.WriteLine(myName.Length);

}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch(indexOutOfRangeException ex){
    Console.WriteLine("An exception occured"+ ex.Message);

}


// dotnet new console -o ExceptionalHandling
// dotnet run 