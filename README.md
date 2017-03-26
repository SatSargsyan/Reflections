# Reflections

###  [Reflection](https://msdn.microsoft.com/en-us/library/ms173183(v=vs.90).aspx)  provides objects (of type Type) that describe assemblies, modules and types. You can use reflection to dynamically create an instance of a type, bind the type to an existing object, or get the type from an existing object and invoke its methods or access its fields and properties. If you are using attributes in your code, reflection enables you to access them. 

#### Here's a simple example of reflection using the static method GetType - inherited by all types from the Object base class - to obtain the type of a variable:
```C#
// Using GetType to obtain type information: 
int i = 42;
System.Type type = i.GetType();
System.Console.WriteLine(type);
```
#### The output is:
System.Int32

#### The following example uses reflection to obtain the full name of the loaded assembly.
```C#
// Using Reflection to get information from an Assembly:
System.Reflection.Assembly info = typeof(System.Int32).Assembly;
System.Console.WriteLine(info);
```
#### The output is:
mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089

### The C# keywords protected and internal have no meaning in IL and are not used in the reflection APIs. The corresponding terms in IL are Family and Assembly. To identify an<b> internal</b> method using reflection, use the
[IsAssembly](https://msdn.microsoft.com/en-us/library/system.reflection.methodbase.isassembly(v=vs.90).aspx) property. To identify a <b>protected internal</b> method, use the [IsFamilyOrAssembly](https://msdn.microsoft.com/en-us/library/system.reflection.methodbase.isfamilyorassembly(v=vs.90).aspx).

#### Reflection is useful in the following situations:
<ul type=circle>
<li>When you have to access attributes in your program's metadata. See the topic [Accessing Attributes With Reflection](https://msdn.microsoft.com/en-us/library/z919e8tw(v=vs.90).aspx).(It allows view attribute information at runtime.)
<li>For examining and instantiating types in an assembly.(It allows examining various types in an assembly and instantiate these types.)
<li>For building new types at runtime. Use classes in <a hreh=https://msdn.microsoft.com/en-us/library/system.reflection.emit(v=vs.90).aspx>System.Reflection.Emit</a>. (It allows creating new types at runtime and then performs some tasks using those types.)
<li>For performing late binding, accessing methods on types created at run time. See the topic<a href=Dynamically Loading and Using Types> Dynamically Loading and Using Types</a>.(It allows late binding to methods and properties)
</ul>






