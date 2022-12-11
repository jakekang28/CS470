# CS470
## Final Project : Contributor : 20190015 강지훈, 20190437 이경재

Our project is about simulating quadruped robots in Unity. 
## Prerequisites
Initially, in the Unity Editor we should export MLAgents Package, so that it helps the model to be trained in the Unity Editor.
Also, we need python version over 3.8, and less than 3.11. This is because the numpy modules' precompiled wheels are not distributed for python 3.11. 

The robot is run by three types of scripts. DecisionRequester, BehaviorParameters, and the Agent. The rewards and the orientation that the robot follows is determined in the Agent file. Then the DecisionRequester decides the action depending on the result that Agent produces. The vector values of the joint strength and rotation values are saved in BehaviorParameters. 

In Unity C# script we can add public components in the script to enable manipulation in the Unity Editor. All of the joints and body parts are declared as public. 

Next, in the Unity editor, we drag and drop the body parts to the parameters of the script to be sensed. If all of the parameters are set, we turn on the cmd.


In the cmd, we type 
'''c 
py {version} mlagents-learn --force --run-id= {the name you want}
'''
