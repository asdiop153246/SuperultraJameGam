using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManageScript : MonoBehaviour
{
    public void MainMenuScene()
    {
        SceneManager.LoadScene(0);
    }

    public void StoryScene()
    {
        SceneManager.LoadScene(1);
    }

    public void GameScene()
    {
        SceneManager.LoadScene(2);
    }

    public void EndingScene()
    {
        SceneManager.LoadScene(3);
    }
}
