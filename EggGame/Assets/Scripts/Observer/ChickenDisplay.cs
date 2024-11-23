using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChickenDisplay : Observer
{
    public Text chickensCountText;
    public Text moneyText;

    private float count;
    public float money;

    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        chickensCountText.text = count.ToString();

        moneyText.text = money.ToString();

        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            money += count * 0.5f;
            timer = 0f;
        }
    }

    public override void Notify(Subject subject)
    {
        count++;
    }

    IEnumerator moneyCalc()
    {
        money += count * 0.5f;
        yield return new WaitForSeconds(1);
    }
}