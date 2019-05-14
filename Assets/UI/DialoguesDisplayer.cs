using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialoguesDisplayer : MonoBehaviour
{
    static DialoguesDisplayer _object;
    public GameObject window;
    public Text person;
    public Text dialog;
    int currentPart;
    string[] parts; //parts of dialog

    public static void Display(TextAsset text, string person)
    {
        _object.Open(text, person);
    }
    
    void Open(TextAsset text, string person)
    {
        window.SetActive(true);
        this.person.text = person;
        parts = text.text.Split(';');
        currentPart = 0;
        dialog.text = parts[0];
    }
    
    void Awake()
    {
        _object = this;
        window.SetActive(false);
    }
    
    void Update()
    {
        if(window.activeInHierarchy)
        {
            if (Input.GetButtonDown("Interaction"))
            {
                currentPart++;
                if(currentPart == parts.Length)
                {
                    window.SetActive(false);
                    return;
                }
                dialog.text = parts[currentPart];
            }
        }
    }
}
