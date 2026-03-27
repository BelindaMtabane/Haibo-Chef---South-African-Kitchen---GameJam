using UnityEngine;
using UnityEngine.SceneManagement;

public class QuickRunnerMode : MonoBehaviour
{
    [SerializeField] private int requiredPickups = 3;
    [SerializeField] private string returnSceneName = "KitchenScene";
    [SerializeField] private float goTextSeconds = 1.5f;

    private int collected;
    private float goTimer;
    private float warningTimer;

    private void Start()
    {
        goTimer = goTextSeconds;
    }

    private void Update()
    {
        if (goTimer > 0f) goTimer -= Time.deltaTime;
        if (warningTimer > 0f) warningTimer -= Time.deltaTime;
    }

    public void CollectCorrectPickup()
    {
        collected++;
    }

    public void TryReturnThroughPortal()
    {
        if (collected >= requiredPickups)
        {
            SceneManager.LoadScene(returnSceneName);
            return;
        }

        warningTimer = 2f;
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

        string objective = $"Collect pickups: {collected}/{requiredPickups} then reach portal";
        GUI.Label(new Rect(0, 20, Screen.width, 40), objective, style);

        if (warningTimer > 0f)
        {
            GUI.Label(new Rect(0, 56, Screen.width, 32), "Collect all required pickups first", style);
        }
    }
}
