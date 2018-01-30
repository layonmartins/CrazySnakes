using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerScript : MonoBehaviour {

	public GameObject enemyPrefab; //Prefab do inimigo

	// Use this for initialization
	void Start () {
		InvokeRepeating("GenerateNewEnemy", 1f, 1f);
	}
	
	void GenerateNewEnemy(){
		Vector2 spawnPosition = new Vector2(this.transform.position.x + Random.Range(-2,2), this.transform.position.y - 0.5f);

		//Cria um inimigo novo
		GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity) as GameObject;
	}
}
