using UnityEngine;

public class Collectible : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Just collect the coin
            GameManager.instance.CollectCoin();
            Destroy(gameObject);
        }
    }
}