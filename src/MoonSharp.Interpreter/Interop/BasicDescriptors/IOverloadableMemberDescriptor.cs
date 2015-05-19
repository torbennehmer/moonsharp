﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
	/// <summary>
	/// Specialized <see cref="IMemberDescriptor"/> for members supporting overloads resolution.
	/// </summary>
	public interface IOverloadableMemberDescriptor : IMemberDescriptor
	{
		/// <summary>
		/// Invokes the member from script
		/// </summary>
		/// <param name="script">The script.</param>
		/// <param name="obj">The object.</param>
		/// <param name="context">The context.</param>
		/// <param name="args">The arguments.</param>
		/// <returns></returns>
		DynValue Execute(Script script, object obj, ScriptExecutionContext context, CallbackArguments args);

		/// <summary>
		/// Gets the type which this extension method extends, null if this is not an extension method.
		/// </summary>
		Type ExtensionMethodType { get; }

		/// <summary>
		/// Gets the type of the arguments of the underlying CLR function
		/// </summary>
		ParameterDescriptor[] Parameters { get; }

		/// <summary>
		/// Gets a value indicating the type of the ParamArray parameter of a var-args function. If the function is not var-args,
		/// null is returned.
		/// </summary>
		Type VarArgsArrayType { get; }
		/// <summary>
		/// Gets a value indicating the type of the elements of the ParamArray parameter of a var-args function. If the function is not var-args,
		/// null is returned.
		/// </summary>
		Type VarArgsElementType { get; }

		/// <summary>
		/// Gets a sort discriminant to give consistent overload resolution matching in case of perfectly equal scores
		/// </summary>
		string SortDiscriminant { get; }
	}

}
