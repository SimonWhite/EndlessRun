using UnityEngine;
using System.Collections;

public class PowerScript : MonoBehaviour {

	public GameObject explosion;

	HudScript hud;

	void Start(){
	}

	
	void Update (){
		//if (doRotation == true) {
		//	mainCamera.camera.transform.rotation = Quaternion.Euler (0, 0, rotation++);
		//}
	}

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player"){
			hud = GameObject.Find ("Main Camera").GetComponent<HudScript> ();
			hud.IncreaseScore(10);

			if (this.gameObject.tag == "Shroom") {
				hud.IncreaseScore(-20);
			}
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}
}
