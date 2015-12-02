using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	//private float angVel;
	public Color lerpedColor = Color.white;
	public Renderer rend;
	private Rigidbody rb;
	public float speed = 50;
	public float rotationalForce;
	Vector3 rotation = new Vector3 (0,0,0);


	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void FixedUpdate () {
		//physicsRotate();

//		rotation = new Vector3(0, 198*OSCControl.xWaxPitch, 0);
//		rb.transform.Rotate(rotation*Time.deltaTime);


		//lerpedColor = Colo	r.Lerp(Color.white, Color.black, Mathf.Abs(rotationalForce));
		//rend.material.color = lerpedColor;
		//angVel = rb.angularVelocity.magnitude;
	}


	void physicsRotate() {
		rotationalForce = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
		Debug.Log ("input: " + Input.GetAxis("Horizontal") * Time.deltaTime);
		//Debug.Log ("torque: " + transform.up * rotationalForce);
		rb.AddTorque (transform.up * rotationalForce);
	}
	
}
