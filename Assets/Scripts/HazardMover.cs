using UnityEngine;
using System.Collections;

public class HazardMover : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		float dir = Random.Range (1, 4);

		if (dir < 1) GetComponent<Rigidbody>().velocity = transform.up * speed;
		else if (dir < 2) GetComponent<Rigidbody>().velocity = transform.right * speed;
		else if (dir < 3) GetComponent<Rigidbody>().velocity = transform.up * -speed;
		else if (dir < 4) GetComponent<Rigidbody>().velocity = transform.right * -speed;
	}

}
