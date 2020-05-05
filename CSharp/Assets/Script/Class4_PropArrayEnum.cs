using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class4_PropArrayEnum : MonoBehaviour
{
    public Ship ship;

    private void Start()
    {
        // 設定屬性
        ship.length = 99.9f;
        // 取得屬性
        print("船的長度：" + ship.length);

        // 設定唯讀屬性
        // ship.width = 20.5f;  // 錯誤
        // 取得唯讀屬性
        print("船的寬度：" + ship.width);

        ship.atk = 50.5f;
        print("船的攻擊力：" + ship.atk);
    }
}
