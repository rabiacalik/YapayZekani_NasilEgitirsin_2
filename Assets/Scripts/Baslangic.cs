using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baslangic : MonoBehaviour
{
    public AudioSource click;

    public void Gec()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisi", 0.5f);
    }

    public void cikis()
    {
        Application.Quit();
    }

    public void sahneGecisi()
    {
        SceneManager.LoadScene("Baslangic-1");
    }
}
