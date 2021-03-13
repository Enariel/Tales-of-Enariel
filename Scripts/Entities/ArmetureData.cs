//copyright(c) FuchsFarbe
//Author: Oliver

using System.Collections.Generic;
using UnityEngine;

namespace Tales_Of_Enariel
{
	public partial class ArmetureData : MonoBehaviour
    {
        #region Variables
        //References
		[SerializeField] private GameObject entity;
		//Variables
		private Dictionary<string, Transform> boneDict = new Dictionary<string, Transform>();
        [SerializeField] private List<Transform> bones = new List<Transform>();
		[SerializeField] private Transform rHand, lHand, weapon;
		//Properties

		public Transform RightHand { get => rHand; }
		public Transform LeftHand { get => lHand; }
		public Transform WeaponObject { get => weapon; }
		public List<Transform> Rig { get => bones; }
		public Dictionary<string, Transform> RigDictionary { get => boneDict; }
		#endregion

		#region Unity Methods
		private void Awake()
		{
			entity = this.gameObject;
			Transform[] rootObjs = entity.GetComponentsInChildren<Transform>();
			Transform rootArm = GetRootArmeture(rootObjs);

			GetBones(rootArm);
			BoneDict(bones);
		}
		#endregion
		private void GetBones(Transform root)
		{
			bones.Clear();

			Transform[] _bones = root.GetComponentsInChildren<Transform>();

			foreach (Transform b in _bones)
			{
				bones.Add(b);

				if (b.CompareTag("RHand"))
				{
					rHand = b;
				}

				if (b.CompareTag("LHand"))
				{
					lHand = b;
				}

				if (b.CompareTag("Staff"))
				{
					weapon = b;
				}
			}
		}
		private void BoneDict(List<Transform> _bones)
		{
			foreach (Transform b in _bones)
			{
				boneDict.Add(b.name, b);
			}
		}
		private Transform GetRootArmeture(Transform[] gameObjects)
		{
			foreach (Transform obj in gameObjects)
			{
				if (obj.gameObject.CompareTag("RootArmeture"))
				{
					return obj;
				}
			}
			return null;
		}
	}
}
