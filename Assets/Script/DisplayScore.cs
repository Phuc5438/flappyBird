using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Sprite[] numbers;

    public GameObject digitsPrefab;
    public Transform digitsParent;
    private List<GameObject> digits = new List<GameObject>();

    public void ShowScore(int score)
    {
        foreach (var obj in digits)
            Destroy(obj);
        digits.Clear();
        
        string scoreString = score.ToString();
        foreach (char c in scoreString)
        {
            int num = c - '0';
            GameObject digit = Instantiate(digitsPrefab, digitsParent);
            digit.GetComponent<Image>().sprite = numbers[num];
            digits.Add(digit);
        }
    }
}