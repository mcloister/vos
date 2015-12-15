using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject Hazard;
	public int hazardCount;
	public int spawnWait;
	public int startWait;

	void Start() 
	{
		StartCoroutine(SpawnWaves());
	}

	IEnumerator SpawnWaves() {

		yield return new WaitForSeconds(startWait);
		for (int i = 0; i < hazardCount; i++) {
			Vector3 spawnPosition = new Vector3 (0, 0, -0.6F);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate (Hazard, spawnPosition, spawnRotation);
			yield return new WaitForSeconds(spawnWait);
		}

	}

}
