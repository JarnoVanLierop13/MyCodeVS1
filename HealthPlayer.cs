//Add to player
//--------------------
//By Jarno van Lierop
//GD2A
//--------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class HealthPlayer : MonoBehaviour {

    private int playerStartingHealth = 100;
    private int playerCurrentHealth;
    private int tempEnemyDamage = 1;
    public bool playerDeath;

    public Transform Enemy;
    public Slider healthBar;
    public GameObject GameOverMenu;

    private void Awake()
    {
        GameOverMenu.gameObject.SetActive(false);
        playerCurrentHealth = playerStartingHealth;
        healthBar.maxValue = playerCurrentHealth;
        healthBar.minValue = 0;
        playerDeath = false;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            TakeDamage();
        }
    }

    void TakeDamage()
    {
        playerCurrentHealth -= tempEnemyDamage;
        healthBar.value = playerCurrentHealth;
    }

    void Update() {
        healthBar.value = playerCurrentHealth;
        if (playerCurrentHealth <= 0)
        {
            PlayerDeath();
        }

        if (playerDeath == true && Input.GetKey(KeyCode.R)) {
            SceneManager.LoadScene("Jarno", LoadSceneMode.Single);//reload scene
        }
	}

    void PlayerDeath()
    { 
        playerDeath = true;
        Time.timeScale = 0.0f;//freeze
        GameOverMenu.gameObject.SetActive(true);
    }
  
  
}