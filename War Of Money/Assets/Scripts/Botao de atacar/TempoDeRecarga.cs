using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoDeRecarga : MonoBehaviour
{
    private float TimeDeRecarga;
    private const float TempoMaximo= 5f;
    public Slider slider;

    void Start(){
        slider= GetComponent<Slider>();
    }
    void UpDate(){
       
        slider.value = CalculateSliderValue();

        if(Input.GetMouseButtonDown(1)){
            TimeDeRecarga = TempoMaximo;
            Debug.Log("apertou");
        }
        if(TimeDeRecarga <= 0 ){
            TimeDeRecarga = 0;
        }
        
        else if(TimeDeRecarga > 0){
            TimeDeRecarga-= Time.deltaTime;
        }
        
    }

    public void tempo(){
        
            TimeDeRecarga = TempoMaximo;
            Debug.Log("apertou");
        
         if(TimeDeRecarga <= 0 ){
            TimeDeRecarga = 0;
        }
        
        else if(TimeDeRecarga > 0){
            TimeDeRecarga-= Time.deltaTime;
        }
    }
    float CalculateSliderValue(){
       return (TimeDeRecarga / TempoMaximo);
    }
}
