using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject kapi;
    [SerializeField] private Sprite kapiSprite;
    [SerializeField] private Sprite newSprite;
    [SerializeField] private Sprite oldSprite;
    private SpriteRenderer newKapiSprite;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        newKapiSprite = kapi.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            spriteRenderer.sprite = newSprite;
            newKapiSprite.sprite = kapiSprite;
            Destroy(gameObject, 3f);
            Invoke("Wall", .3f);
        }
    }

    void Wall()
    {
        newKapiSprite.enabled = false;
        Destroy(kapi, .5f);
    }
}
