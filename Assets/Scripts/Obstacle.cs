﻿﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    public static Obstacle thisObstacle;

    [SerializeField] private float Speed = 3;

    void Start()
    {
        thisObstacle = this;
    }

    void Update()
    {
        if (transform.position.x <= -8)
            Destroy(gameObject);
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);
    }
}
