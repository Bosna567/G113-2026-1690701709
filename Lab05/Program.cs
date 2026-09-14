namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hero stast
            Console.WriteLine("===> Game Title <===");
            Console.WriteLine("Hero vs Monster --- Calculate Damage");

            Console.WriteLine("Hero Hp; ");
            bool heroHpOK = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.WriteLine("Hero Attack; ");
            bool heroAtkOK = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.WriteLine("Hero Defense; ");
            bool heroDefOK = int.TryParse(Console.ReadLine(), out int heroDef);



            //Monster stats
            Console.WriteLine("Monster Hp; ");
            bool monHpOK = int.TryParse(Console.ReadLine(), out int monHp);
            Console.WriteLine("Monster Attack; ");
            bool monAtkOK = int.TryParse(Console.ReadLine(), out int monAtk);
            Console.WriteLine("Monster Defense; ");
            bool monDefOK = int.TryParse(Console.ReadLine(), out int monDef);

            //Check for valid input
            bool heroInputValid = heroHpOK && heroAtkOK && heroDefOK;
            bool monsterInputValid = monHpOK && monAtkOK && monDefOK;
            Console.WriteLine($"Hero stast valid : {heroInputValid}");
            Console.WriteLine($"Monster stast valid : {monsterInputValid}");
            Console.WriteLine($"[HERO]   HP: {heroHp} ,ATK: {heroAtk} , DEF: {heroDef}");
            Console.WriteLine($"[MONSTER]   HP: {monHp} ,ATK: {monAtk} , DEF: {monDef}");

            //Hero drink potion before the fight(compond assignment)
            int potion = 14;
            //heroHp + HeroHp + potionHeal ผลคือ 114(สมมติ HP 100)
            //heroHp +=potionHeal ผลคือ 114การคำนวนเหมือนกัน แต่การเขียนแบบนี้สั้นกว่า
            heroHp += potion;
            Console.WriteLine($"Hero drinks a potion healing {potion} Hp, Hero Hp is {heroHp}");

            int normalDamage = Math.Max(0, heroAtk - monDef);
            Console.WriteLine($"Normal attack deals : {normalDamage} DMG");
            int powerDamage = Math.Max(0, heroAtk * 2 - monDef);

            int conunterDamage = Math.Max(0, monAtk - heroDef);
            Console.WriteLine($"Counter acctack deals : {conunterDamage} DMG");
            Random rng = new Random();
            int roll = rng.Next(1, 101); //สุ่ม 1 ถึว 100 ต้องเพิ่ม1ตลอด
            bool isCrit = roll <= 80; // โอกกาสคริติคอล 10 ตัวใน100 คือ 100
            int critDmage = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // ได้ค่า 1 หรือ 0 เป็นตัวกำหมดว่าจะได้คริติคอลหรือไม่
            Console.WriteLine($"CritDamage roll : {roll} (Crit? : {isCrit}");
            Console.WriteLine($"IF crit, nomal attact would deal : {critDmage} DMG");
        }
    }
}
