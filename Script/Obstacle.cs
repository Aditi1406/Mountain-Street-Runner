using UnityEngine;

public class Obstacle : MonoBehaviour
{
    
    PlayerMovement playerMovement;
    // Start is called before the first frame update
    private void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Kill The Player
            playerMovement.Die();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
