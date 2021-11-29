using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float guiTime;
    private int minutes, seconds, fraction;
    public Text textField;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        guiTime = Time.time - startTime;
        minutes = (int)guiTime / 60;
        seconds = (int)guiTime % 60;
        fraction = (int)(guiTime * 100) % 100;
        textTime = string.Format("{0:00}:{1:00}",minutes,seconds,fraction);
        if(minutes >= 5)
        {
            textField.text = "GAME OVER";
        }
        else
        {
            textField.text = textTime;
        }
    }
}
