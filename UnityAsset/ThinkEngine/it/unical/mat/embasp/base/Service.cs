﻿using System.Collections.Generic;

namespace EmbASP4Unity.it.unical.mat.embasp.@base
{

	public interface Service
	{

		void StartAsync(ICallback callback, IList<InputProgram> programs, IList<OptionDescriptor> options);

		Output StartSync(IList<InputProgram> programs, IList<OptionDescriptor> options);

	}

}