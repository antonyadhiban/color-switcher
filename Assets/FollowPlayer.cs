using UnityEngine;
using UnityEngine.SceneManagement;


public class FollowPlayer : MonoBehaviour {

	public Transform player;

	public Vector3 currentPosition;

	private float obstaclePosition;
	private float orbPosition; 

	public GameObject easy;
	public GameObject medium;
	public GameObject hard;
    public GameObject orb;

	void Start () {
		currentPosition = player.position;
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

        if (player.position.y -currentPosition.y > 4)
        {
            Debug.Log("Happening right now 4");
        }

        if (player.position.y - currentPosition.y > 10){
            Debug.Log("Happening right now 10");
            GenerateRandomLevel();
            currentPosition.y = player.position.y;
        }
	}

	void GenerateRandomLevel(){
		var randomLevelIndex = Random.Range(0,3);
        Debug.Log(randomLevelIndex);
        switch(randomLevelIndex){
            case 0:
                Instantiate(easy, new Vector3(0f, 4f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, 8f, 0f), transform.rotation);
                break;
            case 1:
                Instantiate(medium, new Vector3(0f, 4f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, 8f, 0f), transform.rotation);
                break;
            case 2:
                Instantiate(hard, new Vector3(0f, 4f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, 8f, 0f), transform.rotation);
                break;
        }
	}
}
