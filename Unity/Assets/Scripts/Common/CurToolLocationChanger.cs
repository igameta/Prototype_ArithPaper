using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Drawing
{
    public class CurToolLocationChanger : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {
            Vector3 pos = this.GetComponent<RectTransform>().anchoredPosition;
            pos.x = -305f;
            this.GetComponent<RectTransform>().anchoredPosition = pos;
        }

        // Update is called once per frame
        void Update()
        {
            //int CurTool = Drawing.ToolSelection.GetUsingTool();
            ToolSelection.Toolmode CurTool = ToolSelection.UsingTool;
            Vector3 pos = this.GetComponent<RectTransform>().anchoredPosition;

            switch (CurTool)
            {
                case ToolSelection.Toolmode.Pen:
                    pos.x = -305f;
                    this.GetComponent<RectTransform>().anchoredPosition = pos;
                    break;

                case ToolSelection.Toolmode.Highlighter:
                    pos.x = -249f;
                    this.GetComponent<RectTransform>().anchoredPosition = pos;
                    break;

                case ToolSelection.Toolmode.Eraser:
                    pos.x = -192f;
                    this.GetComponent<RectTransform>().anchoredPosition = pos;
                    break;

                case ToolSelection.Toolmode.Constractions:
                    pos.x = 252f;
                    this.GetComponent<RectTransform>().anchoredPosition = pos;
                    break;

            }
        }
    }
}
