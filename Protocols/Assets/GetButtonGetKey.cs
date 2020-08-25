﻿using UnityEngine;
using UnityEngine.UI; 
using System.Collections;
using System.Collections.Generic;

public class GetButtonGetKey : MonoBehaviour
{
   public Image graphic; 
   public Sprite standard; 
   public Sprite downgfx; 
   public Sprite upgfx; 
   public Sprite heldgfx; 
   public Text boolDisplay1;
   public Text boolDisplay2;
   public Text boolDisplay3;


   void Start()
   {
       graphic.sprite = standard; 
   }

   void Update()
   {
       bool down = Input.GetButtonDown("Jump");
       bool held = Input.GetButton("Jump");
       bool up = Input.GetButtonUp("Jump");

       if (down)
       {
           graphic.sprite = downgfx;
       }
       else if (held)
       {
           graphic.sprite = heldgfx;
       }
       else if (up)
       {
           graphic.sprite = upgfx;
       }
       else{
           graphic.sprite = standard;
       }
   }

}
