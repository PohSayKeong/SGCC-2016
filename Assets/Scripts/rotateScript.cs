﻿using UnityEngine;
using System.Collections;

public class rotateScript : MonoBehaviour
{
    public int speed = 10;
    public float friction = 1;
    public float lerpSpeed = 10;
    private float xDeg;
    private float yDeg = 270;
    private Quaternion fromRotation;
    private Quaternion toRotation;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            xDeg -= Input.GetAxis("Mouse X") * speed * friction;
            yDeg += Input.GetAxis("Mouse Y") * speed * friction;
            fromRotation = transform.rotation;
            toRotation = Quaternion.Euler(yDeg, xDeg, 0);
            transform.rotation = Quaternion.Lerp(fromRotation, toRotation, Time.deltaTime * lerpSpeed);
        }


    }
}
