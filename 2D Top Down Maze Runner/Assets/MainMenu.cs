using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public void LevelSelectionMenu()
    {
        SceneManager.LoadScene("Level_Selection_Menu");
    }

    public void Level_1()
    {
        SceneManager.LoadScene("Level_1");
    }

    public void Level_2()
    {
        SceneManager.LoadScene("Level_2");
    }

    public void Level_3()
    {
        SceneManager.LoadScene("Level_3");
    }

    public void Level_4()
    {
        SceneManager.LoadScene("Level_4");
    }

    public void Level_5()
    {
        SceneManager.LoadScene("Level_5");
    }

    public void Level_6()
    {
        SceneManager.LoadScene("Level_6");
    }

    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options_Menu");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
