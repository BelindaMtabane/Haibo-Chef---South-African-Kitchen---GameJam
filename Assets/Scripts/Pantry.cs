using UnityEngine;

public class Pantry : MonoBehaviour
{
    // Create variables
    DishInfor DishInfor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Increate the stock each time the person interact
            DishInfor.increaseStock();
        }
            
    }
}
