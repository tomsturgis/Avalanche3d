﻿using UnityEngine;
using System.Collections;

public class ManBehaviourScript : MonoBehaviour {
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}

	public void ReactToHit()
	{
		Debug.Log("im hit:");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float speed = 10;
        Vector3 movement = new Vector3(moveHorizontal,0f,0f);
        rb.velocity = movement * speed;
	}
}
