using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {

	private GameObject lameCamera = null;
	private GameObject mainCamera = null;

	public Transform player;
	
	private float delta;
	private float yposition;

	void Start(){
		//init camera
		lameCamera = GameObject.Find("Main Camera");
		if (lameCamera == null) {
			Debug.Log ("Start(): Main Camera Camera not found");
		}
		
		mainCamera = GameObject.Find("RealMainCamera");
		if (mainCamera == null) {
			Debug.Log ("Start(): Real Main Camera not found");
		}
		lameCamera.camera.enabled = false;
		mainCamera.camera.enabled = true;
	}

	void Update () {
		if (delta > player.position.y + 9) {
			yposition = delta;
		} else {
			yposition = player.position.y + 9;
		}
		transform.position = new Vector3 (player.position.x, yposition - 5, player.position.z - 12);
		if (Input.GetKey ("escape")) {
			Application.LoadLevel(2);
		}
	}
}
//player.position.y + 10