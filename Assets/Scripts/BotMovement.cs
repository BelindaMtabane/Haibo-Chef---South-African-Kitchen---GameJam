using UnityEngine;
using UnityEngine.AI;

public class BotMovement : MonoBehaviour
{
    public Transform[] cookPoints;

    private NavMeshAgent agent;
    private int currentPoint = 0;
    private float timer = 0f;
    private bool isWaiting = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        if (cookPoints == null || cookPoints.Length == 0)
        {
            Debug.LogError("No cook points assigned!");
            enabled = false;
            return;
        }

        MoveToNextPoint();
    }

    void Update()
    {
        // Check if reached destination
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            if (!isWaiting)
            {
                // Start waiting once
                timer = Random.Range(2f, 5f);
                isWaiting = true;
            }

            // Count down
            timer -= Time.deltaTime;

            if (timer <= 0f)
            {
                MoveToNextPoint();
                isWaiting = false;
            }
        }
    }

    void MoveToNextPoint()
    {
        currentPoint = (currentPoint + 1) % cookPoints.Length;
        agent.SetDestination(cookPoints[currentPoint].position);
    }
}
