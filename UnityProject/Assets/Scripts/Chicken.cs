using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{

    private void Start()
    {
        print("遊戲開始!!!!");
        print("咕咕咕");
    }

    [Header("移動速度"), Range(0.1f,99.9f)]
    public float speed=1.5f;
    [Header("跳躍高度"), Range(1, 9999)]
    public int Jump;
    [Header("對話內容")]
    public string taik = "咕咕咕";
    [Header("是否取得雞蛋")]

    public bool egg = true;


}
