# Inventory Save System
## Added Files:
### InventoryConverterHelper
Static helper functions for serializing and deserializing the inventory
### UDictionary
Makes dictionaries serializable in the editor so they can be viewed and edited (mostly successful but not always)
### ScriptableObjectLocator
`ScriptableObject` used in `Resources` to store and locate other `ScriptableObject` instances more efficiently
### ScriptableObjectLocatorEditor
Editor script for the `ScriptableObjectLocator` to make items easier to add

## Edited Files (and their changes):
### InventorySaveSystemHolder
* Links an `InventoryChannel` to an `InventoryHolder` found on the same GameObject

## How to set up and use:
#### Setup:
1. Make new `ScriptableObjectLocator` in the `Resources` directory.

>Defaults to `"Assets/Resources/ScriptableObjects/SOLocator"` but can be changed in `InventoryConverterHelper` class by editing the `scriptableObjectLocatorResourceRelativePath` variable
2. Click `Find InventoryItems` button to add them to the dictionary.
3. Add `InventorySaveSystemHolder` to the scene on the same GameObject as an `InventoryHolder` 
4. Assign it the appropriate inventory channel

#### Usage:
1. Call `RaiseInventoryImport()` from the `InventoryChannel` `ScriptableObject` to import
2. Call `RaiseInventoryExport()` from the `InventoryChannel` `ScriptableObject` to export