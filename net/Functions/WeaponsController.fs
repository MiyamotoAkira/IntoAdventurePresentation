namespace Functions

open System
open System.Web.Http
open WeaponRepository

type WeaponsController () = 
    inherit ApiController()

    [<Route ("weapons")>]
    member this.getAllWeapons () = WeaponRepository.getAllWeapons ()

    [<Route ("weapons/{weaponid}/getrandomdamage")>]
    member this.getRandomDamageForWeapon weaponId = WeaponRepository.getWeapon weaponId |> Calculations.getRandomDamage
