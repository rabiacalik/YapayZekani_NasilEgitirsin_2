using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secim1Kod : MonoBehaviour
{
    public AudioSource click;
    public void ›yiGec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisi›yi", 0.5f);
    }

    public void KotuGec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisiKotu", 0.5f);
    }
    public void sahneGecisi›yi()
    {
        SceneManager.LoadScene("Level-1›yiSecim");
    }
    public void sahneGecisiKotu()
    {
        SceneManager.LoadScene("Level-1KotuSecim");
    }
}
