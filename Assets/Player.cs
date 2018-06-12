using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public float jumpForce = 10f;

	public Rigidbody2D rb;
	public SpriteRenderer sr;

	public string currentColor;

	public Color colorRed;
	public Color colorGreen;
	public Color colorBlue;
	public Color colorYellow;

	public GameObject first;
	public GameObject second;
	public GameObject third;
	public GameObject orb;

	void Start (){
		SetRandomColor();
		Instantiate (first, new Vector3(0f, 4f, 0f) , transform.rotation);
		Instantiate (orb, new Vector3(0f, 8f, 0f) , transform.rotation);
		Instantiate (second, new Vector3(0f, 4f, 0f) , transform.rotation);
		Instantiate (orb, new Vector3(0f, 8f, 0f) , transform.rotation);
		Instantiate (third, new Vector3(0f, 4f, 0f) , transform.rotation);
		Instantiate (orb, new Vector3(0f, 8f, 0f) , transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			rb.velocity = Vector2.up * jumpForce;
		}
	}

	void OnTriggerEnter2D (Collider2D col){
		if(col.tag != currentColor){
			Debug.Log("Game Over");
			// SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

		if(col.tag == "ColorChanger"){
			SetRandomColor();
			Destroy(col.gameObject);
			return;
		}
	}

	void SetRandomColor(){
		int index = Random.Range(0,4);
		switch(index){
			case 0:
				currentColor = "Blue";
				sr.color = colorBlue;
				break;
			case 1:
				currentColor = "Yellow";
				sr.color = colorYellow;
				break;
			case 2:
				currentColor = "Green";
				sr.color = colorGreen;
				break;
			case 3:
				currentColor = "Red";
				sr.color = colorRed;
				break;
		}
	}
}

