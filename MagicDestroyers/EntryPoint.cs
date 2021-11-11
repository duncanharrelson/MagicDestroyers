using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcasters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers
{
    public class EntryPoint
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int currentMelee = 0;
            int currentSpellcaster = 0;

            bool gameOver = false;

            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                //new Knight(),
                //new Assassin(),
                new Mage(),
                new Mage(),
                new Mage()
                //new Necromancer(),
                //new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();

            foreach (var character in characters)
            {
                if (character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }

            while (!gameOver)
            {
                currentMelee = rng.Next(0, meleeTeam.Count);
                currentSpellcaster = rng.Next(0, spellTeam.Count);

                spellTeam[currentSpellcaster].TakeDamage(meleeTeam[currentMelee].BasicAttack(), meleeTeam[currentMelee].Name);

                if (!spellTeam[currentSpellcaster].IsAlive)
                {
                    meleeTeam[currentMelee].WonBattle();
                    spellTeam.Remove(spellTeam[currentSpellcaster]);

                    if (spellTeam.Count == 0)
                    {
                        Console.WriteLine("Melee team wins!");
                        break;
                    }
                    else
                    {
                        currentSpellcaster = rng.Next(0, spellTeam.Count);
                    }
                }

                meleeTeam[currentMelee].TakeDamage(spellTeam[currentSpellcaster].BasicAttack(), spellTeam[currentSpellcaster].Name);

                if (!meleeTeam[currentMelee].IsAlive)
                {
                    spellTeam[currentSpellcaster].WonBattle();
                    meleeTeam.Remove(meleeTeam[currentMelee]);

                    if (meleeTeam.Count == 0)
                    {
                        Console.WriteLine("Spellcaster team wins!");
                        break;
                    }
                    else
                    {
                        currentMelee = rng.Next(0, meleeTeam.Count);
                    }
                }



                //---Basic logic breakdown---   (aka I'm not a game designer, I just work here)
                //1. Take random melee character
                //2. Take random spellcaster character

                //   Make attack method take character as argument
                //3. Melee attacks spellcaster
                //   Check if character died and remove from team
                //   If dead, get new character from team

                //4. Spellcaster attacks melee
                //   Check if character died and remove from team
                //   If dead, get new character from team



            }
        }
    }
}
