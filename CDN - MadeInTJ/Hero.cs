using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDN___MadeInTJ
{
    public class Hero
    {

        public int HealthPoints { get; set; }
        public int AttackPoints { get; set; }

        public Dictionary<string, bool> Items { get; set; }
        public int PoisonBag { get; set; }
        public string ID { get; } = "C";

        public string Action { get; set; }
        public Hero(int HP, int AP)
        {
            HealthPoints = HP;
            AttackPoints = AP;
            Items = new Dictionary<string, bool>()
                {
                    {"H",false},
                    {"A",false},
                    {"W", false},
                };
        }


        public string getID()
        {
            return ID;
        }

        public int GetHealth()
        {
            return HealthPoints;
        }


        public int GetAttack()
        {
            return AttackPoints;
        }

        public void setHealth(int points, string trough)
        {
            if (Items[trough!] == false)
                HealthPoints += points;
        }
        public void setAttack(int points)
        {
            if (Items["W"] == false)
                AttackPoints += points;
        }
        public void AddPoison()
        {
            if (PoisonBag < 5)
            {
                PoisonBag += 1;
            }

        }
        public void UsePoison(int points)
        {
            if (PoisonBag > 0)
            {
                PoisonBag -= 1;
                HealthPoints += points;
            }

        }

        public int GetPoisons()
        {
            return PoisonBag;
        }

        public void SetAction(string action)
        {
            Action = action;
        }



        public string GetAction()
        {
            return Action;
        }

        public void ClearAction()
        {
            Action = "";
        }

        public void ReciveAttack(int points)
        {
            HealthPoints -= points;
        }

    }
}
