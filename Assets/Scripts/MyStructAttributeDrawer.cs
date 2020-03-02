using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;

namespace Lautaro
{
    public class MyStructAttributeDrawer :  OdinAttributeDrawer<DisplayMyStructAttribute, MyStruct>
    {
        protected override void DrawPropertyLayout( GUIContent label )
        {
            Rect rect = EditorGUILayout.GetControlRect ();

            if ( label != null ) rect = EditorGUI.PrefixLabel ( rect, label );

            var theStruct = this.ValueEntry.SmartValue;

            GUIHelper.PushLabelWidth ( 0 );
            theStruct.SingleShout = (MyEnum)EditorGUI.EnumPopup ( rect,"shout",theStruct.SingleShout );

            int index = 1;
            for ( int i = 0; i < theStruct.LotsOfShouts.Count; i++ )
            {
                MyEnum shout = ( MyEnum )theStruct.LotsOfShouts[i];
                theStruct.LotsOfShouts[i] = ( MyEnum )EditorGUI.EnumPopup ( rect, index++.ToString(), shout );
               
            }
            GUIHelper.PopLabelWidth ();
        }
    }
}
