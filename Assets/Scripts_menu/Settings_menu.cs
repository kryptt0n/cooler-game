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

    /*/public void Awake()
    {
        resolutions = new List<string>();
        rsl = Screen.resolutions;
        foreach (var i in rsl)
        {
            resolutions.Add(i.width + "x" + i.height);
        }
        dropdown.ClearOptions();
        dropdown.AddOptions(resolutions);
    }
    /*public void Resolution(int r)
    {
        Screen.SetResolution(rsl[r].width, rsl[r].height, isFullScreen);
    }
    */
    public void AudioVolume()
    {
        AudioListener.volume = slider.value;
    }
   
    public void Quality()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        Debug.Log(dropdown.value);
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }


}
