using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // text mash pro icin gerekli
using UnityEngine.UI;

public class etkilesimDialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent; //metin bileseni
    public string[] lines; //cizgiler
    public float textSpeed; //yazi hizi

    private int index;
    private GameObject panel;

    void Start()
    {
        gameObject.SetActive(true);
        panel = GameObject.Find("etkilesimliPanel");
        panel.SetActive(false);
        textComponent.text = string.Empty;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            panel.SetActive(true);
            StartDialogue();
        }
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
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
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            panel.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
