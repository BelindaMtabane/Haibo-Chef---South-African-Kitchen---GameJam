using UnityEngine;

public class Consequence : MonoBehaviour
{
    //Declarations
    private float maxHP = 100f;
    private float damage;
    private float currentHP;
    PlayerMovement playerMovement;

    //Create the starting method
    void Start()
    {
        //Set the player health to the maximum
        currentHP = maxHP;
        damage = Random.Range(10.0f, 20.0f);
        playerMovement = GetComponent<PlayerMovement>();
    }
    void DamageTaker(float damager)
    {
        currentHP -= damager;
        Debug.Log("Current HP Damage: " + currentHP);
        Death();
    }
    void HealthIntaker(int healthPickup)
    {
        currentHP += healthPickup;
        Debug.Log("Current HP Increase: " + currentHP);
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
