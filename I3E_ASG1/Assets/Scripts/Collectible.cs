using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // add score
            GameManager.Instance.AddScore(scoreValue);

            // Destroy the collectible after collection
            Destroy(gameObject);
        }
    }
}
