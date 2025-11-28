using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private AudioSource loopingFootstepSource;

    private void Awake()
    {
        instance = this;
    }

    [SerializeField] GameObject audioSourcePrefab;
    [SerializeField] int audioSourceCount;

    List<AudioSource> audioSources;

    private void Start()
    {
        Init();
    }

    private void Init()
    {
        audioSources = new List<AudioSource>();

        for(int i = 0; i < audioSourceCount; i++)
        {
            GameObject go = Instantiate(audioSourcePrefab, transform);
            go.transform.localPosition = Vector3.zero;
            audioSources.Add(go.GetComponent<AudioSource>());
        }

        GameObject footstepGO = Instantiate(audioSourcePrefab, transform);
        footstepGO.name = "FootstepAudioSource";
        loopingFootstepSource = footstepGO.GetComponent<AudioSource>();
        loopingFootstepSource.loop = true;
        loopingFootstepSource.playOnAwake = false;
    }

    public void Play(AudioClip audioClip)
    {
        if(audioClip == null) {  return; }
        AudioSource audioSource = GetFreeAudioSource();

        audioSource.clip = audioClip;
        audioSource.Play();
    }

    private AudioSource GetFreeAudioSource()
    {
        for (int i = 0; i < audioSources.Count; i++)
        {
            if (audioSources[i].isPlaying == false)
            {
                return audioSources[i];
            }
        }

        return audioSources[0];
    }

    private float sfxVolume = 1f;

    public void SetVolume(float volume)
    {
        sfxVolume = volume;
        foreach (var audioSource in audioSources)
        {
            audioSource.volume = sfxVolume;
        }

        if (loopingFootstepSource != null)
        {
            loopingFootstepSource.volume = sfxVolume;
        }
    }

    public void PlayLooping(AudioClip clip)
    {
        if (clip == null || loopingFootstepSource == null) return;

        if (loopingFootstepSource.clip != clip || !loopingFootstepSource.isPlaying)
        {
            loopingFootstepSource.clip = clip;
            loopingFootstepSource.Play();
        }
    }

    public void StopLooping()
    {
        if (loopingFootstepSource != null && loopingFootstepSource.isPlaying)
        {
            loopingFootstepSource.Stop();
        }
    }
}
