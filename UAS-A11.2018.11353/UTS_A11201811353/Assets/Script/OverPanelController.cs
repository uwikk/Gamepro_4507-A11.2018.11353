using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OverPanelController : MonoBehaviour
{
    public Text HStext;
    // Start is called before the first frame update
    void Start()
    {
        HStext.text = "HighScore : " + PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
