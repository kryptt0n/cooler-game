using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_menu : MonoBehaviour
{

    public Slider slider;

   Resolution[] rsl;
    List<string> resolutions;
    public Dropdown dropdown;

    public bool isFullScreen = false;

    /*public void Awake()
    {
        resolutions = new List<string>();// создание списка со значениями
        rsl = Screen.resolutions;// получение доступных разрешений
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions(); //удаление элементов
        dropdown.AddOptions(resolutions); //добавление элементов
    }
    public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }
    */
    public void AudioVolume()
    {
        AudioListener.volume = slider.value;
        GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>().volume = StaticVariables.Audio;
    }
   
    public void Quality()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        StaticVariables.Quality = dropdown.value;
        Debug.Log(dropdown.value);
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
        StaticVariables.FullScreen = Screen.fullScreen;
    }
}
