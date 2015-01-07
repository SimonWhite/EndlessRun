using UnityEngine;
using System.Collections;

public class HudScript : MonoBehaviour {

	public GameObject rain, storm, explosion;

	private float playerScore = 0;
	private bool boom = false;

	void Start (){
		rain = GameObject.Find ("Rain");
		rain.renderer.enabled = false;
		storm = GameObject.Find ("Rain Storm");
		storm.renderer.enabled = false;
	}

	void Update () {
		playerScore += Time.deltaTime;
		if (boom) {
			transform.position = new Vector3(transform.position.x - 10, transform.position.y - 10, transform.position.z);
			Instantiate(explosion, transform.position, Quaternion.identity);
			boom = false;
		}
		if (playerScore > 20) {
			rain.renderer.enabled = true;
		}
		if (playerScore > 30) {
			storm.renderer.enabled = true;
		}
	}

	public void IncreaseScore(int amount)
	{
		playerScore += amount;
		boom = true;
	}

	void OnDisable()
	{
		PlayerPrefs.SetInt ("Score", (int)(playerScore*100));
	}

	void OnGUI()
	{
		GUIStyle style = new GUIStyle();
		style.fontSize = 48;
		GUI.Label (new Rect (20, 20, 100, 30), "Score: " + (int)(playerScore * 100), style);
	}

}
