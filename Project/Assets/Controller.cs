using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;

public class Controller : Agent
{
    public float speed = 10.0f;
    public Rigidbody rb;

    

    public override void OnActionReceived(ActionBuffers actions)
    {
        int Discrete = actions.DiscreteActions[0];
        // float Continuous = Mathf.Clamp(actions.ContinuousActions[0], -1f, 1f);

        Debug.Log("Discrete :"+ Discrete);
        // Debug.Log("Continuous :", Continuous);
    }

}
