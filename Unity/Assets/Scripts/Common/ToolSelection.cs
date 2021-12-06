using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


namespace FreeDraw
{
    public class ToolSelection : MonoBehaviour
    {
        /* 選択中のツールを保持 初期値:0(Pen)
                   Pen=0   Highrighter=1 
                Eraser=2 Constractions=3
        */
        public enum Toolmode
        {
            Pen=0,
            Highlighter=1,
            Eraser=2,
            Constractions=3
        }
        public static Toolmode UsingTool = Toolmode.Pen;

        // UsingToolGeter
        public static int GetUsingTool()
        {
            return (int)UsingTool;
        }

        // 選択中の色の保持
        public enum ColorPicker
        {
            first,
            second,
            third
        }
        public ColorPicker CurColor = ColorPicker.first;

        // 選択ツールを有効化
        private void ToolActivator ( Toolmode SelTool )
        {
            switch (SelTool)
            {
                case Toolmode.Pen:
                    UsingTool = Toolmode.Pen;
                    //CurrentTool.transform.Translate(-305, 191, 0);
                    break;

                case Toolmode.Highlighter:
                    UsingTool = Toolmode.Highlighter;
                    //CurrentTool.transform.Translate(-249, 191, 0);
                    break;

                case Toolmode.Eraser:
                    UsingTool = Toolmode.Eraser;
                    //CurrentTool.transform.Translate(-192, 191, 0);
                    break;

                case Toolmode.Constractions:
                    UsingTool = Toolmode.Constractions;
                    //CurrentTool.transform.Translate(252, 191, 0);
                    break;

            }
        }

        //// 選択カラーピッカーを有効化
        //void ColorActivator(ColorPicker SelColor)
        //{

        //}

        // Start is called before the first frame update
        void Start()
        {
            //念の為初期化
            UsingTool = Toolmode.Pen;
            CurColor = ColorPicker.first;

            // ボタン押下検知
            //Button btn = ToolSelection.GetComponent<Button>();
            //btn.onClick.AddListener(TaskOnClick);
        }


        // ツールが選択されたときの処理
        public void ChangeTool( Toolmode SelTool )
        {
            // 選択ツールが選択中のツールと同じか判定
            if ( SelTool != UsingTool)
            {
                // ToolActivatorの起動とか
                switch (SelTool)
                {
                    case Toolmode.Pen:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Highlighter:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Eraser:
                        ToolActivator(SelTool);
                    break;

                    case Toolmode.Constractions:
                        ToolActivator(SelTool);
                    break;

                }
            }
            // 太さの変更処理
            else if ( SelTool != Toolmode.Constractions)
            {

            }
        }

        // カラーピッカーを押されたときの処理
        //public void ChangeColorPicker ( ColorPicker SelPicker )
        //{
        //    if ( CurColor != SelPicker)
        //    {

        //    }
        //}

        // Update is called once per frame
        void Update()
        {

        }

    }

}