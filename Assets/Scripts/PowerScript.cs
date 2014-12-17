using UnityEngine;
using System.Collections;

public class PowerScript : MonoBehaviour {

	public GameObject explosion;
	private GameObject mainCamera;
	private GameObject lameCamera;

	public bool doRotation = false;
	private float rotation = 0.0f; 

	HudScript hud;

	void Start(){
		mainCamera = GameObject.Find("RealMainCamera");
	}

	
	void Update(){
		//if (doRotation == true) {
		//	mainCamera.camera.transform.rotation = Quaternion.Euler (0, 0, rotation++);
		//}
		rotateCamera ();
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			hud = GameObject.Find ("Main Camera").GetComponent<HudScript> ();
			hud.IncreaseScore(10);

			if (this.gameObject.tag == "Shroom") {
				//init camera
				lameCamera = GameObject.Find("Main Camera");
				if (lameCamera == null) {
					Debug.Log ("Start(): Main Camera Camera not found");
				}
				
				mainCamera = GameObject.Find("RealMainCamera");
				if (mainCamera == null) {
					Debug.Log ("Start(): Real Main Camera not found");
				}
				bool variable = lameCamera.camera.enabled;
				lameCamera.camera.enabled = mainCamera.camera.enabled;
				mainCamera.camera.enabled = variable;
				doRotation = true;
				hud.IncreaseScore(-20);
				startRotating();
			}

			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}

	void startRotating(){
		doRotation = true;
	}

	private void rotateCamera(){
		if (doRotation) {
			mainCamera.camera.transform.rotation = Quaternion.Euler (0, 0, rotation++);
		}
		if (rotation == 360f) {
			doRotation = false;
			rotation = 0;
		}
	}

}
