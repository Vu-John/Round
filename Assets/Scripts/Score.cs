﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Text text;
    private Controls player;

	void Start () {
		text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
	}
	
	void Update () {
		text.text = "Gems: " + player.gems + " / 10";
	}
}
