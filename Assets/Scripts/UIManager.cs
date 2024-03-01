using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // public Transform player;
    public Text scoreText;
    // public GameObject cake;
    // public GameObject FinalScore;
    public static int scorevalue;
    // public GameObject restartbtn;

    private void Start()
    {

        scoreText = GetComponent<Text>();
        scoreText.text = "Score: " + 0;
    }

   
    void Update()
    {
        // scorevalue++;
        scoreText.text = "Score: " + scorevalue;
        Debug.Log("Food Collected! Score: " + scorevalue);
       


    }

 
}