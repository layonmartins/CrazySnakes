﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMainControllerScript : MonoBehaviour {

	public Text scoreText;
	public int score;

	// Use this for initialization
	void Start () {
		Debug.Log("Hi");
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Olá");
		scoreText.text = "Pontos: " + score;
	}
}