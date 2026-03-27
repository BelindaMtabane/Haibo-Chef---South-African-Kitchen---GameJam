using UnityEngine;
using TMPro;
using System.Diagnostics.Tracing;

public class PlattingButton : MonoBehaviour
{
    //Create variables
    private int quality;
    public int count;
    public TMP_Text qualityPercent;
    public GameObject platePanel;
    DishInfor DishInfor;

    //Press a button to be evaluted on the dish to get score
    public void EvaluatePlate()
    {
        if (qualityPercent == null)
        {
            Debug.LogWarning("Text is not assigned in the Inspector!");
            return;
        }
        //Cacluate the platequality based on other stations
        int random = Random.Range(45, 80);
        
        quality = random;

        qualityPercent.text = "Well done" + "\n"+ " Your food Quality is: \n" + quality;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (DishInfor != null) return;
        //Check that the one near to the station is the player
        if (collision.gameObject.CompareTag("Player") )
        {
            platePanel.SetActive(true);
            EvaluatePlate();
        }
        else
        {
            platePanel.SetActive(false);
        }
    }
}
