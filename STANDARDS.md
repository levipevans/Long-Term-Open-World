# #1 most important rule: DON'T WRITE BAD CODE

I swear to god if I find some piece of code that used 12 individual If Statements instead of using only 1 with an extra variable, I'm going to lose my mind.
Really just don't write stupid code that's hard to edit or read. That's really what defines bad code. If I can look at your code, understand how it works, and edit it to do what I want it to with ease, that's good code. That means that even if you can do something super clever with less code, it might (depending on the circumstances) be better to use more code so it can be more easily customizable/understandable.

## General code formatting etiquette:

+ Commenting
    - Add comments as often as you can without being redundant. This is technically subjective, just try your best to make it easy for everyone on the project to be able to figure out the code you wrote.
+ Variable Naming
    - Variables should all follow the naming system unless there's an edge-case reason why that's not possible:
    - First letter of each word except for the first should be capitalized
    - examples: myString, mySecondString, health
+ GameObject naming
    - This naming system applies only to GameObjects in the hiarchy or any Prefabs in the project (scripts, 3d models, textures, animations, etc.), not variable names for GameObjects or Prefabs being referenced in a script
    - First letter of each word (including first word this time) should be capitalized
    - examples: MyGameObject, Player, NPC, SmallHouse

## Non-coding-specific etiquette

+ Base Scripts vs. Custom Scripts
    - Base Scripts are scripts such as 'TriggerScript', which are deliberatly designed with public variables that can be changed so that the same script can do several things.
    - Custom Scripts are just normal scripts that are specific to a single function, such as 'PlayerMovementScript' (I know it's in the wrong folder rn, I'll fix it when I work on the project next). These scripts may have public variables, but they are used to allow you to easily tweak the behaviour of the script, not to allow it to be used for a wide range of different uses.
    - Yes, there is a gray area between these two areas, just try to put it where it makes most sense to you, I'll move it to a different folder if I don't like where it was put.
+ Put things in the right folders
    - This is super easy, scripts go in the scripts folder, 3D models go in the models folder, any assets you did not create should be imported into the 'Import' folder. Feel free to ask if you have any questions about the folders if they ever get confusing, and I'll help you out and add the info in here.
+ Try not to clog up the hiarchy too much
    - Make things children of other objects when it makes sense, you can also create an empty object and use that as the parent of several objects
    - This is what I did for my player, I put the player and both cameras as children of the same 1 empty object. This made it so it was all in the same place in the hiarchy, and also took up less space.
