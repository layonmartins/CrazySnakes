using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	private float speed = 5f; //velocidade do jogador
	private int direction; //0 = parado, 1 = direita, -1 = Esquerda

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(direction == 1){
			//Move o jogador para direita
			transform.position += Vector3.right * speed * Time.deltaTime;
		} else if(direction == -1){
			//Mover para esquerda
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		
		if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.S))
			ChangeDirection();
		

	}

	//muda a direção do jogador
	void ChangeDirection(){
		direction = (direction == 1) ? -1 : 1;
	}

	//verifica a colisão
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.name == "WallMask")
			ChangeDirection();
	}
}
