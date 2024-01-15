using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CrowdCounter : MonoBehaviour
{
    [SerializeField] private TMP_Text runnerCountText;
    [SerializeField] private Transform runnerParent;

    // Update is called once per frame
    void Update()
    {
        runnerCountText.text = runnerParent.childCount.ToString();
    }
}
