using UnityEngine;
using TMPro;
using System.Diagnostics.Tracing;

public class PlattingButton : MonoBehaviour
{
    //Create variables
    public int quality;
    public int count;
    //public TMP_Text qualityPercent;
    public GameObject platePanel;
    DishInfor DishInfor;

    //Press a button to be evaluted on the dish to get score
    public void EvaluatePlate()
    {
        //Cacluate the platequality based on other stations
        quality += count;

        Debug.Log("Well done" + "\n"+ " Your food Quality is: \n" + quality.ToString());
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
