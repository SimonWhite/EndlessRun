using UnityEngine;
using System.Collections;

public class TntScript : MonoBehaviour 
{

	public float force;
	public float radius;
	public GameObject explosion;

	void OnMouseDown()
	{
		/*
		Collider[] colliders = Physics.OverlapSphere (transform.position, radius);
		foreach (Collider c in colliders)
						if (c.rigidbody != null)
								c.rigidbody.AddExplosionForce (force, transform.position, radius, 0.5f, ForceMode.Impulse);
		*/
		Instantiate(explosion, transform.position, Quaternion.identity);

	}

}












