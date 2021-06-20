using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_menu : MonoBehaviour
{

    public Slider slider;

   Resolution[] rsl;
    List<string> resolutions;
    public Dropdown dropdown_resolution, dropdown_quality;

    public bool isFullScreen = false;

    private GameObject settingsPanel;

    public void Awake()
    {
        GameObject.FindGameObjectWithTag("name").GetComponent<Text>().text = StaticVariables.Nickname;

        resolutions = new List<string>();// создание списка со значениями
        rsl = Screen.resolutions; // получение доступных разрешений
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        //dropdown_resolution.ClearOptions(); //удаление элементов
        dropdown_resolution.AddOptions(resolutions); //добавление элементов
    }

    public void Start()
    {
        settingsPanel = GameObject.Find("Settings_Panel");
        settingsPanel.SetActive(false);
    }
    public void Resolution()
    {
        int r = dropdown_resolution.value;
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
        
    }
    
    public void AudioVolume()
    {
        AudioListener.volume = slider.value;
        GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>().volume = StaticVariables.Audio;
    }
   
    public void Quality()
    {
        QualitySettings.SetQualityLevel(dropdown_quality.value);
        Debug.Log(dropdown_quality.value);
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
        
    }

    public void SaveButton()
    {
        StaticVariables.FullScreen = Screen.fullScreen;
        StaticVariables.Audio = GameObject.FindGameObjectWithTag("audio").GetComponent<AudioSource>().volume;
        StaticVariables.Quality = dropdown_quality.value;
        StaticVariables.Nickname = GameObject.FindGameObjectWithTag("name").GetComponent<Text>().text;
        
    }
}
