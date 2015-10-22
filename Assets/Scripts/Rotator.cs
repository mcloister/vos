using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	//private float angVel;
	public Color lerpedColor = Color.white;
	public Renderer rend;
	private Rigidbody rb;
	public float speed;
	private float rotationalForce;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {
		rotationalForce = Input.GetAxis ("Horizontal") * speed;
		transform.Rotate (new Vector3 (0, 0, 30) * rotationalForce);
		lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.Abs(rotationalForce));
		rend.material.color = lerpedColor;
		//angVel = rb.angularVelocity.magnitude;
	}

}
