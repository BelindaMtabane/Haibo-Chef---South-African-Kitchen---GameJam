using UnityEngine;

public class DishInfor : MonoBehaviour
{
    DishChecker dishChecker;
    //South African Dishes
    public DishChecker Brekkie;
    public DishChecker BraaiMeal;
    public DishChecker MalvaPudding;
    public DishChecker Bobtie;
    public DishChecker SourPorridge;
    public DishChecker SampMeatStew;


    void Start()
    {
        // Initialize dishes
        Brekkie = new DishChecker("Brekkie", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Carb,
                                InventorySystem.IngredientType.Vegetable, InventorySystem.IngredientType.Meat,
                                InventorySystem.IngredientType.Spice},
                                new int[] { 2, 2, 1, 2 });

        BraaiMeal = new DishChecker("BraaiMeal", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Carb,
                                InventorySystem.IngredientType.Vegetable,InventorySystem.IngredientType.Wet,
                                InventorySystem.IngredientType.Dry,InventorySystem.IngredientType.Spice,
                                InventorySystem.IngredientType.Meat},
                                new int[] { 2, 3, 2, 1, 2, 1 });

        MalvaPudding = new DishChecker("MalvaPudding", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Wet,
                                InventorySystem.IngredientType.Dry, InventorySystem.IngredientType.Spice},
                                new int[] { 1, 3, 2 });

        Bobtie = new DishChecker("Bobtie", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Wet,
                                InventorySystem.IngredientType.Dry, InventorySystem.IngredientType.Spice},
                                new int[] { 2, 3, 1 });

        SourPorridge = new DishChecker("SourPorridge", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Carb,
                                InventorySystem.IngredientType.Wet,InventorySystem.IngredientType.Spice},
                                new int[] { 2, 3, 2 });

        SampMeatStew = new DishChecker("SampMeatStew", new InventorySystem.IngredientType[] { InventorySystem.IngredientType.Carb,
                                InventorySystem.IngredientType.Vegetable,InventorySystem.IngredientType.Meat,
                                InventorySystem.IngredientType.Spice, InventorySystem.IngredientType.Carb,
                                InventorySystem.IngredientType.Wet},
                                new int[] { 2, 3, 3, 2, 3, 2 });
    }
}
