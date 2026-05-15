using UnityEngine;

public class Hazard : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.position = Checkpoint.lastCheckpoint;
            Debug.Log("Hit spike! Respawning at checkpoint.");
        }
    }
}