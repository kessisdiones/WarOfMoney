using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarMagias : MonoBehaviour
{
    public Rigidbody Magia;
    public Transform OndeSaiMagia;
    public int VelocidadeDaMagia;
    private Animator Animacao;
    

void Start(){
       
        Animacao = GetComponent<Animator>();
    }
    void UpDate(){
    AninAtacar();
    
    }
     
    public void atacar(){

          
        Rigidbody Rb = Rigidbody.Instantiate (Magia, OndeSaiMagia.position, OndeSaiMagia.rotation)
            as Rigidbody;
            Rb.AddForce(OndeSaiMagia.forward * VelocidadeDaMagia);
         // Animacao.SetInteger("Atacar",2);
            Debug.Log("Lançou Magia");
           
        
        
            
    }

    public void AninAtacar(){
        if(Input.GetKey( KeyCode.Space )){
            Animacao.SetInteger("Atacar",2);
        }
        
    }  

    
    

    
}
