using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public AudioMixer mainMixer;
    public void SetVolum(float volum){
        mainMixer.SetFloat("volum", volum);

    }

  public void SetFullscreen(bool isFullscreen){
    Screen.fullScreen = isFullscreen;
  }

  public void SetQuality(int qualityIndex){
    QualitySettings.SetQualityLevel(qualityIndex);
  }

}
