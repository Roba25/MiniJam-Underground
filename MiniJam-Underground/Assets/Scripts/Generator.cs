using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
   private int toolsUsed = 0;



   void ToolUsed()
   {
      toolsUsed++;
      
   }

   private void Update()
   {
      if (toolsUsed == 3)
      {
         //Generator is on
      }
   }
}
