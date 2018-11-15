using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;
	public float forwardForce = 800f;
	public float sidewaysForce = 800f;

	// Use this for initialization
	void Start () {
		rb.useGravity = true;
	}

	// Fixed for messing up with physics
	void FixedUpdate () {
		// add a forward force
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if( Input.GetKey(KeyCode.RightArrow) ){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if( Input.GetKey(KeyCode.LeftArrow) ){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        // if player falls down
        if( rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
	}
}
