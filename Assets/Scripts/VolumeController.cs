using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider sfxSlider;

    private IEnumerator Start()
    {
        yield return null;

        musicSlider.onValueChanged.AddListener(OnMusicVolumeChanged);
        sfxSlider.onValueChanged.AddListener(OnSFXVolumeChanged);

        // Optional: load saved volume from PlayerPrefs
        musicSlider.value = PlayerPrefs.GetFloat("MusicVolume", 1f);
        sfxSlider.value = PlayerPrefs.GetFloat("SFXVolume", 1f);

        if (AudioManager.instance != null)
        {
            AudioManager.instance.SetVolume(sfxSlider.value);
        }
        else
        {
            Debug.LogWarning("AudioManager chưa sẵn sàng tại Start của VolumeController.");
        }
    }

    private void OnMusicVolumeChanged(float volume)
    {
        if (MusicManager.instance != null)
        {
            MusicManager.instance.SetVolume(volume);
        }

        PlayerPrefs.SetFloat("MusicVolume", volume);
    }

    private void OnSFXVolumeChanged(float volume)
    {
        if (AudioManager.instance != null)
        {
            AudioManager.instance.SetVolume(volume);
        }

        PlayerPrefs.SetFloat("SFXVolume", volume);
    }
}
