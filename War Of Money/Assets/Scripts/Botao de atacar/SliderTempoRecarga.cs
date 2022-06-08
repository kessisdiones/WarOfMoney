using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderTempoRecarga : MonoBehaviour
{
    public Slider timeSlider;
    public float gameTime;
    private bool stopTimer;

    void Start()
    {
        stopTimer = false;
        timeSlider.maxValue = gameTime;
        timeSlider.value = gameTime;
    }

    
    void Update()
    {
        float time = gameTime - Time.time;

        int minutos = Mathf.FloorToInt(time / 60);
        int segundos = Mathf.FloorToInt(time - minutos * 60f);

        if(time <= 0)
        {
            stopTimer = true;
        }
        if(stopTimer == false)
        {
            timeSlider.value = time;
        }
    }
}
