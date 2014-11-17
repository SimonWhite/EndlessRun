using UnityEngine;
using System.Collections;

public class BackgroundScript : MonoBehaviour 
{
	public int materialIndex = 0;
	public Vector2 uvAnimationRate = new Vector2( -0.75f, 0.0f );
	public string textureName = "_MainTex";
	
	Vector2 uvOffset = Vector2.zero;
	
	void LateUpdate() 
	{
		uvOffset += ( uvAnimationRate * Time.deltaTime );
		if( renderer.enabled )
		{
			renderer.materials[ materialIndex ].SetTextureOffset( textureName, uvOffset );
		}
	}
}