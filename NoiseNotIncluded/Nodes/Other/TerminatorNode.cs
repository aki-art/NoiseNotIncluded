﻿using DynamicData;
using LibNoise;
using NodeNetwork.Toolkit.ValueNode;
using NodeNetwork.Views;
using NoiseNotIncluded.Util;
using NoiseNotIncluded.Yaml;
using NoiseNotIncluded.Yaml.Noise.Nodes;
using ReactiveUI;
using System;
using System.Windows.Media;

namespace NoiseNotIncluded.Nodes.Other
{
	public class TerminatorNode : NodeWithPreview
	{
		public ValueNodeInputViewModel<IModule> NodeInput { get; } = NodeHelpers.CreateNodeInput("Input");

		public override Link.Type NodeType => Link.Type.Terminator;

		public TerminatorNode() : base()
		{
			Name = "TERMINATOR";
			CanBeRemovedByUser = false;

			NodeOutput.Name = "";
			NodeOutput.MaxConnections = 0;
			NodeOutput.Port.IsVisible = false;

			RegisterOutputValue(NodeInput.ValueChanged);

			Inputs.Add(NodeInput);
		}

		static TerminatorNode()
		{
			Splat.Locator.CurrentMutable.Register(() => GetNodeView(), typeof(IViewFor<TerminatorNode>));
		}

		static NodeView GetNodeView()
		{
			return NodeHelpers.CreateNodeView(Brushes.Black);
		}

		protected override IModule GetNewOutput()
		{
			throw new NotImplementedException();
		}

		public override NoiseBase GetYamlNode()
		{
			return null;
		}
	}
}
