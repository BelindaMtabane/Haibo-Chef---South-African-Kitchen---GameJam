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
    private TMP_Text health;
    RecognitionBar recognitionBar;
    public GameObject death ;

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
        death.SetActive(false);
    }
    void DamageTaker(float damager)
    {
        currentHP -= damager;
        Death();
    }
    void HealthIntaker(int healthPickup)
    {
        currentHP += healthPickup;
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
            death.SetActive(true);
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
