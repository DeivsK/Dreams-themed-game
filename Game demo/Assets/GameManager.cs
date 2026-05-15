using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    public TextMeshProUGUI coinText;
    public int coinsCollected = 0;
    public int coinsNeeded = 3;
    
    // Spike materials
    public Material spikeFaint;
    public Material spikeShadow;
    public Material spikeSolid;
    
    // Level materials
    public Material GroundLight;
    public Material GroundDark;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateCoinUI();
        SetSpikePhase(0);
    }

    public void CollectCoin()
    {
        coinsCollected++;
        UpdateCoinUI();
        SetSpikePhase(coinsCollected);
    }

    void SetSpikePhase(int phase)
    {
        GameObject[] spikes = GameObject.FindGameObjectsWithTag("Hazard");
        GameObject[] levelPieces = GameObject.FindGameObjectsWithTag("LevelPiece");
        
        foreach (GameObject spike in spikes)
        {
            MeshRenderer renderer = spike.GetComponent<MeshRenderer>();
            Collider collider = spike.GetComponent<Collider>();
            
            switch (phase)
            {
                case 0:
                    renderer.enabled = false;
                    collider.enabled = false;
                    break;
                    
                case 1:
                    renderer.enabled = true;
                    renderer.material = spikeFaint;
                    collider.enabled = false;
                    break;
                    
                case 2:
                    renderer.enabled = true;
                    renderer.material = spikeShadow;
                    collider.enabled = false;
                    break;
                    
                case 3:
                    renderer.enabled = true;
                    renderer.material = spikeSolid;
                    collider.enabled = true;
                    
                    // Change level color
                    foreach (GameObject piece in levelPieces)
                    {
                        piece.GetComponent<MeshRenderer>().material = GroundDark;
                    }
                    
                    // Show portal
                    GameObject portal = GameObject.Find("ExitPortal");
                    if (portal != null)
                    {
                        portal.GetComponent<MeshRenderer>().enabled = true;
                    }
                    
                    // Set chekpoint at player position
                    GameObject player = GameObject.FindGameObjectWithTag("Player");
                    if (player != null)
                    {
                        Checkpoint.lastCheckpoint = player.transform.position;
                        Debug.Log("Checkpoint: Start of nightmare phase!");
                    }
                    break;
            }
        }
    } 

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + coinsCollected + " / " + coinsNeeded;
    }
}