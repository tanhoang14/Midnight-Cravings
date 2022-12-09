using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
   private Renderer rend;

   [SerializeField]
   private Color colorToTurnTo = Color.white;

   private void Start(){
    rend = GetComponent<Renderer>();
    rend.material.color = colorToTurnTo;
   }
}
