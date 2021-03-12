using System.Collections;

namespace Tales_Of_Enariel
{
	public interface IDamageOverTime
	{
		public IEnumerator DoT(float damage, float time);
	}
}
