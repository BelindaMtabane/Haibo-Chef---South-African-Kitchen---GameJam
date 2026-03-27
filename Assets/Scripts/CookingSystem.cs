using UnityEngine;
using TMPro;

public class CookingSystem : MonoBehaviour
{
    private int progress = 0;
    public GameObject cookProgress;
    DishInfor DishInfor;
    public Orders orders;
    
    //Create a text ui label
    public TMP_Text progressPercent;
    private void Start()
    {
        if (progressPercent == null)
        {
            Debug.LogWarning("Text is not assigned in the Inspector!");
            return;
        }
    }
    //Create a method to which when the player click on it it ingress progress percent
    public void OnButtonPressed()
    {
        //Increase the progress percent by 20% each time the button is pressed
        progress += 20;
        progressPercent.text = "" + progress + "%";
        if (progress == 110)
        {
            progressPercent.text = "Cooking complete!";
            cookProgress.SetActive(false);
            orders.CompleteOrder(DishInfor.dishName);
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (DishInfor != null) return;
        //Check that the one near to the station is the player
        if (collision.gameObject.CompareTag("Player") )
        {
            cookProgress.SetActive(true);
            OnButtonPressed();
        }
        else
        {
            cookProgress.SetActive(false);
        }
    }

}
