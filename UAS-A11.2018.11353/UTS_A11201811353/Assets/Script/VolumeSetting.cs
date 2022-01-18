using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSetting : MonoBehaviour
{
    public Slider Volume_musik;
    public AudioSource lagu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnMouseDown(){
        lagu.volume = Volume_musik.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
