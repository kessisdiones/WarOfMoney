using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovimentacao : MonoBehaviour
{   
 public MSJoystickController moveJoystic;
    private Animator Animacao;
    private Rigidbody rb;
    private float moveH,moveV;
    public float SpeedMove = 10;
    

    
    bool atacando=false;
   
    
    
    void Start(){
        rb = GetComponent<Rigidbody>();
        Animacao = GetComponent<Animator>();
    }
    void Update(){
        movePlayer();
        atacar();
       
    }

    
    void movePlayer(){
        if(atacando==false){
        moveH = Input.GetAxis("Horizontal");
        moveV = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(moveH,0, moveV);
        rb.velocity = new Vector3(moveH*SpeedMove, rb.velocity.y, moveV*SpeedMove);
    
        if(direcao != Vector3.zero){
            transform.LookAt(transform.position + direcao);
        }
        if(direcao.magnitude ==0){
            Animacao.SetInteger("Animacao",0);
        }
        if(direcao.magnitude > 0 && direcao.magnitude <= 1){
            Animacao.SetInteger("Animacao",1);
        }
        }   
    }
    public void atacar(){
     if(Input.GetMouseButtonDown(1)){ 
            atacando=true;
            Animacao.SetBool("Ataque",true);
            Debug.Log("Atacou!");
        }
        else
        {   if(Input.GetMouseButtonUp(1)){ 
            Animacao.SetBool("Ataque",false);
            atacando= false;
        }}

    }
}
