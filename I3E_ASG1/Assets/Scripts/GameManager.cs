using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int currentScore = 0;
    public AudioClip collectSound;
    void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ModifyScore(int score)
    {
        currentScore += score;
        Debug.Log("Score:" + currentScore);
        AudioSource.PlayClipAtPoint(collectSound, transform.position);
    }
}
