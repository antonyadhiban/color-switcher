
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public GameObject newRandomLevel;

	public GameObject sampleLevel;
	public GameObject orb;

	public Vector3 start;

	public float obstaclePosition;
	public float orbPosition; 

	void Start () {
		start = transform.position;
		obstaclePosition = 16f;
		orbPosition = 20f;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.y > transform.position.y){
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		}
		if (player.position.y - start.y > 10 ){
			Instantiate (sampleLevel, new Vector3(0f, obstaclePosition, 0f) , transform.rotation);
			Instantiate (orb, new Vector3(0f, orbPosition, 0f) , transform.rotation);
			obstaclePosition = obstaclePosition + 8f;
			orbPosition = orbPosition + 8f;
			Instantiate (sampleLevel, new Vector3(0f, obstaclePosition, 0f) , transform.rotation);
			Instantiate (orb, new Vector3(0f, orbPosition, 0f) , transform.rotation);
			obstaclePosition = obstaclePosition + 8f;
			orbPosition = orbPosition + 8f;
			start = transform.position;
		}
	}
}
