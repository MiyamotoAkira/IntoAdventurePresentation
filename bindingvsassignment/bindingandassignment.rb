def example()
    x = 5
    puts x
end


class ExampleObject

	def initialize(sentence)
		@sentence = sentence
	end

    def set_sentence(value)
      @sentence = value
    end
    
	def to_s
		"#{@sentence}"
	end
end


def print_value (y)
	z = y
	puts z
end

class TheAssigner
  attr_reader :firstExample
  attr_reader :secondExample
  def initialize
    @firstExample = ExampleObject
.new "This is a string"
  end

  def assign_new_value(value)
    @firstExample.set_sentence value
  end

  def add_new_object(newObject)
    @secondExample = newObject
  end

  def modify_second_object(value)
    @secondExample.set_sentence value
  end
end


