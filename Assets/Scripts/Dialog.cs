using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // text mash pro icin gerekli
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent; //metin bileseni
    public string[] lines; //cizgiler
    public float textSpeed; //yazi hizi
    public AudioSource klavye_click;

    private int index;
   
    // Start is called before the first frame update
    void Start()
    {
        klavye_click = GetComponent<AudioSource>();
        textComponent.text = string.Empty;
            StartDialogue();
            
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            klavye_click.Play();
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
