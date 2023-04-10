using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzik : MonoBehaviour
{
    public static muzik ses;

    private void Awake()
    {
        if (ses)
        {
            Destroy(gameObject);
        }
        else
        {
            ses = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
