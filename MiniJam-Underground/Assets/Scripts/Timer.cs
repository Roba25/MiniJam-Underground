using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
float time = 0;
TextMeshProUGUI timeText;



    void Update()
    {
    time += Time.deltaTime;
    timeText.text = time.ToString();

    }



}