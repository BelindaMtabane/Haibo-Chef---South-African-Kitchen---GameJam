using System;
using UnityEngine;


public class InventorySystem : MonoBehaviour
{
    //Create variables
    public int[] ingredients = new int[6];
    public int maxStock = 20;

    public enum IngredientType
    {
        Vegetable, 
        Meat,      
        Spice,     
        Carb,      
        Dry,      
        Wet       
    }

    void Start()
    {
        //Set the stock for each category ingredient
        for (int i = 0; i < ingredients.Length; i++)
        {
            ingredients[i] = maxStock;
            Debug.Log("Initial stock of " + ((IngredientType)i).ToString() + ": " + ingredients[i]);
        }
    }
}
// Define a dish simply with arrays
[System.Serializable]

public class DishChecker
{
    public string dishName;
    InventorySystem InventorySystem;
    public InventorySystem.IngredientType[] ingredients;
    public int[] stockAmount;

    public DishChecker(string receipeName, InventorySystem.IngredientType[] ingredientTypes, int[] stockAmounts)
    {
        dishName = receipeName;
        ingredients = ingredientTypes;
        stockAmount = stockAmounts;
    }
    
    public void StockChecker()
    {
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (InventorySystem.ingredients[(int)ingredients[i]] < stockAmount[i])
            {
                Debug.Log("Not enough " + ingredients[i].ToString() + " to cut for " + dishName);
                return;
            }
            if (ingredients[i] < 0) ingredients[i] = 0;
            Debug.Log("All ingredients are sufficient for cutting " + dishName);
            StockDecrease(ingredients[i]);
        }
    }
    public void StockDecrease(InventorySystem.IngredientType types)
    {
        int stockNum = (int)types;
        //Create a for loop to decrease the stock for each ingredient
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (InventorySystem.ingredients[stockNum] > 0)
            {
                //Decrease the stock based on the amounts required
                InventorySystem.ingredients[stockNum]-= stockAmount[i];
                Debug.Log("Decreased stock of " + types.ToString() + " by 1. Current stock: " + InventorySystem.ingredients[stockNum]);
            }
            else
            {
                Debug.Log("Cannot decrease stock of " + types.ToString() + ". Stock is already at 0.");
            }
        }
    }
    public void StockIncrease(InventorySystem.IngredientType types)
    {
        int stockNum = (int)types;
        //Create a for loop to decrease the stock for each ingredient
        for (int i = 0; i < ingredients.Length; i++)
        {
            if (InventorySystem.ingredients[stockNum] < 20)
            {
                //Decrease the stock based on the amounts required
                InventorySystem.ingredients[stockNum] += stockAmount[i];
                Debug.Log("Increased stock of " + types.ToString() + " by 1. Current stock: " + InventorySystem.ingredients[stockNum]);
            }
            else
            {
                Debug.Log("Full stock in" + types.ToString());
            }
        }
    }
}
