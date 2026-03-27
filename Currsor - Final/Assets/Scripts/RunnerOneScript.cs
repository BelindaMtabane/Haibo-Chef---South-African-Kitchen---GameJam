using UnityEngine;
using UnityEngine.SceneManagement;

public class RunnerOneScript : MonoBehaviour
{
    [Header("Setup")]
    public string returnSceneName = "KitchenScene";
    public int requiredPickups = 3;
    public float goSeconds = 1.5f;

    private int collected;
    private float goTimer;
    private float warningTimer;

    private void Start()
    {
        goTimer = goSeconds;
    }

    private void Update()
    {
        if (goTimer > 0f) goTimer -= Time.deltaTime;
        if (warningTimer > 0f) warningTimer -= Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("CorrectPickup"))
        {
            collected++;
            Destroy(other.gameObject);
            return;
        }

        if (other.CompareTag("ReturnPortal"))
        {
            if (collected >= requiredPickups)
            {
                SceneManager.LoadScene(returnSceneName);
            }
            else
            {
                warningTimer = 2f;
            }
        }
    }

    private void OnGUI()
    {
        GUIStyle style = new GUIStyle(GUI.skin.label)
        {
            fontSize = 28,
            alignment = TextAnchor.UpperCenter
        };

        if (goTimer > 0f)
        {
            GUI.Label(new Rect(0, 20, Screen.width, 40), "GO!", style);
            return;
        }

        GUI.Label(
            new Rect(0, 20, Screen.width, 40),
            $"Collect: {collected}/{requiredPickups} then go to portal",
            style
        );

        if (warningTimer > 0f)
        {
            GUI.Label(new Rect(0, 56, Screen.width, 32), "Get all pickups first", style);
        }
    }
}
