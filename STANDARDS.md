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

## Github etiquette
### General
+ Label any issues you create with the proper tag (issues tab)
+ Only check off list items on projects in the pull request where you have actually solved the problem (or if the list says otherwise, follow the instructions on there)
+ Be helpful
    - Create Projects (in the projects tab)
    - Automate Projects
    - Create wiki pages (Just try and make nice pages until I make an actual etiquette page and then we can update the old ones to match our agreed upon formatting).
    - Create issue pages if there are any problems
    - Resolve issues if they exist
    - Keep things organized and nice
    - Organize things that aren't

### Commits
+ General
    - Capitalize the start of sentences and lines.
    - Use proper grammar and spelling so I know exactly what you're talking about
    - Don't use run-ons, make it easy to read. Take advantage of short sentences.
    - Don't make joke commits or commit messages.
+ Subject line
    - The short description is the subject line, that's what we're gonna call it
    - A proper subject line should always be able to fit into the sentence "If applied, this commit will <your subject line here>"
    - Be more descriptive that "fix problem", try "fix character floor glitch", or "fix issue #237".
    - Don't name it stupid things, and don't be lazy
    - If the commit solves or works on an issue, add the issue number in the front of the subject line in brackets (like so: "[#132] fix item dupe glitch")
+ Extended description
    - Add an extended description unless you only changed a text document (.txt, .md, or another non-code text file), or the change you made was extremely small
    - Press enter before pasting a long link
    - Format well, don't have a single, large block of text for me to read. Use lists, break text into blocks, even add symbols or emojis if you feel it's makes it easier to read
+ How to create a commit message
    - Explain what you did and why you did it.
    - Explain how this effects the problem you're attempting to solve
    - Explain any other side-effects, short-comings, or bugs (new or old) within the new code.
    - Don't expect the reviewer to understand the problem you were trying to fix.
    - Don't assume your code is self-explanatory
    - Reread your commit message before submitting

### Branch names
+ Just name them after what you're fixing
+ Same rules for what NOT to label them apply as the commit rules
+ As for what you DO name them, just say what feature you're working on
+ examples: 'walking anim', 'fall damage', 'dialogue', etc.
+ ***Do not be the reason I have to expand the rules on how to name branches***
