using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button Restart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Restart.onClick.AddListener(Restarts);
    }

    void Restarts()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
