//copyright(c) FuchsFarbe
//Author: Oliver

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel.StaffCasting
{
    public class ElementManager : MonoBehaviour
    {
		public static Action<Element> OnElementChange;

		#region Variables and Properties
		//Variables
		[SerializeField] private ElementData currentElementData;
		[SerializeField] private List<ElementData> elements;
		private int elementIndex;
		//Properties
		public ElementData CurrentElementData { get => currentElementData; } 
		#endregion

		public void Start()
		{
			if (currentElementData == null)
			{
				currentElementData = elements[0];
			}
			elementIndex = 0;
		}

		public void Update()
		{
			SwapCombatElement();
		}

		//Uses input from mouse to cycle through index
		//Selects the current element data
		private void SwapCombatElement()
		{
			//Mouse wheel input
			Vector2 mouseDelta = Input.mouseScrollDelta;

			if (mouseDelta.magnitude >= .5f)
			{
				elementIndex += (int)mouseDelta.y;
				if (elementIndex > elements.Count - 1)
				{
					elementIndex = 0;
				}
				else if (elementIndex < 0)
				{
					elementIndex = elements.Count - 1;
				}

				if (elements[elementIndex] != null)
				{
					currentElementData = elements[elementIndex];
				}
				
				//Invoke the element change event to trigger an animation, sound, and visual effect change.
				OnElementChange?.Invoke(currentElementData.Element);
			}
		}
	}
}
