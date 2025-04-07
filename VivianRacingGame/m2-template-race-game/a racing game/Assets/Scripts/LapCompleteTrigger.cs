using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrig;
    public GameObject HalfLapTrig;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;
    public int counter;

    public GameObject RaceFinish;

    void Update()
    {
        if (LapsDone == 3)
        {
            RaceFinish.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        
        LapsDone += 1;
        
        counter++;

        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.SecondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<TextMeshProUGUI>().text = "" + LapTimeManager.MilliCount;

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;
        LapCounter.GetComponent<TextMeshProUGUI>().text = "" + LapsDone + " / 3";

        HalfLapTrig.SetActive(true);
        LapCompleteTrig.SetActive(false);
        if (LapsDone == 3)
        {
            RaceFinish.SetActive(true);
        }


    }
}
