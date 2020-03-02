using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Lautaro
{
    public class GameFun : MonoBehaviour
    {
        // Start is called before the first frame update
        public GameObject spawnOfSatan;

        public static List<GameObject> AllSpawns = new List<GameObject> ();

        // Update is called once per frame
        void Update()
        {
            if ( Random.Range ( 0, 100 ) == 0 )
            {
                var x = GameObject.Instantiate ( spawnOfSatan, new Vector2 ( Random.Range ( -5, 5 ), Random.Range ( -5, 5 ) ), Quaternion.identity, transform );
                AllSpawns.Add ( x );

            }
        }
    }
}