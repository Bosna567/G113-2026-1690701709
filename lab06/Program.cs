namespace lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int lives = 0;
            //if (lives == 0)
            //{
            //    Console.WriteLine("Game Over");
            //}
            //else
            //{
            //    Console.WriteLine("Continue to play");
            //}


            //Console.WriteLine("Continue to run");
            //bool haskey = true;
            //Console.WriteLine("Your level (1-99): ");
            //bool ok = int.TryParse(Console.ReadLine(), out int level);
            //if (!ok || level < 1 || level > 99)
            //{
            //    Console.WriteLine("Invalid level Input");
            //}

            //else if (level >= 10)
            //{
            //    Console.WriteLine("Boss floor unlocked");
            //}
            //else if (level >= 5)
            //{
            //    if (haskey == true)
            //    {
            //        Console.WriteLine("The door open");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Locked. Find a Key");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The door stay shut.");
            //}
            int WitchHp = 100;
            int Attack = 30;
            int SpecialAttack = 80;
            int MonHp = 100;
            int MonAttack = 80;
            int MonSpecialAttack = 50;


            Console.WriteLine("GAME TITLE : Vertex Adventure");
            Console.WriteLine("Hero Vs Monster");
            Console.WriteLine("Action 1: Attack");
            Console.WriteLine("Action 2: Special Attack");

            Console.WriteLine("Choose your action (1 or 2): ");
            bool isInputValid = int.TryParse(Console.ReadLine(), out int action);

            if (isInputValid == false || action < 1 || action > 2)
            {
                Console.WriteLine("Invalid Input, Please enter 1 or 2");
            }
            else if (action == 1)
            {
                MonHp -= Attack;
                Console.WriteLine($"Witch attacked the monster! Monster's HP is now {MonHp}");
            }
            else if (action == 2)
            {
                MonHp -= SpecialAttack;
                Console.WriteLine($"Witch used a special attack! Monster's HP is now {MonHp}");
            }
        }
    }
}
