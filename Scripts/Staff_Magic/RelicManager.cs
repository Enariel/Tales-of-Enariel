//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
    public class RelicManager : MonoBehaviour
    {
        public static Action<Element> OnElementSelected;
		public static Action<ElementData> OnRelicStart;
		public static Action<ElementData> OnRelicUpdate;
		public static Action<ElementData> OnRelicEnd;

		#region Variables
		[SerializeField] private Element selectedElement;
		[SerializeField] private List<ElementData> currentRelics;
		[SerializeField] private List<ElementData> relicInventory;
		#endregion

		#region Unity Methods
		private void OnEnable()
		{
			OnElementSelected += ElementSelected;
		}

		private void OnDisable()
		{
			OnElementSelected -= ElementSelected;
		}
		#endregion

		public void ElementSelected(Element e)
		{
			Debug.Log(e);
		}
    }
}
