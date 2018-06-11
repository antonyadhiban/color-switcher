using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2D rb;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			rb.velocity = Vector2.up * jumpForce;
		}
	}
}
