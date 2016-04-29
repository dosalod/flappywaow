using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prov {
    class Character {
        //deklarerar variabler
        int strenght;
        int spirit;
        int level;
        int mana;
        public List<string> SpellHistory = new List<string>();

        //ökar värdet på dessa variabler med 1
        public void LevelUp() {
            level += 1;
            strenght += 10;
            spirit += 10;
        }

        public string CastSpell(string spell) {
            //gör en lista för spell historik


            SpellHistory.Add(spell);

            //kollar om man har nog med mana för att casta ett spell om true så kastar den ditt spell
            if (spell == "kadabra" && mana >= 2) {
                return spell + " did " + spirit + level + "damage";
            }

            //om mana är större än 2 kasta spellet
            else if (mana >= 2)
                return spell + " did " + spirit * 2 + level * 2 + " damage";

            //printar ut alla castade spell om man anger SpellHistory som spell

            //försökte med return men FÖRSTÅR INTE VARFÖR DET BLIR UNREACHABLE CODE
            else if (spell == "SpellHistory") {
                for (int i = 0; i != SpellHistory.Count;) {
                    Console.WriteLine(SpellHistory[i]);
                    i++;
                }
            }
            //om mana är inte större än 2 kasta inte spellet
            else if (mana < 2 && spell != "SpellHistory") {
                return "you do not have enougn mana to cast " + spell;
            }
            return null;
            
        }
        public float MultiCombo() {
            //skriver ut pow lika många gånger som strenght är
            for (int i = 0; i < strenght; i++) {
                Console.Write("POW! ");
            }
            return strenght * 1.5f;
        }
        //tar emot start värdena av spirit och strenght och sätter det i mana
        public Character() {
            mana += strenght + spirit;
        }
        public void TakePotion() {
            //gör en random som vi ska använda för att se om man ska få max mana
            Random rnd = new Random();
            int femtioProcent = 0;
            femtioProcent = rnd.Next(0, 2);

            //om femtioProcent == 1 så får vi max mana
            if (femtioProcent == 1) {
                mana = spirit;
            }
            //tar ett slumpmässigt nummer mellan 0 och spirit och sedan lägger till detta
            //till mana och kan inte göra så vi får mer mana än spirit
            else{
                int hurMycketManaFårVi = 0;
                hurMycketManaFårVi = rnd.Next(0, spirit - mana);
                mana = hurMycketManaFårVi;
            }
            
        }   
            
        
    }
}
