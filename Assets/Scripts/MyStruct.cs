using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lautaro
{
  public struct MyStruct
    {
        public MyEnum SingleShout;
        public List<MyEnum> LotsOfShouts;

        public MyStruct(int shouts)
        {
            LotsOfShouts = new List<MyEnum> (); 

            for ( int i = 0; i < shouts; i++ )
            {
                LotsOfShouts.Add ( MyEnum.AwwwwYeaah );
            }

            SingleShout = MyEnum.Niiin;

        }
    }

    public enum MyEnum{
        Woho, 
        AwwwwYeaah,
        Niiin

    }
}
