using System.Collections.Generic;

namespace ClassesAndInterfaces
{
    public interface IWeaponRepository
    {
        IEnumerable<Weapon> GetAll();
        Weapon GetWeapon(int weaponId);
    }
}
