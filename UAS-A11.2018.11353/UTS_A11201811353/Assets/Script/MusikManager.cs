using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusikManager : MonoBehaviour
{
    private static MusikManager instance = null;

    public MusikManager Instance()
    {
        return instance;
    }

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
