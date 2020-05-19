using UnityEngine;

public class Enemy : MonoBehaviour
{
    // 一般欄位 (非靜態)
    // 屬於物件：每個物件都是獨立的
    public float hp;

    // 靜態欄位
    // 屬於類別：所有物件共用
    public static float speed = 3;

    // 一般方法 (非靜態)
    public void Walk()
    {
        print(name + " 走路中...");
    }

    // 靜態方法
    // 靜態方法內只能存取靜態成員
    public static void Stop()
    {
        // hp = 100;  (錯誤)
        speed = 0;
        print("所有怪物的速度： " + speed);
    }
}
