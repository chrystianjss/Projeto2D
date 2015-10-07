using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	Animator animator;
	public float speed;
	int cima = 1;
	int direita = 2;
	int baixo = 3;
	int esquerda = 4;
	

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		float vertical = Input.GetAxis("Vertical");
		float horizontal = Input.GetAxis("Horizontal");


		if (vertical > 0){
			animator.SetInteger("direcao", cima);
			animator.SetFloat("velocidade", 1.0f);
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
		} else if (vertical < 0){
			animator.SetInteger("direcao", baixo);
			animator.SetFloat("velocidade", 1.0f);
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
		} else if (horizontal > 0){
			animator.SetInteger("direcao", direita);
			animator.SetFloat("velocidade", 1.0f);
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
		} else if (horizontal < 0){
			animator.SetInteger("direcao", esquerda);
			animator.SetFloat("velocidade", 1.0f);
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
		} else {
			animator.SetFloat("velocidade", 0.0f);
		}
		
//		if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)){
//			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
//			animator.SetInteger("direcao", cima);
//		}
//		if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
//			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
//			animator.SetInteger("direcao", direita);
//		} 
//		if(Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)){
//			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
//			animator.SetInteger("direcao", baixo);
//		}
//		if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
//			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
//			animator.SetInteger("direcao", esquerda);
//		}

	}


}
