using UnityEngine;

[CreateAssetMenu(fileName = "NewDish", menuName = "Kitchen/Dish")]
public class DishBase : ScriptableObject
{
    //Create headers for clear section separation
    [Header("Cutting Station")]
    public string[] cuttingOrder;
    public int vegetableUse;
    public int carbsUse;

    [Header("Stirring Station")]
    public string[] stirringDirections;
    public int wetIngredientsUse;
    public int dryIngredientsUse;

    [Header("Cooking Station")]
    public string[] cookingOrder;
    public int meatUse;
    public int spicesUse;
    public int vegetablesCookingCount;
    public int carbsCookingCount;

    [Header("Stirring Station")]
    public float dishTimeHolder;

}
