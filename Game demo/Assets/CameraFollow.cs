using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offset = new Vector3(0, 2, -10);

    void LateUpdate()
    {
        // Follow player's X, but keep Y and Z fixed
        Vector3 targetPosition = new Vector3(
            player.position.x + offset.x,
            offset.y,
            offset.z
        );
        
        transform.position = targetPosition;
    }
}