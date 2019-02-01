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
#### Editor Only
* Pedestrian Controller (reference to ROS publisher)
* Used for all testing where spatial anchors are not required (becasue spatial anchors cannot be simulated in the Unity editor)
####  HololensOrigin
Includes SpatialMapping that uses a persistent global anchor that will serve as the origin for pedestrians.
**Instructions**
- Look around until you are satisfied with the spatial mapping
- Say "Ready" to stop mapping and observe the pedestrians spawning

##
Affiliation: MIT ACL
