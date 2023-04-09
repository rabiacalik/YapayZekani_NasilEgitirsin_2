using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anlasma_metni : MonoBehaviour
{
    public AudioSource click;
    public void anlasma_ileri()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisi_anlasma", 0.5f);
    }

    public void anlasma_geri()
    {
        click = GetComponent<AudioSource>();
        click.Play();
        Invoke("sahneGecisi_geri", 0.5f);
    }

    public void sahneGecisi_anlasma()
    {
        SceneManager.LoadScene("Sahne-Anlasma");
    }
    public void sahneGecisi_geri()
    {
        SceneManager.LoadScene("Baslangic-4");
    }
}
