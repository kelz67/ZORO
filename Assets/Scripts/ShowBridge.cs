﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowBridge : MonoBehaviour 

{
	public GameObject bridge;
	public int enemiesToKill;

	// Use this for initialization
	void Start () {
		bridge.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") {
			if (InventoKill.Refrence.KilledEnemies >= enemiesToKill ) {
				//&& InventoKill.Refrence.haveKey
				//active the bridge
				bridge.gameObject.SetActive (true);
			}
		}
		
	}
}
