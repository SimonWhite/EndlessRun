using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;
	int real_score = 0;
	int temp;

	void Start () {
		score = PlayerPrefs.GetInt ("Score");
		real_score = score;

		for(int i=1; i<=10; i++)
		{
			if(PlayerPrefs.GetInt("highscorePos"+i)<score)
			{
				temp=PlayerPrefs.GetInt("highscorePos"+i);
				PlayerPrefs.SetInt("highscorePos"+i,score);
				if(i<10)
				{
					int j=i+1;
					score = PlayerPrefs.GetInt("highscorePos"+j);
					PlayerPrefs.SetInt("highscorePos"+j,temp);
				}
			}
		}
	}

	void OnGUI()
	{
		GUIStyle Style = new GUIStyle ();
		Style.fontSize = 35;
		GUI.Label (new Rect (Screen.width/6, Screen.height/4, 80, 30), "GAME OVER", Style);

		GUI.Label (new Rect (Screen.width/5*3 + 40, 110, 80, 30), "High scores:");
		for(int i=1; i<=10; i++)
		{
			GUI.Box(new Rect(Screen.width/5*3, 100+40*i, 150, 25), i+". "+PlayerPrefs.GetInt("highscorePos"+i));
		}
		
		Style.fontSize = 25;
		GUI.Label (new Rect (Screen.width/6, Screen.height/3,150,30), "Your score: " +real_score, Style);
		if(GUI.Button(new Rect(Screen.width/5, Screen.height/2,120,45),"Retry"))
		{
			Application.LoadLevel(1);
		}
		if (Input.GetKey ("space")) {
			Application.LoadLevel(1);
		}
		if(GUI.Button(new Rect(Screen.width/5, Screen.height/2 + 60,120,45),"Quit"))
		{
			Application.Quit();
		}

	}

}
