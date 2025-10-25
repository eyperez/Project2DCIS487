using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public static SceneController instance;
    public DialogueDisplay dialogueDisplay;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void NextLevel()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int totalScenes = SceneManager.sceneCountInBuildSettings;

        if (currentSceneIndex < totalScenes - 1)
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            if (dialogueDisplay != null)
            {
                dialogueDisplay.ShowMessage("Congrats u done lol. now get OUT", 5f);
            }
            else
            {
                Debug.Log("Congrats u finished ok");
            }
        }
    }

                public void LoadScene(string sceneName)
                {
                    SceneManager.LoadSceneAsync(sceneName);
                }
}

public class DialogueDisplay
{
    internal void ShowMessage(string v1, float v2)
    {
        throw new NotImplementedException();
    }
}