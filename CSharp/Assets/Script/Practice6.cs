using UnityEngine;

public class Practice6 : MonoBehaviour
{
    [Header("練習 2")]
    public SpriteRenderer picture;
    [Header("練習 4")]
    public Rigidbody sphere;

    private void Start()
    {
        // 練習 1 設定遊戲速度 - 靜態屬性
        Time.timeScale = 2;

        // 練習 2 翻轉圖片 - 非靜態屬性
        picture.flipX = true;

        // 練習 3 去小數點 - 靜態方法
        print("去小數點： " + Mathf.Floor(1.23456f));

        // 練習 4 添加推力 - 非靜態方法
        sphere.AddForce(0, 800, -800);
    }
}
