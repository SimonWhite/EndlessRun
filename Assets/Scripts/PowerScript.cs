using UnityEngine;
using System.Collections;

public class PowerScript : MonoBehaviour {

	public GameObject explosion;
	private GameObject mainCamera;

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
