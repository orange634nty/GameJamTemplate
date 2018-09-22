﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataStore : MonoBehaviour
{
    private static GameObject mInstance = null;
    void Awake ()
    {
        if (mInstance == null)
        {
            mInstance = gameObject;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}