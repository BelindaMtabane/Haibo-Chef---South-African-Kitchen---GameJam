using UnityEngine;

public class CuttiingSystems : MonoBehaviour
{
    //Instantiate variables
    InventorySystem inventorySystem;
    DishChecker dishChecker;

    //Create an method to check if the player intereacted with the correct button when they trigger an area
    void Checker()
    {
        Debug.Log("Display cut by interacting text");
        if (Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("Decrease Stock");
            dishChecker.StockChecker();
        }
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("CuttingBoardSpace"))
        {
            // Implement cutting logic here
            Debug.Log("Dsiplay cut by interacting with a button");
            Checker();
        }
    }
}
