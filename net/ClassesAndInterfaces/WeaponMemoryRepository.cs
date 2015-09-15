using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassesAndInterfaces
{
    public class WeaponMemoryRepository : IWeaponRepository
    {
        private List<Weapon> weapons;
        public WeaponMemoryRepository()
        {
            weapons = new List<Weapon>() {
                new Weapon() {
                    WeaponId = 1,
                    Name = "Sword",
                    Damage = "1d10"
                },
                new Weapon() {
                    WeaponId = 2,
                    Name = "Axe",
                    Damage = "1d12"
                }
            };
        }

        #region IWeaponRepository implementation

        public IEnumerable<Weapon> GetAll()
        {
            return weapons;
        }

        public Weapon GetWeapon(int weaponId)
        {
            return weapons.First(x => x.WeaponId == weaponId);
        }

        #endregion
    }
}

