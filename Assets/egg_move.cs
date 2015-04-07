using UnityEngine;
using System.Collections;

public class egg_move : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//xac = 1f * Input.acceleration.x;
		GetComponent<Rigidbody2D>().AddForce(Vector2.up*Input.acceleration.y*2, ForceMode2D.Impulse);
		//transform.Rotate();
	}
}
