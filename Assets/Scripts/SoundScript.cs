using UnityEngine;
using System.Collections;

public class SoundScript : MonoBehaviour {
	
	public AudioClip CoinSound;
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player")
		{
			AudioSource.PlayClipAtPoint(CoinSound, transform.position);
		}
	}
	
}