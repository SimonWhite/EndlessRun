using UnityEngine;
using System.Collections;

public class BadPowerupScript : MonoBehaviour {

	private GameObject mainCamera;
	
	private bool doRotation = false;
	private float rotation = 0.0f; 

	void Start () {
		mainCamera = GameObject.Find("RealMainCamera");
		if (mainCamera == null) {
			Debug.Log ("Bad powerup Start(): Real Main Camera not found");
		} else {
			mainCamera.camera.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		rotateCamera ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "ShroomRotate"){
			if (this.gameObject.tag == "Player") {
				doRotation = true;
			}
		}
	}

	private void rotateCamera(){
		if (doRotation) {
			Debug.Log ("rotating");
			mainCamera.camera.transform.rotation = Quaternion.Euler (0, 0, rotation++);
		}
		if (rotation == 360f) {
			doRotation = false;
			rotation = 0;
		}
	}

}
