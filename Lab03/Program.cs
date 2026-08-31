namespace Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MaxLevel = 10;

            var bossName = "Kirin";   // ต้องประกาศด้วย var ห้ามเขียน string ตรงๆ
            var rank = 'S';            // ต้องประกาศด้วย var ห้ามเขียน char ตรงๆ
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;       // ค่าตั้งต้นของ Lab นี้คือ HP "หลังโดนโจมตี" จาก Lab 2 แล้ว ไม่ใช่ 175
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;
            //Boss Stats
            Console.WriteLine("===== KIRIN SAVE CONVERTER =====");
            Console.WriteLine($"\nNAME: {bossName}"+
                $"\nRANK: {rank}" +
                $"\nLEVEL: {level} / {MaxLevel}" +
                $"\nHP: {currentHp} / {maxHp}" +
                $"\nATTACK POWER: {attackPower}" +
                $"\nCRIT MULTIPLIER: {critMultiplier}" +
                $"\nIS BOSS: {isBoss}");
            // Implicit Conversion Hp (int) to double
            Console.WriteLine("----- Implicit Conversion: HP as double -----");
            double currentHpAsDouble = currentHp; 
            Console.WriteLine("Current HP as double: " + currentHpAsDouble);

            // Casting Hp (double) to int
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = (double)currentHp / maxHp * 100;
            Console.WriteLine($"HP Percent (exact): {hpPercentExact}%");
            // Explict casting attackPower (float) to int

            //cact vs. Convert: Crit Multiplier
            Console.WriteLine("\n----- Cast vs Convert: Crit Multiplier -----");
            int critMultiplierAsInt = (int)critMultiplier;
            int critMultiplierAsIntConverted = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (cast): {critMultiplierAsInt}");
            Console.WriteLine($"Crit Multiplier (convert): {critMultiplierAsIntConverted}");
        }
    }
}
