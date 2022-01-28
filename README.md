# NameGeneratorLib

This is an example of how to build a Randomized Name Generation system. This type of system could be used in psuedo data generators or video games.

#### How it Works
The code is a DLL that can be referenced in projects. The code loads embedded text files that store the names on each line and uses C# Random to choose a random line
the file. Documentation is provided via [Vsxmd](https://github.com/lijunle/Vsxmd).


#### Text Files
The code allows you to choose which rows in the file to start and stop at. For this example, I grabbed some big lists that I found on the internet. The sources are at the top
of the files.



<a name='assembly'></a>
# NameGeneratorLib

## Contents

- [NameGen](#T-NameGeneratorLib-NameGen 'NameGeneratorLib.NameGen')
  - [GetName(option,gender)](#M-NameGeneratorLib-NameGen-GetName-NameGeneratorLib-NameGen-NAME_OPTION,NameGeneratorLib-NameGen-NAME_GENDER- 'NameGeneratorLib.NameGen.GetName(NameGeneratorLib.NameGen.NAME_OPTION,NameGeneratorLib.NameGen.NAME_GENDER)')
  - [GetResourceEntry(resourceName,start,end,lineNumber)](#M-NameGeneratorLib-NameGen-GetResourceEntry-System-String,System-Int32- 'NameGeneratorLib.NameGen.GetResourceEntry(System.String,System.Int32)')

<a name='T-NameGeneratorLib-NameGen'></a>
## NameGen `type`

##### Namespace

NameGeneratorLib

<a name='M-NameGeneratorLib-NameGen-GetName-NameGeneratorLib-NameGen-NAME_OPTION,NameGeneratorLib-NameGen-NAME_GENDER-'></a>
### GetName(option,gender) `method`

##### Summary

Retrieves a random name with options for the the kind of name to retrieve.

##### Returns

String of the name

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| option | [NameGeneratorLib.NameGen.NAME_OPTION](#T-NameGeneratorLib-NameGen-NAME_OPTION 'NameGeneratorLib.NameGen.NAME_OPTION') | Determines if a first name, surname, or full name is returned. |
| gender | [NameGeneratorLib.NameGen.NAME_GENDER](#T-NameGeneratorLib-NameGen-NAME_GENDER 'NameGeneratorLib.NameGen.NAME_GENDER') | Determines if the name should be female, male, or either. |

<a name='M-NameGeneratorLib-NameGen-GetResourceEntry-System-String,System-Int32-'></a>
### GetResourceEntry(resourceName,start,end,lineNumber) `method`

##### Summary

Reads a line from the embedded resource file and returns its contents in string form.

##### Returns

a single string line from the resource

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the resource. |
| start | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting line to begin reading from. |

