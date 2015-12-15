using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {

	void OnTriggerExit(Collider other) {
		// Destroy everything that leaves the trigger
		if (other.tag != "Player") Destroy(other.gameObject);
	}

}
