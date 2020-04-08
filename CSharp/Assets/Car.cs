﻿using UnityEngine;

// 註解 : 用來說明紀錄等等...只會在此腳本內看到
// 摘要 summary : 描述此內容會在其他腳本內看到  -  提高維護性與擴充性 (可讀性)
// 新增的 C# 放在專案內為藍圖
// 放在場景物件上為實體物件
/// <summary>
/// 定義汽車物件
/// </summary>
public class Car : MonoBehaviour
{
    // 認識第一個成員 : 欄位 field  -  儲存物件資料

    // 資料類型
    // cc 數         -  2000            -  整數  int
    // 重量           -  100.9           -  浮點數  float
    // 品牌           -  BMW          -  字串  string
    // 剎車           -  是否開啟     -  布林值 bool  -  true 、 false

    // 定義欄位語法 :
    // 修飾詞  資料型態  欄位名稱 (指定  值);
    // 修飾詞 : 
    // 公開 public : 允許其他類別存取，顯示在屬性面板(Inspector)上
    // 私人 private (預設) : 不允許、不顯示

    // 預設值 :
    // int、float 為 0
    // string 為 ""
    // bool 為 false
    // 欄位屬性  Attribute : Unity 提供用於輔助欄位的功能
    // 語法 : [屬性名稱(值)]
    // 標題  [Header("字串"]
    // 提示  [Tooltip("字串")]
    // 範圍  [Range(最小值,最大值)]  -  僅限於數值類型資料  int、float

    /// <summary>
    /// 汽車的 cc 數
    /// </summary>
    [Header("汽車的 cc 數")]
    [Tooltip("汽車CC數"), Range(500, 5000)]
    public int cc = 2000;
    /// <summary>
    /// 重量
    /// </summary>
    [Header("重量"), Tooltip("汽車重量"),Range(50,500)]
    public float weight =  100.9f;
    /// <summary>
    /// 品牌
    /// </summary>
    [Header("品牌"), Tooltip("汽車品牌")]
    public string brand =  "BMW";
    /// <summary>
    /// 剎車
    /// </summary>
    [Header("剎車"), Tooltip("汽車剎車")]
    public bool brake = false;

}
