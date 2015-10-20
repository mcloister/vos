using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public Color lerpedColor = Color.white;

	// Use this for initialization
	void Start () {
		GetComponent<SpriteRenderer>().color = lerpedColor;
	}

	public float speed = 1;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 30) * Time.deltaTime * speed);
		lerpedColor = Color.Lerp(Color.white, Color.black, speed);

	}

}
