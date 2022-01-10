using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public SlideToggle toggle;

    // Start is called before the first frame update
    void Start()
    {        
        toggle.isOn = false;
        //toggle.toogleEvent.AddListener((enabled) => Debug.Log("Main : "+enabled));        
    }

    public void OnClickBtn(bool enabled)
    {
        Debug.Log("OnClickBtn : "+enabled);
    }
    
}
