using UnityEngine;

// 命名空間
namespace Shane.Class8
{
    public class Player : MonoBehaviour
    {
        public Transform hand;

        private void OnTriggerEnter(Collider other)
        {
            // 不使用介面的寫法
            if (other.name == "道具" || other.name == "武器") Hit(other.GetComponent<ICanUse>());

            // 使用介面的寫法
            if (other.GetComponent<ICanUse>() != null) Hit(other.GetComponent<ICanUse>());
        }
        private void Hit(ICanUse use)
        {
            print("碰到東西囉");
            use.Use();
        }
    }
}

