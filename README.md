# Pedestrian Simulation via Hololens and ROS

## Dependencies
* Unity 2018.x
* Net 4.x
* Visual Studio 2017+

## Installation

#### Unity
* Download project.
* Open the project which is the *ACL_Holo_ROS/ACL_Holo_ROS* folder
* In Unity, Open a [scene](#Scenes) under the *Scenes* folder
* In the *PedestrianController* object, change the **serverURL** to your ROS URL.
#### ROS
Any ROS publisher that uses WebSocket (with port 9090) will work. To use the pedestrian simulation engine follow [these](https://github.com/blutjens/pedestrian_simulation) instructions


## Scenes
#### Base 
A project including the bare requirements for running a Hololens and ROS project.
* Configured VR settings
* Hololens Camera
#### Editor
A project that can be run entirely from the editor and can be used for debugging network traffic. Includes everything base project has, additionally: 
* Pedestrian Controller (reference to ROS publisher)
####  Hololens
Includes SpatialMapping, VoiceInput and uses a persistent global anchor that will serve as the origin for pedestrians.
**Instructions:**
- Look around until you are satisfied with the spatial mapping
- Say "Ready" to stop mapping and observe the pedestrians spawning
- If it your first time running the project, you will be prompted to place down your origin, all subsequent iterations of the program will use that anchor and prmpt you to continue with the voice command "*start*" or give you the option to re-configure the position of your origin.
- Once you say *start*, the pedestrians should spawn and move relative to the origin you have set.
### Demo
Created so that the user does not have to use voice commands or input; in this project, the pedestrians will spawn immediately and the spatial map will be continuously updated.
##
Affiliation: MIT ACL
