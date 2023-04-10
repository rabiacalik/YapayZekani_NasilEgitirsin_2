using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secim2Kod : MonoBehaviour
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
        SceneManager.LoadScene("Level-2›yiSecim");
    }
    public void sahneGecisiKotu()
    {
        SceneManager.LoadScene("Level-2KotuSecim");
    }
}
