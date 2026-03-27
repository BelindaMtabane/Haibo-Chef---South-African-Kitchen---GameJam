using Unity.Content;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DishInfor : MonoBehaviour
{
    public InventorySystem inventorySystem; // Assign in inspector

    public string dishName;
    public bool canCook = false;
    public InventorySystem.IngredientType[] ingredients;
    public int[] requiredAmounts;
    private bool hasStock = true;

    public void UseIngredients()
    {
        Debug.Log("Prepare " + dishName);
        //Check if there is enough stock for ingrdients
        for (int k = 0; k <ingredients.Length; k++)
        {
            if (inventorySystem.ingredients[(int)ingredients[k]] < requiredAmounts[k])
            {
                Debug.Log("Not enough " + ingredients[k]);
                hasStock = false; //Stop the loop if there isnt enough stock

                break;
            }
        }
        if(hasStock)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                //Decrease the stock to the ingredients used
                inventorySystem.ingredients[(int)ingredients[i]] -= requiredAmounts[i];
                Debug.Log("Decreased stock of " + ingredients[i] + " .Current stock: " + inventorySystem.ingredients[(int)ingredients[i]]);
                canCook = true;
            }
        }
        else
        {
            Debug.Log("Not enough ingredients for " + dishName);
        }
    }
    
}