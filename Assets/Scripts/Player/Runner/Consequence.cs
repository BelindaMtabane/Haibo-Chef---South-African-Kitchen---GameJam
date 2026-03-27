using TMPro.Examples;
using UnityEngine;
using TMPro;

public class Consequence : MonoBehaviour
{
    //Declarations
    private float maxHP = 100f;
    private float damage;
    private float currentHP;
    PlayerMovement playerMovement;
    public TMP_Text health;
    RecognitionBar recognitionBar;

    //Create the starting method
    void Start()
    {
        if (health == null)
        {
            Debug.LogWarning("Text is not assigned in the Inspector!");
            return;
        }
        //Set the player health to the maximum
        currentHP = maxHP;
        damage = Random.Range(10.0f, 20.0f);
        playerMovement = GetComponent<PlayerMovement>();
    }
    void DamageTaker(float damager)
    {
        currentHP -= damager;
        health.text = "Health: " + currentHP;
        recognitionBar.qualitycontroller = -6;
        Death();
    }
    void HealthIntaker(int healthPickup)
    {
        currentHP += healthPickup;
        recognitionBar.qualitycontroller = 7;
        health.text = "Health: " + currentHP;
        if (currentHP >= maxHP)
        {
            currentHP = maxHP;
        }
    }
    void Death()
    {
        if (currentHP <= 0)
        {
            Debug.Log("Player died!");
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("health"))
        {
            HealthIntaker(10);
        }
        if (collision.gameObject.CompareTag("speed"))
        {
            playerMovement.speed += 10f;
        }
        if (collision.gameObject.CompareTag("Obstacle1"))
        {
            DamageTaker(damage);
        }
        if (collision.gameObject.CompareTag("Obstacle2"))
        {
            playerMovement.speed -= 15f;
        }
    }
}
