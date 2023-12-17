using System.Collections.Generic;
using _Modules.ObjectPooling.Scripts.Data.ValueObjects;
using _Modules.ObjectPooling.Scripts.Enums;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Rendering;

namespace _Modules.ObjectPooling.Scripts.Data.UnityObjects
{
    [CreateAssetMenu(fileName = "CD_Pool", menuName = "MaxedOutEntertainmentModules/CD_Pool", order = 0)]
    public class CD_Pool : SerializedScriptableObject
    {
        public Dictionary<PoolType, PoolData> PoolList = new Dictionary<PoolType, PoolData>();
    }
}