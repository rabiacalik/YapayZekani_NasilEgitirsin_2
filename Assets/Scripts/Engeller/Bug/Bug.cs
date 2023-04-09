using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bug : MonoBehaviour
{   [SerializeField] private GameObject[] noktalar;
    private int index = 0;
    [SerializeField] private float speed = 2f;

    private float moveSpeed = 2f;
    public Animator clip;

    private void Start()
    {
        clip = GetComponent<Animator>();    
    }

    private void Update()
    {
        if (noktalar != null && noktalar.Length > 0)
        {
            if (Vector2.Distance(noktalar[index % noktalar.Length].transform.position, transform.position) < .1f)
            {
                index++;
            }
            transform.position = Vector2.MoveTowards(transform.position, noktalar[index % noktalar.Length].transform.position, Time.deltaTime * speed);
        }
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
