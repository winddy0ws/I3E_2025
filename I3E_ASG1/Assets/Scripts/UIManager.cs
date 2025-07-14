using UnityEngine;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject instructionPanel;
    void Start()
    {
        startPanel.SetActive(true);
        instructionPanel.SetActive(false);
    }
    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void OpenInstructionPanel()
    {
        startPanel.SetActive(false);
        instructionPanel.SetActive(true);
    }
    public void ReturnToStartPanel()
    {
        startPanel.SetActive(true);
        instructionPanel.SetActive(false);
    }
}
