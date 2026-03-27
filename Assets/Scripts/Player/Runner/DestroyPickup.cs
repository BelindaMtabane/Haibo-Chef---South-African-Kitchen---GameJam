using UnityEngine;

public class DestroyPickup : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Destroy the object accordingly
            Destroy(gameObject);
            Debug.Log("Collected:" + gameObject.name);
        }
    }
}
