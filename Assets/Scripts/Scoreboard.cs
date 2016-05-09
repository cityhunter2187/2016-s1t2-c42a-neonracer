using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public bool playerfin = false; //Whether or not the player has finished the race
    public bool AI1fin = false;
    public bool AI2fin = false;
    public bool AI3fin = false;
    public bool racefin = false;   //Whether or not the race has finished
    public float[] racetime;       //The racers time
    public string[] timeDisplay;   //The Display Variable
    public string[] name;          //The Racers Name
    public Text ScoreboardText1;   //The Individual Scoreboard Texts
    public Text ScoreboardText2;
    public Text ScoreboardText3;
    public Text ScoreboardText4;
    // Use this for initialization
    void Start ()
    {
        name = new string[4];
        racetime = new float[4];
        timeDisplay = new string[4];

    }
	
	// Update is called once per frame
	void Update ()
    {
        if (playerfin==true)
        {
            racetime[0] = GameObject.Find("Player").GetComponent<PlayerRacer>().tracktime;
            name[0] = GameObject.Find("Player").name;
        }
        if (AI1fin == true)
        {
            racetime[1] = GameObject.Find("AI1").GetComponent<AIRacer>().tracktime;
            name[1] = GameObject.Find("AI1").name;
        }
        if (AI2fin == true)
        {
            racetime[2] = GameObject.Find("AI2").GetComponent<AIRacer>().tracktime;
            name[2] = GameObject.Find("AI2").name;
        }
        if (AI3fin == true)
        {
            racetime[3] = GameObject.Find("AI3").GetComponent<AIRacer>().tracktime;
            name[3] = GameObject.Find("AI3").name;
        }
        //Displays the Score Board
        if (Input.GetKey(KeyCode.Tab))
        {
            ScoreboardText1.enabled = true;
            ScoreboardText2.enabled = true;
            ScoreboardText3.enabled = true;
            ScoreboardText4.enabled = true;
        }
        else
        {
            ScoreboardText1.enabled = false;
            ScoreboardText2.enabled = false;
            ScoreboardText3.enabled = false;
            ScoreboardText4.enabled = false;
        }
        SortTime();
        RaceFinish();
    }
    void RaceFinish()
    {
        for (int i = 0;i < timeDisplay.Length; i++)
        {
            timeDisplay[i] = racetime[i].ToString();
            ScoreboardText1.text = "Champion!!! " + name[0] + " Time " + timeDisplay[0];
            ScoreboardText2.text = "2nd Place " + name[1] + " Time " + timeDisplay[1];
            ScoreboardText3.text = "3rd Place " + name[2] + " Time " + timeDisplay[2];
            ScoreboardText4.text = "4th Place " + name[3] + " Time " + timeDisplay[3];
        }
    }
    void SortTime()
    {
        for (int x = 0; x < racetime.Length - 1; x++)
        {
            if (racetime[x] > racetime[x + 1])
            {
                float tempF = racetime[x];
                string tempS = name[x];
                racetime[x] = racetime[x + 1];
                name[x] = name[x + 1];
                racetime[x + 1] = tempF;
                name[x + 1] = tempS;
            }
        }
    }
}
