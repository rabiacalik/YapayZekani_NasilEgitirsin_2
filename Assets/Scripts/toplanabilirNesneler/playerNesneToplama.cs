using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerNesneToplama : MonoBehaviour
{
    private int nesne = 0;

    [SerializeField] private Text score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Toplanabilir"))
        {
            Destroy(collision.gameObject);
            nesne++;
            score.text = "Bilgi : " + nesne;
        }
    }
}
