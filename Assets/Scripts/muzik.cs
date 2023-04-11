using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class muzik : MonoBehaviour
{
    public static muzik ses;

    AudioSource audioSource;
    private void Start() {
        SceneManager.sceneUnloaded += OnSceneUnloaded;
        audioSource = GetComponent<AudioSource>();
    }
    private void Awake()
    {
        if (ses)
        {
            Destroy(gameObject);
        }
        else
        {
            ses = this;
            DontDestroyOnLoad(gameObject);
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
