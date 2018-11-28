﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketRiseFall : MonoBehaviour {

    //Public Variables
    public GameObject switchOne;
    public GameObject switchTwo;
    public Vector3 maxHeight;
    public Vector3 minHeight;
    public float lerpPosition;

    //Private Variables
    private bool switchOneActive;
    private bool switchTwoActive;
    
	// Use this for initialization
	void Start () {
        switchOneActive = false;
        switchTwoActive = false;
	}
	
	// Update is called once per frame
	void Update () {
        switchOneActive = switchOne.GetComponent<Switches>().activated;
        switchTwoActive = switchTwo.GetComponent<Switches>().activated;

        if (switchOneActive == true && switchTwoActive == true)
        {
            transform.position = Vector3.Lerp(maxHeight, minHeight, lerpPosition * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(minHeight, maxHeight, lerpPosition * Time.deltaTime);
        }
    }
}