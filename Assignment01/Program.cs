namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "Elden Ring";
            const string Characterclass = "Astrologer";

            int Level = 6;
            int Vigor = 9;
            int Mind = 15;
            int Endurance = 9;
            int Strength = 8;
            int Dexterity = 12;
            int Intelligence = 16;
            int Faith = 7;
            int Arcane = 9;
            double staminaPrecise = 60.5;  
            bool isPlayable = true;


            Console.WriteLine(GameTitle);
            Console.WriteLine($"Character class: {Characterclass}");
            Console.WriteLine($"|       level       :  {Level}         |");
            Console.WriteLine($"|       Vigor       :  {Vigor}         |");
            Console.WriteLine($"|       Mind        :  {Mind}        |");
            Console.WriteLine($"|       Endurance   :  {Endurance}         |");
            Console.WriteLine($"|       Strength    :  {Strength}         |");
            Console.WriteLine($"|       Dexterity   :  {Dexterity}        |");
            Console.WriteLine($"|       Intelligence:  {Intelligence}        |");
            Console.WriteLine($"|       Faith       :  {Faith}         |");
            Console.WriteLine($"|       Arcane      :  {Arcane}         |");
            Console.WriteLine($"|       Stamina     :  {staminaPrecise}      |");
            Console.WriteLine($"|       Playable    :  {isPlayable}      |");
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
