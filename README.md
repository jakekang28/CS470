# CS470
## Final Project : Contributor : 20190015 강지훈, 20190437 이경재

Our project is about simulating quadruped robots in Unity. 
## Prerequisites
Initially, in the Unity Editor we should export MLAgents Package, so that it helps the model to be trained in the Unity Editor. <br/>
The MLAgents installation guide : ```https://github.com/Unity-Technologies/ml-agents/blob/develop/docs/Installation.md``` <br/>
Also, we need python version over 3.8, and less than 3.11. This is because the numpy modules' precompiled wheels are not distributed for python 3.11. 
Then, install the Unity Editor and the Unity Hub in the official website.

After installation, replace the ml-agents-main/Project folder to our folder. In the ml-agents-main folder, there are many dependencies and used libraries, so this is necessary. Then on the Unity Hub, do Open Project on the Projects folder which is replaced by ours. 

The robot is run by three types of scripts. DecisionRequester, BehaviorParameters, and the Agent. The rewards and the orientation that the robot follows is determined in the Agent file. Then the DecisionRequester decides the action depending on the result that Agent produces. The vector values of the joint strength and rotation values are saved in BehaviorParameters. 

In Unity C# script we can add public components in the script to enable manipulation in the Unity Editor. All of the joints and body parts are declared as public. 



Next, in the Unity editor, we drag and drop the body parts to the parameters of the script to be sensed. If all of the parameters are set, we turn on the cmd.

![unity화면](https://user-images.githubusercontent.com/108389214/206897377-55363d75-ac12-417f-8dca-a0051851be8e.png)


In the cmd, we type 
 
```py {version} mlagents-learn --force --run-id= {the name you want}```

Then the model will be trained for the max steps we registered. 

For 500,000 steps the model file is automatically saved in the TFmodels folder. Then we drag and drop the .onnx file to the Unity Editor in the BehaviorParameter folder 'Model' section.

Then click the Play button to see the behavior of the robot.


