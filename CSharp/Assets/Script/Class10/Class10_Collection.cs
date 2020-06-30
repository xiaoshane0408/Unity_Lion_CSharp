using UnityEngine;
using System.Collections;           // ArrayList
using System.Collections.Generic;   // List         - 泛型

namespace Shane.Class10
{
    public class Class10_Collection : MonoBehaviour
    {
        #region List、ArrayList
        // 陣列：一旦固定長度就不能改變
        public int[] scores = { 100, 90, 80, 70, 60 };

        // 集合：彈性，可改變長度
        // 清單
        public List<float> hp = new List<float> { 99.9f, 88.8f, 77.7f };

        public List<float> hpResult = new List<float>();

        public ArrayList numbers = new ArrayList();

        // 排序
        public List<int> count = new List<int> { 9, 50, 1, 100, 3 };

        private void Start()
        {
            // 1. 集合可以改變長度
            hp.Add(66.6f);      // 清單.增加(T)
            hp.Remove(88.8f);   // 清單.刪除(T)

            print("是否包含 66.6：" + hp.Contains(66.6f));   // 是否包含(T)

            hpResult = hp.FindAll((x) => x >= 70f);    // 搜尋所有 (大於等於 70) 的資料

            // ArrayList 與 List 差異
            // ArrayList 為 object 型別：可存放所有類型
            // List 為泛型：一旦指定類型就只能存放一種類型 List<Int> - int
            // ArrayList 不會顯示在屬性面板
            // ArrayList 可儲存各種資料，會造成型別不安全問題
            numbers.Add(100);
            numbers.Add(100.1f);
            numbers.Add("String666");
            numbers.Add(true);

            count.Sort();       // 由小到大
            count.Reverse();    // 反轉
        }
        #endregion

        #region 佇列與堆疊
        // 佇列
        // 1. 添加資料到尾端
        // 先進先出
        // 例：飲料店的隊伍，先來的人先點飲料
        public Queue<int> lv = new Queue<int>();

        // 堆疊
        // 2. 添加資料到頂端
        // 先進後出
        // 例：堆放椅子，後疊的椅子可以先拿
        public Stack<int> n = new Stack<int>();

        public Queue<string> people = new Queue<string>();
        public Stack<string> box = new Stack<string>();

        private void Awake()
        {
            // 添加佇列資料
            lv.Enqueue(10);
            lv.Enqueue(20);
            lv.Enqueue(30);

            foreach (var item in lv)
            {
                print("佇列的資料：" + item);
            }

            // 添加堆疊資料
            n.Push(10);
            n.Push(20);
            n.Push(30);

            foreach (var item in n)
            {
                print("堆疊的資料：" + item);
            }

            people.Enqueue("亮");
            people.Enqueue("50");
            people.Enqueue("KID");

            box.Push("盒子1號");
            box.Push("盒子2號");
            box.Push("盒子3號");
        }
        private void Update()
        {
            // 佇列 先進先出
            if (Input.GetKeyDown(KeyCode.Alpha1) && people.Count != 0)
            {
                print("排隊的第一個人：" + people.Dequeue());
            }
            // 堆疊 後進先出
            if (Input.GetKeyDown(KeyCode.Alpha2) && box.Count != 0)
            {
                print("堆放的第一個箱子：" + box.Pop());
            }
        }
        #endregion

        #region 雜湊表、字典
        // 兩個關鍵字
        // Key、Value - 關鍵字、值

        // 差異
        // 雜湊表 - 物件
        // 字典 - 泛型 (可避免安全性問題)

        // 雜湊表
        public Hashtable player = new Hashtable();
        // 字典 - 關鍵字 (字串)，值 (整數)
        public Dictionary<string, int> data = new Dictionary<string, int>();

        // 當物件啟動時執行事件
        private void OnEnable()
        {
            player.Add("Lv", 99);
            player.Add("HP", 9999);
            player.Add("MP", 500);
            player.Add(true, true); // 不曉得是啥

            // DictionaryEntry 結構 - 儲存 Key 與 Value
            foreach (DictionaryEntry item in player)
            {
                print("雜湊表資料 Key：" + item.Key);
                print("雜湊表資料 Value：" + item.Value);
            }

            data.Add("短刀", 100);
            data.Add("長刀", 300);
            data.Add("屠龍刀", 1500);
            // data.Add(true, true);   // 錯誤

            foreach (KeyValuePair<string, int> item in data)
            {
                print("字典資料：" + item);
            }

            // 用陣列或清單存取資料時，只能透過索引值 index - 0, 1, 2, 3, 4 ...
            // 用雜湊表與字典可以使用 Key 存取資料 - "屠龍刀"、"Lv"
            print("屠龍刀價格：" + data["屠龍刀"]);
            print("等級：" + player["Lv"]);
        }
        #endregion
    }
}
