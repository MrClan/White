using System.Windows.Automation.Peers;
using System.Windows.Controls.Primitives;
using White.CustomControls.Automation;

namespace White.CustomControls.Peers
{
    public class WhiteThumbAutomationPeer : ThumbAutomationPeer
    {
        private readonly WhitePeer whitePeer;

        public WhiteThumbAutomationPeer(Thumb owner) : base(owner)
        {
            whitePeer = WhitePeer.Create(this, owner);
        }

        public void SetValue(string commandString)
        {
            whitePeer.SetValue(commandString);
        }

        public string Value
        {
            get { return whitePeer.Value; }
        }

        public bool IsReadOnly
        {
            get { return whitePeer.IsReadOnly; }
        }

        public override object GetPattern(PatternInterface patternInterface)
        {
            return whitePeer.GetPattern(patternInterface);
        }
    }
}