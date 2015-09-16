using System;
using System.Web.Http;
using System.Text.RegularExpressions;

namespace ClassesAndInterfaces
{
    public class Weapon
    {
        public int WeaponId {get; set;}
        public string Name { get; set;}
        public string Damage {get; set;}


        public int GetRandomDamage() {
            var elements = Regex.Matches(this.Damage, @"\d+");
            var numberOfDice = int.Parse(elements[0].Value);
            var sizeOfDie = int.Parse(elements[1].Value);

            var random = new Random();
            var total = 0;

            for (int diethrow = 0; diethrow < numberOfDice; diethrow++)
            {
                total += random.Next(1, sizeOfDie);
            }

            return total;
        }
    }
}

