using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {

	public GameObject explosion;
	void OnGUI()
	{
		GUIStyle Style = new GUIStyle ();
		Style.fontSize = 50;

		GUI.Label (new Rect (Screen.width/8, Screen.height/3, 100, 30), "Endless runner", Style);

		GUI.Label (new Rect (Screen.width/5*3 + 40, 110, 80, 30), "High scores:");
		for(int i=1; i<=10; i++)
		{
			GUI.Box(new Rect(Screen.width/5*3, 100+40*i, 150, 25), i+". "+PlayerPrefs.GetInt("highscorePos"+i));
		}

		if(GUI.Button(new Rect(Screen.width/5, Screen.height/2,120,45),"New game"))
		{
			Instantiate(explosion, transform.position, Quaternion.identity);
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width/5, Screen.height/2 + 60,120,45),"Quit"))
		{
			Instantiate(explosion, transform.position, Quaternion.identity);
			Application.Quit();
		}
	}
}
