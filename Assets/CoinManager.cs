using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coincount;
    public Text value;
    void Start()
    {
        
    }

    void Update()
    {
        value.text = coincount.ToString();
    }
}
