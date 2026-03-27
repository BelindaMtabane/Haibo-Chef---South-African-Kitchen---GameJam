using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [Header("Timer")]
    [SerializeField] private float runSeconds = 120f;
    [SerializeField] private TMP_Text label;

    [Header("Player Return")]
    [SerializeField] private Transform player;
    [SerializeField] private float returnX = -23.1f;
    [SerializeField] private float returnZ = -48.3f;
    [SerializeField] private bool restartTimerAfterReturn = true;

    private float timer;
    private float goTimer = 1f;

    private void Start()
    {
        timer = runSeconds;
        if (label != null) label.text = "GO!";
    }

    private void Update()
    {
        if (goTimer > 0f)
        {
            goTimer -= Time.deltaTime;
            if (goTimer <= 0f && label != null)
                label.text = "Time: " + Mathf.CeilToInt(timer);
            return;
        }

        timer -= Time.deltaTime;
        if (timer > 0f)
        {
            if (label != null) label.text = "Time: " + Mathf.CeilToInt(timer);
            return;
        }

        if (label != null)
        {
            label.text = "Time's Up! Returning to kitchen...";
        }

        if (player != null)
        {
            Vector3 p = player.position;
            player.position = new Vector3(returnX, p.y, returnZ);
        }

        if (restartTimerAfterReturn)
        {
            timer = runSeconds;
            goTimer = 1f;
            if (label != null) label.text = "GO!";
        }
        else
        {
            enabled = false;
        }
    }
}
