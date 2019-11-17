using UnityEngine;
using System.Collections;

namespace Adnc.Utility.Examples {
	public class TestClass : MonoBehaviour {
		[InfoBox("Info box goes here. Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum Lorem Ipsum", InfoBoxType.Warning)]
		[SerializeField, Range(0, 1)] float myCustomField;

		[MinMaxFloat(0, 10)] public MinMaxFloat rangeFloatExample;

		[Range(0, 10)] public float floatRangeDefault;
		
		[SerializeField] string fieldBelow;

		[EnumFlags]
		[SerializeField]
		private EnumFlagsTest _enumFlagTest;

		[Layer] 
		public int targetLayer;

		[Tag]
		public string targetTag;

		[MinMaxInt(0, 10)] public MinMaxInt rangeIntExample;

		public int aNumber;

		[SerializeField]
		private bool _disable;

		[ShowToggle("_disable", false, ShowToggleDisplay.Disable)]
		[SerializeField]
		string _contentA;

		[SerializeField]
		private bool _show;

		[ShowToggle("_show", true, ShowToggleDisplay.Hide)]
		[SerializeField]
		string _contentB;

		[SerializeField]
		[SortLayer]
		private int _sortLayer;

		void Awake () {
			TestRangeInt();
			TestRangeFloat();
		}

	    public void TestRangeInt () {
	        Debug.LogFormat("Random Int Range: {0}", rangeIntExample.GetRandom());
	    }

	    public void TestRangeFloat () {
		    Debug.LogFormat("Random Float Range: {0}", rangeFloatExample.GetRandom());

	    }
	}
}
