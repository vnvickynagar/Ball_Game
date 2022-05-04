using UnityEngine;
public class Ending : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        FindObjectOfType<GameManager>().endGame();
        
    }
}