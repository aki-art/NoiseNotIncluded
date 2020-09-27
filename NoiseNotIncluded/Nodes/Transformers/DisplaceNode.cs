﻿using NodeNetwork.Views;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Transformers
{
  public class DisplaceNode : TransformerNode
  {
    public DisplaceNode() : base()
    {
      Name = "Displace";
    }

    static DisplaceNode()
    {
      Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<DisplaceNode>));
    }
  }
}
