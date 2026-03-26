using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StirringSystem : MonoBehaviour
{
    public GameObject Rightbutton;
    public GameObject Leftbutton;
    private GameObject[] buttons;
    private string[] colours = { "Right", "Left"};
    private GameObject[] sequence;
    private int currentIndex = 0;
    private float timer;
    private bool canClick = false;

    void Start()
    {
        buttons = new GameObject[] { Rightbutton, Leftbutton};
        sequence = new GameObject[6];

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
        Debug.Log("Press the buttons: " + "\n" + sequence[0].name + "\n" + sequence[1].name + "\n" + sequence[2].name + "\n" + sequence[3].name + "\n" + sequence[4].name + "\n" + sequence[5].name);
    }
    void buttonSequence()
    {
        
        for (int i = 0; i < sequence.Length; i++)
        {
            //Randomly select buttons for the sequence
            int randomIndex = Random.Range(0, buttons.Length);
            sequence[i] = buttons[randomIndex];
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
