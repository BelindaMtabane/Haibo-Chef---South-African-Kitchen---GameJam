using UnityEngine;
using UnityEngine.SceneManagement;

public class SimpleSceneTimer : MonoBehaviour
{
    [Header("Timer Setup")]
    public float countdownSeconds = 3f;
    public float playSeconds = 300f; // 5 minutes
    public bool restartSceneOnTimeUp = false;

    private float timeLeft;
    private bool playing;
    private bool finished;

    public bool IsPlaying => playing && !finished;
    public bool IsFinished => finished;

    private void Start()
    {
        timeLeft = countdownSeconds;
        Debug.Log("Countdown started.");
    }

    private void Update()
    {
        if (finished) return;

        timeLeft -= Time.deltaTime;
        if (timeLeft > 0f) return;

        if (!playing)
        {
            playing = true;
            timeLeft = playSeconds;
            Debug.Log("GO! 5-minute timer started.");
            return;
        }

        finished = true;
        timeLeft = 0f;
        Debug.Log("Time Up!");

        if (restartSceneOnTimeUp)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void OnGUI()
    {
        string label;

        if (!playing)
        {
            label = "Start in: " + Mathf.CeilToInt(timeLeft);
        }
        else if (!finished)
        {
            int minutes = Mathf.FloorToInt(timeLeft / 60f);
            int seconds = Mathf.FloorToInt(timeLeft % 60f);
            label = $"Time Left: {minutes:00}:{seconds:00}";
        }
        else
        {
            label = "Time Up!";
        }

        GUIStyle style = new GUIStyle(GUI.skin.label)
        {
            fontSize = 28,
            alignment = TextAnchor.UpperCenter
        };

        GUI.Label(new Rect(0, 20, Screen.width, 40), label, style);
    }
}
