using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GlobalCar : MonoBehaviour
{
    public static int CarType;
    public GameObject TrackWindow;
    public void PinkCar()
    {
        CarType = 1;
        TrackWindow.SetActive(true);
    }
    public void YellowCar()
    {
        CarType = 2;
        TrackWindow.SetActive(true);
    }
    public void BlueCar()
    {
        CarType = 3;
        TrackWindow.SetActive(true);
    }
}
