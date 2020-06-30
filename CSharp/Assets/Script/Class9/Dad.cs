using UnityEngine;

namespace Shane.Class9
{
    public class Dad : MonoBehaviour
    {
        public Boy boy;

        private void Start()
        {
            boy.onNoMoney += HitBot;
            boy.onNoMoney += GiveMoney;
        }

        private void GiveMoney()
        {
            boy.money += 50;
            print("五雜摳齁哩啦");
        }

        private void HitBot()
        {
            print("欠打，呷老本");
        }
    }
}
