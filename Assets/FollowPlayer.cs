using UnityEngine;
using UnityEngine.SceneManagement;


public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public GameObject newRandomLevel;

	public GameObject sampleLevel;
	public GameObject orb;

	public Vector3 start;

	private float obstaclePosition;
	private float orbPosition; 

	void Start () {
		start = transform.position;
		obstaclePosition = 4f;
		orbPosition = 8f;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.y > transform.position.y){
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		}

		if (player.position.y < transform.position.y - 8){
			Debug.Log("Player Fell Down -> Better Luck Next time");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
