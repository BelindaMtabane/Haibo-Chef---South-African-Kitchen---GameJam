using UnityEngine;

public class ReturnPortal : MonoBehaviour
{
    [SerializeField] private QuickRunnerMode runnerMode;

    private void Awake()
    {
        if (runnerMode == null) runnerMode = FindObjectOfType<QuickRunnerMode>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        if (runnerMode != null) runnerMode.TryReturnThroughPortal();
    }
}
