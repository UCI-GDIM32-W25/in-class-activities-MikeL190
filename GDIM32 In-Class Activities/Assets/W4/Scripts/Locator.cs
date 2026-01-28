using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Locator : MonoBehaviour
{
    public static Locator Instance { get; private set; }
    public W4Pigeon Pigeon { get; private set; }


    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;

        GameObject pigeonObj = GameObject.FindWithTag("Player");
        Pigeon = pigeonObj.GetComponent<W4Pigeon>(); 
    }
}
