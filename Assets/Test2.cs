using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    //魔法攻撃関数
    public void Magic(int cost)
    {
        if (this.mp >= 5)
        {
            cost = this.mp - 5;
            UnityEngine.Debug.Log("魔法攻撃をした。残りＭＰは" + cost + "。");
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

        lastboss.Magic(0);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
