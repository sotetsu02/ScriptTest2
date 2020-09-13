using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    //魔法攻撃関数
    public void Magic(int cost)
    {
        if (this.mp >= cost)
        {
            this.mp -= cost;
            UnityEngine.Debug.Log("魔法攻撃をした。残りＭＰは" + this.mp + "。");
        }
        else
        {
            UnityEngine.Debug.Log("ＭＰが足りないため魔法が使えない。");
        }
    }
}

public class Test2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();

        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
