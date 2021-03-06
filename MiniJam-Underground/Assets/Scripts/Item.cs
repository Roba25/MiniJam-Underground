﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
   private string description;
   private string title;
   private Sprite icon;

   public Item(string description, string title, Sprite icon)
   {
      this.description = description;
      this.title = title;
      this.icon = Resources.Load<Sprite>("Graphics/Items/" + title);
      if (this.icon == null)
      {
      this.icon = icon;
      }
      
   }
   public string GetDescription() {
   return description;
   }
   public string GetTitle() {
   return title;
   }
   public Sprite GetIcon() {
   return icon;
   }

}
