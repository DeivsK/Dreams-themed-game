using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public static Vector3 lastCheckpoint = new Vector3(0, 2, 0); // Default spawn
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lastCheckpoint = transform.position;
            Debug.Log("Checkpoint saved!");
            
            // Visual feedback (optional)
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
}