namespace Functions

open System
open System.Web.Http
open WeaponRepository

type WeaponsController (getRandomDamageFromWeapon : int -> int) = 
    inherit ApiController()

    [<Route ("weapons")>]
    member this.getAllWeapons () = WeaponRepository.getAllWeapons ()

    [<Route ("weapons/{weaponid}/getrandomdamage")>]
    member this.getRandomDamageForWeapon weaponId = getRandomDamageFromWeapon weaponId