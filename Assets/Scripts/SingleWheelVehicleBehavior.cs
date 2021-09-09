﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleWheelVehicleBehavior : MonoBehaviour
{
    //Get a permanent reference to the two tires on this axel
    [SerializeField]
    public HingeJoint leftWheel;
    [SerializeField]
    public HingeJoint rightWheel;

    //Create an instance of what will hold the motors
    private JointMotor _rightMotor = new JointMotor();
    private JointMotor _leftMotor = new JointMotor();

    public void UpdateDesiredVelocity(float byThisMuch)
    {
        //set the reference of the motors equal to the motors
        _rightMotor = rightWheel.motor;
        _leftMotor = leftWheel.motor;
        //modify the reference motors
        _rightMotor.targetVelocity -= byThisMuch;
        _leftMotor.targetVelocity += byThisMuch;
        //set the motors equal to the reference motors
        rightWheel.motor = _rightMotor;
        leftWheel.motor = _leftMotor;
    }
}
