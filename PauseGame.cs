//By Jarno van Lierop
//GD2A
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour {
	
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = 0.0f;//freezes the game
            else
                Time.timeScale = 1.0f;
        }
    }
}
