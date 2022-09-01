using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Singleton.Instance.GetText());
        Debug.Log(GameManager.Instance.text);// Tercih edilen kullanim yapisi
    }

    
}
