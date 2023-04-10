using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class portal_2 : MonoBehaviour
{
    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Invoke("SahneGecisi", 0.5f);
        }
    }

    private void SahneGecisi()
    {
        SceneManager.LoadScene("son_menu");
    }
}
