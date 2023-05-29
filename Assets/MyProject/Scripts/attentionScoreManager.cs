using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attentionScoreManager : MonoBehaviour
{
    [Header("Score")]
    public float attentionScore;

    // Start is called before the first frame update
    void Start()
    {
        attentionScore=10.0f;
    }
}
