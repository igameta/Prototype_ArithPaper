using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    public class ColorPicker : MonoBehaviour
    {
        public void FPicker()
        {
            InputSystem_Drawable.PenColor = Color.black;
            Debug.Log("FirstPicker");
        }

        public void SPicker()
        {
            InputSystem_Drawable.PenColor = Color.red;
            Debug.Log("SecondPicker");
        }

        public void TPicker()
        {
            InputSystem_Drawable.PenColor = Color.blue;
            Debug.Log("ThirdPicker");
        }
    }

}