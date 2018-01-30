using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	//verifica a colisão
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "FloorMask" || col.gameObject.name == "Player")
			Destroy(gameObject);
	}
}
