using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioController : MonoBehaviour
{
AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
        {
            audioSource.Play();
            SceneManager.sceneUnloaded += OnSceneUnloaded;
        }
    }

    void OnSceneUnloaded(Scene scene)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }
    }
}
