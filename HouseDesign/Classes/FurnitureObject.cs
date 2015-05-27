﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseDesign.Classes
{
    [Serializable]
    public class FurnitureObject:StoredObject
    {     
        
        public Decimal InitialPrice { get; set; }

        public FurnitureObject()
        {
            DefaultIconPath = @"D:\Licenta\HouseDesign\HouseDesign\Images\defaultObjectIcon.png";
        }
        public FurnitureObject(String name, String fullPath, String description, Decimal initialPrice):this()
        {
            this.Name = name;
            this.FullPath = fullPath;
            this.Description = description;
            this.InitialPrice = initialPrice;
           
        }
    }
}
