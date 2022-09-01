using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton : MonoBehaviour
{
    //Temel singleton yapisi


    private string text;

    private static Singleton instance = null;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<Singleton>();
            }
            return instance;
        }
    }
    private void OnEnable()
    {
        instance = this;
        text = "Singleton";
    }

    public string GetText()
    {
        return text;
    }
}
