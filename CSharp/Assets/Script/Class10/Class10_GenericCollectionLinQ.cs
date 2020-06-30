using UnityEngine;

namespace Shane.Class10
{
    public class Class10_GenericCollectionLinQ : MonoBehaviour
    {
        public CharacterFloat cF = new CharacterFloat(100.1f, 50.1f, 10.1f);   // 角色浮點數
        public CharacterInt cI = new CharacterInt(100, 50, 10);   // 角色整數

        public Character<float> c1 = new Character<float>(100.2f, 50.2f,10.2f); // 使用泛型：給予浮點數
        public Character<int> c2 = new Character<int>(101, 51, 11); // 使用泛型：給予整數
        public Character<long> c3 = new Character<long>(1000, 500, 100); // 使用泛型：給予長整數
    }

    #region 不使用泛型
    // 假設系統需要角色類別：
    // 1. 浮點數欄位 - 血量、經驗值、魔力、攻擊力
    // 2. 整數欄位 - 血量、經驗值、魔力、攻擊力
    public class CharacterFloat
    {
        public float hp;
        public float mp;
        public float exp;
        public float atk;

        // 建構子：跟類別名稱相同並且無傳回的方法 - 在新增物件時執行
        public CharacterFloat(float h,float m, float a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    }

    public class CharacterInt
    {
        // 多個游標：Alt + Shift + >
        public int mp;
        public int hp;
        public int exp;
        public int atk;

        public CharacterInt(int h, int m, int a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    }

    // 若想多一個長整數 long
    #endregion

    // 使用泛型 T 泛型
    public class Character<T>
    {
        // 欄位的類型為泛型
        public T hp;
        public T mp;
        public T exp;
        public T atk;

        public Character(T h, T m, T a)
        {
            hp = h;
            mp = m;
            atk = a;
        }
    }
}
