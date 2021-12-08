using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurToolLocationChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.GetComponent<RectTransform>().anchoredPosition;
        pos.x= -305f;
        this.GetComponent<RectTransform>().anchoredPosition = pos;
    }

    // Update is called once per frame
    void Update()
    {
        int CurTool = Drawing.ToolSelection.GetUsingTool();
        Vector3 pos = this.GetComponent<RectTransform>().anchoredPosition;

        switch (CurTool)
        {
            case 0:
                pos.x=-305f;
                this.GetComponent<RectTransform>().anchoredPosition = pos;
                break;

            case 1:
                pos.x=-249f;
                this.GetComponent<RectTransform>().anchoredPosition = pos;
                break;

            case 2:
                pos.x=-192f;
                this.GetComponent<RectTransform>().anchoredPosition = pos;
                break;

            case 3:
                pos.x=252f;
                this.GetComponent<RectTransform>().anchoredPosition = pos;
                break;

        }
    }
}
