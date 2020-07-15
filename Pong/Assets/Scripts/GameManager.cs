using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static int playerScore01 = 0;
    static int playerScore02 = 0;
    public GUISkin theSkin;
    public Transform theBall;

    private void Start()
    {
        theBall = GameObject.Find("Ball").transform;
    }
    // Update is called once per frame
    public static void Score(string wallName)
    {
        if (wallName == "rightWall")
        {
            playerScore01 += 1;
        }
        else
        {
            playerScore02 += 1;
        }
        Debug.Log("Player Score 1 is " + playerScore01);
        Debug.Log("Player Score 2 is " + playerScore02);
    }
    private void OnGUI()
    {
        GUI.skin = theSkin;
        GUI.Label(new Rect(Screen.width/2 - 150 - 11, 20, 100, 100), "" + playerScore01);
        GUI.Label(new Rect(Screen.width/2 + 150 + 13, 20, 100, 100), "" + playerScore02);

        if (GUI.Button(new Rect(Screen.width/2 -121/2 + 18, 35, 121, 53), "RESET"))
        {
            playerScore01 = 0;
            playerScore02 = 0;

            theBall.gameObject.SendMessage("ResetBall");
        }
    }
}
