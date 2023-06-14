using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPanel;

    int MenuIndex = 0;
    int TutorialIndex = 1;
    int RulesIndex = 2;
    int WinIndex = 3;
    int LoseIndex = 4;

    public void PlayTutorial()
    {
        SceneManager.LoadScene(TutorialIndex);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(MenuIndex);
    }

    public void SelectLevel()
    {
        OptionPanel.alpha = 1;
        OptionPanel.blocksRaycasts = true;
    }

    public void LevelEasy()
    {
        SceneManager.LoadScene(TutorialIndex);
    }

    public void LevelMedium()
    {
        SceneManager.LoadScene(TutorialIndex);
    }

    public void LevelHard()
    {
        SceneManager.LoadScene(TutorialIndex);
    }

    public void Rules()
    {
        SceneManager.LoadScene(RulesIndex);
    }

    public void Back()
    {
        OptionPanel.alpha = 0;
        OptionPanel.blocksRaycasts = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

