using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    NetworkHandler net;
    float YPos = 0;
    private void Awake()
    {
        net = new(null);
        net.setCallback(PlayerPosition);
    }
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        //YPos++;
        //transform.position = new Vector2(transform.position.x, (float)Math.Tanh((YPos)%100/15)*4);
        transform.position = new Vector2(transform.position.x, YPos);
    }

    void PlayerPosition(int SensorDistance)
    {
        // SensorDistance 10 or lower = Y=-4
        // SensorDistance 20 = Y=0
        // SensorDistance 30 or higher = Y=4
        if (SensorDistance <= 10) YPos = -4;
        else if (SensorDistance > 30) YPos = 4;
        else YPos = (float)(SensorDistance*0.4 - 8);

    }
}
