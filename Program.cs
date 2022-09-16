public class program {
    static ReadingRoom data;
    static void Main(){
        data = new ReadingRoom();
        Hairpin();
    }
        static void Hairpin(){
            Console.WriteLine("Input menu");
            Console.WriteLine("a = University");
            Console.WriteLine("b = Academia");
            Console.WriteLine("c = Electricity FT");
            string input = Console.ReadLine();
            if(input == "a" ) data.University();
            if(input == "d" ) data.Academia();
            if(input == "c" ) data.ElectricityFT();




        }

        }



