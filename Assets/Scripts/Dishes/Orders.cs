using UnityEngine;
using TMPro;
using System.Collections.Generic;

public class Orders : MonoBehaviour
{
    // Assign all your DishInfor objects here in the inspector
    public DishInfor[] allDishes;
    public int count;

    //Text of the orders
    public TMP_Text ordersLabel; // No changes needed here after including the correct namespace

    //Orders active
    private List<DishInfor> activeOrders = new List<DishInfor>();

    // Start: pick some orders to show
    void Start()
    {
        count = 2; //Start with 2 order
        GeneratorOrder();
        UpdateOrdersUI();
    }
    public void GeneratorOrder()
    {
        activeOrders.Clear();
        //Check if there are dishes to do
        while (activeOrders.Count < count)
        {
            DishInfor order = allDishes[Random.Range(0, allDishes.Length)];
            if (!activeOrders.Contains(order))
            {
                activeOrders.Add(order);
            }
        }
    }
    public void CompleteOrder(string dishName)
    {
        DishInfor order = activeOrders.Find(d => d.dishName == dishName);
        if (order != null)
        {
            activeOrders.Remove(order);
            Debug.Log("Order completed");
            UpdateOrdersUI();
        }
    }

    void UpdateOrdersUI()
    {
        //Check if orders are assigned
        if (ordersLabel == null) return;

        ordersLabel.text = "Orders:\n";
        //Check if there are active orders
        foreach (DishInfor order in activeOrders)
        {
            ordersLabel.text += order.dishName + "\n";
        }
    }
    void Update()
    {
        
        //Check if there are no active orders
        if (activeOrders.Count == 0)
        {
            count++; //Increment the order
            GeneratorOrder(); //Start a new round of orders
        }
    }

}
