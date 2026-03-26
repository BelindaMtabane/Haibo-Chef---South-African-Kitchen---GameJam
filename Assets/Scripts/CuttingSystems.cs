using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.UIElements;
public class CuttingSystems : MonoBehaviour
{
    public GameObject Redbutton;
    public GameObject Bluebutton;
    public GameObject Greenbutton;
    public GameObject Yellowbutton;
    private GameObject[] buttons;
    private string[] colours = { "Red", "Blue", "Green", "Yellow" };
    private GameObject[] sequence;
    private int currentIndex = 0;
    private float timer;
    private bool canClick = false;

    void Start()
    {
        buttons = new GameObject[] { Redbutton, Bluebutton, Greenbutton, Yellowbutton };
        sequence = new GameObject[buttons.Length];
        
        buttonSequence();
        HighlightButtons();
        timer = Time.time + 2f;//CountDown Timer
    }
    //Create a method to check if the button clicked matches the sequence
    void Update()
    {
        // Wait before allowing clicks
        if (!canClick && Time.time >= timer)
        {
            canClick = true;
            Debug.Log("Start clicking!");
            timer = Time.time + 5f; // Give player 5 seconds to complete the sequence
        }
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
    }
    public void CheckButton(GameObject clickedButton)
    {
        if (!canClick) return;
        Debug.Log("Clicked: " + clickedButton.name);

        //Check if the clcick buttton accompanies the sequence
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
            }
        }
        else
        {
            Debug.Log("Wrong button for the position " + (currentIndex + 1));
            canClick = false;
            Debug.Log("Sequence failed! Restarting...");
            currentIndex = 0;
            buttonSequence();
        }
    }
}

