using JetBrains.Annotations;
using UnityEngine;

public class TestLearning : MonoBehaviour
{
    public int bill = 40;
    public float tip = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float tipPercentege = bill * (tip / 100);
        float total = bill + tipPercentege;
        Debug.Log($"Your bill is: {bill}, and your tip is: {tip}, so you owe: {total} ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
