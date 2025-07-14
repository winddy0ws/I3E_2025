using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string targetSceneName = "NextScene";
    private bool isPlayerLooking = false;
    public GameObject interactPrompt; 

    void Update()
    {
        if (isPlayerLooking && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }

    public void SetLooking(bool looking)
    {
        isPlayerLooking = looking;

        if (interactPrompt != null)
        {
            interactPrompt.SetActive(looking);
        }
    }
}