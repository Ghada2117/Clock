    using System;
using UnityEngine;
public class Clock : MonoBehaviour
{
    [SerializeField] Transform hourPivot, minutesPivot, secondsPivot;
    const float hourToDegrees = -30f;
    const float secAndMinToDegree = -6f;
    void Update() 
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourPivot.localRotation = Quaternion.Euler(0f,0f,hourToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f,0f,secAndMinToDegree*(float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f,0f,secAndMinToDegree*(float)time.TotalSeconds);

    }
}