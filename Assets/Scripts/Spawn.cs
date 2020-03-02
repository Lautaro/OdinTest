using Lautaro;
using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lautaro
{

    public class Spawn : MonoBehaviour
    {
        [ShowInInspector]
        //[DisplayMyStruct]
        public MyStruct TheStruct;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if ( Random.Range ( 0, 5 ) == 1 )
            {
                transform.eulerAngles += new Vector3 ( Rnd ( 2f ), Rnd ( 1f ), Rnd ( 3f ) );
            }
        }

        float Rnd( float floaty )
        {
            var x = Random.Range ( -floaty, floaty );
            return x;

        }
    }
}