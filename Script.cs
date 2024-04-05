using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Linq;
public class Script : MonoBehaviour
{

    public TMP_InputField InputField;

    // Start is called before the first frame update
    void Start()
    {
        int skill = UnityEngine.Random.Range(1, 10);
        Debug.LogFormat("random skill: " + skill);
        int[] myArray = new int[] {
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50),
        UnityEngine.Random.Range(0, 50) };
        Array.Sort(myArray);
        for (int i = 0; i < myArray.Length; i++)
        Debug.LogFormat("sort: " + (myArray[i]));
        int result1 = myArray[skill-1];
        Debug.LogFormat("weighted random: " + result1);

        int a;
        a = 1 + (int.Parse(InputField.text));
        Debug.LogFormat("a" + a);
        Debug.LogFormat("Inputfield;" + InputField.text);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
