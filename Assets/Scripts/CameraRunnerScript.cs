using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	public Transform player;
	
	private float delta;
	private float yposition;

	void Start(){
		delta = player.position.y;
	}

	void Update () {
		if (delta > player.position.y +5) {
			yposition = delta;
		} else {
			yposition = player.position.y + 2;
		}
		transform.position = new Vector3 (player.position.x, yposition, player.position.z - 12);
		if (Input.GetKey ("escape")) {
			Application.LoadLevel(2);
		}
	}
}
//player.position.y + 10