﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // prof's code. couldn't get player to ride platform with what i had before
	float freq = 1f; //how fast it goes
    float amp = 1.7f; //how far platform goes

    float theta = 0;

    Vector3 startPosition;
    Vector3 previousPosition;
    public Vector3 DistanceMoved = Vector3.zero;

   
    void Start()
    {
        startPosition = transform.position;
        previousPosition = transform.position;
    }

    
    void Update()
    {
    	theta += Time.deltaTime;
        // mostly because of these 2 lines:
        // I was using a timer to decide when platforms switched direction, not sin
        Vector3 newPos = startPosition + transform.forward * Mathf.Sin(theta * freq) * amp;
        transform.position = newPos;
        
     
        DistanceMoved = transform.position - previousPosition;

        previousPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player")) {
			PlayerController player = other.gameObject.GetComponent<PlayerController>();
			player.PlatformAttachedTo = this;
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player")) {
			PlayerController player = other.gameObject.GetComponent<PlayerController>();
			player.PlatformAttachedTo = null;
		}
	}
}
