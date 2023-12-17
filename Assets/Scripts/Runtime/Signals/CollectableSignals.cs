using Runtime.Extentions;
using UnityEngine.Events;

namespace Runtime.Signals
{
    public class CollectableSignals : MonoSingleton<CollectableSignals>
    {
        public UnityAction<int> onCollectableUpgrade = delegate { };
    }
}