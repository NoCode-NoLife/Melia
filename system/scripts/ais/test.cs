using System.Collections;
using Melia.Zone.Scripting;
using Melia.Zone.Scripting.AI;

[Ai("Test")]
public class TestAiScript : AiScript
{
	protected override void Root()
	{
		StartRoutine("Idle", Idle());
	}

	protected IEnumerable Idle()
	{
		yield return Wait(3000, 10000);

		SwitchRandom();
		if (Case(90))
		{
			yield return MoveRandom();
		}
		else if (Case(5))
		{
			yield return Say("Whoop, whoop!");
			yield return MoveRandom();
		}
		else if (Case(5))
		{
			yield return Emoticon("I_emo_mvp");
		}
	}
}
