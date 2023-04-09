using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{
    private float moveSpeed = 2f;
    public Animator clip;
    private void Start()
    {
        clip = GetComponent<Animator>();    
    }

    private void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time * moveSpeed, 2));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 1f);
            clip.enabled = true;
        }
    }
}
