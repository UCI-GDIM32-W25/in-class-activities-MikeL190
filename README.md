# GDIM32 In Class Activities
## W1

### Activity 1
Have others playtest your game so that they might find bugs that you might not know exist

### Activity 2
1. x = 10
2. x = 2
3. The text "hello world" will get printed out in the terminal window very fast, like every frame
4. MonoBehavior
5. The text "x = 10" will get printed out
6. Demonstrates method arguments and parameters where you pass input into functions or methods. When being added with a string, even though 10 is an int, the program will automatically convert the int into a string (implicit conversion I think it's called)
7. The variables have not been initialized. Neither the _playerTransform and _direction variables have been given values. Also, you are calling Translate on the Transform class as if it were a static method, when Translate should instead be called on an instance/object of the Transform class.
8. For this specific case, you just have to make Transform lowercase, so that it references the current script's Transform component that the script is attached to. You could also use the _playerTransform variable and call the Translate method on this object. But also the _direction variable should be set to a certain value, otherwise the object that the script is attached to won't get moved anywhere.

### Activity 3
[MG1 Breakdown Google Doc] (https://docs.google.com/document/d/13CpbeuxDdSu4rNWc0M-8HcteVHemPggOYnJ30APiQpM/edit?tab=t.0)




