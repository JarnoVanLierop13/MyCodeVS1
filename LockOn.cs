//Add to player
//Add to camera
//--------------------
//By Jarno van Lierop
//GD2A
//--------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOn : MonoBehaviour {

    private string enemyTag = "";
    public GameObject focusBar;
    public GameObject focusMarker;
    private bool lockedOn;//lockedon: yes or no
    public Transform enemyTarget;
    public Transform playerTarget;

    void LockOnTarget()
    {
        lockedOn = true;
        enemyTag = "Enemy";//set lockon target Enemy
        transform.LookAt(enemyTarget);//focus camera on Enemy
    }
    void ReleaseTarget()
    {
        lockedOn = false;
        enemyTag = "";//remove Enemy as target
        transform.LookAt(playerTarget);//focus camera on Player
    }

    void Start()
    { //all begin as false
        lockedOn = false;
        focusBar.gameObject.SetActive(false);
        focusMarker.gameObject.SetActive(false);
    }

    void Update () {
        if (lockedOn == false)
        {
            ReleaseTarget();
            if (Input.GetKeyUp(KeyCode.L))
            {
                LockOnTarget();//call
                focusBar.gameObject.SetActive(true);
                focusMarker.gameObject.SetActive(true);
            }
        } else {
            LockOnTarget();
            if (Input.GetKeyUp(KeyCode.L))
            {
                ReleaseTarget();//call
                focusBar.gameObject.SetActive(false);
                focusMarker.gameObject.SetActive(false);
            }
        }            
	}   
}
