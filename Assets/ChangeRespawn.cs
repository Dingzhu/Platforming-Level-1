using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeRespawn : MonoBehaviour {

	public GameObject player;
	public Vector3 newPoint;

	void OnTriggerEnter2D(Collider2D collision)
	{
		
		if (collision.gameObject.tag == "Player")
		{ 
			Debug.Log ("HHAHAHA");
			player.GetComponent<Respawn> ().ChangeRespawn (newPoint);
		}
	}
}
