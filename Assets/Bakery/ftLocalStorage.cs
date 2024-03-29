using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
#endif

public class ftLocalStorage : ScriptableObject
{
    [SerializeField]
    public List<string> modifiedAssetPathList = new List<string>(); // marks model as processed

    [SerializeField]
    public List<int> modifiedAssetPaddingHash = new List<int>();
}

