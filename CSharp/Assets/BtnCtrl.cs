using UnityEngine;
using UnityEngine.UI;

public class BtnCtrl : MonoBehaviour
{
    public BtnSet[] buttons = new BtnSet[6];

    private void Awake()
    {
        BtnReset();
    }


    /*public void BtnOnClick()
    {
        // player 按按鈕，取得按鈕索引值 index
        print(buttons[0].Value);
    }*/

    public void BtnReset()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].Value = i;
            print(buttons[i].Value);
        }
    }

    private void Start()
    {
        buttons[0].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[0].Value; });
        buttons[1].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[1].Value; });
        buttons[2].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[2].Value; });
        buttons[3].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[3].Value; });
        buttons[4].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[4].Value; });
        buttons[5].GetComponent<Button>().onClick.AddListener(delegate { index = buttons[5].Value; });
    }

    public int index;
}
