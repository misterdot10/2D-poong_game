//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    private int playerscore;
    private int computerscore;
    public void Playerscore(){
        playerscore++;
        this.ball.ResetPosition();
        Debug.Log(playerscore);
    }
    public void Computerscore(){
        computerscore++;
        this.ball.ResetPosition();
        Debug.Log(computerscore);
    }
}
