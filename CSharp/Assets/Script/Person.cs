using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    // 定義方法語法：
    // 修飾詞 傳回類型 方法名稱 (參數) { 陳述式 }
    // void 無傳回：當使用此方法時不會得到任何回傳資料
    public void Talk()
    {
        // gameObject 套用此腳本的物件
        // gameObject.name 套用此腳本的物件 的 名稱
        print("安安你好，我是 " + gameObject.name);
    }

    /// <summary>
    /// 計算人的 BMI
    /// </summary>
    /// <returns>計算完的 BMI</returns>
    public float BMI()
    {
        // BMI公式
        float result = weight / ((height / 100) * (height / 100));
        // 傳回 return
        return result;
    }

    /// <summary>
    /// 走路方法
    /// </summary>
    /// <param name="speed">需要以多少速度走路</param>
    // 參數語法：類型 名稱 指定 預設值
    // 有預設值參數稱為 【選填式參數】 - 可以不填，值為預設值
    // 選填式參數必須定義在最右邊
    public void Walk(int speed, string direction = "前", string sound = "叩叩叩")
    {
        print(gameObject.name + "用時速 " + speed + " 公里向 " + direction + " 走路");
        print("走路音效 : " + sound);
    }

    // 多載 Overload
    // 1. 相同名稱的方法
    // 2. 參數數量不同 或者 參數類型不同
    // 攻擊方法：徒手
    // 攻擊方法：拿武器攻擊、音效
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊 ~");
    }
    public void Attack(string weapon)
    {
        print(gameObject.name + "用武器：" + weapon + " 攻擊~");
    }

    // 讓 Unity 按鈕 Button 使用方法條件：
    // 1. 修飾詞為公開 public
    // 2. 參數數量小於等於 1
    /// <summary>
    /// 技能
    /// </summary>
    public void Skill()
    {
        print(gameObject.name + "施放技能");
    }
}
