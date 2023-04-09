using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bir_sonraki_sahneye_gec : MonoBehaviour
{
    public AudioSource click;
    public void Gec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisi", 0.5f);
    }

    public void sahneGecisi()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = currentSceneIndex + 1;
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }
}
