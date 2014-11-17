using UnityEngine;
using System.Collections;

public class PowerScript : MonoBehaviour {

	public GameObject explosion;
	HudScript hud;

	void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			hud = GameObject.Find ("Main Camera").GetComponent<HudScript> ();
			hud.IncreaseScore(10);
			Instantiate(explosion, transform.position, Quaternion.identity);
			Destroy(this.gameObject);
		}
	}

}
