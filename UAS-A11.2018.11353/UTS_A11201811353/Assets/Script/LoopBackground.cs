using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    public float backspeed;
    public Renderer backrender;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backrender.material.mainTextureOffset += new Vector2(backspeed * Time.deltaTime, 0f);
    }
}
