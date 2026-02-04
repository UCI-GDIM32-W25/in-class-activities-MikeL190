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

## W5

### Activity 1
I would keep the design of the interfaces and abstract classes the way they are because to me, you can easily add on to the project with the current setup. For example, when adding another weapon, you would want to automatically make it inherit from the Item abstract class, since it's an item, and if you want this weapon to be breakable, then you implement the IBreakable interface, but if you want this weapon to be unbreakable, then you don't implement the interface. Also, if you want to add more functionality to this new weapon, then you just add more methods to it if needed and if you need more interfaces to implement, then you can do that as well; the whole design is very flexible.
### Activity 2
The EnemyStats class is used as a Scriptable Object, and it's used as a template in a way, where you create Enemy_Frog and Enemy_Mask, which have all the properties defined in the EnemyStats class, but you can modify them for each individual one you create, so the frog can have different values for the variables compared to the mask. The way this is setup is very flexible, and you don't have to know any code inside the EnemyStats class, you just have to create a new EnemyStats Scriptable Object and modify its properties to whatever you want from the editor window.
### Activity 3

#### Scenario 1
For a rhythm game, all of these sound useful. C# events can be used in many ways, such as creating events for when the player presses the correct key on their computer, alerting any methods hooked up to the event such as changing the way the note looks to see if the user pressed the correct key or not. The Finite State Machine can be used for any animations, such as for the notes, where if you get the note correct, then a little animation plays. Scriptable Objects can be used for the different notes themselves, where you store the data for the different notes inside Scriptable Objects, this way everything is organized. Inheritance can also be used here because even though you may have different notes, they may still have similarites amongst them, so using inheritance here can make the code less tedious and more efficient.  

#### Scenario 2
For a shooter game, such as Valorant that has different characters and different guns, Scriptable Objects will be very useful here, where you create different Scriptable Objects to store the data for the guns and characters. The Finite State Machine can be used for the characters' different animations, so you can store the animation state in an enum variable, and then update it when applicable, such as when the user suddenly dies when shot enough times. Singletons can be used here for an overall UI, Character, and Gun Managers. I have a specific idea for a C# event that can be useful, where you create an event that will fire when the team wins, and you would want to hook up methods for displaying the Victory screen, playing any winning sound effects, and making sure the player cannot move anymore since the match is over. 

#### Scenario 3
You can use C# events for various things in Stardew Valley, such as when a plant is ready to harvest an event will be fired and this will alert the user that it's ready to be farmed, by displaying UI on the user's screen and / or playing sound effects. You will have different types of plants, so creating Scriptable Objects for the different types of plants will be very useful, and you can even use inheritance here. For example, if you want 5 different plants in the game, but they have similar properties, then you can create a base Scriptable Object (PlantBase), with things like plantName and plantAge, and then you can create a Scriptable Object for each plant type, like creating ApplePlant and StrawberryPlant Scriptable Objects which both inherit from the PlantBase and then you can add individual properties to both the ApplePlant and StrawberryPlant Scriptable Objects. You can use the Finite State Machine for animations of the user or the plants. You can use singletons for overall managers, like the UI Manager or Plant Manager, and doing this will probably be best since there will only be one UI or Plant Manager if you implement it this way.

### Activity 4
Attendance: Michael Lopez, Ruth Sun, Armando Topete
<br>
Proposal: [Final Project Proposal First Draft](https://github.com/MikeL190/HW4/commit/cbd29fd65199c42a6ad51591150c3ebdbcc6e133)
