using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndUI : MonoBehaviour
{
    public bool useBuildIndexOrder = true;
    public string nextSceneName = "DeskDefense-Hard";

    void UnpauseIfNeeded()
    {
        if (Time.timeScale == 0f) Time.timeScale = 1f;
    }

    public void OnRestartClicked()
    {
        UnpauseIfNeeded();
        Scene current = SceneManager.GetActiveScene();
        SceneManager.LoadScene(current.name);
    }

    public void OnNextLevelClicked()
    {
        UnpauseIfNeeded();
        if (useBuildIndexOrder)
        {
            int next = SceneManager.GetActiveScene().buildIndex + 1;
            if (next < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(next);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
        else
        {
            if (!string.IsNullOrEmpty(nextSceneName))
                SceneManager.LoadScene(nextSceneName);
        }
    }
}
