using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;
	public Transform player;
	public float height;

	public bool isGround;

	// Use this for initialization
	void Start () {
		if (isGround) {
			Invoke("Modify", 10.0f);
			Invoke("Modify", 30.0f);
			Invoke("Modify", 60.0f);
		}
		Spawn ();
	}
	
	void Spawn()
	{
		Instantiate (obj [Random.Range (0, obj.Length)], new Vector3 (player.position.x + 70, height, player.position.z), Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}

	void Modify() {
		if (spawnMin < spawnMax) {
			spawnMin = spawnMin * 1.8f;
			spawnMax = spawnMax * 1.3f;
		} else {
			spawnMin = 3.9f;
			spawnMax = 4.2f;
		}

		Spawn ();
	}
}
