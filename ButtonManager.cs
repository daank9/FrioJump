using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Begin met het spelen van de game
    public void startGame()
    {
        SceneManager.LoadScene("SampleScene");  
    }

    //Stop met het spelen van de game
    public void ExitGame()
    {
        Application.Quit();
    }

    //Ga terug naar het start menu van de game
    public void MenuGame()
    {
        SceneManager.LoadScene("Menu");
    }
}
