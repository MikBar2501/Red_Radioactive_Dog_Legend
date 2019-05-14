using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testDialog : MonoBehaviour
{
    public TextAsset TA;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Esc"))
            DialoguesDisplayer.Display(TA, "someone");
    }
}
