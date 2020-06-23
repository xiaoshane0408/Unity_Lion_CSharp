using UnityEngine;
using UnityEngine.UI;

public class House : MonoBehaviour
{
    [Header("血量"), Range(1000, 10000)]
    public float hp;
    [Header("血條")]
    public Image hpBar;

    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }

    /// <summary>
    /// 接收傷害值
    /// </summary>
    /// <param name="damage">傷害值</param>
    public void Damage(float damage)
    {
        // 血量 遞減 傷害值
        hp -= damage;
        // 更新 血條
        hpBar.fillAmount = hp / hpMax;
    }
}
