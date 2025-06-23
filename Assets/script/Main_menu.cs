using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    public int level;
    public GameObject panel;
    public void Reload()
    {
        SceneManager.LoadScene(level);
    }
    public void Menu()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
    }
    public void Load_MainMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }
    public void Continue()
    {
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(1);
    }



}
