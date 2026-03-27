using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using TMPro;

public class RecognitionBar : MonoBehaviour
{
    //Create variables
    public TMP_Text recognitionPercentPLY;
    public TMP_Text recognitionPercentNPC;
    public int RecognitionCountPLY;
    public int RecognitionCountNPC;
    public int qualitycontroller;
    public int qualitycontrollerNPC = 5;
    void Start()
    {
        if (recognitionPercentPLY == null)
        {
            Debug.LogWarning("Text is not assigned in the Inspector!");
            return;
        }
        if (recognitionPercentNPC == null)
        {
            Debug.LogWarning("Text is not assigned in the Inspector!");
            return;
        }
        recognitionPercentPLY.text = "5%";
        recognitionPercentNPC.text = "15%";
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (RecognitionCountPLY >= 100)
            {
                Debug.Log("Lose");
            }
            else if (RecognitionCountPLY < 100)
            {
                RecognitionCountPLY += qualitycontroller;
                RecognitionCountNPC += qualitycontrollerNPC;
                recognitionPercentPLY.text = "Player Recognition: "+RecognitionCountPLY.ToString() + "%";
                recognitionPercentNPC.text = "MainChef Recognition: " + RecognitionCountNPC.ToString() + "%";
            }
            else if (RecognitionCountNPC >= 100)
            {
                Debug.Log("Lose");
            }
            
        }
    }
}
