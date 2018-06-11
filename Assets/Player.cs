using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2d rb;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")) || Input.GetMouseButtonDown(0) || Input.GetTouch(1)){
			rb.velocity = Vector2.up * jumpForce;
		}
	}
}
