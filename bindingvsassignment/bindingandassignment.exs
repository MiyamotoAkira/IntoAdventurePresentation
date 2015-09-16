defmodule Card do
	defstruct mana: 0, cost: 0

	def tryToChange(card = %Card{}) do
		IO.puts card.mana
		#card.mana = 5
		card5 = %{card | mana: 5}
		IO.puts card5.mana
	end
	
end
