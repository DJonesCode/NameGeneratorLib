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
