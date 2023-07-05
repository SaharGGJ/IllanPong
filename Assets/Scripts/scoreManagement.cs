using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManagement : MonoBehaviour
{

    public TMP_Text rightScore;
    public TMP_Text leftScore;
    public int rightScoreNum;
    public int leftScoreNum;
    // Start is called before the first frame update
    private void Start()
    {
        leftScoreNum = 0;
        rightScoreNum = 0;
    }
    public void AddScoreToRight()
    {
        rightScoreNum++;
        rightScore.text = $"{rightScoreNum}";
    }
    public void AddScoreToLeft()
    {
        leftScoreNum++;
        leftScore.text = $"{leftScoreNum}";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
