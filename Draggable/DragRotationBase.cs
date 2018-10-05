﻿using UnityEngine;

namespace ArtisanDream.Experimental.Draggable
{
    public abstract class DragRotationBase : MonoBehaviour {

        public string AxisName = "Mouse X";
        public float Speed = 10.0F;
       // protected Vector3 Vectors;
 

        public abstract void OnMouseDrag ();
    }
}



