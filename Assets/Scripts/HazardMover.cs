using UnityEngine;
using System.Collections;

public class HazardMover : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {

		//had to Google this as well...ahem ;)
		//http://answers.unity3d.com/questions/46770/rotate-a-vector3-direction.html
		Vector3 direction = Quaternion.Euler(0,0,Random.Range(0, 360)) * Vector3.right;
		GetComponent<Rigidbody> ().velocity = direction * speed;
	}

}
