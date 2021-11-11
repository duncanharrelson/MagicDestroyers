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
                //---Basic logic breakdown---   (aka I'm not a game designer, I just work here)
                //1. Take random melee character
                //2. Take random spellcaster character

                //   Make attack method take character as argument
                spellTeam[0].TakeDamage(meleeTeam[0].BasicAttack());

                //3. Melee attacks spellcaster
                //   Check if character died and remove from team
                //   If dead, get new character from team

                meleeTeam[0].TakeDamage(spellTeam[0].BasicAttack());
                //4. Spellcaster attacks melee
                //   Check if character died and remove from team
                //   If dead, get new character from team

                //5. If no characters alive from either team, gameOver = true


            }
        }
    }
}
