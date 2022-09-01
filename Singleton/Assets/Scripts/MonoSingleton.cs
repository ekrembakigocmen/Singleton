using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    //Tercih edilen kullanim yapisi
    //Her seferinde singleton olusturmamak icin 



    //volatile veriyi direk bellekten alicak ara katmandan degil
    private static volatile T instance = null;

    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType(typeof(T)) as T;
            }
            return instance;
        }
    }
}
