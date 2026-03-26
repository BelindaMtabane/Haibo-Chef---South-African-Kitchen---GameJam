using UnityEngine;

public class DishInfor : MonoBehaviour
{
    public InventorySystem inventorySystem; // Assign in inspector

    public string dishName;

    public InventorySystem.IngredientType[] ingredients;
    public int[] requiredAmounts;
    private bool hasStock = true;

    public void UseIngredients()
    {
        //Check if there is enough stock for ingrdients
        for (int k = 0; k <ingredients.Length; k++)
        {
            if (inventorySystem.ingredients[(int)ingredients[k]] < requiredAmounts[k])
            {
                Debug.Log("Not enough " + ingredients[k]);
                hasStock = false; //Stop the loop if there isnt enough
                break;
            }
        }
        if(hasStock)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                inventorySystem.ingredients[(int)ingredients[i]] -= requiredAmounts[i];
                Debug.Log("Decreased stock of " + ingredients[i] + " .Current stock: " + inventorySystem.ingredients[(int)ingredients[i]]);
            }
        }
        else
        {
            Debug.Log("Not enough ingredients for " + dishName);
        }
    }
}