﻿using NodeNetwork.Views;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Transformers
{
  public class TurbulenceNode : TransformerNode
  {
    public TurbulenceNode() : base()
    {
      Name = "Turbulence";
    }

    static TurbulenceNode()
    {
      Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<TurbulenceNode>));
    }
  }
}
