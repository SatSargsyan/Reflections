# Reflections

Reflection has the following applications:

It allows view attribute information at runtime.

It allows examining various types in an assembly and instantiate these types.

It allows late binding to methods and properties

It allows creating new types at runtime and then performs some tasks using those types.


###The C# keywords protected and internal have no meaning in IL and are not used in the reflection APIs. The corresponding terms in IL are Family and Assembly. To identify an<b> internal</b> method using reflection, use the<b> IsAssembly</b> property. To identify a <b>protected internal</b> method, use the <b>IsFamilyOrAssembly</b>.
