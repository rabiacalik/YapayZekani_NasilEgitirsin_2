using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secim1Kod : MonoBehaviour
{
    public AudioSource click;
    public void İyiGec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisiİyi", 0.5f);
    }

    public void KotuGec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisiKotu", 0.5f);
    }
    public void sahneGecisiİyi()
    {
        SceneManager.LoadScene("Level-1İyiSecim");
    }
    public void sahneGecisiKotu()
    {
        SceneManager.LoadScene("Level-1KotuSecim");
    }
}
