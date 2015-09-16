defmodule Player do
	defstruct weapon: nil
end

defmodule Weapon do
	defstruct damage: 0
end

defmodule Attack do

	def attackWithWeapon do
		weapon = %Weapon{damage: 5}
		player = %Player{weapon: weapon}

		IO.puts player.weapon.damage
	end
end

Attack.attackWithWeapon


defmodule Monster do
	defstruct life: 0

	def receiveDamage(damage, monster=%Monster{}) do
		%Monster{monster|life: monster.life-damage}
	end
end

defmodule Demonstration do
	def demo do
		weapon = %Weapon{damage: 5}
		player = %Player{weapon: weapon}
		monster = %Monster{life: 17}
		monster = player.weapon.damage |> Monster.receiveDamage monster
		IO.puts monster.life
	end
end

Demonstration.demo
