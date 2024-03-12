using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("SampleScene");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting the game!"); // Optional: Display a log message in the console

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; // Stop playing in the editor
#else
        Application.Quit(); // Quit the application in a standalone build
#endif
    }
}
