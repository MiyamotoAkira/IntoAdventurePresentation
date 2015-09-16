def example()
    x = 5
    puts x
end


class MyExample
	def initialize(sentence)
		@sentence = sentence
	end
	def to_s
		"#{@sentence}"
	end
end

x = MyExample.new "This is a string"

def print_value (y)
	z = y
	puts z
end

print_value x
puts x
