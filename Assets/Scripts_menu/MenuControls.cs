using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Load_rooms");
    }

    public void ExitPressed()
    {
        Application.Quit();
        Debug.Log("ExitPressed");
    }
}
