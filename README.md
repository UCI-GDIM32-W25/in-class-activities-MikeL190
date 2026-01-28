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
[MG1 Breakdown Google Doc](https://docs.google.com/document/d/1IAbfUZMwyBKvY7Xv__4lsDwhYpiD753GZPPafO9OXXg/edit?usp=sharing)

## W2

### Activity 1
<img width="1152" height="648" alt="School_Image1" src="https://github.com/user-attachments/assets/590ca12b-aba9-4b62-9b1e-3a6524cb29a7" />

### Activity 2
I added the penguin sprite, sample text UI, coin sprite, and floor sprite. I also created some scripts, where one script makes the coins spawn and another script that makes the coins move left across the screen.
<br> <br>
[MG2 Breakdown](https://github.com/UCI-GDIM32-W25/mg2-MikeL190/commit/01b5b1a91d98542f1f5f5eff434429e81631d906)

## W3

### Activity 0 - 2
Partner Name: Nansong Sun

### Activity 3
<img width="1152" height="648" alt="School_Image_2" src="https://github.com/user-attachments/assets/f4dc931f-cd26-4779-85c2-c25f21ca853c" />

## W4

### Activity 0
Partner Name: Nansong Sun

### Activity 1
When you add multiple GameObjects with a Locator script attached to each of them, only one of the Locator script components will stay on a GameObject, so the rest will get deleted from the game. For example, I added 3 empty GameObjects to my scene, and then I added my Locator script to each of them. When I ran the game and looked back at the Hierarchy, only one of those GameObject had a Locator script attached to it, while the other GameObjects had their Locator script removed.

### Activity 2
<img width="1152" height="648" alt="School_Image_3" src="https://github.com/user-attachments/assets/5484ebe2-e958-4b4b-9e39-56258429bc57" />

### Activity 3
I set up the Unity Project on my own. Then, I added a Bird GameObject, with a temp Sprite, and added a Bird_Controller script to it to make it simulate jumping. Then, I created the Pipe GameObject with three child GameObjects and added a script to the parent to make it move left when the pipe spawns. I also added a Pipe_Manager script that handles spawning the pipe.
<br> <br>
[MG4 Commit](https://github.com/MikeL190/HW4/commit/cbd29fd65199c42a6ad51591150c3ebdbcc6e133)
