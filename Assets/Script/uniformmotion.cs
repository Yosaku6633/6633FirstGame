﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uniformmotion: MonoBehaviour
{
    public float speed = 1.5f;//move speed
    public 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}