using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	public GameObject explosion;


	void OnTriggerEnter(Collider other) {
		Debug.Log (other);
		if (other.tag == "Boundary")
			return;

		Instantiate(explosion, transform.position, transform.rotation);
		if (other.tag != "Player") Destroy(other.gameObject);
		Destroy (gameObject);
	}

}
