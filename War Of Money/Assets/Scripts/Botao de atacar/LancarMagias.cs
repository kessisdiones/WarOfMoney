using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LancarMagias : MonoBehaviour
{
    public Rigidbody Magia;
    public Transform OndeSaiMagia;
    public int VelocidadeDaMagia;
    private Animator Animacao;
    bool HabilidadeDisponivel=true;
    public float TempoDelayHabilidade = 3f;
    public Button botao;
    
   

  

void Start(){
        botao= GetComponent<Button>();
        Animacao = GetComponent<Animator>();
    }

void UpDate(){
     
    }
     
    public void atacar(){
        
        if(HabilidadeDisponivel){
            
           
            
            Animacao.SetTrigger("Atacando");
            
            Rigidbody Rb = Rigidbody.Instantiate (Magia, OndeSaiMagia.position, OndeSaiMagia.rotation)
            as Rigidbody;
            Rb.AddForce(OndeSaiMagia.forward * VelocidadeDaMagia);

            botao.interactable=false;
            HabilidadeDisponivel=false;
            StartCoroutine("DelayHabilidade");
        
        
        
        }     
    }

    IEnumerator DelayHabilidade(){
       
        yield return new WaitForSeconds(TempoDelayHabilidade);
        HabilidadeDisponivel=true;
        botao.interactable=true;
    }

}