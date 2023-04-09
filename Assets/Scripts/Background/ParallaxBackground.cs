using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    [SerializeField] private Transform _cam;
    [SerializeField] private float moveSpeed;

    private void Update()
    {
        transform.Translate(-1 * moveSpeed * Time.deltaTime, 0f, 0f);

        if (_cam.transform.position.x >= transform.position.x + 23f)
        {
            transform.position = new Vector2(
                    _cam.position.x + 23f,
                    transform.position.y     
                );
        }
    }
}
