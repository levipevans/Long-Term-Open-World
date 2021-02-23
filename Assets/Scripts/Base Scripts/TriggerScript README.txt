- Type: how should we determine if the object entering the collider should trigger it 

 	* Game Object -> is it the exact object set to the variable 'Trigger Object', 

	* Tag -> does it have the tag listed in the variable 'Tag'
 
	* any -> if any object enters the collider it should trigger.)


- Target: What object should we BroadcastMessage to?

	* Other -> the object that triggered the collider

	* SpecificGameObject -> the object set to as 'Target Game Object'


- Target Game Object: see Target

- Trigger Object: see Type

- TriggerTag: see Type

- Function: The function to call when trigger is activated (what to put in the BroadcastMessage() thing)

- RequireButton: Do you need to press a button for the trigger to work? (This does not null out any previous criterion, it is simply adding another one to the list if set true)

- ActivationInput: What button do u have to press? (should be written as an input axis {CASE SENSITIVE})

- Repeat Forever: can the trigger continue to be activated indefinetly?

- Repeat Count: how many times can the trigger be activated (N/A if Repeat Forever is set to true)