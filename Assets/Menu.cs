using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
  
    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        Time.timeScale = 1;
    }    

    public void menu()
    {
        SceneManager.LoadScene(1);
    }
    
}
