using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TempoDeRecarga : MonoBehaviour
{
    private Button botao;
    public GameObject SliderTempoRecarga;
    bool HabilidadeDisponivel=true;
    public float TempoDelayHabilidade = 1f;


    void Start(){
        botao= GetComponent<Button>();
       
        
    }

    public void TimeDeRecarga(){
        if(HabilidadeDisponivel){
            HabilidadeDisponivel=true;
            SliderTempoRecarga.SetActive(true);
            botao.enabled = false;
            botao.interactable=false;
            StartCoroutine("DelayHabilidade");
        }

    }

    IEnumerator DelayHabilidade(){
       
        yield return new WaitForSeconds(TempoDelayHabilidade);
        HabilidadeDisponivel=true;
        botao.enabled = true;
        botao.interactable = true;
        SliderTempoRecarga.SetActive(false);
    }
}
