using UnityEngine;           // 引用 Unity API(函式庫:Unity 屬性、功能...)

// 類別 class 定義一個物件
// 語法 : class 類別名稱
// : MonoBehaviour 可以將此腳本掛在 Unity 物件上
// 類別必須放在物件上才會執行
public class Class1 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1.大小寫不一樣
    // 2.括號成對出現 () [] {} '' "" <>

    [Header("存放汽車 1 號")]
    public Car car1;
    [Header("存放汽車 2 號")]
    public Car car2;

    // 事件 : 在特定時間會以指定次數執行的方法 (名稱為藍色)
    // 開始事件 : 播放遊戲時執行一次  -  初始設定
    private void Start()
    {
        // 輸出("文字訊息");
        // C# 結尾為分號 ;
        print("Hey");

        // 取得  get
        print("汽車 1 號  cc數 : " + car1.cc + "  重量 : " + car1.weight + "  品牌 : " + car1.brand + "  剎車狀態 : " + car1.brake);
        print("汽車 2 號  cc數 : " + car2.cc + "  重量 : " + car2.weight + "  品牌 : " + car2.brand + "  剎車狀態 : " + car2.brake);

        // 設定  set
        car1.cc = 870;
        car1.weight = 250;
        car1.brand = "Benz";
        car1.brake = true;
    }
}