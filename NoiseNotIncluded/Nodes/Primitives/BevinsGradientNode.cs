﻿using NodeNetwork.Views;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Primitives
{
  public class BevinsGradientNode : PrimitiveNode
  {
    public BevinsGradientNode() : base()
    {
      Name = "BevinsGradient";
    }

    static BevinsGradientNode()
    {
      Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<BevinsGradientNode>));
    }
  }
}
