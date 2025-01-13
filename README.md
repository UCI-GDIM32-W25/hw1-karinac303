[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.
UI
  Seed counter (planted and remaining)
  Planted text
  Every time something is planted, add 1 
  Remaining text
  Every time something is planted, subtract 1 to a limit of 0
Plant Prefab
  Plant sprite
  Can be planted if Seeds remaining counter >0
  Can only be created by the player
  Only 5 can exist
Bunny (Player)
  Bunny sprite
  Can move with WASD
  Plant seeds with Space bar
  Adds a plant prefab where the bunny is located IF there’s seeds remaining
  If no seeds remaining, cannot plant (nothing happens)
  Updates UI with changes to seed count and seeds planted



## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.

Following our guide and plan for each object (UI text, plant prefab, Player), I was able to input all the attributes required for each one. I started working on each object individually, starting with the Player object. I created a sprite object for the player(and plantPrefab), then input the bunny image for its sprite. I then implemented code for the bunny to move up, down, left, right with the WASD keys within Update() method so it updates the player's location every frame based on the input. I also implemented code for space to put down a plant, and code to instantiate the _plantPrefab within PlantSeed().

PlantPrefab: 
I also had to set a limit (of 5 seeds you can plant) and did that by adding to _numSeedsPlanted and subtracted from _numSeedsLeft within PlantSeed(); By subtracting from _numSeedsLeft and inputting a conditional statement within the line where you press space to put down a plantPrefab where _numSeedsLeft > 0 to plant, it limited the amount of seeds you plant.

Planted/remaining UI:
For the UI, we needed to show the amount of plants there are remaining and planted. By using the variables _numSeedsLeft and _numSeedsPlanted as arguments for UpdateSeeds(), then calling that method within Plant Seed, I was able to update the UI everytime PlantSeed() was called, and so the player can see how many plants they can plant still. 

all of these attributed that I created were stated in the guide above, and I was able to follow it like a to-do list in order to have all function as it should! 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
