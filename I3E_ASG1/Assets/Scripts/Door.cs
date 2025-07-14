using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public string targetSceneName = "NextScene";
    private bool isPlayerLooking = false;
    public GameObject interactPrompt; 
    public GameObject noKeyWarning;

    void Update()
    {
        if (isPlayerLooking && Input.GetKeyDown(KeyCode.E))
        {
            if (Key.HasKey == true)
            {
                SceneManager.LoadScene(targetSceneName);
            }
            else
            {
                StartCoroutine(ShowNoKeyWarning());
            }
        }
    }

    IEnumerator ShowNoKeyWarning()
        {
            noKeyWarning.SetActive(true);
            yield return new WaitForSeconds(2f);
            noKeyWarning.SetActive(false);
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