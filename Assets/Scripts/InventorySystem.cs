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
        //State the initial stock for each category
        ingredients = new int[System.Enum.GetValues(typeof(IngredientType)).Length];
        for (int i = 0; i < ingredients.Length; i++)
        {
            ingredients[i] = maxStock; //Keep the initial ingredients as 20
        }
    }
}
