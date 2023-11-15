using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    // 試験の点数を保存するための5つ容量のある配列を宣言
    int[] testScores = new int[5];
    int[] numbers = { 5, 8, 12, 7, 3 };
    string[] fruits = { "apple", "banana", "cherry", "date", "elderberry" };
    List<int> testNum = new List<int>();
    List<int> listNumber = new List<int> { 1, 2, 3, 4, 5 };

    // Start is called before the first frame update
    void Start()
    {
        testScores[0] = 85;
        testScores[1] = 90;
        testScores[2] = 78;
        testScores[3] = 88;
        testScores[4] = 76;
        Debug.Log(testScores[1]); // 90

        Debug.Log(numbers[2]);
        Debug.Log(numbers[2]);

        testNum.Add(1); // リストの0番目の要素に1を追加(1)
        testNum.Add(2); // リストの1番目の要素に2を追加(1, 2)
        testNum.Add(3); // リストの2番目の要素に3を追加(1, 2, 3)
        Debug.Log(testNum[0]); //リストの最初の要素を取得(1)
        testNum.Remove(2); // リスト内の一致する要素を削除(1, 3)
        Debug.Log(testNum.Count); // リストの要素数を取得(この場合、2)

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
