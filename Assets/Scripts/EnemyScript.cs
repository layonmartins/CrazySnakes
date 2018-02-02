using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	private GameObject gameMainController;

	void Start(){
		gameMainController = GameObject.FindGameObjectWithTag("GameMainController");
	}

	//verifica a colisão
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "FloorMask"){
			gameMainController.GetComponent<GameMainControllerScript>().addScore();
			Destroy(gameObject);
		}

		if(col.gameObject.name == "Player")
			Destroy(gameObject);
	}
}
