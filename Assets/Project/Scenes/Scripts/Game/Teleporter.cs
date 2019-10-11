﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour {

	public Teleporter exitTeleporter;
	public float exitOffSet = 2f;

	void OnTriggerEnter(Collider otherCollider){
		
		if (otherCollider.GetComponent<Player> () != null) {
			if (exitTeleporter != null) {
				Player player = otherCollider.GetComponent<Player> ();
				player.transform.position = exitTeleporter.transform.position + exitTeleporter.transform.forward * exitOffSet;
			
			}
		}


	}
}
