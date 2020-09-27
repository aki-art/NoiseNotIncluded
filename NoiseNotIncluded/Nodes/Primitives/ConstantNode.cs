﻿using DynamicData;
using LibNoise;
using LibNoise.Primitive;
using ReactiveUI;

namespace NoiseNotIncluded.Nodes.Primitives
{
  public class ConstantNode : PrimitiveNode
  {
    public ConstantNode() : base()
    {
      Name = "Constant";

      Inputs.Add(Offset);
    }

    static ConstantNode()
    {
      Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<ConstantNode>));
    }

    protected override IModule GetNewOutput()
    {
      if (Offset.Value == null) return null;
      return new Constant(Offset.Value.Value);
    }
  }
}
