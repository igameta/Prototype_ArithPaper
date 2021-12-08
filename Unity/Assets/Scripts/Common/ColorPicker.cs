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
        }

        public void SPicker()
        {
            InputSystem_Drawable.PenColor = Color.red;
        }

        public void TPicker()
        {
            InputSystem_Drawable.PenColor = Color.blue;
        }
    }

}