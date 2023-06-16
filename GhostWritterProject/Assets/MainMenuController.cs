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
    int EasyIndex = 5;
    int MediumIndex = 6;
    int HardIndex = 7;

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
        SceneManager.LoadScene(EasyIndex);
    }

    public void LevelMedium()
    {
        SceneManager.LoadScene(MediumIndex);
    }

    public void LevelHard()
    {
        SceneManager.LoadScene(HardIndex);
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
