using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class TimerHandler : MonoBehaviour
{
    private float startTime;
    private string textTime;
    private float guiTime;
    private int minutes, seconds, fraction;
    private List<String> correctCombination;
    private List<String> currentCombination;
    private List<String> displayedBottles;
    public Text textField;


    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;

        // generate a random combination
        var bottles = new List<String> { "Champagne", "Hennesy", "Wine" };
        displayedBottles = bottles;
        currentCombination = new List<String>(bottles.Count);
        var r = new System.Random();
        correctCombination = new List<String>(bottles.Count);
        while (bottles.Count > 0)
        {
            var i = r.Next(bottles.Count);
            correctCombination.Add(bottles[i]);
            bottles.RemoveAt(i);
        }
        correctCombination = new List<String>{"Champagne","Hennesy","Wine" };
    }

    private void addToCurrentCombination(String name)
    {
        Debug.Log(name);
        currentCombination.Add(name);
    }


    // Update is called once per frame
    void Update()
    {
        guiTime = Time.time - startTime;
        minutes = (int)guiTime / 60;
        seconds = (int)guiTime % 60;
        fraction = (int)(guiTime * 100) % 100;
        textTime = string.Format("{0:00}:{1:00}", minutes, seconds, fraction);
        if (minutes >= 5)
        {
            textField.text = "GAME OVER";
        }
        else if(currentCombination.SequenceEqual(correctCombination)){
            textField.text = "BRAVO";
        }
        else
        {
            textField.text = textTime;
        }
    }
}