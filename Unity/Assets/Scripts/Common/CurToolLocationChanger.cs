using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurToolLocationChanger : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = this.gameObject.transform.position;
        pos.x= -305; pos.y = 191; pos.z = 0;
        this.gameObject.transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {
        int CurTool = Drawing.ToolSelection.GetUsingTool();
        Vector3 pos = this.gameObject.transform.position;
        pos.y = 191; pos.z = 0;

        switch (CurTool)
        {
            case 0:
                pos.x=-305;
                this.gameObject.transform.position = pos;
                break;

            case 1:
                pos.x=-249;
                this.gameObject.transform.position = pos;
                break;

            case 2:
                pos.x=-192;
                this.gameObject.transform.position = pos;
                break;

            case 3:
                pos.x=252;
                this.gameObject.transform.position = pos;
                break;

        }
    }
}
