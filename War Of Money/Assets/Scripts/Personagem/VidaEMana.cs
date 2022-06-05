using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEMana : MonoBehaviour
{
  public Slider SliderVida;
  public Slider SliderMana;
  public int VidaJogador;
  public int VidaMaxJogador;
  public int ManaJogador;
  public int ManaMaxJogador;



    void Update()
    {
        BarraMana();
        BarraVida();
    }

    void BarraVida()
    {
       SliderVida.value = VidaJogador;
       SliderVida.maxValue = VidaMaxJogador;
       if(VidaJogador > VidaMaxJogador){
           VidaJogador = VidaMaxJogador;
       } 
       if(VidaJogador < 0){
           VidaJogador = 0;
       }
    }
    void BarraMana()
    {
         SliderMana.value = ManaJogador;
       SliderMana.maxValue = ManaMaxJogador;
       if(ManaJogador > ManaMaxJogador){
           ManaJogador = ManaMaxJogador;
       } 
       if(ManaJogador < 0){
           ManaJogador = 0;
       }
    }

}
