defmodule Chaining do
		def stripchars(str, chars) do
		String.replace str, ~r/"|#{Enum.join(String.split(chars, ""), "|")}"/, ""
	end

	def isAllUppercase(str) do
		upper = (stripchars str, "123456789,") |> String.upcase
		upper |> String.strip |> String.length > 0 && stripchars(str, "1234567890,") == upper
	end
end

(Chaining.isAllUppercase "Is it?") |> IO.puts
