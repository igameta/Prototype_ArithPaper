using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolSelection : MonoBehaviour
{
    /* 選択中のツールを保持 初期値:0(Pen)
               Pen=0   Highrighter=1 
            Eraser=2 Constractions=3
    */
    public enum Toolmode
    {
        Pen,
        Highlighter,
        Eraser,
        Constractions
    }
    public Toolmode UsingTool = Toolmode.Pen;

    // 選択中の色の保持
    public enum ColorPicker
    {
        first,
        second,
        third
    }
    public ColorPicker CurColor = ColorPicker.first;

    // Start is called before the first frame update
    void Start()
    {

    }


    // ツールが選択されたときの処理
    public void ChangeTool ()
    {
        switch (UsingTool)
        {
            case Toolmode.Pen:
                break;

            case Toolmode.Highlighter:
                break;

            case Toolmode.Eraser:
                break;

            case Toolmode.Constractions:
                break;

        }
    }

    // カラーピッカーを押されたときの処理
    public void ChangeColorPicker
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
