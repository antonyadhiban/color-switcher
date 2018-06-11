using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public GameObject randomLevel;
	public Transform generationPoint;
	public float distanceBetween;

	private float levelHeight;

	float distanceTravelled = 0;
	Vector3 lastPosition;

	// Use this for initialization
	void Start () {
		lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		distanceTravelled += Vector3.Distance(transform.position, lastPosition);
		lastPosition = transform.position;
	}
}
