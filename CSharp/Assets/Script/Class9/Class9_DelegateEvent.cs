using UnityEngine;

public class Class9_DelegateEvent : MonoBehaviour
{
    public void AddTen(int number)
    {
        int n = number += 10;
        print("數字累加：" + n);
    }

    private int number1 = 1;

    private void Awake()
    {
        AddTen(9);
        AddTen(number1);
    }

    public void MethodA()
    {
        print("Method A");
    }

    public void MethodB()
    {
        print("Method B");
    }

    // 簽名：無傳回、一個字串參數
    public void MethodC(string msg)
    {
        print("Method C - " + msg);
    }

    // 定義委派
    // 可以儲存 無傳回、無參數 的任何方法
    public delegate void DelegateTest();

    // 可以儲存 無傳回、一個字串參數 的任何方法
    public delegate void DelegateTest2(string s);

    // 定義委派欄位
    public DelegateTest dA;
    public DelegateTest dB;
    public DelegateTest dC;

    public DelegateTest2 d2C;

    public DelegateTest d;
    public DelegateTest dd;

    private void Start()
    {
        dA = MethodA;   // dA 欄位儲存 方法A
        dA();           // 呼叫 dA

        dB = MethodB;   // dB 欄位儲存 方法A
        dB();

        // dC = MethodC;   // 不同簽名無法儲存
        // dC();

        d2C = MethodC;  // 儲存 方法C
        d2C("我是委派");

        d = MethodA;
        d += MethodB;
        d += MethodB;

        d();

        dd = MethodB;
        dd = dd + MethodA + MethodB;
        dd();
    }
}
