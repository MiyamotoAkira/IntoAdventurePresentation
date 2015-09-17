defmodule Person do
	defstruct name: "Araceli", age: 70

	def salute(%Person{name: name, age: age}) when name == "Araceli" do
		IO.puts "Happy #{age}th Birthday"
	end
	
	def salute(%Person{name: name}) when name != "" do
		IO.puts "I salute you, #{name}"
	end

	def salute(%Person{}) do
		IO.puts "Hey Stranger"
	end
end
