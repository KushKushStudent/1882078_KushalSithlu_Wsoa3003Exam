using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenecontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backToMenu() 
    {
        SceneManager.LoadScene(0);
    }
    public void playGame() {
        SceneManager.LoadScene(1);
    }
    public void exitGame() {

        Application.Quit();
    }
    public void tutorial() 
    {

        SceneManager.LoadScene(2);
    }
}
