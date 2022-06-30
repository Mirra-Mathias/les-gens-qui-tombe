using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwicthScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitGame() {
        Debug.Log("exit game");
        Application.Quit();
    }

    public void toNewLevel() {
        Debug.Log("Change Scene");
        SceneManager.LoadScene("GameOver");
    }
}
