﻿using System;

namespace EmbASP4Unity.it.unical.mat.embasp.languages.asp
{
	public class IllegalTermException : Exception
	{
    public IllegalTermException(string msg) : base(msg) { }
	}
}