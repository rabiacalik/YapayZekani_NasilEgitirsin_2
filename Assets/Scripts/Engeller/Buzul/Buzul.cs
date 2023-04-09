using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzul : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] Sprite newSprite;
    [SerializeField] Sprite oldSprite;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();    
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = newSprite;
            Invoke("ComeBack", 1f); 
        }

    }

    void ComeBack()
    {
        gameObject.SetActive(false);
        Invoke("SpriteAktif", 3f);
    }
    void SpriteAktif()
    {
        spriteRenderer.sprite = oldSprite;
        gameObject.SetActive(true);
    }
}
