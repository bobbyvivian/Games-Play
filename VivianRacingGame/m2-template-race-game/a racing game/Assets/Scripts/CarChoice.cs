using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    public GameObject PinkBody;
    public GameObject PinkComponent;
    public GameObject PinkLeftGuard;
    public GameObject PinkRightGuard;
    public GameObject PinkSuspensionLeft;
    public GameObject PinkSuspensionRight;
    public GameObject PinkFrontLeftWheel;
    public GameObject PinkFrontRightWheel;
    public GameObject PinkRearLeftWheel;
    public GameObject PinkRearRightWheel;


    public GameObject YellowBody;
    public GameObject YellowComponent;
    public GameObject YellowLeftGuard;
    public GameObject YellowRightGuard;
    public GameObject YellowSuspensionLeft;
    public GameObject YellowSuspensionRight;
    public GameObject YellowFrontLeftWheel;
    public GameObject YellowFrontRightWheel;
    public GameObject YellowRearLeftWheel;
    public GameObject YellowRearRightWheel;

    public GameObject BlueBody;
    public GameObject BlueComponent;
    public GameObject BlueLeftGuard;
    public GameObject BlueRightGuard;
    public GameObject BlueSuspensionLeft;
    public GameObject BlueSuspensionRight;
    public GameObject BlueFrontLeftWheel;
    public GameObject BlueFrontRightWheel;
    public GameObject BlueRearLeftWheel;
    public GameObject BlueRearRightWheel;

    public int CarImport;
    void Start()
    {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            PinkBody.SetActive(true);
            PinkComponent.SetActive(true);
            PinkLeftGuard.SetActive(true);
            PinkRightGuard.SetActive(true);
            PinkSuspensionLeft.SetActive(true);
            PinkSuspensionRight.SetActive(true);
            PinkFrontLeftWheel.SetActive(true);
            PinkFrontRightWheel.SetActive(true);
            PinkRearLeftWheel.SetActive(true);
            PinkRearRightWheel.SetActive(true);

        }
        if (CarImport == 2)
        {
            YellowBody.SetActive(true);
            YellowComponent.SetActive(true);
            YellowLeftGuard.SetActive(true);
            YellowRightGuard.SetActive(true);
            YellowSuspensionLeft.SetActive(true);
            YellowSuspensionRight.SetActive(true);
            YellowFrontLeftWheel.SetActive(true);
            YellowFrontRightWheel.SetActive(true);
            YellowRearLeftWheel.SetActive(true);
            YellowRearRightWheel.SetActive(true);

        }
        if (CarImport == 3)
        {
            BlueBody.SetActive(true);
            BlueComponent.SetActive(true);
            BlueLeftGuard.SetActive(true);
            BlueRightGuard.SetActive(true);
            BlueSuspensionLeft.SetActive(true);
            BlueSuspensionRight.SetActive(true);
            BlueFrontLeftWheel.SetActive(true);
            BlueFrontRightWheel.SetActive(true);
            BlueRearLeftWheel.SetActive(true);
            BlueRearRightWheel.SetActive(true);

        }
    }
}
