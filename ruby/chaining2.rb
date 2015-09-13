class Player
  def initialize (weapon)
    @weapon = weapon
  end
  
  def AttackWithWeapon
    @weapon
  end
end

class Weapon
  def initialize (damage)
    @damage = damage
  end

  def getDamage
    @damage
  end
end

sword = Weapon.new(5)
player = Player.new(sword)
puts player.AttackWithWeapon().getDamage()

# But what about damaging a monster?

class Monster
  def initialize (life)
    @life = life
  end
  
  def receiveDamage (damage)
    @life = @life - damage
  end
end

monster = Monster.new(10)
monster.receiveDamage(player.AttackWithWeapon().getDamage())
