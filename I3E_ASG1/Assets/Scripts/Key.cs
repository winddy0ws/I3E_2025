using NUnit.Framework;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool HasKey = false;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            HasKey = true;
            // Destroy the key after collection
            Destroy(gameObject);
        }
    }
}
