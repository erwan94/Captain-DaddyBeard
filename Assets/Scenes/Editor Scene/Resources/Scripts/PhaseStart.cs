﻿using UnityEngine;
using System.Collections;

/*
 * Put the players at the position of this object.
 * 
 * The players must have the tag "Player".
 */
public class PhaseStart : MonoBehaviour {

	private void Start () {
		string playerTag = "Player";
		GameObject[] players = GameObject.FindGameObjectsWithTag (playerTag);
		if (players.Length == 0)
			Debug.LogError (GetType ().Name + " : No player found. The player must have the tag \"" + playerTag + "\".");

		for (int i = 0; i < players.Length; i++)
			players[i].transform.position = transform.position + i * Vector3.up; // Put players above each other instead of the exact same place.

		GameObject.Destroy (gameObject);
	}
}
