using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFootStep : MonoBehaviour
{
    [SerializeField] private AudioClip footstepClip;
    [SerializeField] private CharacterController character;

    private void Update()
    {
        if (character.moving)
        {
            AudioManager.instance.PlayLooping(footstepClip);
        }
        else
        {
            AudioManager.instance.StopLooping();
        }
    }
}
