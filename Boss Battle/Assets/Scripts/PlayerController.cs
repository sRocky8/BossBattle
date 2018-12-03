using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//Public Variables
	public float walkSpeed;
	public float rotationSpeed;
	public float health;
	public float healthGainedFromPickup;

	//Private Variables
	private float maxHealth;

	// Use this for initialization
	void Start () {
		maxHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		transform.Translate (0.0f, 0.0f, moveVertical * walkSpeed);
		transform.Rotate(0.0f, moveHorizontal * rotationSpeed, 0.0f);
	}

	void OnTriggerStay (Collider other){
		if (other.tag == "Health" && Input.GetKeyDown(KeyCode.U)) {
			if (health < maxHealth && health > 0.0f) {
				health += healthGainedFromPickup;
			}
		}
	}
}
