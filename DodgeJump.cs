//Add to player
//--------------------
//By Jarno van Lierop
//GD2A
//--------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DodgeJump : MonoBehaviour {

    public int dodgeSpeed;
    public int jumpHeight;
	
	void Update () {
		if (Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.LeftShift)))//L-shift + A == 
        {
            transform.position += Vector3.left * dodgeSpeed * Time.deltaTime;
            transform.position += Vector3.up * jumpHeight * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D) && (Input.GetKey(KeyCode.LeftShift)))//L-shift + D ==
        {
            transform.position += Vector3.right * dodgeSpeed * Time.deltaTime;
            transform.position += Vector3.up * jumpHeight * Time.deltaTime;
        }
    }
}
