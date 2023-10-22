using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Profiling;
using UnityEngine;

public class ProfilerCounterSample : MonoBehaviour
{
    static readonly ProfilerCounter<int> characterNumber =
       new ProfilerCounter<int>(ProfilerCategory.Scripts,
           "キャラの数",
           ProfilerMarkerDataUnit.Count);

    private int characterNum;

    public void OnCharacterNumChanged(int number)
    {
        this.characterNum = number;
    }

    void Update()
    {
        characterNumber.Sample(characterNum);
    }
}
