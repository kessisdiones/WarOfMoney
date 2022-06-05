using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimetJoystic : MonoBehaviour
{
    public MSJoystickController moveJoystic;
    private Animator Animacao;
    private Rigidbody rb;
    private float moveH,moveV;
    public float SpeedMove = 8;
    public bool atacando=false;

    bool AndarDisponivel=true;
    public float TempoDelayAndar = 0.5f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Animacao = GetComponent<Animator>();
    }
    void Update()
    {
        movePlayer();
        animationPlayer();
        animationPlayerAnim();
    
        
       
    }

    
    void movePlayer(){
        if(!atacando && AndarDisponivel){
        
        moveH = moveJoystic.joystick.joystickX;
        moveV = moveJoystic.joystick.joystickY; 
        Vector3 dir = new Vector3(moveH,0, moveV);
        rb.velocity = new Vector3(moveH*SpeedMove, rb.velocity.y, moveV*SpeedMove);
         
        
        if(dir != Vector3.zero){
            transform.LookAt(transform.position + dir);
        }
       
        }
        else if(!AndarDisponivel){
             StartCoroutine("DelayAndar");
        }

        
        
    }   
    void animationPlayer(){
        
        Animacao.SetFloat("HorizontalMove",moveH);
        Animacao.SetFloat("VerticalMove",moveV);
        
         
    }

    public void animationPlayerAnim(){
        
       if(Input.GetMouseButtonDown(1)){
       atacando = true;
        AndarDisponivel=false;
    
       }
       else if(Input.GetMouseButtonUp(1)) {
           atacando=false;
           }
        
    }

    IEnumerator DelayAndar(){
       
        yield return new WaitForSeconds(TempoDelayAndar);
        AndarDisponivel=true;
    }
}
    