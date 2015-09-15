namespace Functions
        

module WeaponRepository =
    let weapons = [{weaponId = 1; name = "Sword"; damage="1d10"};{weaponId = 2; name="Axe"; damage="1d12"}]
    let getAllWeapons () =
        weapons
    let getWeapon weaponId =
        weapons |> List.find (fun weapon -> weapon.weaponId = weaponId)
    