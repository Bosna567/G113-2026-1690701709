namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Elden Ring"; 

            var Name = "Bob";     
            var Weapon = "Dagers";        
            int Level = 18;
            int Damage = 50;
            double staminaPrecise = 60.5;  
            bool isPlayable = true;

            Console.WriteLine($"===== {GameTitle} =====");    
            Console.WriteLine($"Hero Name   : {Name}");
            Console.WriteLine($"Weapon      : {Weapon}");
            Console.WriteLine($"Level       : {Level}");
            Console.WriteLine($"Damage      : {Damage}");
            Console.WriteLine($"Stamina     : {staminaPrecise}");
            Console.WriteLine($"Playable    : {isPlayable}");
            Console.WriteLine();

            double heroLevelAsDouble =  Level; // implicit — ไม่มี cast
            Console.WriteLine($"Level as double (implicit): {heroLevelAsDouble}");

            int staminaTruncated = (int)staminaPrecise;               // explicit cast
            int staminaRounded = Convert.ToInt32(staminaPrecise);      // Convert
            Console.WriteLine($"Stamina cast (truncates)  : {staminaTruncated}");
            Console.WriteLine($"Stamina Convert (rounds)  : {staminaRounded}");
        }
    }
}
