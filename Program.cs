public class Program {
     static void Main (){
        Console.Write("input number : ");
        int Number;
        Number = int.Parse(Console.ReadLine());
            if (Number >=1){
                Console.WriteLine("yellow");
                Number = Number-1;
            }
            if (Number >=2){
                Console.WriteLine("orange");
                Number = Number-2;
            }
            if (Number >= 4){
                Console.WriteLine("red");
                Number = Number-4;
            }
     }
}