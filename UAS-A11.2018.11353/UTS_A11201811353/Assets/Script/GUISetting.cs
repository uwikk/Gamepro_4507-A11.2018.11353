using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUISetting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPlay()
    {
        SceneManager.LoadScene("pilihLevel");
    }

    public void OnSetting()
    {
        SceneManager.LoadScene("Setting");
    }

    public void OnHelp()
    {
        SceneManager.LoadScene("Help");
    }

    public void OnBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OnEasy()
    {
        SceneManager.LoadScene("Easy");
    }
    public void OnMedium()
    {
        SceneManager.LoadScene("Medium");
    }
    public void OnHard()
    {
        SceneManager.LoadScene("Hard");
    }
}
