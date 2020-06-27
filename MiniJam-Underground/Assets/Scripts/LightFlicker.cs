using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
Light lightRef;       

public float time;
float timeValue;



    // Start is called before the first frame update
    void Start()
    {
    lightRef = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
    
    
    lightRef.intensity = Random.Range(2, 3);   
    }
}