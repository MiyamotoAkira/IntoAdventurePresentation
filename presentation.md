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

SOLID and Clean Code principles still apply very much to FP

Design patterns, though, are completely different. FP has its own patterns.

### Binding vs Assigment

As an OO programmer never cared.

Binding is about identifying a piece of code or data inside a scope. Once you leave the scope the identifer is gone, but not the data or the code.

Assignment is changing the value of the data of something for the lifetime of that something. Where something can be a strutcture/record/object


### State

This. This is the major difference. What makes FP. Eliminating state makes a whole lot of problems dissapear. Of course, there are always other issues. But because of the lack of state is much easier to know what a part of the code is doing. 

### Chaining

Fluent interfaces. 

#### Pattern Matching

Is in the roadmap of C#.

To be easy to understand is a switch on steroids
