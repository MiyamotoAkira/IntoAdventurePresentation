What are we going to talk about here?

Functional Programming and what is different from Object Oriented Programming (OOP)

Let's be clear, there is really only one difference. But is a major one. The rest are techniques/styles/capabilities that originated because of the paradigm of functional programming, but there are present on OOP languages.

I'm not an expert on FP. I'm still very much learning.

The code we are going to be looking at is from 6 languages coupled into three.

We have C# and F# for the .Net world

We have Java and Clojure for the JVM world

We have Ruby and Elixir. They don't share a vm. Ruby has its own while Elixir uses BEAM. But the creator of Elixir Jose Valim was a contributor to Ruby On Rails and the syntax of Ruby has influenced Elixir.


### Classes/Interfaces vs functions

Nothing new under the sun if you have done procedural languages before

Look at them as if they were static classes with static methods. Which is what F# does to translate to CLR

SOLID and Clean Code principles still apply very much to FP

Design patterns, though, are completely different. FP has its own patterns.

### Binding vs Assigment

As an OO programmer never cared.

Binding is about identifying a piece of code or data inside a scope. Once you leave the scope the identifer is gone, but not the data or the code.

Assignment is changing the value of the data of something for the lifetime of that something. Where something can be a strutcture/record/object

irb bindingvsassignment.rb

-- Here we can see that z inside print_value refers to the y parameter, which is in fact x

x = ExampleObject.new "This is a string"
print_value x
puts x

--  We are going to create an assigner object
assigner = TheAssigner.new

puts "Example object before"
puts assigner.firstExample

-- we can see that we are ching the value inside assigner
assigner.assign_new_value "Another value"

puts "Example object after"
puts assigner.firstExample


-- But of course, this affects outside
second = ExampleObject.new "Second object"

puts "second object before assignment"
puts second

assigner.add_new_object second
puts "Second object before"
puts assigner.secondExample

assigner.modify_second_object "Another second value"

puts "Second object after"
puts assigner.secondExample

puts "second object after assignment"
puts second




### State

This. This is the major difference. What makes FP. Eliminating state makes a whole lot of problems dissapear. Of course, there are always other issues. But because of the lack of state is much easier to know what a part of the code is doing.

Let's look at some Java code

Let's going to try to replicate on Clojure

First function, creates a new version of the list

Second function is rebinding the identifier

We can see even better if we use pass the sequence:
(let [array [1 2 3]]
(listchanger/list-changer2' array)
(println array))

Or inside the same method

### Chaining

Fluent interfaces. 

#### Pattern Matching

Is in the roadmap of C#.

To be easy to understand is a switch on steroids.

Though it is more than that. Pattern matching is about finding a value that satisfies the condition. There is a decision, a type of if.

Show on C#

Show basic on F#

Show deconstruction and guards

Show Elixir pattern matching on functions. Unlike overloading, arity and data type can be the same
