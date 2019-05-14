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
  //  int currentPart;
 //   string[] parts; //parts of dialog

    public static void Display(TextAsset text, string person)
    {
        _object.Open(text, person);
    }

    public static void Close()
    {
        _object.window.SetActive(false);
    }
    
    void Open(TextAsset text, string person)
    {
        window.SetActive(true);
        this.person.text = person;
        dialog.text = text.text;
   //     parts = text.text.Split(';');
    //    currentPart = 0;
    //    dialog.text = parts[0];
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
                window.SetActive(false);
                return;
            }
        }
    }
}
