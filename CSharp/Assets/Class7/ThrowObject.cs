using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    [Header("爆炸效果")]
    public GameObject explosion;
    [Header("傷害值"), Range(10, 500)]
    public float damage;

    /// <summary>
    /// 爆炸
    /// </summary>
    public void Explosion()
    {
        // 生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);    // 刪除怪物
        Destroy(exp, 1.5f);     // 2.5秒後刪除爆炸效果
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "房子")
        {
            collision.gameObject.GetComponent<House>().Damage(damage);
            Explosion();
        }
    }
}
