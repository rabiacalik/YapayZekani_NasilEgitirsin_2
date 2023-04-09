using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketliPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[] noktalar;
    private int index = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if (Vector2.Distance(noktalar[index].transform.position, transform.position) < .1f)
        {
            index++;
            if (index >= noktalar.Length)
            {
                index = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, noktalar[index].transform.position, Time.deltaTime * speed);
    }
}
