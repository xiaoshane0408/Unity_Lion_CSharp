using UnityEngine;
using System.Collections; // 引用 系統 集合 API (協同程序)

namespace Shane.Class8
{
    public class Prop : MonoBehaviour, ICanUse
    {
        public Data data;

        public void Use()
        {
            print("使用道具：" + data.name);
            // 啟動協同程序(協同方法)
            StartCoroutine(Big());
        }

        private IEnumerator Big()
        {
            Transform player = FindObjectOfType<Player>().transform;

            while (player.lossyScale.x < 1.5)
            {
                player.localScale += Vector3.one * 0.1f;
                yield return new WaitForSeconds(0.1f);
            }

            Destroy(gameObject);
        }
    }
}
