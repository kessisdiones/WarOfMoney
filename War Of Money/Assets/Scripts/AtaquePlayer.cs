using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaquePlayer : MonoBehaviour
{
    public Animator anim;
    public int noOfClicks = 0;
    float lastClickedTime = 0;
    public float MaxComboDelay = 0.9f;
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Atacar();
        if(Time.time - lastClickedTime > MaxComboDelay){
            noOfClicks = 0;
        
        }
        
    }
    public void Atacar(){
        if(Input.GetMouseButtonUp(0)){
            lastClickedTime = Time.time;
            noOfClicks++;
            if(noOfClicks == 1){
                anim.SetBool("Ataque1", true);
            }
            else{
                anim.SetBool("Ataque1", false);
                
            }
            noOfClicks = Mathf.Clamp(noOfClicks,0,1);
        }
    }

   
}
