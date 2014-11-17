using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;

	void Start(){

	}

	void Update () {
		transform.position = new Vector3 (player.position.x - 15, 6, player.position.z - 12);
		if (Input.GetKey ("escape")) {
			Application.LoadLevel(2);
		}
	}
}
//player.position.y + 10