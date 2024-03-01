using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Firstscene : MonoBehaviour
{
    // Start is called before the first frame update
    // public int score;
    public void StartButtonClick()
    {
        // Load the game scene or any other scene you want to transition to
        // SceneManager.LoadScene("Snake");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
        
            }

// public void OptionsButtonClick()
//     {
//         // Implement your options menu logic here
//         Debug.Log("Options button clicked");
//     }

   public void ExitButtonClick()
    {
        // Quit the application
        Application.Quit();
    }
    public void Back(){
        SceneManager.LoadScene(0);
    }
      public  void Restart()
    {

        SceneManager.LoadScene(1);
    }
}
