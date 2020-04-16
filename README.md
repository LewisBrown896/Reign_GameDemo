# Reign (Game Demo)
Capstone project for spring 2020 This game allows the user to walk around a 3d forest environment, attack an enemy, block an enemies attack, run, jump, and crouch. All while using the standard keyboard and mouse controlls

# Table of contents:
* Background
* Technologies used
* Risks and Challenges
* Future Development

# Background
This project came about because some of my colleagues were talking about the role playing game D&D and were mentioning how neat it would be to make a full video game based off the table top. since I am fairly new to making video games I thought about making a combat based 1v1 fighting game demo based off of fantasy monsters as my first game.

# Technologies
1. MakeHuman (Version 1.1.1)  
Website: http://www.makehumancommunity.org/  
There were a couple of softwares that were used for this project. One of the first Softwares used was MakeHuman. MakeHuman is a free open-source program designed for giving users an easy way of creating 3D humanoids. Also has a large repository of 3D assets for your created model. This program was used to make the player character by selecting the zombie humanoid model then adding warlock robes and a medieval helmet.    
![Player Character](/docs/2A.png)
Player Character.  
  
2. Blender (Version 2.82)  
Website: https://www.blender.org/  
Blender is another open source software, but blender is for all types of 3D modeling and can even do animations. This software was used for the game demo to make 3D models of swords and shields.  
![Sword and Shield](/docs/3A.png)  
Sword and Shield.  
  
4. Unity (Version 2018.4.8f1)  
Website: https://unity.com/  
The Unity game engine is capable of rendering full 3D environments, handling complex animations, and uses C# as a programming language. Unity is chosen for this project because it uses the programming language C# which is what i am most familiar with. Unity will be responsible for handeling all the scripts, animations, 3D characters, and 3D environments.  
![Forest](/docs/4A.png)  
Forest  

3. Visual Studio 2019 (Version 16.2)  
Website: https://visualstudio.microsoft.com/  
Microsoft's IDE that is able to create scripts for the game written in c#. Visual Studio was chosen because it supports integration to Unity. This IDE will be used to create scripts for the enemy AI, animation cycles, game physics, and damage calculations  
  
4. Adobe mixamo
Website: https://www.mixamo.com/#/  
Adobe mixamo is a website that makes animation and rigging a lot easier. Mixamo has a large library of free 3d models and animations. You can even upload your own 3d model and it will place the skeleton inside that model. This website will be used in this project for is vast array of animations.  
  
# Risks and Challenges
Risks  
There we not that many risk that were dealt with, but one risk was importing items for the asset store and that item prevents you from running the game. Another risk would be crashes, they do not happen often but they haved caused some set backs.  
  
Challenges  
There were two big noticable challenges when making this project. The First Challenge was the animations, the challenges were that if they were implemented improperly they would cause all sorts of problems such as endlessly looping through all the animations at once, only finishing half of an animation, or messing with your character model. The second challenge was implementing an enemy AI that one prbably took the longest and caused some minor set backs, such as the character just wondering around to just doing nothing, but eventually code was emplemented that will start a chase when the player reaches a certain amount of feet around the Enemy, then the enemy will follow and will attack if the player.  
```
 if (Vector3.Distance(player.position, this.transform.position) < 30) // if player is in a distance of 30 of the enemy
        {
             Vector3 direction = player.position - this.transform.position;
            direction.y = 0; //skeleton doesnt follow on the y axis

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f); //turns entire body to look at player

            anim.SetBool("isIdle", false); //IDle animation false when in range of player

            //follows player along x and z axis
            if (direction.magnitude > 5) //if player is in range of enemy
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("walking", true); //walking animation on
                anim.SetBool("attacking", false); //attack animation off
            }
            else //player is next to from enemy
            {
                anim.SetBool("attacking", true);// attack
                anim.SetBool("walking", false);
            }
        }
```
# Future Development  
The development for future iterations of this game will slowly build upon the what was original project was supposed to be and that will be an RPG based upon the table top game D&D. There are several tutorials on the internet and a lot of resources from unity themselves on how to make small RPG. There are also several books and other online resources. But for now the future interations will have to be about patching several known bugs such as the enemy losing line of sight way too easy, snaping the camera to the head properly, the player character attacking sideways, and the menu popping up way too fast on death. further into the Future additions to the game will include a quest system and an inventory system to start up that original idea of creating an rpg.  
2020 Lewis Brown
