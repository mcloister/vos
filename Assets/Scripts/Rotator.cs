using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	//private float angVel;
	public Color lerpedColor = Color.white;
	public Renderer rend;
	private Rigidbody rb;
	public float speed = 50;
	public float rotationalForce;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void FixedUpdate () {
		rotationalForce = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		//transform.Rotate (new Vector3 (0, 0, 30) * rotationalForce);
		Debug.Log ("torque: " + transform.up * rotationalForce);
		rb.AddTorque (transform.up * rotationalForce);
		//lerpedColor = Color.Lerp(Color.white, Color.black, Mathf.Abs(rotationalForce));
		//rend.material.color = lerpedColor;
		//angVel = rb.angularVelocity.magnitude;
	}
	
}
