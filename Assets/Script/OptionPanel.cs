using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class OptionPanel : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] Toggle muteToggle;
    [SerializeField] Slider bgmSlider;

    private void OnEnable()
    {
        muteToggle.isOn = audioManager.IsMute;
        bgmSlider.value = audioManager.BgmVolume;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetFloat("bgmVolume", audioManager.BgmVolume);
        PlayerPrefs.SetInt("mute", audioManager.IsMute ? 1 : 0);
    }
}
