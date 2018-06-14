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
        Instantiate(easy, new Vector3(0f, obstaclePosition, 0f), transform.rotation);
        Instantiate(orb, new Vector3(0f, orbPosition, 0f), transform.rotation);
        Instantiate(easy, new Vector3(0f, obstaclePosition + 8f, 0f), transform.rotation);
        Instantiate(orb, new Vector3(0f, orbPosition + 8f, 0f), transform.rotation);
        Instantiate(medium, new Vector3(0f, obstaclePosition + 16f, 0f), transform.rotation);
        Instantiate(orb, new Vector3(0f, orbPosition + 16f, 0f), transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if (player.position.y > transform.position.y){
			transform.position = new Vector3(transform.position.x, player.position.y, transform.position.z);
		}

		if (player.position.y < transform.position.y - 8f){
			Debug.Log("Player Fell Down -> Better Luck Next time");
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

        if (player.position.y - currentPosition.y > 24f){
            Debug.Log("Happening right now 8");
            GenerateRandomLevel();
            GenerateRandomLevel();
            currentPosition.y = player.position.y;
        }
	}

	void GenerateRandomLevel(){
		var randomLevelIndex = Random.Range(0,3);
        Debug.Log(randomLevelIndex);
        switch(randomLevelIndex){
            case 0:
                Instantiate(easy, new Vector3(0f, obstaclePosition, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition, 0f), transform.rotation);
                Instantiate(easy, new Vector3(0f, obstaclePosition + 8f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 8f, 0f), transform.rotation);
                Instantiate(medium, new Vector3(0f, obstaclePosition + 16f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 16f, 0f), transform.rotation);
                break;
            case 1:
                Instantiate(easy, new Vector3(0f, obstaclePosition, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition, 0f), transform.rotation);
                Instantiate(medium, new Vector3(0f, obstaclePosition + 8f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 8f, 0f), transform.rotation);
                Instantiate(medium, new Vector3(0f, obstaclePosition + 16f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 16f, 0f), transform.rotation);
                break;
            case 2:
                Instantiate(hard, new Vector3(0f, obstaclePosition, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition, 0f), transform.rotation);
                Instantiate(medium, new Vector3(0f, obstaclePosition + 8f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 8f, 0f), transform.rotation);
                Instantiate(hard, new Vector3(0f, obstaclePosition + 16f, 0f), transform.rotation);
                Instantiate(orb, new Vector3(0f, orbPosition + 16f, 0f), transform.rotation);
                break;
        }
        obstaclePosition = obstaclePosition + 24f;
        orbPosition = orbPosition + 24f;
	}
}
