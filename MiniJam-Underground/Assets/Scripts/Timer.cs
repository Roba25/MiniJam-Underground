using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
int time = 0;
private float oneSecond;
TextMeshProUGUI timeText;



    void Update()
    {
        
    oneSecond+= Time.deltaTime;
    if (oneSecond >= 1)
    {
        oneSecond = 0;
        time++;
    }
    timeText.text = time.ToString();

    }



}