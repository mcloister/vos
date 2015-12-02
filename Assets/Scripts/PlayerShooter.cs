using UnityEngine;
using System.Collections;

public class PlayerShooter : MonoBehaviour {

	public GameObject ball;
	public Transform ballSpawn;
	public float fireRate;
	private float nextFire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(ball, ballSpawn.position, ballSpawn.rotation);
		}
	}
}
