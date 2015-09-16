using System;
using System.Web.Http;
using System.Collections.Generic;

namespace ClassesAndInterfaces
{
    public class WeaponsController : ApiController
    {
        IWeaponRepository weaponRepository;

        public WeaponsController (IWeaponRepository weaponRepository)
        {
            this.weaponRepository = weaponRepository;
        }

        [Route("weapons")]
        public IHttpActionResult GetAllWeapons()
        {
            IEnumerable<Weapon> allweapons = this.weaponRepository.GetAll();
            return Ok(allweapons);
        }

        [Route("weapons/{weaponid}/getrandomdamage")]
        public IHttpActionResult GetRandomDamageForWeapon(int weaponid)
        {
            return Ok(this.weaponRepository.GetWeapon(weaponid).GetRandomDamage());
        }
    }
}

