using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lautaro
{
    [CreateAssetMenu(fileName = "NewMyStruct",menuName = "Lautaro/MyStruct", order = 0)]
    public class Structy_SO : SerializedScriptableObject
    {

        public string Name;

       [DisplayMyStruct]
        public MyStruct TheStruct;

    }
}