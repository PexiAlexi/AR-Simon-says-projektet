using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Uiscript : MonoBehaviour
{
    public void ChangeScene(string Spelscenen)
    {
        SceneManager.LoadScene(Spelscenen);
    }

    public void QuitApp()
    {

            Application.Quit();
    }

    public void ChangeSceneMenu(string Startscean)
    {
        SceneManager.LoadScene(Startscean);
    }
}
