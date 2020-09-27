﻿using NodeNetwork.Views;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Primitives
{
  public class ConstantNode : PrimitiveNode
  {
    public ConstantNode() : base()
    {
      Name = "Constant";
    }

    static ConstantNode()
    {
      Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<ConstantNode>));
    }
  }
}
