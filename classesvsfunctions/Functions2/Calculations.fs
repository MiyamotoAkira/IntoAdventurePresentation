namespace Functions

module Calculations = 
    open System
    open System.Text.RegularExpressions

    let getRandomDamage getWeapon (weaponId :int) : int=
        let weapon = getWeapon weaponId
        let elements = Regex.Matches(weapon.damage, @"\d+");
        let numberOfDice = Int32.Parse elements.[0].Value
        let sizeOfDie = Int32.Parse elements.[1].Value

        let getRandom maximum = 
            let random = new Random()
            random.Next(1, maximum)

        let total = List.reduce (fun total _ -> total + (getRandom sizeOfDie)) [1..numberOfDice]
        total
