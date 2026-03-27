using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;
public class CuttingSystems : MonoBehaviour
{
    //DishCheck dishChecker;
    public GameObject Redbutton;
    public GameObject Bluebutton;
    public GameObject Greenbutton;
    public GameObject Yellowbutton;

    //public TMP_Text cuttext;
    private GameObject[] buttons;
    private string[] colours = { "Red", "Blue", "Green", "Yellow" };
    private GameObject[] sequence;
    private int currentIndex = 0;
    private float timer;
    private bool canClick = false;
    DishInfor DishInfor;

    void Start()
    {
        buttons = new GameObject[] { Redbutton, Bluebutton, Greenbutton, Yellowbutton };
        sequence = new GameObject[buttons.Length];
    }
    void HighlightButtons()
    {
        canClick = true;
        //Highlight the buttons in the sequence
        Debug.Log("Press the buttons: " + "\n" + sequence[0].name + "\n" + sequence[1].name + "\n" + sequence[2].name + "\n" + sequence[3].name);
    }
    void buttonSequence()
    {
        buttons.CopyTo(sequence, 0);
        for (int i = 0; i < sequence.Length; i++)
        {
            //Randomly select buttons for the sequence
            int randomIndex = Random.Range(i, buttons.Length);

            // Swap the buttons
            GameObject temp = sequence[i];
            sequence[i] = sequence[randomIndex];
            sequence[randomIndex] = temp;
        }

        HighlightButtons();
    }
    public void CheckButton(GameObject clickedButton)
    {
        if (!canClick) return;
        Debug.Log("Clicked: " + clickedButton.name);

        //Check if the clickck buttton accompanies the sequence
        bool correct = (clickedButton == sequence[currentIndex]);

        //Provide feedback and move to the next button in the sequence if correct
        if (correct)
        {
            Debug.Log(" Correct button for the position " + (currentIndex + 1));
            currentIndex++;

            //Check if all buttons are correct and pressed
            if (currentIndex >= sequence.Length)
            {
                Debug.Log("Sequence complete!");
                canClick = false;
                Redbutton.SetActive(false);
                Bluebutton.SetActive(false);
                Greenbutton.SetActive(false);
                Yellowbutton.SetActive(false);
            }
        }
        else
        {
            Debug.Log("Wrong button for the position " + (currentIndex + 1));
            canClick = false;
            Debug.Log("Sequence failed! Restarting...");
            currentIndex = 0;
            Redbutton.SetActive(false);
            Bluebutton.SetActive(false);
            Greenbutton.SetActive(false);
            Yellowbutton.SetActive(false);
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (DishInfor != null) return;
        //Check that the one near to the station is the player
        if (collision.gameObject.CompareTag("Player"))
        {
            Redbutton.SetActive(true);
            Bluebutton.SetActive(true);
            Greenbutton.SetActive(true);
            Yellowbutton.SetActive(true);
            buttonSequence();
        }
        else
        {
            Redbutton.SetActive(false);
            Bluebutton.SetActive(false);
            Greenbutton.SetActive(false);
            Yellowbutton.SetActive(false);
        }
    }
}

